using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RXO - Pharmacy Treatment Order.
    /// </summary>
    public class RxoSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RXO";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// RXO.1 - Requested Give Code.
        /// <para>Suggested: 0747 Requested Give Code</para>
        /// </summary>
        public CodedWithExceptions RequestedGiveCode { get; set; }

        /// <summary>
        /// RXO.2 - Requested Give Amount - Minimum.
        /// </summary>
        public decimal? RequestedGiveAmountMinimum { get; set; }

        /// <summary>
        /// RXO.3 - Requested Give Amount - Maximum.
        /// </summary>
        public decimal? RequestedGiveAmountMaximum { get; set; }

        /// <summary>
        /// RXO.4 - Requested Give Units.
        /// <para>Suggested: 0748 Requested Give Units</para>
        /// </summary>
        public CodedWithExceptions RequestedGiveUnits { get; set; }

        /// <summary>
        /// RXO.5 - Requested Dosage Form.
        /// <para>Suggested: 0750 Requested Dosage Form</para>
        /// </summary>
        public CodedWithExceptions RequestedDosageForm { get; set; }

        /// <summary>
        /// RXO.6 - Provider's Pharmacy/Treatment Instructions.
        /// <para>Suggested: 0751 Provider's Pharmacy/Treatment Instructions</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ProvidersPharmacyTreatmentInstructions { get; set; }

        /// <summary>
        /// RXO.7 - Provider's Administration Instructions.
        /// <para>Suggested: 0718 Provider's Administration Instructions</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ProvidersAdministrationInstructions { get; set; }

        /// <summary>
        /// RXO.8 - Deliver-To Location.
        /// </summary>
        public string DeliverToLocation { get; set; }

        /// <summary>
        /// RXO.9 - Allow Substitutions.
        /// <para>Suggested: 0161 Allow Substitution -&gt; ClearHl7.Codes.V290.CodeAllowSubstitution</para>
        /// </summary>
        public string AllowSubstitutions { get; set; }

        /// <summary>
        /// RXO.10 - Requested Dispense Code.
        /// <para>Suggested: 0753 Requested Dispense Code</para>
        /// </summary>
        public CodedWithExceptions RequestedDispenseCode { get; set; }

        /// <summary>
        /// RXO.11 - Requested Dispense Amount.
        /// </summary>
        public decimal? RequestedDispenseAmount { get; set; }

        /// <summary>
        /// RXO.12 - Requested Dispense Units.
        /// <para>Suggested: 0754 Requested Dispense Units</para>
        /// </summary>
        public CodedWithExceptions RequestedDispenseUnits { get; set; }

        /// <summary>
        /// RXO.13 - Number Of Refills.
        /// </summary>
        public decimal? NumberOfRefills { get; set; }

        /// <summary>
        /// RXO.14 - Ordering Provider's DEA Number.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons OrderingProvidersDeaNumber { get; set; }

        /// <summary>
        /// RXO.15 - Pharmacist/Treatment Supplier's Verifier ID.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> PharmacistTreatmentSuppliersVerifierId { get; set; }

        /// <summary>
        /// RXO.16 - Needs Human Review.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string NeedsHumanReview { get; set; }

        /// <summary>
        /// RXO.17 - Requested Give Per (Time Unit).
        /// </summary>
        public string RequestedGivePerTimeUnit { get; set; }

        /// <summary>
        /// RXO.18 - Requested Give Strength.
        /// </summary>
        public decimal? RequestedGiveStrength { get; set; }

        /// <summary>
        /// RXO.19 - Requested Give Strength Units.
        /// <para>Suggested: 0756 Requested Give Strength Units</para>
        /// </summary>
        public CodedWithExceptions RequestedGiveStrengthUnits { get; set; }

        /// <summary>
        /// RXO.20 - Indication.
        /// <para>Suggested: 0694 Indication</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> Indication { get; set; }

        /// <summary>
        /// RXO.21 - Requested Give Rate Amount.
        /// </summary>
        public string RequestedGiveRateAmount { get; set; }

        /// <summary>
        /// RXO.22 - Requested Give Rate Units.
        /// <para>Suggested: 0760 Requested Give Rate Units</para>
        /// </summary>
        public CodedWithExceptions RequestedGiveRateUnits { get; set; }

        /// <summary>
        /// RXO.23 - Total Daily Dose.
        /// </summary>
        public CompositeQuantityWithUnits TotalDailyDose { get; set; }

        /// <summary>
        /// RXO.24 - Supplementary Code.
        /// <para>Suggested: 0700 Supplementary Code</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> SupplementaryCode { get; set; }

        /// <summary>
        /// RXO.25 - Requested Drug Strength Volume.
        /// </summary>
        public decimal? RequestedDrugStrengthVolume { get; set; }

        /// <summary>
        /// RXO.26 - Requested Drug Strength Volume Units.
        /// <para>Suggested: 0764 Requested Drug Strength Volume Units</para>
        /// </summary>
        public CodedWithExceptions RequestedDrugStrengthVolumeUnits { get; set; }

        /// <summary>
        /// RXO.27 - Pharmacy Order Type.
        /// <para>Suggested: 0480 Pharmacy Order Types -&gt; ClearHl7.Codes.V290.CodePharmacyOrderTypes</para>
        /// </summary>
        public string PharmacyOrderType { get; set; }

        /// <summary>
        /// RXO.28 - Dispensing Interval.
        /// </summary>
        public decimal? DispensingInterval { get; set; }

        /// <summary>
        /// RXO.29 - Medication Instance Identifier.
        /// </summary>
        public EntityIdentifier MedicationInstanceIdentifier { get; set; }

        /// <summary>
        /// RXO.30 - Segment Instance Identifier.
        /// </summary>
        public EntityIdentifier SegmentInstanceIdentifier { get; set; }

        /// <summary>
        /// RXO.31 - Mood Code.
        /// <para>Suggested: 0725 Mood Codes -&gt; ClearHl7.Codes.V290.CodeMoodCodes</para>
        /// </summary>
        public CodedWithNoExceptions MoodCode { get; set; }

        /// <summary>
        /// RXO.32 - Dispensing Pharmacy.
        /// <para>Suggested: 0733 Dispensing Pharmacy</para>
        /// </summary>
        public CodedWithExceptions DispensingPharmacy { get; set; }

        /// <summary>
        /// RXO.33 - Dispensing Pharmacy Address.
        /// </summary>
        public ExtendedAddress DispensingPharmacyAddress { get; set; }

        /// <summary>
        /// RXO.34 - Deliver-to Patient Location.
        /// </summary>
        public PersonLocation DeliverToPatientLocation { get; set; }

        /// <summary>
        /// RXO.35 - Deliver-to Address.
        /// </summary>
        public ExtendedAddress DeliverToAddress { get; set; }

        /// <summary>
        /// RXO.36 - Pharmacy Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> PharmacyPhoneNumber { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public RxoSegment FromDelimitedString(string delimitedString)
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

            RequestedGiveCode = segments.Length > 1 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(1)) : null;
            RequestedGiveAmountMinimum = segments.ElementAtOrDefault(2)?.ToNullableDecimal();
            RequestedGiveAmountMaximum = segments.ElementAtOrDefault(3)?.ToNullableDecimal();
            RequestedGiveUnits = segments.Length > 4 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(4)) : null;
            RequestedDosageForm = segments.Length > 5 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(5)) : null;
            ProvidersPharmacyTreatmentInstructions = segments.Length > 6 ? segments.ElementAtOrDefault(6).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            ProvidersAdministrationInstructions = segments.Length > 7 ? segments.ElementAtOrDefault(7).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            DeliverToLocation = segments.ElementAtOrDefault(8);
            AllowSubstitutions = segments.ElementAtOrDefault(9);
            RequestedDispenseCode = segments.Length > 10 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(10)) : null;
            RequestedDispenseAmount = segments.ElementAtOrDefault(11)?.ToNullableDecimal();
            RequestedDispenseUnits = segments.Length > 12 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(12)) : null;
            NumberOfRefills = segments.ElementAtOrDefault(13)?.ToNullableDecimal();
            OrderingProvidersDeaNumber = segments.Length > 14 ? new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(segments.ElementAtOrDefault(14)) : null;
            PharmacistTreatmentSuppliersVerifierId = segments.Length > 15 ? segments.ElementAtOrDefault(15).Split(separator).Select(x => new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(x)) : null;
            NeedsHumanReview = segments.ElementAtOrDefault(16);
            RequestedGivePerTimeUnit = segments.ElementAtOrDefault(17);
            RequestedGiveStrength = segments.ElementAtOrDefault(18)?.ToNullableDecimal();
            RequestedGiveStrengthUnits = segments.Length > 19 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(19)) : null;
            Indication = segments.Length > 20 ? segments.ElementAtOrDefault(20).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            RequestedGiveRateAmount = segments.ElementAtOrDefault(21);
            RequestedGiveRateUnits = segments.Length > 22 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(22)) : null;
            TotalDailyDose = segments.Length > 23 ? new CompositeQuantityWithUnits().FromDelimitedString(segments.ElementAtOrDefault(23)) : null;
            SupplementaryCode = segments.Length > 24 ? segments.ElementAtOrDefault(24).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            RequestedDrugStrengthVolume = segments.ElementAtOrDefault(25)?.ToNullableDecimal();
            RequestedDrugStrengthVolumeUnits = segments.Length > 26 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(26)) : null;
            PharmacyOrderType = segments.ElementAtOrDefault(27);
            DispensingInterval = segments.ElementAtOrDefault(28)?.ToNullableDecimal();
            MedicationInstanceIdentifier = segments.Length > 29 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(29)) : null;
            SegmentInstanceIdentifier = segments.Length > 30 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(30)) : null;
            MoodCode = segments.Length > 31 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(31)) : null;
            DispensingPharmacy = segments.Length > 32 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(32)) : null;
            DispensingPharmacyAddress = segments.Length > 33 ? new ExtendedAddress().FromDelimitedString(segments.ElementAtOrDefault(33)) : null;
            DeliverToPatientLocation = segments.Length > 34 ? new PersonLocation().FromDelimitedString(segments.ElementAtOrDefault(34)) : null;
            DeliverToAddress = segments.Length > 35 ? new ExtendedAddress().FromDelimitedString(segments.ElementAtOrDefault(35)) : null;
            PharmacyPhoneNumber = segments.Length > 36 ? segments.ElementAtOrDefault(36).Split(separator).Select(x => new ExtendedTelecommunicationNumber().FromDelimitedString(x)) : null;
            
            return this;
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
                                StringHelper.StringFormatSequence(0, 37, Configuration.FieldSeparator),
                                Id,
                                RequestedGiveCode?.ToDelimitedString(),
                                RequestedGiveAmountMinimum.HasValue ? RequestedGiveAmountMinimum.Value.ToString(Consts.NumericFormat, culture) : null,
                                RequestedGiveAmountMaximum.HasValue ? RequestedGiveAmountMaximum.Value.ToString(Consts.NumericFormat, culture) : null,
                                RequestedGiveUnits?.ToDelimitedString(),
                                RequestedDosageForm?.ToDelimitedString(),
                                ProvidersPharmacyTreatmentInstructions != null ? string.Join(Configuration.FieldRepeatSeparator, ProvidersPharmacyTreatmentInstructions.Select(x => x.ToDelimitedString())) : null,
                                ProvidersAdministrationInstructions != null ? string.Join(Configuration.FieldRepeatSeparator, ProvidersAdministrationInstructions.Select(x => x.ToDelimitedString())) : null,
                                DeliverToLocation,
                                AllowSubstitutions,
                                RequestedDispenseCode?.ToDelimitedString(),
                                RequestedDispenseAmount.HasValue ? RequestedDispenseAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                RequestedDispenseUnits?.ToDelimitedString(),
                                NumberOfRefills.HasValue ? NumberOfRefills.Value.ToString(Consts.NumericFormat, culture) : null,
                                OrderingProvidersDeaNumber?.ToDelimitedString(),
                                PharmacistTreatmentSuppliersVerifierId != null ? string.Join(Configuration.FieldRepeatSeparator, PharmacistTreatmentSuppliersVerifierId.Select(x => x.ToDelimitedString())) : null,
                                NeedsHumanReview,
                                RequestedGivePerTimeUnit,
                                RequestedGiveStrength.HasValue ? RequestedGiveStrength.Value.ToString(Consts.NumericFormat, culture) : null,
                                RequestedGiveStrengthUnits?.ToDelimitedString(),
                                Indication != null ? string.Join(Configuration.FieldRepeatSeparator, Indication.Select(x => x.ToDelimitedString())) : null,
                                RequestedGiveRateAmount,
                                RequestedGiveRateUnits?.ToDelimitedString(),
                                TotalDailyDose?.ToDelimitedString(),
                                SupplementaryCode != null ? string.Join(Configuration.FieldRepeatSeparator, SupplementaryCode.Select(x => x.ToDelimitedString())) : null,
                                RequestedDrugStrengthVolume.HasValue ? RequestedDrugStrengthVolume.Value.ToString(Consts.NumericFormat, culture) : null,
                                RequestedDrugStrengthVolumeUnits?.ToDelimitedString(),
                                PharmacyOrderType,
                                DispensingInterval.HasValue ? DispensingInterval.Value.ToString(Consts.NumericFormat, culture) : null,
                                MedicationInstanceIdentifier?.ToDelimitedString(),
                                SegmentInstanceIdentifier?.ToDelimitedString(),
                                MoodCode?.ToDelimitedString(),
                                DispensingPharmacy?.ToDelimitedString(),
                                DispensingPharmacyAddress?.ToDelimitedString(),
                                DeliverToPatientLocation?.ToDelimitedString(),
                                DeliverToAddress?.ToDelimitedString(),
                                PharmacyPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, PharmacyPhoneNumber.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}