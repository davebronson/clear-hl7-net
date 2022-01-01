namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0253 - Indirect Exposure Mechanism.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0253</remarks>
    public enum CodeIndirectExposureMechanism
    {
        /// <summary>
        /// B - Breast milk.
        /// </summary>
        BreastMilk,

        /// <summary>
        /// F - Father.
        /// </summary>
        Father,

        /// <summary>
        /// O - Other.
        /// </summary>
        Other,

        /// <summary>
        /// P - Transplacental.
        /// </summary>
        Transplacental,

        /// <summary>
        /// X - Blood product.
        /// </summary>
        BloodProduct
    }
}
