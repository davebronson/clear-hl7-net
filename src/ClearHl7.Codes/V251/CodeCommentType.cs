namespace ClearHl7.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0364 - Comment Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0364</remarks>
    public enum CodeCommentType
    {
        /// <summary>
        /// 1R - Primary Reason.
        /// </summary>
        PrimaryReason,

        /// <summary>
        /// 2R - Secondary Reason.
        /// </summary>
        SecondaryReason,

        /// <summary>
        /// AI - Ancillary Instructions.
        /// </summary>
        AncillaryInstructions,

        /// <summary>
        /// DR - Duplicate/Interaction Reason.
        /// </summary>
        DuplicateInteractionReason,

        /// <summary>
        /// GI - General Instructions.
        /// </summary>
        GeneralInstructions,

        /// <summary>
        /// GR - General Reason.
        /// </summary>
        GeneralReason,

        /// <summary>
        /// PI - Patient Instructions.
        /// </summary>
        PatientInstructions,

        /// <summary>
        /// RE - Remark.
        /// </summary>
        Remark
    }
}
