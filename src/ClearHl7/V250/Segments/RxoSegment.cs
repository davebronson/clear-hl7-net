using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RXO - Pharmacy Treatment Order.
    /// </summary>
    public class RxoSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RxoSegment"/> class.
        /// </summary>
        public RxoSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RxoSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public RxoSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "RXO";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// RXO.1 - Requested Give Code.
        /// </summary>
        public CodedElement RequestedGiveCode { get; set; }

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
        /// </summary>
        public CodedElement RequestedGiveUnits { get; set; }

        /// <summary>
        /// RXO.5 - Requested Dosage Form.
        /// </summary>
        public CodedElement RequestedDosageForm { get; set; }

        /// <summary>
        /// RXO.6 - Provider's Pharmacy/Treatment Instructions.
        /// </summary>
        public IEnumerable<CodedElement> ProvidersPharmacyTreatmentInstructions { get; set; }

        /// <summary>
        /// RXO.7 - Provider's Administration Instructions.
        /// </summary>
        public IEnumerable<CodedElement> ProvidersAdministrationInstructions { get; set; }

        /// <summary>
        /// RXO.8 - Deliver-To Location.
        /// </summary>
        public LocationWithAddressVariationOne DeliverToLocation { get; set; }

        /// <summary>
        /// RXO.9 - Allow Substitutions.
        /// <para>Suggested: 0161 Allow Substitution -&gt; ClearHl7.Codes.V250.CodeAllowSubstitution</para>
        /// </summary>
        public string AllowSubstitutions { get; set; }

        /// <summary>
        /// RXO.10 - Requested Dispense Code.
        /// </summary>
        public CodedElement RequestedDispenseCode { get; set; }

        /// <summary>
        /// RXO.11 - Requested Dispense Amount.
        /// </summary>
        public decimal? RequestedDispenseAmount { get; set; }

        /// <summary>
        /// RXO.12 - Requested Dispense Units.
        /// </summary>
        public CodedElement RequestedDispenseUnits { get; set; }

        /// <summary>
        /// RXO.13 - Number Of Refills.
        /// </summary>
        public decimal? NumberOfRefills { get; set; }

        /// <summary>
        /// RXO.14 - Ordering Provider's DEA Number.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> OrderingProvidersDeaNumber { get; set; }

        /// <summary>
        /// RXO.15 - Pharmacist/Treatment Supplier's Verifier ID.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> PharmacistTreatmentSuppliersVerifierId { get; set; }

        /// <summary>
        /// RXO.16 - Needs Human Review.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V250.CodeYesNoIndicator</para>
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
        /// </summary>
        public CodedElement RequestedGiveStrengthUnits { get; set; }

        /// <summary>
        /// RXO.20 - Indication.
        /// </summary>
        public IEnumerable<CodedElement> Indication { get; set; }

        /// <summary>
        /// RXO.21 - Requested Give Rate Amount.
        /// </summary>
        public string RequestedGiveRateAmount { get; set; }

        /// <summary>
        /// RXO.22 - Requested Give Rate Units.
        /// </summary>
        public CodedElement RequestedGiveRateUnits { get; set; }

        /// <summary>
        /// RXO.23 - Total Daily Dose.
        /// </summary>
        public CompositeQuantityWithUnits TotalDailyDose { get; set; }

        /// <summary>
        /// RXO.24 - Supplementary Code.
        /// </summary>
        public IEnumerable<CodedElement> SupplementaryCode { get; set; }

        /// <summary>
        /// RXO.25 - Requested Drug Strength Volume.
        /// </summary>
        public decimal? RequestedDrugStrengthVolume { get; set; }

        /// <summary>
        /// RXO.26 - Requested Drug Strength Volume Units.
        /// </summary>
        public CodedWithExceptions RequestedDrugStrengthVolumeUnits { get; set; }

        /// <summary>
        /// RXO.27 - Pharmacy Order Type.
        /// <para>Suggested: 0480 Pharmacy Order Types -&gt; ClearHl7.Codes.V250.CodePharmacyOrderTypes</para>
        /// </summary>
        public string PharmacyOrderType { get; set; }

        /// <summary>
        /// RXO.28 - Dispensing Interval.
        /// </summary>
        public decimal? DispensingInterval { get; set; }

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

            RequestedGiveCode = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[1], false, seps) : null;
            RequestedGiveAmountMinimum = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
            RequestedGiveAmountMaximum = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDecimal() : null;
            RequestedGiveUnits = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[4], false, seps) : null;
            RequestedDosageForm = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[5], false, seps) : null;
            ProvidersPharmacyTreatmentInstructions = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            ProvidersAdministrationInstructions = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            DeliverToLocation = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<LocationWithAddressVariationOne>(segments[8], false, seps) : null;
            AllowSubstitutions = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            RequestedDispenseCode = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[10], false, seps) : null;
            RequestedDispenseAmount = segments.Length > 11 && segments[11].Length > 0 ? segments[11].ToNullableDecimal() : null;
            RequestedDispenseUnits = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[12], false, seps) : null;
            NumberOfRefills = segments.Length > 13 && segments[13].Length > 0 ? segments[13].ToNullableDecimal() : null;
            OrderingProvidersDeaNumber = segments.Length > 14 && segments[14].Length > 0 ? segments[14].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            PharmacistTreatmentSuppliersVerifierId = segments.Length > 15 && segments[15].Length > 0 ? segments[15].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            NeedsHumanReview = segments.Length > 16 && segments[16].Length > 0 ? segments[16] : null;
            RequestedGivePerTimeUnit = segments.Length > 17 && segments[17].Length > 0 ? segments[17] : null;
            RequestedGiveStrength = segments.Length > 18 && segments[18].Length > 0 ? segments[18].ToNullableDecimal() : null;
            RequestedGiveStrengthUnits = segments.Length > 19 && segments[19].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[19], false, seps) : null;
            Indication = segments.Length > 20 && segments[20].Length > 0 ? segments[20].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            RequestedGiveRateAmount = segments.Length > 21 && segments[21].Length > 0 ? segments[21] : null;
            RequestedGiveRateUnits = segments.Length > 22 && segments[22].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[22], false, seps) : null;
            TotalDailyDose = segments.Length > 23 && segments[23].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[23], false, seps) : null;
            SupplementaryCode = segments.Length > 24 && segments[24].Length > 0 ? segments[24].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            RequestedDrugStrengthVolume = segments.Length > 25 && segments[25].Length > 0 ? segments[25].ToNullableDecimal() : null;
            RequestedDrugStrengthVolumeUnits = segments.Length > 26 && segments[26].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[26], false, seps) : null;
            PharmacyOrderType = segments.Length > 27 && segments[27].Length > 0 ? segments[27] : null;
            DispensingInterval = segments.Length > 28 && segments[28].Length > 0 ? segments[28].ToNullableDecimal() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 29, Configuration.FieldSeparator),
                                Id,
                                RequestedGiveCode?.ToDelimitedString(),
                                RequestedGiveAmountMinimum.HasValue ? RequestedGiveAmountMinimum.Value.ToString(Consts.NumericFormat, culture) : null,
                                RequestedGiveAmountMaximum.HasValue ? RequestedGiveAmountMaximum.Value.ToString(Consts.NumericFormat, culture) : null,
                                RequestedGiveUnits?.ToDelimitedString(),
                                RequestedDosageForm?.ToDelimitedString(),
                                ProvidersPharmacyTreatmentInstructions != null ? string.Join(Configuration.FieldRepeatSeparator, ProvidersPharmacyTreatmentInstructions.Select(x => x.ToDelimitedString())) : null,
                                ProvidersAdministrationInstructions != null ? string.Join(Configuration.FieldRepeatSeparator, ProvidersAdministrationInstructions.Select(x => x.ToDelimitedString())) : null,
                                DeliverToLocation?.ToDelimitedString(),
                                AllowSubstitutions,
                                RequestedDispenseCode?.ToDelimitedString(),
                                RequestedDispenseAmount.HasValue ? RequestedDispenseAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                RequestedDispenseUnits?.ToDelimitedString(),
                                NumberOfRefills.HasValue ? NumberOfRefills.Value.ToString(Consts.NumericFormat, culture) : null,
                                OrderingProvidersDeaNumber != null ? string.Join(Configuration.FieldRepeatSeparator, OrderingProvidersDeaNumber.Select(x => x.ToDelimitedString())) : null,
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
                                DispensingInterval.HasValue ? DispensingInterval.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
