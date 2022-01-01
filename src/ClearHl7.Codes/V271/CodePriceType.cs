namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0205 - Price Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0205</remarks>
    public enum CodePriceType
    {
        /// <summary>
        /// AP - administrative price or handling fee.
        /// </summary>
        AdministrativePriceOrHandlingFee,

        /// <summary>
        /// DC - direct unit cost.
        /// </summary>
        DirectUnitCost,

        /// <summary>
        /// IC - indirect unit cost.
        /// </summary>
        IndirectUnitCost,

        /// <summary>
        /// PF - professional fee for performing provider.
        /// </summary>
        ProfessionalFeeForPerformingProvider,

        /// <summary>
        /// TF - technology fee for use of equipment.
        /// </summary>
        TechnologyFeeForUseOfEquipment,

        /// <summary>
        /// TP - total price.
        /// </summary>
        TotalPrice,

        /// <summary>
        /// UP - unit price, may be based on length of procedure or service.
        /// </summary>
        UnitPrice
    }
}
