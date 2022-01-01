namespace ClearHl7.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0201 - Telecommunication Use Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0201</remarks>
    public enum CodeTelecommunicationUseCode
    {
        /// <summary>
        /// ASN - Answering Service Number.
        /// </summary>
        AnsweringServiceNumber,

        /// <summary>
        /// EMR - Emergency Number.
        /// </summary>
        EmergencyNumber,

        /// <summary>
        /// NET - Network (email) Address.
        /// </summary>
        NetworkEmailAddress,

        /// <summary>
        /// ORN - Other Residence Number.
        /// </summary>
        OtherResidenceNumber,

        /// <summary>
        /// PRN - Primary Residence Number.
        /// </summary>
        PrimaryResidenceNumber,

        /// <summary>
        /// VHN - Vacation Home Number.
        /// </summary>
        VacationHomeNumber,

        /// <summary>
        /// WPN - Work Number.
        /// </summary>
        WorkNumber
    }
}
