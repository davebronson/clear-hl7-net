using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RXG - Pharmacy Treatment Give.
    /// </summary>
    public class RxgSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RXG";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// RXG.1 - Give Sub-ID Counter.
        /// </summary>
        public decimal? GiveSubIdCounter { get; set; }

        /// <summary>
        /// RXG.2 - Dispense Sub-ID Counter.
        /// </summary>
        public decimal? DispenseSubIdCounter { get; set; }

        /// <summary>
        /// RXG.3 - Quantity/Timing.
        /// </summary>
        public TimingQuantity QuantityTiming { get; set; }

        /// <summary>
        /// RXG.4 - Give Code.
        /// <para>Suggested: 0292 Vaccines Administered -&gt; ClearHl7.Codes.V240.CodeVaccinesAdministered</para>
        /// </summary>
        public CodedElement GiveCode { get; set; }

        /// <summary>
        /// RXG.5 - Give Amount - Minimum.
        /// </summary>
        public decimal? GiveAmountMinimum { get; set; }

        /// <summary>
        /// RXG.6 - Give Amount - Maximum.
        /// </summary>
        public decimal? GiveAmountMaximum { get; set; }

        /// <summary>
        /// RXG.7 - Give Units.
        /// </summary>
        public CodedElement GiveUnits { get; set; }

        /// <summary>
        /// RXG.8 - Give Dosage Form.
        /// </summary>
        public CodedElement GiveDosageForm { get; set; }

        /// <summary>
        /// RXG.9 - Administration Notes.
        /// </summary>
        public IEnumerable<CodedElement> AdministrationNotes { get; set; }

        /// <summary>
        /// RXG.10 - Substitution Status.
        /// <para>Suggested: 0167 Substitution Status -&gt; ClearHl7.Codes.V240.CodeSubstitutionStatus</para>
        /// </summary>
        public string SubstitutionStatus { get; set; }

        /// <summary>
        /// RXG.11 - Dispense-to Location.
        /// </summary>
        public LocationWithAddressVariationTwo DispenseToLocation { get; set; }

        /// <summary>
        /// RXG.12 - Needs Human Review.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V240.CodeYesNoIndicator</para>
        /// </summary>
        public string NeedsHumanReview { get; set; }

        /// <summary>
        /// RXG.13 - Special Administration Instructions.
        /// </summary>
        public IEnumerable<CodedElement> SpecialAdministrationInstructions { get; set; }

        /// <summary>
        /// RXG.14 - Give Per (Time Unit).
        /// </summary>
        public string GivePerTimeUnit { get; set; }

        /// <summary>
        /// RXG.15 - Give Rate Amount.
        /// </summary>
        public string GiveRateAmount { get; set; }

        /// <summary>
        /// RXG.16 - Give Rate Units.
        /// </summary>
        public CodedElement GiveRateUnits { get; set; }

        /// <summary>
        /// RXG.17 - Give Strength.
        /// </summary>
        public decimal? GiveStrength { get; set; }

        /// <summary>
        /// RXG.18 - Give Strength Units.
        /// </summary>
        public CodedElement GiveStrengthUnits { get; set; }

        /// <summary>
        /// RXG.19 - Substance Lot Number.
        /// </summary>
        public IEnumerable<string> SubstanceLotNumber { get; set; }

        /// <summary>
        /// RXG.20 - Substance Expiration Date.
        /// </summary>
        public IEnumerable<DateTime> SubstanceExpirationDate { get; set; }

        /// <summary>
        /// RXG.21 - Substance Manufacturer Name.
        /// <para>Suggested: 0227 Manufacturers Of Vaccines (code=MVX) -&gt; ClearHl7.Codes.V240.CodeManufacturersOfVaccines</para>
        /// </summary>
        public IEnumerable<CodedElement> SubstanceManufacturerName { get; set; }

        /// <summary>
        /// RXG.22 - Indication.
        /// </summary>
        public IEnumerable<CodedElement> Indication { get; set; }

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

            GiveSubIdCounter = segments.ElementAtOrDefault(1)?.ToNullableDecimal();
            DispenseSubIdCounter = segments.ElementAtOrDefault(2)?.ToNullableDecimal();
            QuantityTiming = segments.Length > 3 ? TypeHelper.Deserialize<TimingQuantity>(segments.ElementAtOrDefault(3), false) : null;
            GiveCode = segments.Length > 4 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(4), false) : null;
            GiveAmountMinimum = segments.ElementAtOrDefault(5)?.ToNullableDecimal();
            GiveAmountMaximum = segments.ElementAtOrDefault(6)?.ToNullableDecimal();
            GiveUnits = segments.Length > 7 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(7), false) : null;
            GiveDosageForm = segments.Length > 8 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(8), false) : null;
            AdministrationNotes = segments.Length > 9 ? segments.ElementAtOrDefault(9).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            SubstitutionStatus = segments.ElementAtOrDefault(10);
            DispenseToLocation = segments.Length > 11 ? TypeHelper.Deserialize<LocationWithAddressVariationTwo>(segments.ElementAtOrDefault(11), false) : null;
            NeedsHumanReview = segments.ElementAtOrDefault(12);
            SpecialAdministrationInstructions = segments.Length > 13 ? segments.ElementAtOrDefault(13).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            GivePerTimeUnit = segments.ElementAtOrDefault(14);
            GiveRateAmount = segments.ElementAtOrDefault(15);
            GiveRateUnits = segments.Length > 16 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(16), false) : null;
            GiveStrength = segments.ElementAtOrDefault(17)?.ToNullableDecimal();
            GiveStrengthUnits = segments.Length > 18 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(18), false) : null;
            SubstanceLotNumber = segments.Length > 19 ? segments.ElementAtOrDefault(19).Split(separator) : null;
            SubstanceExpirationDate = segments.Length > 20 ? segments.ElementAtOrDefault(20).Split(separator).Select(x => x.ToDateTime()) : null;
            SubstanceManufacturerName = segments.Length > 21 ? segments.ElementAtOrDefault(21).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            Indication = segments.Length > 22 ? segments.ElementAtOrDefault(22).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
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
                                GiveSubIdCounter.HasValue ? GiveSubIdCounter.Value.ToString(Consts.NumericFormat, culture) : null,
                                DispenseSubIdCounter.HasValue ? DispenseSubIdCounter.Value.ToString(Consts.NumericFormat, culture) : null,
                                QuantityTiming?.ToDelimitedString(),
                                GiveCode?.ToDelimitedString(),
                                GiveAmountMinimum.HasValue ? GiveAmountMinimum.Value.ToString(Consts.NumericFormat, culture) : null,
                                GiveAmountMaximum.HasValue ? GiveAmountMaximum.Value.ToString(Consts.NumericFormat, culture) : null,
                                GiveUnits?.ToDelimitedString(),
                                GiveDosageForm?.ToDelimitedString(),
                                AdministrationNotes != null ? string.Join(Configuration.FieldRepeatSeparator, AdministrationNotes.Select(x => x.ToDelimitedString())) : null,
                                SubstitutionStatus,
                                DispenseToLocation?.ToDelimitedString(),
                                NeedsHumanReview,
                                SpecialAdministrationInstructions != null ? string.Join(Configuration.FieldRepeatSeparator, SpecialAdministrationInstructions.Select(x => x.ToDelimitedString())) : null,
                                GivePerTimeUnit,
                                GiveRateAmount,
                                GiveRateUnits?.ToDelimitedString(),
                                GiveStrength.HasValue ? GiveStrength.Value.ToString(Consts.NumericFormat, culture) : null,
                                GiveStrengthUnits?.ToDelimitedString(),
                                SubstanceLotNumber != null ? string.Join(Configuration.FieldRepeatSeparator, SubstanceLotNumber) : null,
                                SubstanceExpirationDate != null ? string.Join(Configuration.FieldRepeatSeparator, SubstanceExpirationDate.Select(x => x.ToString(Consts.DateTimeFormatPrecisionSecond, culture))) : null,
                                SubstanceManufacturerName != null ? string.Join(Configuration.FieldRepeatSeparator, SubstanceManufacturerName.Select(x => x.ToDelimitedString())) : null,
                                Indication != null ? string.Join(Configuration.FieldRepeatSeparator, Indication.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}