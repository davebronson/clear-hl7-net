namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0669 - Load Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0669</remarks>
    public enum CodeLoadStatus
    {
        /// <summary>
        /// LCC - Load is Complete.
        /// </summary>
        LoadIsComplete,

        /// <summary>
        /// LCN - Load Canceled.
        /// </summary>
        LoadCanceled,

        /// <summary>
        /// LCP - Load In Process.
        /// </summary>
        LoadInProcess,

        /// <summary>
        /// LLD - Building a Load.
        /// </summary>
        BuildingALoad
    }
}
