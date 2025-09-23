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
        /// Gets or sets the global DateTime format override for all DateTime fields.
        /// When null, fields use their original precision. When set, all fields use this format unless individually overridden.
        /// </summary>
        public static string GlobalDateTimeFormatOverride { get; set; } = null;

        // Use (segmentType, propertyName) as the key for per-field precision
        private static readonly Dictionary<(Type, string), string> FieldPrecisions = new();

        // Track original field precisions - this preserves the original behavior
        private static readonly Dictionary<(Type, string), string> OriginalFieldPrecisions = new();

        static Hl7DateTimeFormatConfig()
        {
            // Initialize original precisions based on the original codebase
            // These preserve the original field-specific precisions from the codebase
            SetOriginalPrecision<ClearHl7.V251.Segments.MshSegment>("DateTimeOfMessage", Consts.DateTimeFormatPrecisionSecond);
            SetOriginalPrecision<ClearHl7.V251.Segments.EvnSegment>("RecordedDateTime", Consts.DateTimeFormatPrecisionSecond);
            SetOriginalPrecision<ClearHl7.V251.Segments.EvnSegment>("DateTimePlannedEvent", Consts.DateTimeFormatPrecisionSecond);
            SetOriginalPrecision<ClearHl7.V251.Segments.EvnSegment>("EventOccurred", Consts.DateTimeFormatPrecisionSecond);
            
            // Add other original precisions as they are discovered
            // Fields that originally used day precision should be added here
        }

        /// <summary>
        /// Sets the original precision for a field (used internally to preserve original behavior).
        /// </summary>
        private static void SetOriginalPrecision<TSegment>(string propertyName, string format)
        {
            OriginalFieldPrecisions[(typeof(TSegment), propertyName)] = format;
        }

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
        /// Gets the DateTime format for a specific field, respecting the hierarchy:
        /// 1. Individual field override (if set)
        /// 2. Global override (if set) 
        /// 3. Original field precision (preserved from original codebase)
        /// 4. Fallback to second precision if no original precision is known
        /// </summary>
        /// <param name="segmentType">The type of the segment or type containing the field.</param>
        /// <param name="propertyName">The name of the DateTime property.</param>
        /// <returns>The DateTime format string to use for this field.</returns>
        public static string GetFormatForField(Type segmentType, string propertyName)
        {
            // 1. Check for individual field override first
            if (FieldPrecisions.TryGetValue((segmentType, propertyName), out var fieldFormat))
                return fieldFormat;

            // 2. Check for global override
            if (GlobalDateTimeFormatOverride != null)
                return GlobalDateTimeFormatOverride;

            // 3. Use original field precision (preserves original behavior)
            if (OriginalFieldPrecisions.TryGetValue((segmentType, propertyName), out var originalFormat))
                return originalFormat;

            // 4. Fallback to second precision (should rarely be needed)
            return Consts.DateTimeFormatPrecisionSecond;
        }

        /// <summary>
        /// Clears all per-field precision settings, reverting to global override or original precisions.
        /// </summary>
        public static void ClearFieldPrecisions()
        {
            FieldPrecisions.Clear();
        }

        /// <summary>
        /// Clears the global DateTime format override, reverting to original field-specific precisions.
        /// </summary>
        public static void ClearGlobalOverride()
        {
            GlobalDateTimeFormatOverride = null;
        }

        /// <summary>
        /// Gets the count of configured field-specific precisions.
        /// </summary>
        public static int ConfiguredFieldCount => FieldPrecisions.Count;

        /// <summary>
        /// Gets whether a global override is currently set.
        /// </summary>
        public static bool HasGlobalOverride => GlobalDateTimeFormatOverride != null;
    }
}