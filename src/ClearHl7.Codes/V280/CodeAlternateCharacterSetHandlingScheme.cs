namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0356 - Alternate Character Set Handling Scheme.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0356</remarks>
    public enum CodeAlternateCharacterSetHandlingScheme
    {
        /// <summary>
        /// 2.3 - The character set switching mode specified in HL7 2.5, section 2.7.2 and section 2.A.46, "XPN - extended person name".
        /// </summary>
        CharacterSetSwitchingXpnExtendedPersonName,

        /// <summary>
        /// null - This is the default, indicating that there is no character set switching occurring in this message.
        /// </summary>
        NoCharacterSetSwitching,

        /// <summary>
        /// ISO 2022-1994 - This standard is titled "Information Technology - Character Code Structure and Extension Technique".
        /// </summary>
        Iso20221994
    }
}
