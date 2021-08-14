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
    /// HL7 Version 2 Segment RXA - Pharmacy Treatment Administration.
    /// </summary>
    public class RxaSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RXA";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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
        /// <para>Suggested: 0292 Vaccines Administered -&gt; ClearHl7.Codes.V230.CodeVaccinesAdministered</para>
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
        /// <para>Suggested: 0227 Manufacturers Of Vaccines (code=MVX) -&gt; ClearHl7.Codes.V230.CodeManufacturersOfVaccines</para>
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
        /// <para>Suggested: 0322 Completion Status -&gt; ClearHl7.Codes.V230.CodeCompletionStatus</para>
        /// </summary>
        public string CompletionStatus { get; set; }

        /// <summary>
        /// RXA.21 - Action Code - RXA.
        /// <para>Suggested: 0323 Action Code -&gt; ClearHl7.Codes.V230.CodeActionCode</para>
        /// </summary>
        public string ActionCodeRxa { get; set; }

        /// <summary>
        /// RXA.22 - System Entry Date/Time.
        /// </summary>
        public DateTime? SystemEntryDateTime { get; set; }

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
            AdministrationSubIdCounter = segments.ElementAtOrDefault(2)?.ToNullableDecimal();
            DateTimeStartOfAdministration = segments.ElementAtOrDefault(3)?.ToNullableDateTime();
            DateTimeEndOfAdministration = segments.ElementAtOrDefault(4)?.ToNullableDateTime();
            AdministeredCode = segments.Length > 5 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(5), false) : null;
            AdministeredAmount = segments.ElementAtOrDefault(6)?.ToNullableDecimal();
            AdministeredUnits = segments.Length > 7 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(7), false) : null;
            AdministeredDosageForm = segments.Length > 8 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(8), false) : null;
            AdministrationNotes = segments.Length > 9 ? segments.ElementAtOrDefault(9).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            AdministeringProvider = segments.Length > 10 ? segments.ElementAtOrDefault(10).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            AdministeredAtLocation = segments.Length > 11 ? TypeHelper.Deserialize<LocationWithAddressVariationTwo>(segments.ElementAtOrDefault(1), false) : null;
            AdministeredPerTimeUnit = segments.ElementAtOrDefault(12);
            AdministeredStrength = segments.ElementAtOrDefault(13)?.ToNullableDecimal();
            AdministeredStrengthUnits = segments.Length > 14 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(14), false) : null;
            SubstanceLotNumber = segments.Length > 15 ? segments.ElementAtOrDefault(15).Split(separator) : null;
            SubstanceExpirationDate = segments.Length > 16 ? segments.ElementAtOrDefault(16).Split(separator).Select(x => x.ToDateTime()) : null;
            SubstanceManufacturerName = segments.Length > 17 ? segments.ElementAtOrDefault(17).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            SubstanceTreatmentRefusalReason = segments.Length > 18 ? segments.ElementAtOrDefault(18).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            Indication = segments.Length > 19 ? segments.ElementAtOrDefault(19).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            CompletionStatus = segments.ElementAtOrDefault(20);
            ActionCodeRxa = segments.ElementAtOrDefault(21);
            SystemEntryDateTime = segments.ElementAtOrDefault(22)?.ToNullableDateTime();
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
                                AdministrationSubIdCounter.HasValue ? AdministrationSubIdCounter.Value.ToString(Consts.NumericFormat, culture) : null,
                                DateTimeStartOfAdministration.HasValue ? DateTimeStartOfAdministration.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DateTimeEndOfAdministration.HasValue ? DateTimeEndOfAdministration.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
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
                                SystemEntryDateTime.HasValue ? SystemEntryDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}