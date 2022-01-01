namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0372 - Specimen Component.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0372</remarks>
    public enum CodeSpecimenComponent
    {
        /// <summary>
        /// BLD - Whole blood, homogeneous.
        /// </summary>
        WholeBloodHomogeneous,

        /// <summary>
        /// BSEP - Whole blood, separated.
        /// </summary>
        WholeBloodSeparated,

        /// <summary>
        /// PLAS - Plasma, NOS (not otherwise specified).
        /// </summary>
        Plasma,

        /// <summary>
        /// PPP - Platelet poor plasma.
        /// </summary>
        PlateletPoorPlasma,

        /// <summary>
        /// PRP - Platelet rich plasma.
        /// </summary>
        PlateletRichPlasma,

        /// <summary>
        /// SED - Sediment.
        /// </summary>
        Sediment,

        /// <summary>
        /// SER - Serum, NOS (not otherwise specified).
        /// </summary>
        SerumNosNotOtherwiseSpecified,

        /// <summary>
        /// SUP - Supernatant.
        /// </summary>
        Supernatant
    }
}
