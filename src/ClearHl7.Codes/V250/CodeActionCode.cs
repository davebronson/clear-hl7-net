namespace ClearHl7.Codes.V250
{
    /// <summary>
    /// HL7 Version 2 Table 0323 - Action Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0323</remarks>
    public enum CodeActionCode
    {
        /// <summary>
        /// A - Add/Insert.
        /// </summary>
        AddInsert,

        /// <summary>
        /// D - Delete.
        /// </summary>
        Delete,

        /// <summary>
        /// U - Update.
        /// </summary>
        Update,

        /// <summary>
        /// X - No change.
        /// </summary>
        NoChange
    }
}
