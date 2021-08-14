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
        /// <para>Suggested: 0932 Donation Duration Units</para>
        /// </summary>
        public CodedWithNoExceptions DonationDurationUnits { get; set; }

        /// <summary>
        /// DON.7 - Intended Procedure Type.
        /// <para>Suggested: 0933 Intended Procedure Type -&gt; ClearHl7.Codes.V280.CodeIntendedProcedureType</para>
        /// </summary>
        public IEnumerable<CodedWithNoExceptions> IntendedProcedureType { get; set; }

        /// <summary>
        /// DON.8 - Actual Procedure Type.
        /// <para>Suggested: 0933 Intended Procedure Type -&gt; ClearHl7.Codes.V280.CodeIntendedProcedureType</para>
        /// </summary>
        public IEnumerable<CodedWithNoExceptions> ActualProcedureType { get; set; }

        /// <summary>
        /// DON.9 - Donor Eligibility Flag.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V280.CodeYesNoIndicator</para>
        /// </summary>
        public string DonorEligibilityFlag { get; set; }

        /// <summary>
        /// DON.10 - Donor Eligibility Procedure Type.
        /// <para>Suggested: 0933 Intended Procedure Type -&gt; ClearHl7.Codes.V280.CodeIntendedProcedureType</para>
        /// </summary>
        public IEnumerable<CodedWithNoExceptions> DonorEligibilityProcedureType { get; set; }

        /// <summary>
        /// DON.11 - Donor Eligibility Date.
        /// </summary>
        public DateTime? DonorEligibilityDate { get; set; }

        /// <summary>
        /// DON.12 - Process Interruption.
        /// <para>Suggested: 0923 Process Interruption -&gt; ClearHl7.Codes.V280.CodeProcessInterruption</para>
        /// </summary>
        public CodedWithNoExceptions ProcessInterruption { get; set; }

        /// <summary>
        /// DON.13 - Process Interruption Reason.
        /// <para>Suggested: 0935 Process Interruption Reason -&gt; ClearHl7.Codes.V280.CodeProcessInterruptionReason</para>
        /// </summary>
        public CodedWithNoExceptions ProcessInterruptionReason { get; set; }

        /// <summary>
        /// DON.14 - Phlebotomy Issue.
        /// <para>Suggested: 0925 Phlebotomy Issue -&gt; ClearHl7.Codes.V280.CodePhlebotomyIssue</para>
        /// </summary>
        public IEnumerable<CodedWithNoExceptions> PhlebotomyIssue { get; set; }

        /// <summary>
        /// DON.15 - Intended Recipient Blood Relative.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V280.CodeYesNoIndicator</para>
        /// </summary>
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
        /// <para>Suggested: 0926 Phlebotomy Status -&gt; ClearHl7.Codes.V280.CodePhlebotomyStatus</para>
        /// </summary>
        public CodedWithNoExceptions PhlebotomyStatus { get; set; }

        /// <summary>
        /// DON.22 - Arm Stick.
        /// <para>Suggested: 0927 Arm Stick -&gt; ClearHl7.Codes.V280.CodeArmStick</para>
        /// </summary>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V280.CodeYesNoIndicator</para>
        /// </summary>
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

            DonationIdentificationNumberDin = segments.Length > 1 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(1), false) : null;
            DonationType = segments.Length > 2 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(2), false) : null;
            PhlebotomyStartDateTime = segments.ElementAtOrDefault(3)?.ToNullableDateTime();
            PhlebotomyEndDateTime = segments.ElementAtOrDefault(4)?.ToNullableDateTime();
            DonationDuration = segments.ElementAtOrDefault(5)?.ToNullableDecimal();
            DonationDurationUnits = segments.Length > 6 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(6), false) : null;
            IntendedProcedureType = segments.Length > 7 ? segments.ElementAtOrDefault(7).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithNoExceptions>(x, false)) : null;
            ActualProcedureType = segments.Length > 8 ? segments.ElementAtOrDefault(8).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithNoExceptions>(x, false)) : null;
            DonorEligibilityFlag = segments.ElementAtOrDefault(9);
            DonorEligibilityProcedureType = segments.Length > 10 ? segments.ElementAtOrDefault(10).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithNoExceptions>(x, false)) : null;
            DonorEligibilityDate = segments.ElementAtOrDefault(11)?.ToNullableDateTime();
            ProcessInterruption = segments.Length > 12 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(12), false) : null;
            ProcessInterruptionReason = segments.Length > 13 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(13), false) : null;
            PhlebotomyIssue = segments.Length > 14 ? segments.ElementAtOrDefault(14).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithNoExceptions>(x, false)) : null;
            IntendedRecipientBloodRelative = segments.ElementAtOrDefault(15);
            IntendedRecipientName = segments.Length > 16 ? TypeHelper.Deserialize<ExtendedPersonName>(segments.ElementAtOrDefault(16), false) : null;
            IntendedRecipientDob = segments.ElementAtOrDefault(17)?.ToNullableDateTime();
            IntendedRecipientFacility = segments.Length > 18 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments.ElementAtOrDefault(18), false) : null;
            IntendedRecipientProcedureDate = segments.ElementAtOrDefault(19)?.ToNullableDateTime();
            IntendedRecipientOrderingProvider = segments.Length > 20 ? TypeHelper.Deserialize<ExtendedPersonName>(segments.ElementAtOrDefault(20), false) : null;
            PhlebotomyStatus = segments.Length > 21 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(21), false) : null;
            ArmStick = segments.Length > 22 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(22), false) : null;
            BleedStartPhlebotomist = segments.Length > 23 ? TypeHelper.Deserialize<ExtendedPersonName>(segments.ElementAtOrDefault(23), false) : null;
            BleedEndPhlebotomist = segments.Length > 24 ? TypeHelper.Deserialize<ExtendedPersonName>(segments.ElementAtOrDefault(24), false) : null;
            AphaeresisTypeMachine = segments.ElementAtOrDefault(25);
            AphaeresisMachineSerialNumber = segments.ElementAtOrDefault(26);
            DonorReaction = segments.ElementAtOrDefault(27);
            FinalReviewStaffId = segments.Length > 28 ? TypeHelper.Deserialize<ExtendedPersonName>(segments.ElementAtOrDefault(28), false) : null;
            FinalReviewDateTime = segments.ElementAtOrDefault(29)?.ToNullableDateTime();
            NumberOfTubesCollected = segments.ElementAtOrDefault(30)?.ToNullableDecimal();
            DonationSampleIdentifier = segments.Length > 31 ? segments.ElementAtOrDefault(31).Split(separator).Select(x => TypeHelper.Deserialize<EntityIdentifier>(x, false)) : null;
            DonationAcceptStaff = segments.Length > 32 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(32), false) : null;
            DonationMaterialReviewStaff = segments.Length > 33 ? segments.ElementAtOrDefault(33).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
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
                                DonationIdentificationNumberDin?.ToDelimitedString(),
                                DonationType?.ToDelimitedString(),
                                PhlebotomyStartDateTime.HasValue ? PhlebotomyStartDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PhlebotomyEndDateTime.HasValue ? PhlebotomyEndDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DonationDuration.HasValue ? DonationDuration.Value.ToString(Consts.NumericFormat, culture) : null,
                                DonationDurationUnits?.ToDelimitedString(),
                                IntendedProcedureType != null ? string.Join(Configuration.FieldRepeatSeparator, IntendedProcedureType.Select(x => x.ToDelimitedString())) : null,
                                ActualProcedureType != null ? string.Join(Configuration.FieldRepeatSeparator, ActualProcedureType.Select(x => x.ToDelimitedString())) : null,
                                DonorEligibilityFlag,
                                DonorEligibilityProcedureType != null ? string.Join(Configuration.FieldRepeatSeparator, DonorEligibilityProcedureType.Select(x => x.ToDelimitedString())) : null,
                                DonorEligibilityDate.HasValue ? DonorEligibilityDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ProcessInterruption?.ToDelimitedString(),
                                ProcessInterruptionReason?.ToDelimitedString(),
                                PhlebotomyIssue != null ? string.Join(Configuration.FieldRepeatSeparator, PhlebotomyIssue.Select(x => x.ToDelimitedString())) : null,
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
                                DonationSampleIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, DonationSampleIdentifier.Select(x => x.ToDelimitedString())) : null,
                                DonationAcceptStaff?.ToDelimitedString(),
                                DonationMaterialReviewStaff != null ? string.Join(Configuration.FieldRepeatSeparator, DonationMaterialReviewStaff.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}