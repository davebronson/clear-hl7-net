using System;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V230.Types
{
    /// <summary>
    /// HL7 Version 2 OSP - Occurrence Span Code And Date.
    /// </summary>
    public class OccurrenceSpanCodeAndDate : IType
    {
        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// OSP.1 - Occurrence Span Code.
        /// </summary>
        public CodedWithNoExceptions OccurrenceSpanCode { get; set; }

        /// <summary>
        /// OSP.2 - Occurrence Span Start Date.
        /// </summary>
        public DateTime? OccurrenceSpanStartDate { get; set; }

        /// <summary>
        /// OSP.3 - Occurrence Span Stop Date.
        /// </summary>
        public DateTime? OccurrenceSpanStopDate { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(separator, StringSplitOptions.None);

            OccurrenceSpanCode = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[0], true, seps) : null;
            OccurrenceSpanStartDate = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDateTime() : null;
            OccurrenceSpanStopDate = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDateTime() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, separator),
                                OccurrenceSpanCode?.ToDelimitedString(),
                                OccurrenceSpanStartDate.HasValue ? OccurrenceSpanStartDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                OccurrenceSpanStopDate.HasValue ? OccurrenceSpanStopDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
