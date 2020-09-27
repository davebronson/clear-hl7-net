using System;

namespace ClearHl7.Fhir.V220.Types
{
    /// <summary>
    /// HL7 Version 2 PN - Person Name.
    /// </summary>
    public class PersonName : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// PN.1 - Family Name.
        /// </summary>
        public string FamilyName { get; set; }

        /// <summary>
        /// PN.2 - Given Name.
        /// </summary>
        public string GivenName { get; set; }

        /// <summary>
        /// PN.3 - Second and Further Given Names or Initials Thereof.
        /// </summary>
        public string SecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

        /// <summary>
        /// PN.4 - Suffix.
        /// </summary>
        public string Suffix { get; set; }

        /// <summary>
        /// PN.5 - Prefix.
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// PN.6 - Degree.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0360</remarks>
        public string Degree { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}&{2}&{3}&{4}&{5}" : "{0}^{1}^{2}^{3}^{4}^{5}",
                                FamilyName,
                                GivenName,
                                SecondAndFurtherGivenNamesOrInitialsThereof,
                                Suffix,
                                Prefix,
                                Degree
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
