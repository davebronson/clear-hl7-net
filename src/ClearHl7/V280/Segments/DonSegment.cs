using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment DON - Donation.
    /// </summary>
    public class DonSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DonSegment"/> class.
        /// </summary>
        public DonSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DonSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public DonSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "DON";

        /// <inheritdoc/>
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

            DonationIdentificationNumberDin = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[1], false, seps) : null;
            DonationType = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[2], false, seps) : null;
            PhlebotomyStartDateTime = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
            PhlebotomyEndDateTime = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            DonationDuration = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDecimal() : null;
            DonationDurationUnits = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[6], false, seps) : null;
            IntendedProcedureType = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithNoExceptions>(x, false, seps)) : null;
            ActualProcedureType = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithNoExceptions>(x, false, seps)) : null;
            DonorEligibilityFlag = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            DonorEligibilityProcedureType = segments.Length > 10 && segments[10].Length > 0 ? segments[10].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithNoExceptions>(x, false, seps)) : null;
            DonorEligibilityDate = segments.Length > 11 && segments[11].Length > 0 ? segments[11].ToNullableDateTime() : null;
            ProcessInterruption = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[12], false, seps) : null;
            ProcessInterruptionReason = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[13], false, seps) : null;
            PhlebotomyIssue = segments.Length > 14 && segments[14].Length > 0 ? segments[14].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithNoExceptions>(x, false, seps)) : null;
            IntendedRecipientBloodRelative = segments.Length > 15 && segments[15].Length > 0 ? segments[15] : null;
            IntendedRecipientName = segments.Length > 16 && segments[16].Length > 0 ? TypeSerializer.Deserialize<ExtendedPersonName>(segments[16], false, seps) : null;
            IntendedRecipientDob = segments.Length > 17 && segments[17].Length > 0 ? segments[17].ToNullableDateTime() : null;
            IntendedRecipientFacility = segments.Length > 18 && segments[18].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[18], false, seps) : null;
            IntendedRecipientProcedureDate = segments.Length > 19 && segments[19].Length > 0 ? segments[19].ToNullableDateTime() : null;
            IntendedRecipientOrderingProvider = segments.Length > 20 && segments[20].Length > 0 ? TypeSerializer.Deserialize<ExtendedPersonName>(segments[20], false, seps) : null;
            PhlebotomyStatus = segments.Length > 21 && segments[21].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[21], false, seps) : null;
            ArmStick = segments.Length > 22 && segments[22].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[22], false, seps) : null;
            BleedStartPhlebotomist = segments.Length > 23 && segments[23].Length > 0 ? TypeSerializer.Deserialize<ExtendedPersonName>(segments[23], false, seps) : null;
            BleedEndPhlebotomist = segments.Length > 24 && segments[24].Length > 0 ? TypeSerializer.Deserialize<ExtendedPersonName>(segments[24], false, seps) : null;
            AphaeresisTypeMachine = segments.Length > 25 && segments[25].Length > 0 ? segments[25] : null;
            AphaeresisMachineSerialNumber = segments.Length > 26 && segments[26].Length > 0 ? segments[26] : null;
            DonorReaction = segments.Length > 27 && segments[27].Length > 0 ? segments[27] : null;
            FinalReviewStaffId = segments.Length > 28 && segments[28].Length > 0 ? TypeSerializer.Deserialize<ExtendedPersonName>(segments[28], false, seps) : null;
            FinalReviewDateTime = segments.Length > 29 && segments[29].Length > 0 ? segments[29].ToNullableDateTime() : null;
            NumberOfTubesCollected = segments.Length > 30 && segments[30].Length > 0 ? segments[30].ToNullableDecimal() : null;
            DonationSampleIdentifier = segments.Length > 31 && segments[31].Length > 0 ? segments[31].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<EntityIdentifier>(x, false, seps)) : null;
            DonationAcceptStaff = segments.Length > 32 && segments[32].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[32], false, seps) : null;
            DonationMaterialReviewStaff = segments.Length > 33 && segments[33].Length > 0 ? segments[33].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 34, Configuration.FieldSeparator),
                                Id,
                                DonationIdentificationNumberDin?.ToDelimitedString(),
                                DonationType?.ToDelimitedString(),
                                PhlebotomyStartDateTime?.ToHl7DateTimeString(typeof(DonSegment), nameof(PhlebotomyStartDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                PhlebotomyEndDateTime?.ToHl7DateTimeString(typeof(DonSegment), nameof(PhlebotomyEndDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                DonationDuration.HasValue ? DonationDuration.Value.ToString(Consts.NumericFormat, culture) : null,
                                DonationDurationUnits?.ToDelimitedString(),
                                IntendedProcedureType != null ? string.Join(Configuration.FieldRepeatSeparator, IntendedProcedureType.Select(x => x.ToDelimitedString())) : null,
                                ActualProcedureType != null ? string.Join(Configuration.FieldRepeatSeparator, ActualProcedureType.Select(x => x.ToDelimitedString())) : null,
                                DonorEligibilityFlag,
                                DonorEligibilityProcedureType != null ? string.Join(Configuration.FieldRepeatSeparator, DonorEligibilityProcedureType.Select(x => x.ToDelimitedString())) : null,
                                DonorEligibilityDate?.ToHl7DateTimeString(typeof(DonSegment), nameof(DonorEligibilityDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                ProcessInterruption?.ToDelimitedString(),
                                ProcessInterruptionReason?.ToDelimitedString(),
                                PhlebotomyIssue != null ? string.Join(Configuration.FieldRepeatSeparator, PhlebotomyIssue.Select(x => x.ToDelimitedString())) : null,
                                IntendedRecipientBloodRelative,
                                IntendedRecipientName?.ToDelimitedString(),
                                IntendedRecipientDob?.ToHl7DateTimeString(typeof(DonSegment), nameof(IntendedRecipientDob), Consts.DateTimeFormatPrecisionSecond, culture),
                                IntendedRecipientFacility?.ToDelimitedString(),
                                IntendedRecipientProcedureDate?.ToHl7DateTimeString(typeof(DonSegment), nameof(IntendedRecipientProcedureDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                IntendedRecipientOrderingProvider?.ToDelimitedString(),
                                PhlebotomyStatus?.ToDelimitedString(),
                                ArmStick?.ToDelimitedString(),
                                BleedStartPhlebotomist?.ToDelimitedString(),
                                BleedEndPhlebotomist?.ToDelimitedString(),
                                AphaeresisTypeMachine,
                                AphaeresisMachineSerialNumber,
                                DonorReaction,
                                FinalReviewStaffId?.ToDelimitedString(),
                                FinalReviewDateTime?.ToHl7DateTimeString(typeof(DonSegment), nameof(FinalReviewDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                NumberOfTubesCollected.HasValue ? NumberOfTubesCollected.Value.ToString(Consts.NumericFormat, culture) : null,
                                DonationSampleIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, DonationSampleIdentifier.Select(x => x.ToDelimitedString())) : null,
                                DonationAcceptStaff?.ToDelimitedString(),
                                DonationMaterialReviewStaff != null ? string.Join(Configuration.FieldRepeatSeparator, DonationMaterialReviewStaff.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
