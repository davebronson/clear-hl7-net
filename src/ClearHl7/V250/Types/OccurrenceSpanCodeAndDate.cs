using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V250.Types
{
    /// <summary>
    /// HL7 Version 2 OSP - Occurrence Span Code And Date.
    /// </summary>
    public class OccurrenceSpanCodeAndDate : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OccurrenceSpanCodeAndDate"/> class.
        /// </summary>
        public OccurrenceSpanCodeAndDate()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OccurrenceSpanCodeAndDate"/> class.
        /// </summary>
        /// <param name="occurrenceSpanCode">OSP.1 - Occurrence Span Code.</param>
        public OccurrenceSpanCodeAndDate(CodedWithNoExceptions occurrenceSpanCode)
        {
            OccurrenceSpanCode = occurrenceSpanCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OccurrenceSpanCodeAndDate"/> class.
        /// </summary>
        /// <param name="occurrenceSpanCode">OSP.1 - Occurrence Span Code.</param>
        /// <param name="occurrenceSpanStartDate">OSP.2 - Occurrence Span Start Date.</param>
        /// <param name="occurrenceSpanStopDate">OSP.3 - Occurrence Span Stop Date.</param>
        public OccurrenceSpanCodeAndDate(CodedWithNoExceptions occurrenceSpanCode, DateTime occurrenceSpanStartDate, DateTime occurrenceSpanStopDate)
        {
            OccurrenceSpanCode = occurrenceSpanCode;
            OccurrenceSpanStartDate = occurrenceSpanStartDate;
            OccurrenceSpanStopDate = occurrenceSpanStopDate;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// OSP.1 - Occurrence Span Code.
        /// <para>Suggested: 0351 Occurrence Span</para>
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
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, separator),
                                OccurrenceSpanCode?.ToDelimitedString(),
                                OccurrenceSpanStartDate?.ToHl7DateTimeString(typeof(OccurrenceSpanCodeAndDate), nameof(OccurrenceSpanStartDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                OccurrenceSpanStopDate?.ToHl7DateTimeString(typeof(OccurrenceSpanCodeAndDate), nameof(OccurrenceSpanStopDate), Consts.DateTimeFormatPrecisionSecond, culture)
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
