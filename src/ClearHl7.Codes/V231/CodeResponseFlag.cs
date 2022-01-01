namespace ClearHl7.Codes.V231
{
    /// <summary>
    /// HL7 Version 2 Table 0121 - Response Flag.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0121</remarks>
    public enum CodeResponseFlag
    {
        /// <summary>
        /// D - Same as R, also other associated segments.
        /// </summary>
        AlsoOtherAssociatedSegments,

        /// <summary>
        /// E - Report exceptions only.
        /// </summary>
        ReportExceptionsOnly,

        /// <summary>
        /// F - Same as D, plus confirmations explicitly.
        /// </summary>
        PlusConfirmationsExplicitly,

        /// <summary>
        /// N - Only the MSA segment is returned.
        /// </summary>
        OnlyMsaSegmentIsReturned,

        /// <summary>
        /// R - Same as E, also Replacement and Parent-Child.
        /// </summary>
        ReplacementAndParentChild
    }
}
