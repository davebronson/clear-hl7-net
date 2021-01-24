using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment FT1 - Financial Transaction.
    /// </summary>
    public class Ft1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "FT1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// FT1.1 - Set ID - FT1.
        /// </summary>
        public uint? SetIdFt1 { get; set; }

        /// <summary>
        /// FT1.2 - Transaction ID.
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// FT1.3 - Transaction Batch ID.
        /// </summary>
        public string TransactionBatchId { get; set; }

        /// <summary>
        /// FT1.4 - Transaction Date.
        /// </summary>
        public DateTimeRange TransactionDate { get; set; }

        /// <summary>
        /// FT1.5 - Transaction Posting Date.
        /// </summary>
        public DateTime? TransactionPostingDate { get; set; }

        /// <summary>
        /// FT1.6 - Transaction Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0017</remarks>
        public CodedWithExceptions TransactionType { get; set; }

        /// <summary>
        /// FT1.7 - Transaction Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0132</remarks>
        public CodedWithExceptions TransactionCode { get; set; }

        /// <summary>
        /// FT1.8 - Transaction Description.
        /// </summary>
        public string TransactionDescription { get; set; }

        /// <summary>
        /// FT1.9 - Transaction Description - Alt.
        /// </summary>
        public string TransactionDescriptionAlt { get; set; }

        /// <summary>
        /// FT1.10 - Transaction Quantity.
        /// </summary>
        public decimal? TransactionQuantity { get; set; }

        /// <summary>
        /// FT1.11 - Transaction Amount - Extended.
        /// </summary>
        public CompositePrice TransactionAmountExtended { get; set; }

        /// <summary>
        /// FT1.12 - Transaction amount - unit.
        /// </summary>
        public CompositePrice TransactionAmountUnit { get; set; }

        /// <summary>
        /// FT1.13 - Department Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0049</remarks>
        public CodedWithExceptions DepartmentCode { get; set; }

        /// <summary>
        /// FT1.14 - Health Plan ID.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0072</remarks>
        public CodedWithExceptions HealthPlanId { get; set; }

        /// <summary>
        /// FT1.15 - Insurance Amount.
        /// </summary>
        public CompositePrice InsuranceAmount { get; set; }

        /// <summary>
        /// FT1.16 - Assigned Patient Location.
        /// </summary>
        public PersonLocation AssignedPatientLocation { get; set; }

        /// <summary>
        /// FT1.17 - Fee Schedule.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0024</remarks>
        public CodedWithExceptions FeeSchedule { get; set; }

        /// <summary>
        /// FT1.18 - Patient Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0018</remarks>
        public CodedWithExceptions PatientType { get; set; }

        /// <summary>
        /// FT1.19 - Diagnosis Code - FT1.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0051</remarks>
        public IEnumerable<CodedWithExceptions> DiagnosisCodeFt1 { get; set; }

        /// <summary>
        /// FT1.20 - Performed By Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0084</remarks>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> PerformedByCode { get; set; }

        /// <summary>
        /// FT1.21 - Ordered By Code.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> OrderedByCode { get; set; }

        /// <summary>
        /// FT1.22 - Unit Cost.
        /// </summary>
        public CompositePrice UnitCost { get; set; }

        /// <summary>
        /// FT1.23 - Filler Order Number.
        /// </summary>
        public EntityIdentifier FillerOrderNumber { get; set; }

        /// <summary>
        /// FT1.24 - Entered By Code.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> EnteredByCode { get; set; }

        /// <summary>
        /// FT1.25 - Procedure Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0088</remarks>
        public CodedWithNoExceptions ProcedureCode { get; set; }

        /// <summary>
        /// FT1.26 - Procedure Code Modifier.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0340</remarks>
        public IEnumerable<CodedWithNoExceptions> ProcedureCodeModifier { get; set; }

        /// <summary>
        /// FT1.27 - Advanced Beneficiary Notice Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0339</remarks>
        public CodedWithExceptions AdvancedBeneficiaryNoticeCode { get; set; }

        /// <summary>
        /// FT1.28 - Medically Necessary Duplicate Procedure Reason.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0476</remarks>
        public CodedWithExceptions MedicallyNecessaryDuplicateProcedureReason { get; set; }

        /// <summary>
        /// FT1.29 - NDC Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0549</remarks>
        public CodedWithExceptions NdcCode { get; set; }

        /// <summary>
        /// FT1.30 - Payment Reference ID.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit PaymentReferenceId { get; set; }

        /// <summary>
        /// FT1.31 - Transaction Reference Key.
        /// </summary>
        public IEnumerable<uint> TransactionReferenceKey { get; set; }

        /// <summary>
        /// FT1.32 - Performing Facility.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> PerformingFacility { get; set; }

        /// <summary>
        /// FT1.33 - Ordering Facility.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations OrderingFacility { get; set; }

        /// <summary>
        /// FT1.34 - Item Number.
        /// </summary>
        public CodedWithExceptions ItemNumber { get; set; }

        /// <summary>
        /// FT1.35 - Model Number.
        /// </summary>
        public string ModelNumber { get; set; }

        /// <summary>
        /// FT1.36 - Special Processing Code.
        /// </summary>
        public IEnumerable<CodedWithExceptions> SpecialProcessingCode { get; set; }

        /// <summary>
        /// FT1.37 - Clinic Code.
        /// </summary>
        public CodedWithExceptions ClinicCode { get; set; }

        /// <summary>
        /// FT1.38 - Referral Number.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit ReferralNumber { get; set; }

        /// <summary>
        /// FT1.39 - Authorization Number.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit AuthorizationNumber { get; set; }

        /// <summary>
        /// FT1.40 - Service Provider Taxonomy Code.
        /// </summary>
        public CodedWithExceptions ServiceProviderTaxonomyCode { get; set; }

        /// <summary>
        /// FT1.41 - Revenue Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0456</remarks>
        public CodedWithExceptions RevenueCode { get; set; }

        /// <summary>
        /// FT1.42 - Prescription Number.
        /// </summary>
        public string PrescriptionNumber { get; set; }

        /// <summary>
        /// FT1.43 - NDC Qty and UOM.
        /// </summary>
        public CompositeQuantityWithUnits NdcQtyAndUom { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 44, Configuration.FieldSeparator),
                                Id,
                                SetIdFt1.HasValue ? SetIdFt1.Value.ToString(culture) : null,
                                TransactionId,
                                TransactionBatchId,
                                TransactionDate?.ToDelimitedString(),
                                TransactionPostingDate.HasValue ? TransactionPostingDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                TransactionType?.ToDelimitedString(),
                                TransactionCode?.ToDelimitedString(),
                                TransactionDescription,
                                TransactionDescriptionAlt,
                                TransactionQuantity.HasValue ? TransactionQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                TransactionAmountExtended?.ToDelimitedString(),
                                TransactionAmountUnit?.ToDelimitedString(),
                                DepartmentCode?.ToDelimitedString(),
                                HealthPlanId?.ToDelimitedString(),
                                InsuranceAmount?.ToDelimitedString(),
                                AssignedPatientLocation?.ToDelimitedString(),
                                FeeSchedule?.ToDelimitedString(),
                                PatientType?.ToDelimitedString(),
                                DiagnosisCodeFt1 != null ? string.Join(Configuration.FieldRepeatSeparator, DiagnosisCodeFt1.Select(x => x.ToDelimitedString())) : null,
                                PerformedByCode != null ? string.Join(Configuration.FieldRepeatSeparator, PerformedByCode.Select(x => x.ToDelimitedString())) : null,
                                OrderedByCode != null ? string.Join(Configuration.FieldRepeatSeparator, OrderedByCode.Select(x => x.ToDelimitedString())) : null,
                                UnitCost?.ToDelimitedString(),
                                FillerOrderNumber?.ToDelimitedString(),
                                EnteredByCode != null ? string.Join(Configuration.FieldRepeatSeparator, EnteredByCode.Select(x => x.ToDelimitedString())) : null,
                                ProcedureCode?.ToDelimitedString(),
                                ProcedureCodeModifier != null ? string.Join(Configuration.FieldRepeatSeparator, ProcedureCodeModifier.Select(x => x.ToDelimitedString())) : null,
                                AdvancedBeneficiaryNoticeCode?.ToDelimitedString(),
                                MedicallyNecessaryDuplicateProcedureReason?.ToDelimitedString(),
                                NdcCode?.ToDelimitedString(),
                                PaymentReferenceId?.ToDelimitedString(),
                                TransactionReferenceKey != null ? string.Join(Configuration.FieldRepeatSeparator, TransactionReferenceKey.Select(x => x.ToString(Consts.NumericFormat, culture))) : null,
                                PerformingFacility != null ? string.Join(Configuration.FieldRepeatSeparator, PerformingFacility.Select(x => x.ToDelimitedString())) : null,
                                OrderingFacility?.ToDelimitedString(),
                                ItemNumber?.ToDelimitedString(),
                                ModelNumber,
                                SpecialProcessingCode != null ? string.Join(Configuration.FieldRepeatSeparator, SpecialProcessingCode.Select(x => x.ToDelimitedString())) : null,
                                ClinicCode?.ToDelimitedString(),
                                ReferralNumber?.ToDelimitedString(),
                                AuthorizationNumber?.ToDelimitedString(),
                                ServiceProviderTaxonomyCode?.ToDelimitedString(),
                                RevenueCode?.ToDelimitedString(),
                                PrescriptionNumber,
                                NdcQtyAndUom?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}