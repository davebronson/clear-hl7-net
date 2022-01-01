namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0251 - Action Taken In Response To The Event.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0251</remarks>
    public enum CodeActionTakenInResponseToTheEvent
    {
        /// <summary>
        /// DI - Product dose or frequency of use increased.
        /// </summary>
        ProductDoseIncreased,

        /// <summary>
        /// DR - Product dose or frequency of use reduced.
        /// </summary>
        ProductDoseReduced,

        /// <summary>
        /// N - None.
        /// </summary>
        None,

        /// <summary>
        /// OT - Other.
        /// </summary>
        Other,

        /// <summary>
        /// WP - Product withdrawn permanently.
        /// </summary>
        ProductWithdrawnPermanently,

        /// <summary>
        /// WT - Product withdrawn temporarily.
        /// </summary>
        ProductWithdrawnTemporarily
    }
}
