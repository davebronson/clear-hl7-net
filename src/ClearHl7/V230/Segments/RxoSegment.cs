using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
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
        /// <para>Suggested: 0161 Allow Substitution -&gt; ClearHl7.Codes.V230.CodeAllowSubstitution</para>
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
        public ExtendedCompositeIdNumberAndNameForPersons OrderingProvidersDeaNumber { get; set; }

        /// <summary>
        /// RXO.15 - Pharmacist/Treatment Supplier's Verifier ID.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons PharmacistTreatmentSuppliersVerifierId { get; set; }

        /// <summary>
        /// RXO.16 - Needs Human Review.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V230.CodeYesNoIndicator</para>
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

            RequestedGiveCode = segments.Length > 1 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(1), false) : null;
            RequestedGiveAmountMinimum = segments.ElementAtOrDefault(2)?.ToNullableDecimal();
            RequestedGiveAmountMaximum = segments.ElementAtOrDefault(3)?.ToNullableDecimal();
            RequestedGiveUnits = segments.Length > 4 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(4), false) : null;
            RequestedDosageForm = segments.Length > 5 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(5), false) : null;
            ProvidersPharmacyTreatmentInstructions = segments.Length > 6 ? segments.ElementAtOrDefault(6).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            ProvidersAdministrationInstructions = segments.Length > 7 ? segments.ElementAtOrDefault(7).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            DeliverToLocation = segments.Length > 8 ? TypeHelper.Deserialize<LocationWithAddressVariationOne>(segments.ElementAtOrDefault(8), false) : null;
            AllowSubstitutions = segments.ElementAtOrDefault(9);
            RequestedDispenseCode = segments.Length > 10 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(10), false) : null;
            RequestedDispenseAmount = segments.ElementAtOrDefault(11)?.ToNullableDecimal();
            RequestedDispenseUnits = segments.Length > 12 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(12), false) : null;
            NumberOfRefills = segments.ElementAtOrDefault(13)?.ToNullableDecimal();
            OrderingProvidersDeaNumber = segments.Length > 14 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(14), false) : null;
            PharmacistTreatmentSuppliersVerifierId = segments.Length > 15 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(15), false) : null;
            NeedsHumanReview = segments.ElementAtOrDefault(16);
            RequestedGivePerTimeUnit = segments.ElementAtOrDefault(17);
            RequestedGiveStrength = segments.ElementAtOrDefault(18)?.ToNullableDecimal();
            RequestedGiveStrengthUnits = segments.Length > 19 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(19), false) : null;
            Indication = segments.Length > 20 ? segments.ElementAtOrDefault(20).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            RequestedGiveRateAmount = segments.ElementAtOrDefault(21);
            RequestedGiveRateUnits = segments.Length > 22 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(22), false) : null;
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
                                StringHelper.StringFormatSequence(0, 23, Configuration.FieldSeparator),
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
                                OrderingProvidersDeaNumber?.ToDelimitedString(),
                                PharmacistTreatmentSuppliersVerifierId?.ToDelimitedString(),
                                NeedsHumanReview,
                                RequestedGivePerTimeUnit,
                                RequestedGiveStrength.HasValue ? RequestedGiveStrength.Value.ToString(Consts.NumericFormat, culture) : null,
                                RequestedGiveStrengthUnits?.ToDelimitedString(),
                                Indication != null ? string.Join(Configuration.FieldRepeatSeparator, Indication.Select(x => x.ToDelimitedString())) : null,
                                RequestedGiveRateAmount,
                                RequestedGiveRateUnits?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}