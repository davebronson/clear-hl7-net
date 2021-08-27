using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
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
        /// <para>Suggested: 0017 Transaction Type -&gt; ClearHl7.Codes.V280.CodeTransactionType</para>
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
        /// <para>Suggested: 0339 Advanced Beneficiary Notice Code -&gt; ClearHl7.Codes.V280.CodeAdvancedBeneficiaryNoticeCode</para>
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
        /// <para>Suggested: 0456 Revenue Code -&gt; ClearHl7.Codes.V280.CodeRevenueCode</para>
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
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);
            
            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdFt1 = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            TransactionId = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            TransactionBatchId = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            TransactionDate = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<DateTimeRange>(segments[4], false) : null;
            TransactionPostingDate = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDateTime() : null;
            TransactionType = segments.Length > 6 && segments[6].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[6], false) : null;
            TransactionCode = segments.Length > 7 && segments[7].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[7], false) : null;
            TransactionDescription = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            TransactionDescriptionAlt = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            TransactionQuantity = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDecimal() : null;
            TransactionAmountExtended = segments.Length > 11 && segments[11].Length > 0 ? TypeHelper.Deserialize<CompositePrice>(segments[11], false) : null;
            TransactionAmountUnit = segments.Length > 12 && segments[12].Length > 0 ? TypeHelper.Deserialize<CompositePrice>(segments[12], false) : null;
            DepartmentCode = segments.Length > 13 && segments[13].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[13], false) : null;
            HealthPlanId = segments.Length > 14 && segments[14].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[14], false) : null;
            InsuranceAmount = segments.Length > 15 && segments[15].Length > 0 ? TypeHelper.Deserialize<CompositePrice>(segments[15], false) : null;
            AssignedPatientLocation = segments.Length > 16 && segments[16].Length > 0 ? TypeHelper.Deserialize<PersonLocation>(segments[16], false) : null;
            FeeSchedule = segments.Length > 17 && segments[17].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[17], false) : null;
            PatientType = segments.Length > 18 && segments[18].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[18], false) : null;
            DiagnosisCodeFt1 = segments.Length > 19 && segments[19].Length > 0 ? segments[19].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            PerformedByCode = segments.Length > 20 && segments[20].Length > 0 ? segments[20].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            OrderedByCode = segments.Length > 21 && segments[21].Length > 0 ? segments[21].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            UnitCost = segments.Length > 22 && segments[22].Length > 0 ? TypeHelper.Deserialize<CompositePrice>(segments[22], false) : null;
            FillerOrderNumber = segments.Length > 23 && segments[23].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[23], false) : null;
            EnteredByCode = segments.Length > 24 && segments[24].Length > 0 ? segments[24].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            ProcedureCode = segments.Length > 25 && segments[25].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[25], false) : null;
            ProcedureCodeModifier = segments.Length > 26 && segments[26].Length > 0 ? segments[26].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithNoExceptions>(x, false)) : null;
            AdvancedBeneficiaryNoticeCode = segments.Length > 27 && segments[27].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[27], false) : null;
            MedicallyNecessaryDuplicateProcedureReason = segments.Length > 28 && segments[28].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[28], false) : null;
            NdcCode = segments.Length > 29 && segments[29].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[29], false) : null;
            PaymentReferenceId = segments.Length > 30 && segments[30].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[30], false) : null;
            TransactionReferenceKey = segments.Length > 31 && segments[31].Length > 0 ? segments[31].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => x.ToUInt()) : null;
            PerformingFacility = segments.Length > 32 && segments[32].Length > 0 ? segments[32].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            OrderingFacility = segments.Length > 33 && segments[33].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[33], false) : null;
            ItemNumber = segments.Length > 34 && segments[34].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[34], false) : null;
            ModelNumber = segments.Length > 35 && segments[35].Length > 0 ? segments[35] : null;
            SpecialProcessingCode = segments.Length > 36 && segments[36].Length > 0 ? segments[36].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            ClinicCode = segments.Length > 37 && segments[37].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[37], false) : null;
            ReferralNumber = segments.Length > 38 && segments[38].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[38], false) : null;
            AuthorizationNumber = segments.Length > 39 && segments[39].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[39], false) : null;
            ServiceProviderTaxonomyCode = segments.Length > 40 && segments[40].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[40], false) : null;
            RevenueCode = segments.Length > 41 && segments[41].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[41], false) : null;
            PrescriptionNumber = segments.Length > 42 && segments[42].Length > 0 ? segments[42] : null;
            NdcQtyAndUom = segments.Length > 43 && segments[43].Length > 0 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments[43], false) : null;
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