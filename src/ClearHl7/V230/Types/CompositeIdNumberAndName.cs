using ClearHl7.Helpers;

namespace ClearHl7.V230.Types
{
    /// <summary>
    /// HL7 Version 2 CN - Composite Id Number And Name.
    /// </summary>
    public class CompositeIdNumberAndName : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// CN.1 - ID Number.
        /// </summary>
        public string IdNumber { get; set; }

        /// <summary>
        /// CN.2 - Family Name.
        /// </summary>
        public string FamilyName { get; set; }

        /// <summary>
        /// CN.3 - Given Name.
        /// </summary>
        public string GivenName { get; set; }

        /// <summary>
        /// CN.4 - Second and Further Given Names or Initials Thereof.
        /// </summary>
        public string SecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

        /// <summary>
        /// CN.5 - Suffix (e.g., JR or III).
        /// </summary>
        public string Suffix { get; set; }

        /// <summary>
        /// CN.6 - Prefix (e.g., DR).
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// CN.7 - Degree (e.g., MD).
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0360</remarks>
        public string Degree { get; set; }

        /// <summary>
        /// CN.8 - Source Table.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0297</remarks>
        public string SourceTable { get; set; }

        /// <summary>
        /// CN.9 - Assigning Authority.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0363</remarks>
        public HierarchicDesignator AssigningAuthority { get; set; }

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
                                StringHelper.StringFormatSequence(0, 9, separator),
                                IdNumber,
                                FamilyName,
                                GivenName,
                                SecondAndFurtherGivenNamesOrInitialsThereof,
                                Suffix,
                                Prefix,
                                Degree,
                                SourceTable,
                                AssigningAuthority?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
