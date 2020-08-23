using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 XTN - Extended Telecommunication Number.
    /// </summary>
    public class ExtendedTelecommunicationNumber
    {
        /// <summary>
        /// XTN.1 - Telephone Number.
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// XTN.2 - Telecommunication Use Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0201</remarks>
        public string TelecommunicationUseCode { get; set; }

        /// <summary>
        /// XTN.3 - Telecommunication Equipment Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0202</remarks>
        public string TelecommunicationEquipmentType { get; set; }

        /// <summary>
        /// XTN.4 - Communication Address.
        /// </summary>
        public string CommunicationAddress { get; set; }

        /// <summary>
        /// XTN.5 - Country Code.
        /// </summary>
        public int? CountryCode { get; set; }

        /// <summary>
        /// XTN.6 - Area/City Code.
        /// </summary>
        public int? AreaCityCode { get; set; }

        /// <summary>
        /// XTN.7 - Local Number.
        /// </summary>
        public int? LocalNumber { get; set; }

        /// <summary>
        /// XTN.8 - Extension.
        /// </summary>
        public int? Extension { get; set; }

        /// <summary>
        /// XTN.9 - Any Text.
        /// </summary>
        public string AnyText { get; set; }

        /// <summary>
        /// XTN.10 - Extension Prefix.
        /// </summary>
        public string ExtensionPrefix { get; set; }

        /// <summary>
        /// XTN.11 - Speed Dial Code.
        /// </summary>
        public string SpeedDialCode { get; set; }

        /// <summary>
        /// XTN.12 - Unformatted Telephone Number.
        /// </summary>
        public string UnformattedTelephoneNumber { get; set; }

        /// <summary>
        /// XTN.13 - Effective Start Date.
        /// </summary>
        public DateTime? EffectiveStartDate { get; set; }

        /// <summary>
        /// XTN.14 - Expiration Date.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// XTN.15 - Expiration Reason.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0868</remarks>
        public CodedWithExceptions ExpirationReason { get; set; }

        /// <summary>
        /// XTN.16 - Protection Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0618</remarks>
        public CodedWithExceptions ProtectionCode { get; set; }

        /// <summary>
        /// XTN.17 - Shared Telecommunication Identifier.
        /// </summary>
        public EntityIdentifier SharedTelecommunicationIdentifier { get; set; }

        /// <summary>
        /// XTN.18 - Preference Order.
        /// </summary>
        public decimal? PreferenceOrder { get; set; }
    }
}
