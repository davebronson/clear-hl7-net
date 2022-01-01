namespace ClearHl7.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0153 - Value Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0153</remarks>
    public enum CodeValueCode
    {
        /// <summary>
        /// 01 - Most common semi-private rate.
        /// </summary>
        MostCommonSemiPrivateRate,

        /// <summary>
        /// 02 - Hospital has no semi-private rooms.
        /// </summary>
        HospitalHasNoSemiPrivateRooms,

        /// <summary>
        /// 04 - Inpatient professional component charges which are combined billed.
        /// </summary>
        InpatientChargesCombinedBilled,

        /// <summary>
        /// 05 - Professional component included in charges and also billed separate to carrier.
        /// </summary>
        ProfessionalComponentIncludedInChargesAndBilledCarrier,

        /// <summary>
        /// 06 - Medicare blood deductible.
        /// </summary>
        MedicareBloodDeductible,

        /// <summary>
        /// 08 - Medicare life time reserve amount in the first calendar year.
        /// </summary>
        MedicareLifeTimeReserveAmountInFirstYear,

        /// <summary>
        /// 09 - Medicare co-insurance amount in the first calendar year.
        /// </summary>
        MedicareCoInsuranceAmountInFirstYear,

        /// <summary>
        /// 10 - Lifetime reserve amount in the second calendar year.
        /// </summary>
        LifetimeReserveAmountInSecondYear,

        /// <summary>
        /// 11 - Co-insurance amount in the second calendar year.
        /// </summary>
        CoInsuranceAmountInSecondYear,

        /// <summary>
        /// 12 - Working aged beneficiary/spouse with employer group health plan.
        /// </summary>
        WorkingAgedBeneficiarySpouseWithEmployerGroupPlan,

        /// <summary>
        /// 13 - ESRD beneficiary in a Medicare coordination period with an employer group health plan.
        /// </summary>
        EsrdBeneficiaryInMedicareCoordPeriodWithEmployerGroupPlan,

        /// <summary>
        /// 14 - No Fault including auto/other.
        /// </summary>
        NoFault,

        /// <summary>
        /// 15 - Worker's Compensation.
        /// </summary>
        WorkersCompensation,

        /// <summary>
        /// 16 - PHS, or other federal agency.
        /// </summary>
        PhsOrOtherFederalAgency,

        /// <summary>
        /// 17 - Payer code.
        /// </summary>
        PayerCode,

        /// <summary>
        /// 21 - Catastrophic.
        /// </summary>
        Catastrophic,

        /// <summary>
        /// 22 - Surplus.
        /// </summary>
        Surplus,

        /// <summary>
        /// 23 - Recurring monthly incode.
        /// </summary>
        RecurringMonthlyIncode,

        /// <summary>
        /// 24 - Medicaid rate code.
        /// </summary>
        MedicaidRateCode,

        /// <summary>
        /// 30 - Pre-admission testing.
        /// </summary>
        PreAdmissionTesting,

        /// <summary>
        /// 31 - Patient liability amount.
        /// </summary>
        PatientLiabilityAmount,

        /// <summary>
        /// 37 - Pints of blood furnished.
        /// </summary>
        PintsOfBloodFurnished,

        /// <summary>
        /// 38 - Blood deductible pints.
        /// </summary>
        BloodDeductiblePints,

        /// <summary>
        /// 39 - Pints of blood replaced.
        /// </summary>
        PintsOfBloodReplaced,

        /// <summary>
        /// 40 - New coverage not implemented by HMO (for inpatient service only).
        /// </summary>
        NewCoverageNotImplementedByHmo,

        /// <summary>
        /// 41 - Black lung.
        /// </summary>
        BlackLung,

        /// <summary>
        /// 42 - VA.
        /// </summary>
        Va,

        /// <summary>
        /// 43 - Disabled beneficiary under age 64 with LGHP.
        /// </summary>
        DisabledBeneficiaryUnderAge64WithLghp,

        /// <summary>
        /// 44 - Amount provider agreed to accept from primary payer when this amount is less than charges but higher than payment received,, then a Medicare secondary payment is due.
        /// </summary>
        AmountFromPayerLessThanChargesButHigherThanPayment,

        /// <summary>
        /// 45 - Accident hour.
        /// </summary>
        AccidentHour,

        /// <summary>
        /// 46 - Number of grace days.
        /// </summary>
        NumberOfGraceDays,

        /// <summary>
        /// 47 - Any liability insurance.
        /// </summary>
        AnyLiabilityInsurance,

        /// <summary>
        /// 48 - Hemoglobin reading.
        /// </summary>
        HemoglobinReading,

        /// <summary>
        /// 49 - Hematocrit reading.
        /// </summary>
        HematocritReading,

        /// <summary>
        /// 50 - Physical therapy visits.
        /// </summary>
        PhysicalTherapyVisits,

        /// <summary>
        /// 51 - Occupational therapy visits.
        /// </summary>
        OccupationalTherapyVisits,

        /// <summary>
        /// 52 - Speech therapy visits.
        /// </summary>
        SpeechTherapyVisits,

        /// <summary>
        /// 53 - Cardiac rehab visits.
        /// </summary>
        CardiacRehabVisits,

        /// <summary>
        /// 56 - Skilled nurse - home visit hours.
        /// </summary>
        SkilledNurseHomeVisitHours,

        /// <summary>
        /// 57 - Home health aide - home visit hours.
        /// </summary>
        HomeHealthAideHomeVisitHours,

        /// <summary>
        /// 58 - Arterial blood gas.
        /// </summary>
        ArterialBloodGas,

        /// <summary>
        /// 59 - Oxygen saturation.
        /// </summary>
        OxygenSaturation,

        /// <summary>
        /// 60 - HHA branch MSA.
        /// </summary>
        HhaBranchMsa,

        /// <summary>
        /// 67 - Peritoneal dialysis.
        /// </summary>
        PeritonealDialysis,

        /// <summary>
        /// 68 - EPO-drug.
        /// </summary>
        EpoDrug,

        /// <summary>
        /// 70 - Payer codes.
        /// </summary>
        PayerCodes70,

        /// <summary>
        /// 70 ... 72 - Payer codes.
        /// </summary>
        PayerCodes70To72,

        /// <summary>
        /// 71 - Payer codes.
        /// </summary>
        PayerCodes71,

        /// <summary>
        /// 72 - Payer codes.
        /// </summary>
        PayerCodes72,

        /// <summary>
        /// 75 - Payer codes.
        /// </summary>
        PayerCodes75,

        /// <summary>
        /// 75 ... 79 - Payer codes.
        /// </summary>
        PayerCodes75To79,

        /// <summary>
        /// 76 - Payer codes.
        /// </summary>
        PayerCodes76,

        /// <summary>
        /// 77 - Payer codes.
        /// </summary>
        PayerCodes77,

        /// <summary>
        /// 78 - Payer codes.
        /// </summary>
        PayerCodes78,

        /// <summary>
        /// 79 - Payer codes.
        /// </summary>
        PayerCodes79,

        /// <summary>
        /// 80 - Psychiatric visits.
        /// </summary>
        PsychiatricVisits,

        /// <summary>
        /// 81 - Visits subject to co-payment.
        /// </summary>
        VisitsSubjectToCoPayment,

        /// <summary>
        /// A1 - Deductible payer A.
        /// </summary>
        DeductiblePayerA,

        /// <summary>
        /// A2 - Coinsurance payer A.
        /// </summary>
        CoinsurancePayerA,

        /// <summary>
        /// A3 - Estimated responsibility payer A.
        /// </summary>
        EstimatedResponsibilityPayerA,

        /// <summary>
        /// X0 - Service excluded on primary policy.
        /// </summary>
        ServiceExcludedOnPrimaryPolicy,

        /// <summary>
        /// X4 - Supplemental coverage.
        /// </summary>
        SupplementalCoverage
    }
}
