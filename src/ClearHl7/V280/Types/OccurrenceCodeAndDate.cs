using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V280.Types
{
    /// <summary>
    /// HL7 Version 2 OCD - Occurrence Code And Date.
    /// </summary>
    public class OccurrenceCodeAndDate : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OccurrenceCodeAndDate"/> class.
        /// </summary>
        public OccurrenceCodeAndDate()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OccurrenceCodeAndDate"/> class.
        /// </summary>
        /// <param name="occurrenceCode">OCD.1 - Occurrence Code.</param>
        /// <param name="occurrenceDate">OCD.2 - Occurrence Date.</param>
        public OccurrenceCodeAndDate(CodedWithNoExceptions occurrenceCode, DateTime occurrenceDate)
        {
            OccurrenceCode = occurrenceCode;
            OccurrenceDate = occurrenceDate;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// OCD.1 - Occurrence Code.
        /// <para>Suggested: 0350 Occurrence Code -&gt; ClearHl7.Codes.V280.CodeOccurrenceCode</para>
        /// </summary>
        public CodedWithNoExceptions OccurrenceCode { get; set; }

        /// <summary>
        /// OCD.2 - Occurrence Date.
        /// </summary>
        public DateTime? OccurrenceDate { get; set; }

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

            OccurrenceCode = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[0], true, seps) : null;
            OccurrenceDate = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDateTime() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                OccurrenceCode?.ToDelimitedString(),
                                OccurrenceDate?.ToHl7DateTimeString(typeof(OccurrenceCodeAndDate), nameof(OccurrenceDate), Consts.DateFormatPrecisionDay, culture)
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
