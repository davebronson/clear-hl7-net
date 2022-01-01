namespace ClearHl7.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0223 - Living Dependency.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0223</remarks>
    public enum CodeLivingDependency
    {
        /// <summary>
        /// CB - Common Bath.
        /// </summary>
        CommonBathDeprecated,

        /// <summary>
        /// D - Spouse dependent.
        /// </summary>
        SpouseDependentDeprecated,

        /// <summary>
        /// M - Medical Supervision Required.
        /// </summary>
        MedicalSupervisionRequired,

        /// <summary>
        /// S - Spouse Dependent.
        /// </summary>
        SpouseDependent,

        /// <summary>
        /// WU - Walk up.
        /// </summary>
        WalkUpDeprecated
    }
}
