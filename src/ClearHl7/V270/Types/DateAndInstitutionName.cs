using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V270.Types
{
    /// <summary>
    /// HL7 Version 2 DIN - Date And Institution Name.
    /// </summary>
    public class DateAndInstitutionName : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateAndInstitutionName"/> class.
        /// </summary>
        public DateAndInstitutionName()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateAndInstitutionName"/> class.
        /// </summary>
        /// <param name="date">DIN.1 - Date.</param>
        /// <param name="institutionName">DIN.2 - Institution Name.</param>
        public DateAndInstitutionName(DateTime date, CodedWithExceptions institutionName)
        {
            Date = date;
            InstitutionName = institutionName;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// DIN.1 - Date.
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// DIN.2 - Institution Name.
        /// <para>Suggested: 0531 Institution Name</para>
        /// </summary>
        public CodedWithExceptions InstitutionName { get; set; }

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

            Date = segments.Length > 0 && segments[0].Length > 0 ? segments[0].ToNullableDateTime() : null;
            InstitutionName = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], true, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                Date?.ToHl7DateTimeString(typeof(DateAndInstitutionName), nameof(Date), Consts.DateFormatPrecisionDay, culture),
                                InstitutionName?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
