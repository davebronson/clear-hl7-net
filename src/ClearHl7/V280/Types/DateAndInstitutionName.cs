using System;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V280.Types
{
    /// <summary>
    /// HL7 Version 2 DIN - Date And Institution Name.
    /// </summary>
    public class DateAndInstitutionName : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
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

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            Date = segments.ElementAtOrDefault(0)?.ToNullableDateTime();
            InstitutionName = segments.Length > 1 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(1), true) : null;
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                Date.HasValue ? Date.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                InstitutionName?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
