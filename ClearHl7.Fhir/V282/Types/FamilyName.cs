using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 FN - Family Name.
    /// </summary>
    public class FamilyName
    {
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
    }
}
