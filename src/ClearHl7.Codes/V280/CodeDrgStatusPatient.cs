namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0739 - DRG Status Patient.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0739</remarks>
    public enum CodeDrgStatusPatient
    {
        /// <summary>
        /// 1 - Normal length of stay.
        /// </summary>
        NormalLengthOfStay,

        /// <summary>
        /// 2 - Short length of stay.
        /// </summary>
        ShortLengthOfStay,

        /// <summary>
        /// 3 - Long length of stay.
        /// </summary>
        LongLengthOfStay
    }
}
