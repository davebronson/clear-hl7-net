using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ClearHl7
{
    /// <summary>
    /// Provides type-safe configuration for DateTime formatting on a per-field basis.
    /// </summary>
    public static class Hl7DateTimeFormatConfig
    {
        private static readonly object _globalOverrideLock = new object();
        private static string _globalDateTimeFormatOverride = null;

        /// <summary>
        /// Gets or sets the global DateTime format override for all DateTime fields.
        /// When null, fields use their original precision. When set, all fields use this format unless individually overridden.
        /// </summary>
        public static string GlobalDateTimeFormatOverride
        {
            get
            {
                lock (_globalOverrideLock)
                {
                    return _globalDateTimeFormatOverride;
                }
            }
            set
            {
                lock (_globalOverrideLock)
                {
                    _globalDateTimeFormatOverride = value;
                }
            }
        }

        // Use (segmentType, propertyName) as the key for per-field precision
        private static readonly ConcurrentDictionary<(Type, string), string> FieldPrecisions = new();

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
        /// 3. Original field precision (as defined in the original code)
        /// </summary>
        /// <param name="segmentType">The type of the segment or type containing the field.</param>
        /// <param name="propertyName">The name of the DateTime property.</param>
        /// <param name="originalFormat">The original format defined in the code for this specific field.</param>
        /// <returns>The DateTime format string to use for this field.</returns>
        public static string GetFormatForField(Type segmentType, string propertyName, string originalFormat)
        {
            // 1. Check for individual field override first
            if (FieldPrecisions.TryGetValue((segmentType, propertyName), out var fieldFormat))
                return fieldFormat;

            // 2. Check for global override
            // Performance optimization: Direct field access is used here instead of the property
            // because reference type reads are atomic in .NET, and this is a hot path.
            // The property accessor uses locks for explicit external access through the public API.
            var globalOverride = _globalDateTimeFormatOverride;
            if (globalOverride != null)
                return globalOverride;

            // 3. Use original field precision (as defined in the original code)
            return originalFormat;
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
            lock (_globalOverrideLock)
            {
                _globalDateTimeFormatOverride = null;
            }
        }

        /// <summary>
        /// Gets the count of configured field-specific precisions.
        /// </summary>
        public static int ConfiguredFieldCount
        {
            get
            {
                return FieldPrecisions.Count;
            }
        }

        /// <summary>
        /// Gets whether a global override is currently set.
        /// </summary>
        public static bool HasGlobalOverride
        {
            get
            {
                lock (_globalOverrideLock)
                {
                    return _globalDateTimeFormatOverride != null;
                }
            }
        }
    }
}