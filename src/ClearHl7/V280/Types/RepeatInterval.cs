using ClearHl7.Helpers;

namespace ClearHl7.V280.Types
{
    /// <summary>
    /// HL7 Version 2 RI - Repeat Interval.
    /// </summary>
    public class RepeatInterval : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// RI.1 - Repeat Pattern.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0335</remarks>
        public CodedWithExceptions RepeatPattern { get; set; }

        /// <summary>
        /// RI.2 - Explicit Time Interval.
        /// </summary>
        public string ExplicitTimeInterval { get; set; }

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
                                RepeatPattern?.ToDelimitedString(),
                                ExplicitTimeInterval
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
