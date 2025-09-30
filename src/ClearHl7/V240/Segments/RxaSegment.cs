using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RXA - Pharmacy Treatment Administration.
    /// </summary>
    public class RxaSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RxaSegment"/> class.
        /// </summary>
        public RxaSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RxaSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public RxaSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "RXA";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// RXA.1 - Give Sub-ID Counter.
        /// </summary>
        public decimal? GiveSubIdCounter { get; set; }

        /// <summary>
        /// RXA.2 - Administration Sub-ID Counter.
        /// </summary>
        public decimal? AdministrationSubIdCounter { get; set; }

        /// <summary>
        /// RXA.3 - Date/Time Start of Administration.
        /// </summary>
        public DateTime? DateTimeStartOfAdministration { get; set; }

        /// <summary>
        /// RXA.4 - Date/Time End of Administration.
        /// </summary>
        public DateTime? DateTimeEndOfAdministration { get; set; }

        /// <summary>
        /// RXA.5 - Administered Code.
        /// <para>Suggested: 0292 Vaccines Administered -&gt; ClearHl7.Codes.V240.CodeVaccinesAdministered</para>
        /// </summary>
        public CodedElement AdministeredCode { get; set; }

        /// <summary>
        /// RXA.6 - Administered Amount.
        /// </summary>
        public decimal? AdministeredAmount { get; set; }

        /// <summary>
        /// RXA.7 - Administered Units.
        /// </summary>
        public CodedElement AdministeredUnits { get; set; }

        /// <summary>
        /// RXA.8 - Administered Dosage Form.
        /// </summary>
        public CodedElement AdministeredDosageForm { get; set; }

        /// <summary>
        /// RXA.9 - Administration Notes.
        /// </summary>
        public IEnumerable<CodedElement> AdministrationNotes { get; set; }

        /// <summary>
        /// RXA.10 - Administering Provider.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> AdministeringProvider { get; set; }

        /// <summary>
        /// RXA.11 - Administered-at Location.
        /// </summary>
        public LocationWithAddressVariationTwo AdministeredAtLocation { get; set; }

        /// <summary>
        /// RXA.12 - Administered Per (Time Unit).
        /// </summary>
        public string AdministeredPerTimeUnit { get; set; }

        /// <summary>
        /// RXA.13 - Administered Strength.
        /// </summary>
        public decimal? AdministeredStrength { get; set; }

        /// <summary>
        /// RXA.14 - Administered Strength Units.
        /// </summary>
        public CodedElement AdministeredStrengthUnits { get; set; }

        /// <summary>
        /// RXA.15 - Substance Lot Number.
        /// </summary>
        public IEnumerable<string> SubstanceLotNumber { get; set; }

        /// <summary>
        /// RXA.16 - Substance Expiration Date.
        /// </summary>
        public IEnumerable<DateTime> SubstanceExpirationDate { get; set; }

        /// <summary>
        /// RXA.17 - Substance Manufacturer Name.
        /// <para>Suggested: 0227 Manufacturers Of Vaccines (code=MVX) -&gt; ClearHl7.Codes.V240.CodeManufacturersOfVaccines</para>
        /// </summary>
        public IEnumerable<CodedElement> SubstanceManufacturerName { get; set; }

        /// <summary>
        /// RXA.18 - Substance/Treatment Refusal Reason.
        /// </summary>
        public IEnumerable<CodedElement> SubstanceTreatmentRefusalReason { get; set; }

        /// <summary>
        /// RXA.19 - Indication.
        /// </summary>
        public IEnumerable<CodedElement> Indication { get; set; }

        /// <summary>
        /// RXA.20 - Completion Status.
        /// <para>Suggested: 0322 Completion Status -&gt; ClearHl7.Codes.V240.CodeCompletionStatus</para>
        /// </summary>
        public string CompletionStatus { get; set; }

        /// <summary>
        /// RXA.21 - Action Code - RXA.
        /// <para>Suggested: 0323 Action Code -&gt; ClearHl7.Codes.V240.CodeActionCode</para>
        /// </summary>
        public string ActionCodeRxa { get; set; }

        /// <summary>
        /// RXA.22 - System Entry Date/Time.
        /// </summary>
        public DateTime? SystemEntryDateTime { get; set; }

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

            GiveSubIdCounter = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            AdministrationSubIdCounter = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
            DateTimeStartOfAdministration = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
            DateTimeEndOfAdministration = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            AdministeredCode = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[5], false, seps) : null;
            AdministeredAmount = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDecimal() : null;
            AdministeredUnits = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[7], false, seps) : null;
            AdministeredDosageForm = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[8], false, seps) : null;
            AdministrationNotes = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            AdministeringProvider = segments.Length > 10 && segments[10].Length > 0 ? segments[10].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            AdministeredAtLocation = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<LocationWithAddressVariationTwo>(segments[1], false, seps) : null;
            AdministeredPerTimeUnit = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            AdministeredStrength = segments.Length > 13 && segments[13].Length > 0 ? segments[13].ToNullableDecimal() : null;
            AdministeredStrengthUnits = segments.Length > 14 && segments[14].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[14], false, seps) : null;
            SubstanceLotNumber = segments.Length > 15 && segments[15].Length > 0 ? segments[15].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            SubstanceExpirationDate = segments.Length > 16 && segments[16].Length > 0 ? segments[16].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => x.ToDateTime()) : null;
            SubstanceManufacturerName = segments.Length > 17 && segments[17].Length > 0 ? segments[17].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            SubstanceTreatmentRefusalReason = segments.Length > 18 && segments[18].Length > 0 ? segments[18].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            Indication = segments.Length > 19 && segments[19].Length > 0 ? segments[19].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            CompletionStatus = segments.Length > 20 && segments[20].Length > 0 ? segments[20] : null;
            ActionCodeRxa = segments.Length > 21 && segments[21].Length > 0 ? segments[21] : null;
            SystemEntryDateTime = segments.Length > 22 && segments[22].Length > 0 ? segments[22].ToNullableDateTime() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 23, Configuration.FieldSeparator),
                                Id,
                                GiveSubIdCounter.HasValue ? GiveSubIdCounter.Value.ToString(Consts.NumericFormat, culture) : null,
                                AdministrationSubIdCounter.HasValue ? AdministrationSubIdCounter.Value.ToString(Consts.NumericFormat, culture) : null,
                                DateTimeStartOfAdministration?.ToHl7DateTimeString(typeof(RxaSegment), nameof(DateTimeStartOfAdministration), Consts.DateTimeFormatPrecisionSecond, culture),
                                DateTimeEndOfAdministration?.ToHl7DateTimeString(typeof(RxaSegment), nameof(DateTimeEndOfAdministration), Consts.DateTimeFormatPrecisionSecond, culture),
                                AdministeredCode?.ToDelimitedString(),
                                AdministeredAmount.HasValue ? AdministeredAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                AdministeredUnits?.ToDelimitedString(),
                                AdministeredDosageForm?.ToDelimitedString(),
                                AdministrationNotes != null ? string.Join(Configuration.FieldRepeatSeparator, AdministrationNotes.Select(x => x.ToDelimitedString())) : null,
                                AdministeringProvider != null ? string.Join(Configuration.FieldRepeatSeparator, AdministeringProvider.Select(x => x.ToDelimitedString())) : null,
                                AdministeredAtLocation,
                                AdministeredPerTimeUnit,
                                AdministeredStrength.HasValue ? AdministeredStrength.Value.ToString(Consts.NumericFormat, culture) : null,
                                AdministeredStrengthUnits?.ToDelimitedString(),
                                SubstanceLotNumber != null ? string.Join(Configuration.FieldRepeatSeparator, SubstanceLotNumber) : null,
                                SubstanceExpirationDate != null ? string.Join(Configuration.FieldRepeatSeparator, SubstanceExpirationDate.Select(x => x.ToString(Consts.DateTimeFormatPrecisionSecond, culture))) : null,
                                SubstanceManufacturerName != null ? string.Join(Configuration.FieldRepeatSeparator, SubstanceManufacturerName.Select(x => x.ToDelimitedString())) : null,
                                SubstanceTreatmentRefusalReason != null ? string.Join(Configuration.FieldRepeatSeparator, SubstanceTreatmentRefusalReason.Select(x => x.ToDelimitedString())) : null,
                                Indication != null ? string.Join(Configuration.FieldRepeatSeparator, Indication.Select(x => x.ToDelimitedString())) : null,
                                CompletionStatus,
                                ActionCodeRxa,
                                SystemEntryDateTime?.ToHl7DateTimeString(typeof(RxaSegment), nameof(SystemEntryDateTime), Consts.DateTimeFormatPrecisionSecond, culture)
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
