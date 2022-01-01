namespace ClearHl7.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0565 - Provider Adjustment Reason Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0565</remarks>
    public enum CodeProviderAdjustmentReasonCode
    {
        /// <summary>
        /// DISP - Dispensing Fee.
        /// </summary>
        DispensingFee,

        /// <summary>
        /// GST - Goods and Services Tax.
        /// </summary>
        GoodsAndServicesTax,

        /// <summary>
        /// HST - Harmonized Sales Tax.
        /// </summary>
        HarmonizedSalesTax,

        /// <summary>
        /// MKUP - Mark up Fee.
        /// </summary>
        MarkUpFee,

        /// <summary>
        /// PST - Provincial Sales Tax.
        /// </summary>
        ProvincialSalesTax
    }
}
