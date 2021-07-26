using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
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
        /// <para>Suggested: 0017 Transaction Type -&gt; ClearHl7.Codes.V281.CodeTransactionType</para>
        /// </summary>
        public CodedWithExceptions TransactionType { get; set; }

        /// <summary>
        /// FT1.7 - Transaction Code.
        /// <para>Suggested: 0132 Transaction Code</para>
        /// </summary>
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
        /// <para>Suggested: 0049 Department Code</para>
        /// </summary>
        public CodedWithExceptions DepartmentCode { get; set; }

        /// <summary>
        /// FT1.14 - Health Plan ID.
        /// <para>Suggested: 0072 Insurance Plan ID</para>
        /// </summary>
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
        /// <para>Suggested: 0024 Fee Schedule</para>
        /// </summary>
        public CodedWithExceptions FeeSchedule { get; set; }

        /// <summary>
        /// FT1.18 - Patient Type.
        /// <para>Suggested: 0018 Patient Type</para>
        /// </summary>
        public CodedWithExceptions PatientType { get; set; }

        /// <summary>
        /// FT1.19 - Diagnosis Code - FT1.
        /// <para>Suggested: 0051 Diagnosis Code</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> DiagnosisCodeFt1 { get; set; }

        /// <summary>
        /// FT1.20 - Performed By Code.
        /// <para>Suggested: 0084 Performed By</para>
        /// </summary>
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
        /// <para>Suggested: 0088 Procedure Code</para>
        /// </summary>
        public CodedWithNoExceptions ProcedureCode { get; set; }

        /// <summary>
        /// FT1.26 - Procedure Code Modifier.
        /// <para>Suggested: 0340 Procedure Code Modifier</para>
        /// </summary>
        public IEnumerable<CodedWithNoExceptions> ProcedureCodeModifier { get; set; }

        /// <summary>
        /// FT1.27 - Advanced Beneficiary Notice Code.
        /// <para>Suggested: 0339 Advanced Beneficiary Notice Code -&gt; ClearHl7.Codes.V281.CodeAdvancedBeneficiaryNoticeCode</para>
        /// </summary>
        public CodedWithExceptions AdvancedBeneficiaryNoticeCode { get; set; }

        /// <summary>
        /// FT1.28 - Medically Necessary Duplicate Procedure Reason.
        /// <para>Suggested: 0476 Medically Necessary Duplicate Procedure Reason</para>
        /// </summary>
        public CodedWithExceptions MedicallyNecessaryDuplicateProcedureReason { get; set; }

        /// <summary>
        /// FT1.29 - NDC Code.
        /// <para>Suggested: 0549 NDC Codes</para>
        /// </summary>
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
        /// <para>Suggested: 0456 Revenue Code -&gt; ClearHl7.Codes.V281.CodeRevenueCode</para>
        /// </summary>
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
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdFt1 = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            TransactionId = segments.ElementAtOrDefault(2);
            TransactionBatchId = segments.ElementAtOrDefault(3);
            TransactionDate = segments.Length > 4 ? TypeHelper.Deserialize<DateTimeRange>(segments.ElementAtOrDefault(4), false) : null;
            TransactionPostingDate = segments.ElementAtOrDefault(5)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            TransactionType = segments.Length > 6 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(6), false) : null;
            TransactionCode = segments.Length > 7 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(7), false) : null;
            TransactionDescription = segments.ElementAtOrDefault(8);
            TransactionDescriptionAlt = segments.ElementAtOrDefault(9);
            TransactionQuantity = segments.ElementAtOrDefault(10)?.ToNullableDecimal();
            TransactionAmountExtended = segments.Length > 11 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(11), false) : null;
            TransactionAmountUnit = segments.Length > 12 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(12), false) : null;
            DepartmentCode = segments.Length > 13 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(13), false) : null;
            HealthPlanId = segments.Length > 14 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(14), false) : null;
            InsuranceAmount = segments.Length > 15 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(15), false) : null;
            AssignedPatientLocation = segments.Length > 16 ? TypeHelper.Deserialize<PersonLocation>(segments.ElementAtOrDefault(16), false) : null;
            FeeSchedule = segments.Length > 17 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(17), false) : null;
            PatientType = segments.Length > 18 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(18), false) : null;
            DiagnosisCodeFt1 = segments.Length > 19 ? segments.ElementAtOrDefault(19).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            PerformedByCode = segments.Length > 20 ? segments.ElementAtOrDefault(20).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            OrderedByCode = segments.Length > 21 ? segments.ElementAtOrDefault(21).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            UnitCost = segments.Length > 22 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(22), false) : null;
            FillerOrderNumber = segments.Length > 23 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(23), false) : null;
            EnteredByCode = segments.Length > 24 ? segments.ElementAtOrDefault(24).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            ProcedureCode = segments.Length > 25 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(25), false) : null;
            ProcedureCodeModifier = segments.Length > 26 ? segments.ElementAtOrDefault(26).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithNoExceptions>(x, false)) : null;
            AdvancedBeneficiaryNoticeCode = segments.Length > 27 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(27), false) : null;
            MedicallyNecessaryDuplicateProcedureReason = segments.Length > 28 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(28), false) : null;
            NdcCode = segments.Length > 29 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(29), false) : null;
            PaymentReferenceId = segments.Length > 30 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments.ElementAtOrDefault(30), false) : null;
            TransactionReferenceKey = segments.Length > 31 ? segments.ElementAtOrDefault(31).Split(separator).Select(x => x.ToUInt()) : null;
            PerformingFacility = segments.Length > 32 ? segments.ElementAtOrDefault(32).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            OrderingFacility = segments.Length > 33 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments.ElementAtOrDefault(33), false) : null;
            ItemNumber = segments.Length > 34 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(34), false) : null;
            ModelNumber = segments.ElementAtOrDefault(35);
            SpecialProcessingCode = segments.Length > 36 ? segments.ElementAtOrDefault(36).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            ClinicCode = segments.Length > 37 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(37), false) : null;
            ReferralNumber = segments.Length > 38 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments.ElementAtOrDefault(38), false) : null;
            AuthorizationNumber = segments.Length > 39 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments.ElementAtOrDefault(39), false) : null;
            ServiceProviderTaxonomyCode = segments.Length > 40 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(40), false) : null;
            RevenueCode = segments.Length > 41 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(41), false) : null;
            PrescriptionNumber = segments.ElementAtOrDefault(42);
            NdcQtyAndUom = segments.Length > 43 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(43), false) : null;
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

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