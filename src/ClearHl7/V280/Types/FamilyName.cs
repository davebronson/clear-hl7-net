using ClearHl7.Fhir.Helpers;

namespace ClearHl7.Fhir.V280.Types
{
    /// <summary>
    /// HL7 Version 2 FN - Family Name.
    /// </summary>
    public class FamilyName : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// FN.1 - Surname.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// FN.2 - Own Surname Prefix.
        /// </summary>
        public string OwnSurnamePrefix { get; set; }

        /// <summary>
        /// FN.3 - Own Surname.
        /// </summary>
        public string OwnSurname { get; set; }

        /// <summary>
        /// FN.4 - Surname Prefix from Partner/Spouse.
        /// </summary>
        public string SurnamePrefixFromPartnerSpouse { get; set; }

        /// <summary>
        /// FN.5 - Surname from Partner/Spouse.
        /// </summary>
        public string SurnameFromPartnerSpouse { get; set; }

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
                                StringHelper.StringFormatSequence(0, 5, separator),
                                Surname,
                                OwnSurnamePrefix,
                                OwnSurname,
                                SurnamePrefixFromPartnerSpouse,
                                SurnameFromPartnerSpouse
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
