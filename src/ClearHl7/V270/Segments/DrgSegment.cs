using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment DRG - Diagnosis Related Group.
    /// </summary>
    public class DrgSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "DRG";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
        /// </summary>
        public string DrgApprovalIndicator { get; set; }

        /// <summary>
        /// DRG.4 - DRG Grouper Review Code.
        /// <para>Suggested: 0056 DRG Grouper Review Code</para>
        /// </summary>
        public CodedWithExceptions DrgGrouperReviewCode { get; set; }

        /// <summary>
        /// DRG.5 - Outlier Type.
        /// <para>Suggested: 0083 Outlier Type -&gt; ClearHl7.Codes.V270.CodeOutlierType</para>
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
        /// <para>Suggested: 0229 DRG Payor -&gt; ClearHl7.Codes.V270.CodeDrgPayor</para>
        /// </summary>
        public CodedWithExceptions DrgPayor { get; set; }

        /// <summary>
        /// DRG.9 - Outlier Reimbursement.
        /// </summary>
        public CompositePrice OutlierReimbursement { get; set; }

        /// <summary>
        /// DRG.10 - Confidential Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
        /// </summary>
        public string ConfidentialIndicator { get; set; }

        /// <summary>
        /// DRG.11 - DRG Transfer Type.
        /// <para>Suggested: 0415 Transfer Type -&gt; ClearHl7.Codes.V270.CodeTransferType</para>
        /// </summary>
        public CodedWithExceptions DrgTransferType { get; set; }

        /// <summary>
        /// DRG.12 - Name of Coder.
        /// </summary>
        public ExtendedPersonName NameOfCoder { get; set; }

        /// <summary>
        /// DRG.13 - Grouper Status.
        /// <para>Suggested: 0734 Grouper Status -&gt; ClearHl7.Codes.V270.CodeGrouperStatus</para>
        /// </summary>
        public CodedWithExceptions GrouperStatus { get; set; }

        /// <summary>
        /// DRG.14 - PCCL Value Code.
        /// <para>Suggested: 0728 CCL Value -&gt; ClearHl7.Codes.V270.CodeCclValue</para>
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
        /// <para>Suggested: 0739 DRG Status Patient -&gt; ClearHl7.Codes.V270.CodeDrgStatusPatient</para>
        /// </summary>
        public CodedWithExceptions StatusPatient { get; set; }

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
        /// <para>Suggested: 0742 DRG Status Financial Calculation -&gt; ClearHl7.Codes.V270.CodeDrgStatusFinancialCalculation</para>
        /// </summary>
        public CodedWithExceptions StatusFinancialCalculation { get; set; }

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
        /// <para>Suggested: 0749 DRG Grouping Status -&gt; ClearHl7.Codes.V270.CodeDrgGroupingStatus</para>
        /// </summary>
        public CodedWithExceptions StatusGender { get; set; }

        /// <summary>
        /// DRG.27 - Status Age.
        /// <para>Suggested: 0749 DRG Grouping Status -&gt; ClearHl7.Codes.V270.CodeDrgGroupingStatus</para>
        /// </summary>
        public CodedWithExceptions StatusAge { get; set; }

        /// <summary>
        /// DRG.28 - Status Length of Stay.
        /// <para>Suggested: 0749 DRG Grouping Status -&gt; ClearHl7.Codes.V270.CodeDrgGroupingStatus</para>
        /// </summary>
        public CodedWithExceptions StatusLengthOfStay { get; set; }

        /// <summary>
        /// DRG.29 - Status Same Day Flag.
        /// <para>Suggested: 0749 DRG Grouping Status -&gt; ClearHl7.Codes.V270.CodeDrgGroupingStatus</para>
        /// </summary>
        public CodedWithExceptions StatusSameDayFlag { get; set; }

        /// <summary>
        /// DRG.30 - Status Separation Mode.
        /// <para>Suggested: 0749 DRG Grouping Status -&gt; ClearHl7.Codes.V270.CodeDrgGroupingStatus</para>
        /// </summary>
        public CodedWithExceptions StatusSeparationMode { get; set; }

        /// <summary>
        /// DRG.31 - Status Weight at Birth.
        /// <para>Suggested: 0755 Status Weight At Birth -&gt; ClearHl7.Codes.V270.CodeStatusWeightAtBirth</para>
        /// </summary>
        public CodedWithExceptions StatusWeightAtBirth { get; set; }

        /// <summary>
        /// DRG.32 - Status Respiration Minutes.
        /// <para>Suggested: 0757 DRG Status Respiration Minutes -&gt; ClearHl7.Codes.V270.CodeDrgStatusRespirationMinutes</para>
        /// </summary>
        public CodedWithExceptions StatusRespirationMinutes { get; set; }

        /// <summary>
        /// DRG.33 - Status Admission.
        /// <para>Suggested: 0759 Status Admission -&gt; ClearHl7.Codes.V270.CodeStatusAdmission</para>
        /// </summary>
        public CodedWithExceptions StatusAdmission { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            DiagnosticRelatedGroup = segments.Length > 1 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(1), false) : null;
            DrgAssignedDateTime = segments.ElementAtOrDefault(2)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            DrgApprovalIndicator = segments.ElementAtOrDefault(3);
            DrgGrouperReviewCode = segments.Length > 4 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(4), false) : null;
            OutlierType = segments.Length > 5 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(5), false) : null;
            OutlierDays = segments.ElementAtOrDefault(6)?.ToNullableDecimal();
            OutlierCost = segments.Length > 7 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(7), false) : null;
            DrgPayor = segments.Length > 8 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(8), false) : null;
            OutlierReimbursement = segments.Length > 9 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(9), false) : null;
            ConfidentialIndicator = segments.ElementAtOrDefault(10);
            DrgTransferType = segments.Length > 11 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(11), false) : null;
            NameOfCoder = segments.Length > 12 ? TypeHelper.Deserialize<ExtendedPersonName>(segments.ElementAtOrDefault(12), false) : null;
            GrouperStatus = segments.Length > 13 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(13), false) : null;
            PcclValueCode = segments.Length > 14 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(14), false) : null;
            EffectiveWeight = segments.ElementAtOrDefault(15)?.ToNullableDecimal();
            MonetaryAmount = segments.Length > 16 ? TypeHelper.Deserialize<Money>(segments.ElementAtOrDefault(16), false) : null;
            StatusPatient = segments.Length > 17 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(17), false) : null;
            GrouperSoftwareName = segments.ElementAtOrDefault(18);
            GrouperSoftwareVersion = segments.ElementAtOrDefault(19);
            StatusFinancialCalculation = segments.Length > 20 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(20), false) : null;
            RelativeDiscountSurcharge = segments.Length > 21 ? TypeHelper.Deserialize<Money>(segments.ElementAtOrDefault(21), false) : null;
            BasicCharge = segments.Length > 22 ? TypeHelper.Deserialize<Money>(segments.ElementAtOrDefault(22), false) : null;
            TotalCharge = segments.Length > 23 ? TypeHelper.Deserialize<Money>(segments.ElementAtOrDefault(23), false) : null;
            DiscountSurcharge = segments.Length > 24 ? TypeHelper.Deserialize<Money>(segments.ElementAtOrDefault(24), false) : null;
            CalculatedDays = segments.ElementAtOrDefault(25)?.ToNullableDecimal();
            StatusGender = segments.Length > 26 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(26), false) : null;
            StatusAge = segments.Length > 27 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(27), false) : null;
            StatusLengthOfStay = segments.Length > 28 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(28), false) : null;
            StatusSameDayFlag = segments.Length > 29 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(29), false) : null;
            StatusSeparationMode = segments.Length > 30 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(30), false) : null;
            StatusWeightAtBirth = segments.Length > 31 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(31), false) : null;
            StatusRespirationMinutes = segments.Length > 32 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(32), false) : null;
            StatusAdmission = segments.Length > 33 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(33), false) : null;
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
                                StringHelper.StringFormatSequence(0, 34, Configuration.FieldSeparator),
                                Id,
                                DiagnosticRelatedGroup?.ToDelimitedString(),
                                DrgAssignedDateTime.HasValue ? DrgAssignedDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DrgApprovalIndicator,
                                DrgGrouperReviewCode?.ToDelimitedString(),
                                OutlierType?.ToDelimitedString(),
                                OutlierDays.HasValue ? OutlierDays.Value.ToString(Consts.NumericFormat, culture) : null,
                                OutlierCost?.ToDelimitedString(),
                                DrgPayor?.ToDelimitedString(),
                                OutlierReimbursement?.ToDelimitedString(),
                                ConfidentialIndicator,
                                DrgTransferType?.ToDelimitedString(),
                                NameOfCoder?.ToDelimitedString(),
                                GrouperStatus?.ToDelimitedString(),
                                PcclValueCode?.ToDelimitedString(),
                                EffectiveWeight.HasValue ? EffectiveWeight.Value.ToString(Consts.NumericFormat, culture) : null,
                                MonetaryAmount?.ToDelimitedString(),
                                StatusPatient?.ToDelimitedString(),
                                GrouperSoftwareName,
                                GrouperSoftwareVersion,
                                StatusFinancialCalculation?.ToDelimitedString(),
                                RelativeDiscountSurcharge?.ToDelimitedString(),
                                BasicCharge?.ToDelimitedString(),
                                TotalCharge?.ToDelimitedString(),
                                DiscountSurcharge?.ToDelimitedString(),
                                CalculatedDays.HasValue ? CalculatedDays.Value.ToString(Consts.NumericFormat, culture) : null,
                                StatusGender?.ToDelimitedString(),
                                StatusAge?.ToDelimitedString(),
                                StatusLengthOfStay?.ToDelimitedString(),
                                StatusSameDayFlag?.ToDelimitedString(),
                                StatusSeparationMode?.ToDelimitedString(),
                                StatusWeightAtBirth?.ToDelimitedString(),
                                StatusRespirationMinutes?.ToDelimitedString(),
                                StatusAdmission?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}