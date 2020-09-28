using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V281.Types;

namespace ClearHl7.Fhir.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment DON - Donation.
    /// </summary>
    public class DonSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "DON";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// DON.1 - Donation Identification Number - DIN.
        /// </summary>
        public EntityIdentifier DonationIdentificationNumberDin { get; set; }

        /// <summary>
        /// DON.2 - Donation Type.
        /// </summary>
        public CodedWithNoExceptions DonationType { get; set; }

        /// <summary>
        /// DON.3 - Phlebotomy Start Date/Time.
        /// </summary>
        public DateTime? PhlebotomyStartDateTime { get; set; }

        /// <summary>
        /// DON.4 - Phlebotomy End Date/Time.
        /// </summary>
        public DateTime? PhlebotomyEndDateTime { get; set; }

        /// <summary>
        /// DON.5 - Donation Duration.
        /// </summary>
        public decimal? DonationDuration { get; set; }

        /// <summary>
        /// DON.6 - Donation Duration Units.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0932</remarks>
        public CodedWithNoExceptions DonationDurationUnits { get; set; }

        /// <summary>
        /// DON.7 - Intended Procedure Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0933</remarks>
        public IEnumerable<CodedWithNoExceptions> IntendedProcedureType { get; set; }

        /// <summary>
        /// DON.8 - Actual Procedure Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0933</remarks>
        public IEnumerable<CodedWithNoExceptions> ActualProcedureType { get; set; }

        /// <summary>
        /// DON.9 - Donor Eligibility Flag.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string DonorEligibilityFlag { get; set; }

        /// <summary>
        /// DON.10 - Donor Eligibility Procedure Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0933</remarks>
        public IEnumerable<CodedWithNoExceptions> DonorEligibilityProcedureType { get; set; }

        /// <summary>
        /// DON.11 - Donor Eligibility Date.
        /// </summary>
        public DateTime? DonorEligibilityDate { get; set; }

        /// <summary>
        /// DON.12 - Process Interruption.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0923</remarks>
        public CodedWithNoExceptions ProcessInterruption { get; set; }

        /// <summary>
        /// DON.13 - Process Interruption Reason.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0935</remarks>
        public CodedWithNoExceptions ProcessInterruptionReason { get; set; }

        /// <summary>
        /// DON.14 - Phlebotomy Issue.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0925</remarks>
        public IEnumerable<CodedWithNoExceptions> PhlebotomyIssue { get; set; }

        /// <summary>
        /// DON.15 - Intended Recipient Blood Relative.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string IntendedRecipientBloodRelative { get; set; }

        /// <summary>
        /// DON.16 - Intended Recipient Name.
        /// </summary>
        public ExtendedPersonName IntendedRecipientName { get; set; }

        /// <summary>
        /// DON.17 - Intended Recipient DOB.
        /// </summary>
        public DateTime? IntendedRecipientDob { get; set; }

        /// <summary>
        /// DON.18 - Intended Recipient Facility.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations IntendedRecipientFacility { get; set; }

        /// <summary>
        /// DON.19 - Intended Recipient Procedure Date.
        /// </summary>
        public DateTime? IntendedRecipientProcedureDate { get; set; }

        /// <summary>
        /// DON.20 - Intended Recipient Ordering Provider.
        /// </summary>
        public ExtendedPersonName IntendedRecipientOrderingProvider { get; set; }

        /// <summary>
        /// DON.21 - Phlebotomy Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0926</remarks>
        public CodedWithNoExceptions PhlebotomyStatus { get; set; }

        /// <summary>
        /// DON.22 - Arm Stick.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0927</remarks>
        public CodedWithNoExceptions ArmStick { get; set; }

        /// <summary>
        /// DON.23 - Bleed Start Phlebotomist.
        /// </summary>
        public ExtendedPersonName BleedStartPhlebotomist { get; set; }

        /// <summary>
        /// DON.24 - Bleed End Phlebotomist.
        /// </summary>
        public ExtendedPersonName BleedEndPhlebotomist { get; set; }

        /// <summary>
        /// DON.25 - Aphaeresis Type Machine.
        /// </summary>
        public string AphaeresisTypeMachine { get; set; }

        /// <summary>
        /// DON.26 - Aphaeresis Machine Serial Number.
        /// </summary>
        public string AphaeresisMachineSerialNumber { get; set; }

        /// <summary>
        /// DON.27 - Donor Reaction.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string DonorReaction { get; set; }

        /// <summary>
        /// DON.28 - Final Review Staff ID.
        /// </summary>
        public ExtendedPersonName FinalReviewStaffId { get; set; }

        /// <summary>
        /// DON.29 - Final Review Date/Time.
        /// </summary>
        public DateTime? FinalReviewDateTime { get; set; }

        /// <summary>
        /// DON.30 - Number of Tubes Collected.
        /// </summary>
        public decimal? NumberOfTubesCollected { get; set; }

        /// <summary>
        /// DON.31 - Donation Sample Identifier.
        /// </summary>
        public IEnumerable<EntityIdentifier> DonationSampleIdentifier { get; set; }

        /// <summary>
        /// DON.32 - Donation Accept Staff.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons DonationAcceptStaff { get; set; }

        /// <summary>
        /// DON.33 - Donation Material Review Staff.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> DonationMaterialReviewStaff { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}|{30}|{31}|{32}|{33}",
                                Id,
                                DonationIdentificationNumberDin?.ToDelimitedString(),
                                DonationType?.ToDelimitedString(),
                                PhlebotomyStartDateTime.HasValue ? PhlebotomyStartDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PhlebotomyEndDateTime.HasValue ? PhlebotomyEndDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DonationDuration.HasValue ? DonationDuration.Value.ToString(Consts.NumericFormat, culture) : null,
                                DonationDurationUnits?.ToDelimitedString(),
                                IntendedProcedureType != null ? string.Join("~", IntendedProcedureType.Select(x => x.ToDelimitedString())) : null,
                                ActualProcedureType != null ? string.Join("~", ActualProcedureType.Select(x => x.ToDelimitedString())) : null,
                                DonorEligibilityFlag,
                                DonorEligibilityProcedureType != null ? string.Join("~", DonorEligibilityProcedureType.Select(x => x.ToDelimitedString())) : null,
                                DonorEligibilityDate.HasValue ? DonorEligibilityDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ProcessInterruption?.ToDelimitedString(),
                                ProcessInterruptionReason?.ToDelimitedString(),
                                PhlebotomyIssue != null ? string.Join("~", PhlebotomyIssue.Select(x => x.ToDelimitedString())) : null,
                                IntendedRecipientBloodRelative,
                                IntendedRecipientName?.ToDelimitedString(),
                                IntendedRecipientDob.HasValue ? IntendedRecipientDob.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                IntendedRecipientFacility?.ToDelimitedString(),
                                IntendedRecipientProcedureDate.HasValue ? IntendedRecipientProcedureDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                IntendedRecipientOrderingProvider?.ToDelimitedString(),
                                PhlebotomyStatus?.ToDelimitedString(),
                                ArmStick?.ToDelimitedString(),
                                BleedStartPhlebotomist?.ToDelimitedString(),
                                BleedEndPhlebotomist?.ToDelimitedString(),
                                AphaeresisTypeMachine,
                                AphaeresisMachineSerialNumber,
                                DonorReaction,
                                FinalReviewStaffId?.ToDelimitedString(),
                                FinalReviewDateTime.HasValue ? FinalReviewDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                NumberOfTubesCollected.HasValue ? NumberOfTubesCollected.Value.ToString(Consts.NumericFormat, culture) : null,
                                DonationSampleIdentifier != null ? string.Join("~", DonationSampleIdentifier.Select(x => x.ToDelimitedString())) : null,
                                DonationAcceptStaff?.ToDelimitedString(),
                                DonationMaterialReviewStaff != null ? string.Join("~", DonationMaterialReviewStaff.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd('|');
        }
    }
}