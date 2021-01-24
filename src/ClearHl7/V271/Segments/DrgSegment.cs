using System;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V271.Types;

namespace ClearHl7.Fhir.V271.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0055</remarks>
        public CodedWithNoExceptions DiagnosticRelatedGroup { get; set; }

        /// <summary>
        /// DRG.2 - DRG Assigned Date/Time.
        /// </summary>
        public DateTime? DrgAssignedDateTime { get; set; }

        /// <summary>
        /// DRG.3 - DRG Approval Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string DrgApprovalIndicator { get; set; }

        /// <summary>
        /// DRG.4 - DRG Grouper Review Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0056</remarks>
        public CodedWithExceptions DrgGrouperReviewCode { get; set; }

        /// <summary>
        /// DRG.5 - Outlier Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0083</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0229</remarks>
        public CodedWithExceptions DrgPayor { get; set; }

        /// <summary>
        /// DRG.9 - Outlier Reimbursement.
        /// </summary>
        public CompositePrice OutlierReimbursement { get; set; }

        /// <summary>
        /// DRG.10 - Confidential Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string ConfidentialIndicator { get; set; }

        /// <summary>
        /// DRG.11 - DRG Transfer Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0415</remarks>
        public CodedWithExceptions DrgTransferType { get; set; }

        /// <summary>
        /// DRG.12 - Name of Coder.
        /// </summary>
        public ExtendedPersonName NameOfCoder { get; set; }

        /// <summary>
        /// DRG.13 - Grouper Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0734</remarks>
        public CodedWithExceptions GrouperStatus { get; set; }

        /// <summary>
        /// DRG.14 - PCCL Value Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0728</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0739</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0742</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0749</remarks>
        public CodedWithExceptions StatusGender { get; set; }

        /// <summary>
        /// DRG.27 - Status Age.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0749</remarks>
        public CodedWithExceptions StatusAge { get; set; }

        /// <summary>
        /// DRG.28 - Status Length of Stay.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0749</remarks>
        public CodedWithExceptions StatusLengthOfStay { get; set; }

        /// <summary>
        /// DRG.29 - Status Same Day Flag.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0749</remarks>
        public CodedWithExceptions StatusSameDayFlag { get; set; }

        /// <summary>
        /// DRG.30 - Status Separation Mode.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0749</remarks>
        public CodedWithExceptions StatusSeparationMode { get; set; }

        /// <summary>
        /// DRG.31 - Status Weight at Birth.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0755</remarks>
        public CodedWithExceptions StatusWeightAtBirth { get; set; }

        /// <summary>
        /// DRG.32 - Status Respiration Minutes.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0757</remarks>
        public CodedWithExceptions StatusRespirationMinutes { get; set; }

        /// <summary>
        /// DRG.33 - Status Admission.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0759</remarks>
        public CodedWithExceptions StatusAdmission { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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