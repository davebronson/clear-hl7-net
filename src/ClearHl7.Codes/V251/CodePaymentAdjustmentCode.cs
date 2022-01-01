namespace ClearHl7.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0468 - Payment Adjustment Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0468</remarks>
    public enum CodePaymentAdjustmentCode
    {
        /// <summary>
        /// 1 - No payment adjustment.
        /// </summary>
        NoPaymentAdjustment,

        /// <summary>
        /// 2 - Designated current drug or biological payment adjustment applies to APC (status indicator G).
        /// </summary>
        DesignatedDrugOrBiologicalPaymentAdjustmentAppliesToApc,

        /// <summary>
        /// 3 - Designated new device payment adjustment applies to APC (status indicator H).
        /// </summary>
        DesignatedNewDevicePaymentAdjustmentAppliesToApc,

        /// <summary>
        /// 4 - Designated new drug or new biological payment adjustment applies to APC (status indicator J).
        /// </summary>
        DesignatedNewDrugOrNewBiologicalPaymentAdjustmentAppliesToApc,

        /// <summary>
        /// 5 - Deductible not applicable (specific list of HCPCS codes).
        /// </summary>
        DeductibleNotApplicable
    }
}
