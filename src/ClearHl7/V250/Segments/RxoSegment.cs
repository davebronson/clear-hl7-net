using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0161</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0480</remarks>
        public string PharmacyOrderType { get; set; }

        /// <summary>
        /// RXO.28 - Dispensing Interval.
        /// </summary>
        public decimal? DispensingInterval { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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