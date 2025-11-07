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
        private static readonly object _timezoneOffsetLock = new object();
        private static TimeSpan _timezoneOffset = TimeSpan.Zero;

        /// <summary>
        /// Gets or sets the timezone offset to use when serializing DateTime/DateTimeOffset values with timezone information.
        /// Default is TimeSpan.Zero (UTC, represented as +0000 in HL7 format).
        /// Set to DateTimeOffset.Now.Offset to use the system's local timezone offset.
        /// Thread-safe.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the value is outside the valid range of -12:00 to +14:00.</exception>
        /// <remarks>
        /// Valid timezone offsets typically range from -12:00 (UTC-12) to +14:00 (UTC+14).
        /// When using TimeSpan constructor with negative offsets, note that for a negative offset like -4 hours 30 minutes,
        /// you must use new TimeSpan(-4, -30, 0) where both components are negative, or use TimeSpan.FromMinutes(-270) for clarity.
        /// </remarks>
        public static TimeSpan TimezoneOffset
        {
            get
            {
                lock (_timezoneOffsetLock)
                {
                    return _timezoneOffset;
                }
            }
            set
            {
                // Validate offset is within typical timezone range: -12:00 to +14:00
                if (value < TimeSpan.FromHours(-12) || value > TimeSpan.FromHours(14))
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value),
                        value,
                        "Timezone offset must be between -12:00 and +14:00 hours. " +
                        $"Provided offset: {value.TotalHours:F2} hours.");
                }

                lock (_timezoneOffsetLock)
                {
                    _timezoneOffset = value;
                }
            }
        }

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

        /// <summary>
        /// Converts a TimeSpan offset to HL7-compliant offset string format (±HHMM without colon).
        /// </summary>
        /// <param name="offset">The timezone offset to convert. Must be between -12:00 and +14:00 hours (typical timezone range).</param>
        /// <returns>A string in ±HHMM format, e.g., "+0000", "-0500", "+0530".</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when offset is outside the valid range of -12:00 to +14:00.</exception>
        /// <remarks>
        /// Valid timezone offsets typically range from -12:00 (UTC-12) to +14:00 (UTC+14).
        /// When using TimeSpan constructor with negative offsets, note that for a negative offset like -4 hours 30 minutes,
        /// you must use new TimeSpan(-4, -30, 0) where both components are negative, or use TimeSpan.FromMinutes(-270) for clarity.
        /// </remarks>
        public static string ToHl7OffsetString(TimeSpan offset)
        {
            // Validate offset is within typical timezone range: -12:00 to +14:00
            if (offset < TimeSpan.FromHours(-12) || offset > TimeSpan.FromHours(14))
            {
                throw new ArgumentOutOfRangeException(
                    nameof(offset),
                    offset,
                    "Timezone offset must be between -12:00 and +14:00 hours. " +
                    $"Provided offset: {offset.TotalHours:F2} hours.");
            }

            var sign = offset.TotalMinutes >= 0 ? "+" : "-";
            var absoluteOffset = offset.Duration();
            var hours = (int)absoluteOffset.TotalHours;
            var minutes = absoluteOffset.Minutes;
            return $"{sign}{hours:D2}{minutes:D2}";
        }

        /// <summary>
        /// Formats a DateTime using the configured TimezoneOffset.
        /// The datetime is treated as UTC and converted to the configured timezone, then formatted as yyyyMMddHHmmss±HHMM.
        /// </summary>
        /// <param name="dt">The DateTime to format (treated as UTC).</param>
        /// <returns>An HL7-formatted datetime string with the configured timezone offset.</returns>
        public static string FormatDateTimeWithConfiguredOffset(DateTime dt)
        {
            var dateTimeOffset = new DateTimeOffset(dt, TimeSpan.Zero);
            return FormatDateTimeWithConfiguredOffset(dateTimeOffset);
        }

        /// <summary>
        /// Formats a DateTimeOffset using the configured TimezoneOffset.
        /// The datetime is converted to the configured timezone and formatted as yyyyMMddHHmmss±HHMM.
        /// </summary>
        /// <param name="dt">The DateTimeOffset to format.</param>
        /// <returns>An HL7-formatted datetime string with the configured timezone offset.</returns>
        public static string FormatDateTimeWithConfiguredOffset(DateTimeOffset dt)
        {
            var configuredOffset = TimezoneOffset;
            var convertedDt = dt.ToOffset(configuredOffset);
            var baseString = convertedDt.ToString(Consts.DateTimeFormatPrecisionSecond);
            var offsetString = ToHl7OffsetString(configuredOffset);
            return baseString + offsetString;
        }

        /// <summary>
        /// Formats a DateTime using the configured TimezoneOffset.
        /// The datetime is treated as unspecified and the configured timezone offset is applied.
        /// </summary>
        /// <param name="dt">The DateTime to format.</param>
        /// <returns>An HL7-formatted datetime string with the configured timezone offset.</returns>
        public static string FormatDateTimeUsingSourceOffset(DateTime dt)
        {
            var baseString = dt.ToString(Consts.DateTimeFormatPrecisionSecond);
            var offsetString = ToHl7OffsetString(TimezoneOffset);
            return baseString + offsetString;
        }

        /// <summary>
        /// Formats a DateTimeOffset using its own offset (preserves the source offset).
        /// The datetime is formatted as yyyyMMddHHmmss±HHMM using dt.Offset.
        /// </summary>
        /// <param name="dt">The DateTimeOffset to format.</param>
        /// <returns>An HL7-formatted datetime string with the source timezone offset.</returns>
        public static string FormatDateTimeUsingSourceOffset(DateTimeOffset dt)
        {
            var baseString = dt.ToString(Consts.DateTimeFormatPrecisionSecond);
            var offsetString = ToHl7OffsetString(dt.Offset);
            return baseString + offsetString;
        }
    }
}