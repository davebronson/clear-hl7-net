using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment DRG - Diagnosis Related Group.
    /// </summary>
    public class DrgSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DrgSegment"/> class.
        /// </summary>
        public DrgSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DrgSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public DrgSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "DRG";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// DRG.1 - Diagnostic Related Group.
        /// <para>Suggested: 0055 Diagnosis Related Group</para>
        /// </summary>
        public CodedWithNoExceptions DiagnosticRelatedGroup { get; set; }

        /// <summary>
        /// DRG.2 - DRG Assigned Date/Time.
        /// </summary>
        public DateTime? DrgAssignedDateTime { get; set; }

        /// <summary>
        /// DRG.3 - DRG Approval Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V260.CodeYesNoIndicator</para>
        /// </summary>
        public string DrgApprovalIndicator { get; set; }

        /// <summary>
        /// DRG.4 - DRG Grouper Review Code.
        /// <para>Suggested: 0056 DRG Grouper Review Code</para>
        /// </summary>
        public string DrgGrouperReviewCode { get; set; }

        /// <summary>
        /// DRG.5 - Outlier Type.
        /// <para>Suggested: 0083 Outlier Type -&gt; ClearHl7.Codes.V260.CodeOutlierType</para>
        /// </summary>
        public CodedWithExceptions OutlierType { get; set; }

        /// <summary>
        /// DRG.6 - Outlier Days.
        /// </summary>
        public decimal? OutlierDays { get; set; }

        /// <summary>
        /// DRG.7 - Outlier Cost.
        /// </summary>
        public CompositePrice OutlierCost { get; set; }

        /// <summary>
        /// DRG.8 - DRG Payor.
        /// <para>Suggested: 0229 DRG Payor -&gt; ClearHl7.Codes.V260.CodeDrgPayor</para>
        /// </summary>
        public string DrgPayor { get; set; }

        /// <summary>
        /// DRG.9 - Outlier Reimbursement.
        /// </summary>
        public CompositePrice OutlierReimbursement { get; set; }

        /// <summary>
        /// DRG.10 - Confidential Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V260.CodeYesNoIndicator</para>
        /// </summary>
        public string ConfidentialIndicator { get; set; }

        /// <summary>
        /// DRG.11 - DRG Transfer Type.
        /// <para>Suggested: 0415 Transfer Type -&gt; ClearHl7.Codes.V260.CodeTransferType</para>
        /// </summary>
        public string DrgTransferType { get; set; }

        /// <summary>
        /// DRG.12 - Name of Coder.
        /// </summary>
        public ExtendedPersonName NameOfCoder { get; set; }

        /// <summary>
        /// DRG.13 - Grouper Status.
        /// <para>Suggested: 0734 Grouper Status -&gt; ClearHl7.Codes.V260.CodeGrouperStatus</para>
        /// </summary>
        public CodedWithExceptions GrouperStatus { get; set; }

        /// <summary>
        /// DRG.14 - PCCL Value Code.
        /// <para>Suggested: 0728 CCL Value -&gt; ClearHl7.Codes.V260.CodeCclValue</para>
        /// </summary>
        public CodedWithExceptions PcclValueCode { get; set; }

        /// <summary>
        /// DRG.15 - Effective Weight.
        /// </summary>
        public decimal? EffectiveWeight { get; set; }

        /// <summary>
        /// DRG.16 - Monetary Amount.
        /// </summary>
        public Money MonetaryAmount { get; set; }

        /// <summary>
        /// DRG.17 - Status Patient.
        /// <para>Suggested: 0739 DRG Status Patient -&gt; ClearHl7.Codes.V260.CodeDrgStatusPatient</para>
        /// </summary>
        public string StatusPatient { get; set; }

        /// <summary>
        /// DRG.18 - Grouper Software Name.
        /// </summary>
        public string GrouperSoftwareName { get; set; }

        /// <summary>
        /// DRG.19 - Grouper Software Version.
        /// </summary>
        public string GrouperSoftwareVersion { get; set; }

        /// <summary>
        /// DRG.20 - Status Financial Calculation.
        /// <para>Suggested: 0742 DRG Status Financial Calculation -&gt; ClearHl7.Codes.V260.CodeDrgStatusFinancialCalculation</para>
        /// </summary>
        public string StatusFinancialCalculation { get; set; }

        /// <summary>
        /// DRG.21 - Relative Discount/Surcharge.
        /// </summary>
        public Money RelativeDiscountSurcharge { get; set; }

        /// <summary>
        /// DRG.22 - Basic Charge.
        /// </summary>
        public Money BasicCharge { get; set; }

        /// <summary>
        /// DRG.23 - Total Charge.
        /// </summary>
        public Money TotalCharge { get; set; }

        /// <summary>
        /// DRG.24 - Discount/Surcharge.
        /// </summary>
        public Money DiscountSurcharge { get; set; }

        /// <summary>
        /// DRG.25 - Calculated Days.
        /// </summary>
        public decimal? CalculatedDays { get; set; }

        /// <summary>
        /// DRG.26 - Status Gender.
        /// <para>Suggested: 0749 DRG Grouping Status -&gt; ClearHl7.Codes.V260.CodeDrgGroupingStatus</para>
        /// </summary>
        public string StatusGender { get; set; }

        /// <summary>
        /// DRG.27 - Status Age.
        /// <para>Suggested: 0749 DRG Grouping Status -&gt; ClearHl7.Codes.V260.CodeDrgGroupingStatus</para>
        /// </summary>
        public string StatusAge { get; set; }

        /// <summary>
        /// DRG.28 - Status Length of Stay.
        /// <para>Suggested: 0749 DRG Grouping Status -&gt; ClearHl7.Codes.V260.CodeDrgGroupingStatus</para>
        /// </summary>
        public string StatusLengthOfStay { get; set; }

        /// <summary>
        /// DRG.29 - Status Same Day Flag.
        /// <para>Suggested: 0749 DRG Grouping Status -&gt; ClearHl7.Codes.V260.CodeDrgGroupingStatus</para>
        /// </summary>
        public string StatusSameDayFlag { get; set; }

        /// <summary>
        /// DRG.30 - Status Separation Mode.
        /// <para>Suggested: 0749 DRG Grouping Status -&gt; ClearHl7.Codes.V260.CodeDrgGroupingStatus</para>
        /// </summary>
        public string StatusSeparationMode { get; set; }

        /// <summary>
        /// DRG.31 - Status Weight at Birth.
        /// <para>Suggested: 0755 Status Weight At Birth -&gt; ClearHl7.Codes.V260.CodeStatusWeightAtBirth</para>
        /// </summary>
        public string StatusWeightAtBirth { get; set; }

        /// <summary>
        /// DRG.32 - Status Respiration Minutes.
        /// <para>Suggested: 0757 DRG Status Respiration Minutes -&gt; ClearHl7.Codes.V260.CodeDrgStatusRespirationMinutes</para>
        /// </summary>
        public string StatusRespirationMinutes { get; set; }

        /// <summary>
        /// DRG.33 - Status Admission.
        /// <para>Suggested: 0759 Status Admission -&gt; ClearHl7.Codes.V260.CodeStatusAdmission</para>
        /// </summary>
        public string StatusAdmission { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            DiagnosticRelatedGroup = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[1], false, seps) : null;
            DrgAssignedDateTime = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDateTime() : null;
            DrgApprovalIndicator = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            DrgGrouperReviewCode = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            OutlierType = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[5], false, seps) : null;
            OutlierDays = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDecimal() : null;
            OutlierCost = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[7], false, seps) : null;
            DrgPayor = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            OutlierReimbursement = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[9], false, seps) : null;
            ConfidentialIndicator = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            DrgTransferType = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            NameOfCoder = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<ExtendedPersonName>(segments[12], false, seps) : null;
            GrouperStatus = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[13], false, seps) : null;
            PcclValueCode = segments.Length > 14 && segments[14].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[14], false, seps) : null;
            EffectiveWeight = segments.Length > 15 && segments[15].Length > 0 ? segments[15].ToNullableDecimal() : null;
            MonetaryAmount = segments.Length > 16 && segments[16].Length > 0 ? TypeSerializer.Deserialize<Money>(segments[16], false, seps) : null;
            StatusPatient = segments.Length > 17 && segments[17].Length > 0 ? segments[17] : null;
            GrouperSoftwareName = segments.Length > 18 && segments[18].Length > 0 ? segments[18] : null;
            GrouperSoftwareVersion = segments.Length > 19 && segments[19].Length > 0 ? segments[19] : null;
            StatusFinancialCalculation = segments.Length > 20 && segments[20].Length > 0 ? segments[20] : null;
            RelativeDiscountSurcharge = segments.Length > 21 && segments[21].Length > 0 ? TypeSerializer.Deserialize<Money>(segments[21], false, seps) : null;
            BasicCharge = segments.Length > 22 && segments[22].Length > 0 ? TypeSerializer.Deserialize<Money>(segments[22], false, seps) : null;
            TotalCharge = segments.Length > 23 && segments[23].Length > 0 ? TypeSerializer.Deserialize<Money>(segments[23], false, seps) : null;
            DiscountSurcharge = segments.Length > 24 && segments[24].Length > 0 ? TypeSerializer.Deserialize<Money>(segments[24], false, seps) : null;
            CalculatedDays = segments.Length > 25 && segments[25].Length > 0 ? segments[25].ToNullableDecimal() : null;
            StatusGender = segments.Length > 26 && segments[26].Length > 0 ? segments[26] : null;
            StatusAge = segments.Length > 27 && segments[27].Length > 0 ? segments[27] : null;
            StatusLengthOfStay = segments.Length > 28 && segments[28].Length > 0 ? segments[28] : null;
            StatusSameDayFlag = segments.Length > 29 && segments[29].Length > 0 ? segments[29] : null;
            StatusSeparationMode = segments.Length > 30 && segments[30].Length > 0 ? segments[30] : null;
            StatusWeightAtBirth = segments.Length > 31 && segments[31].Length > 0 ? segments[31] : null;
            StatusRespirationMinutes = segments.Length > 32 && segments[32].Length > 0 ? segments[32] : null;
            StatusAdmission = segments.Length > 33 && segments[33].Length > 0 ? segments[33] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 34, Configuration.FieldSeparator),
                                Id,
                                DiagnosticRelatedGroup?.ToDelimitedString(),
                                DrgAssignedDateTime.ToHl7DateTimeString(typeof(DrgSegment), nameof(DrgAssignedDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                DrgApprovalIndicator,
                                DrgGrouperReviewCode,
                                OutlierType?.ToDelimitedString(),
                                OutlierDays.HasValue ? OutlierDays.Value.ToString(Consts.NumericFormat, culture) : null,
                                OutlierCost?.ToDelimitedString(),
                                DrgPayor,
                                OutlierReimbursement?.ToDelimitedString(),
                                ConfidentialIndicator,
                                DrgTransferType,
                                NameOfCoder?.ToDelimitedString(),
                                GrouperStatus?.ToDelimitedString(),
                                PcclValueCode?.ToDelimitedString(),
                                EffectiveWeight.HasValue ? EffectiveWeight.Value.ToString(Consts.NumericFormat, culture) : null,
                                MonetaryAmount?.ToDelimitedString(),
                                StatusPatient,
                                GrouperSoftwareName,
                                GrouperSoftwareVersion,
                                StatusFinancialCalculation,
                                RelativeDiscountSurcharge?.ToDelimitedString(),
                                BasicCharge?.ToDelimitedString(),
                                TotalCharge?.ToDelimitedString(),
                                DiscountSurcharge?.ToDelimitedString(),
                                CalculatedDays.HasValue ? CalculatedDays.Value.ToString(Consts.NumericFormat, culture) : null,
                                StatusGender,
                                StatusAge,
                                StatusLengthOfStay,
                                StatusSameDayFlag,
                                StatusSeparationMode,
                                StatusWeightAtBirth,
                                StatusRespirationMinutes,
                                StatusAdmission
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
