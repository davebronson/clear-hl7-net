namespace ClearHl7.Codes.V250
{
    /// <summary>
    /// HL7 Version 2 Table 0508 - Blood Product Processing Requirements.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0508</remarks>
    public enum CodeBloodProductProcessingRequirements
    {
        /// <summary>
        /// AU - Autologous Unit.
        /// </summary>
        AutologousUnit,

        /// <summary>
        /// CM - CMV Negative.
        /// </summary>
        CmvNegative,

        /// <summary>
        /// CS - CMV Safe.
        /// </summary>
        CmvSafe,

        /// <summary>
        /// DI - Directed Unit.
        /// </summary>
        DirectedUnit,

        /// <summary>
        /// FR - Fresh unit.
        /// </summary>
        FreshUnit,

        /// <summary>
        /// HB - Hemoglobin S Negative.
        /// </summary>
        HemoglobinSNegative,

        /// <summary>
        /// HL - HLA Matched.
        /// </summary>
        HlaMatched,

        /// <summary>
        /// IG - IgA Deficient.
        /// </summary>
        IgaDeficient,

        /// <summary>
        /// IR - Irradiated.
        /// </summary>
        Irradiated,

        /// <summary>
        /// LR - Leukoreduced.
        /// </summary>
        Leukoreduced,

        /// <summary>
        /// WA - Washed.
        /// </summary>
        Washed
    }
}
