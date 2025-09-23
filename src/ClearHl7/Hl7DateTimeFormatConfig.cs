using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ClearHl7
{
    /// <summary>
    /// Provides type-safe configuration for DateTime formatting on a per-field basis.
    /// </summary>
    public static class Hl7DateTimeFormatConfig
    {
        /// <summary>
        /// Gets or sets the default DateTime format for all DateTime fields.
        /// </summary>
        public static string DefaultDateTimeFormat { get; set; } = Consts.DateTimeFormatPrecisionSecond;

        // Use (segmentType, propertyName) as the key for per-field precision
        private static readonly Dictionary<(Type, string), string> FieldPrecisions = new();

        /// <summary>
        /// Sets the DateTime format for a specific field in a type-safe manner.
        /// </summary>
        /// <typeparam name="TSegment">The type of the segment or type containing the field.</typeparam>
        /// <param name="property">Expression pointing to the DateTime property.</param>
        /// <param name="format">The DateTime format string to use for this field.</param>
        public static void SetPrecision<TSegment>(
            Expression<Func<TSegment, object>> property,
            string format)
        {
            if (property.Body is MemberExpression member)
            {
                FieldPrecisions[(typeof(TSegment), member.Member.Name)] = format;
            }
            else if (property.Body is UnaryExpression unary && unary.Operand is MemberExpression unaryMember)
            {
                FieldPrecisions[(typeof(TSegment), unaryMember.Member.Name)] = format;
            }
            else
            {
                throw new ArgumentException("Expression is not a property", nameof(property));
            }
        }

        /// <summary>
        /// Gets the DateTime format for a specific field, falling back to the default if no specific format is configured.
        /// </summary>
        /// <param name="segmentType">The type of the segment or type containing the field.</param>
        /// <param name="propertyName">The name of the DateTime property.</param>
        /// <returns>The DateTime format string to use for this field.</returns>
        public static string GetFormatForField(Type segmentType, string propertyName)
        {
            if (FieldPrecisions.TryGetValue((segmentType, propertyName), out var format))
                return format;
            return DefaultDateTimeFormat;
        }

        /// <summary>
        /// Clears all per-field precision settings.
        /// </summary>
        public static void ClearFieldPrecisions()
        {
            FieldPrecisions.Clear();
        }

        /// <summary>
        /// Gets the count of configured field-specific precisions.
        /// </summary>
        public static int ConfiguredFieldCount => FieldPrecisions.Count;
    }
}