namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0742 - DRG Status Financial Calculation.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0742</remarks>
    public enum CodeDrgStatusFinancialCalculation
    {
        /// <summary>
        /// 00 - Effective weight calculated.
        /// </summary>
        EffectiveWeightCalculated,

        /// <summary>
        /// 01 - Hospital specific contract.
        /// </summary>
        HospitalSpecificContract,

        /// <summary>
        /// 03 - Eeffective weight for transfer/referral calculated.
        /// </summary>
        EeffectiveWeightForTransferReferralCalculated,

        /// <summary>
        /// 04 - Referral from other hospital based on a cooperation (no DRG reimbursement).
        /// </summary>
        ReferralFromOtherHospitalBasedOnACooperationNoDrgReimbursement,

        /// <summary>
        /// 05 - Invalid length of stay.
        /// </summary>
        InvalidLengthOfStay,

        /// <summary>
        /// 10 - No information/entry in cost data for this DRG.
        /// </summary>
        NoInformationEntryInCostDataForThisDrg,

        /// <summary>
        /// 11 - No relative weight found for department (type).
        /// </summary>
        NoRelativeWeightFoundForDepartmentType
    }
}
