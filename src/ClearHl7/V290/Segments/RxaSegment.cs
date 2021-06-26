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
        /// <para>Suggested: 0292 Vaccines Administered</para>
        /// </summary>
        public CodedWithExceptions AdministeredCode { get; set; }

        /// <summary>
        /// RXA.6 - Administered Amount.
        /// </summary>
        public decimal? AdministeredAmount { get; set; }

        /// <summary>
        /// RXA.7 - Administered Units.
        /// <para>Suggested: 0689 Administered Units</para>
        /// </summary>
        public CodedWithExceptions AdministeredUnits { get; set; }

        /// <summary>
        /// RXA.8 - Administered Dosage Form.
        /// <para>Suggested: 0690 Administered Dosage Form</para>
        /// </summary>
        public CodedWithExceptions AdministeredDosageForm { get; set; }

        /// <summary>
        /// RXA.9 - Administration Notes.
        /// <para>Suggested: 0691 Administration Notes</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> AdministrationNotes { get; set; }

        /// <summary>
        /// RXA.10 - Administering Provider.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> AdministeringProvider { get; set; }

        /// <summary>
        /// RXA.11 - Administered-at Location.
        /// </summary>
        public string AdministeredAtLocation { get; set; }

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
        /// <para>Suggested: 0692 Administered Strength Units</para>
        /// </summary>
        public CodedWithExceptions AdministeredStrengthUnits { get; set; }

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
        /// </summary>
        public IEnumerable<CodedWithExceptions> SubstanceManufacturerName { get; set; }

        /// <summary>
        /// RXA.18 - Substance/Treatment Refusal Reason.
        /// <para>Suggested: 0693 Substance/Treatment Refusal Reason</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> SubstanceTreatmentRefusalReason { get; set; }

        /// <summary>
        /// RXA.19 - Indication.
        /// <para>Suggested: 0694 Indication</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> Indication { get; set; }

        /// <summary>
        /// RXA.20 - Completion Status.
        /// <para>Suggested: 0322 Completion Status -&gt; ClearHl7.Codes.V290.CodeCompletionStatus</para>
        /// </summary>
        public string CompletionStatus { get; set; }

        /// <summary>
        /// RXA.21 - Action Code - RXA.
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V290.CodeSegmentActionCode</para>
        /// </summary>
        public string ActionCodeRxa { get; set; }

        /// <summary>
        /// RXA.22 - System Entry Date/Time.
        /// </summary>
        public DateTime? SystemEntryDateTime { get; set; }

        /// <summary>
        /// RXA.23 - Administered Drug Strength Volume.
        /// </summary>
        public decimal? AdministeredDrugStrengthVolume { get; set; }

        /// <summary>
        /// RXA.24 - Administered Drug Strength Volume Units.
        /// <para>Suggested: 0695 Administered Drug Strength Volume Units</para>
        /// </summary>
        public CodedWithExceptions AdministeredDrugStrengthVolumeUnits { get; set; }

        /// <summary>
        /// RXA.25 - Administered Barcode Identifier.
        /// <para>Suggested: 0696 Administered Barcode Identifier</para>
        /// </summary>
        public CodedWithExceptions AdministeredBarcodeIdentifier { get; set; }

        /// <summary>
        /// RXA.26 - Pharmacy Order Type.
        /// <para>Suggested: 0480 Pharmacy Order Types -&gt; ClearHl7.Codes.V290.CodePharmacyOrderTypes</para>
        /// </summary>
        public string PharmacyOrderType { get; set; }

        /// <summary>
        /// RXA.27 - Administer-at.
        /// </summary>
        public PersonLocation AdministerAt { get; set; }

        /// <summary>
        /// RXA.28 - Administered-at Address.
        /// </summary>
        public ExtendedAddress AdministeredAtAddress { get; set; }

        /// <summary>
        /// RXA.29 - Administered Tag Identifier.
        /// </summary>
        public IEnumerable<EntityIdentifier> AdministeredTagIdentifier { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public RxaSegment FromDelimitedString(string delimitedString)
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
            DateTimeStartOfAdministration = segments.ElementAtOrDefault(3)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            DateTimeEndOfAdministration = segments.ElementAtOrDefault(4)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            AdministeredCode = segments.Length > 5 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(5)) : null;
            AdministeredAmount = segments.ElementAtOrDefault(6)?.ToNullableDecimal();
            AdministeredUnits = segments.Length > 7 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(7)) : null;
            AdministeredDosageForm = segments.Length > 8 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(8)) : null;
            AdministrationNotes = segments.Length > 9 ? segments.ElementAtOrDefault(9).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            AdministeringProvider = segments.Length > 10 ? segments.ElementAtOrDefault(10).Split(separator).Select(x => new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(x)) : null;
            AdministeredAtLocation = segments.ElementAtOrDefault(11);
            AdministeredPerTimeUnit = segments.ElementAtOrDefault(12);
            AdministeredStrength = segments.ElementAtOrDefault(13)?.ToNullableDecimal();
            AdministeredStrengthUnits = segments.Length > 14 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(14)) : null;
            SubstanceLotNumber = segments.Length > 15 ? segments.ElementAtOrDefault(15).Split(separator) : null;
            SubstanceExpirationDate = segments.Length > 16 ? segments.ElementAtOrDefault(16).Split(separator).Select(x => x.ToDateTime(Consts.DateTimeFormatPrecisionSecond)) : null;
            SubstanceManufacturerName = segments.Length > 17 ? segments.ElementAtOrDefault(17).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            SubstanceTreatmentRefusalReason = segments.Length > 18 ? segments.ElementAtOrDefault(18).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            Indication = segments.Length > 19 ? segments.ElementAtOrDefault(19).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            CompletionStatus = segments.ElementAtOrDefault(20);
            ActionCodeRxa = segments.ElementAtOrDefault(21);
            SystemEntryDateTime = segments.ElementAtOrDefault(22)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            AdministeredDrugStrengthVolume = segments.ElementAtOrDefault(23)?.ToNullableDecimal();
            AdministeredDrugStrengthVolumeUnits = segments.Length > 24 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(24)) : null;
            AdministeredBarcodeIdentifier = segments.Length > 25 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(25)) : null;
            PharmacyOrderType = segments.ElementAtOrDefault(26);
            AdministerAt = segments.Length > 27 ? new PersonLocation().FromDelimitedString(segments.ElementAtOrDefault(27)) : null;
            AdministeredAtAddress = segments.Length > 28 ? new ExtendedAddress().FromDelimitedString(segments.ElementAtOrDefault(28)) : null;
            AdministeredTagIdentifier = segments.Length > 29 ? segments.ElementAtOrDefault(29).Split(separator).Select(x => new EntityIdentifier().FromDelimitedString(x)) : null;
            
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
                                StringHelper.StringFormatSequence(0, 30, Configuration.FieldSeparator),
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
                                SystemEntryDateTime.HasValue ? SystemEntryDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                AdministeredDrugStrengthVolume.HasValue ? AdministeredDrugStrengthVolume.Value.ToString(Consts.NumericFormat, culture) : null,
                                AdministeredDrugStrengthVolumeUnits?.ToDelimitedString(),
                                AdministeredBarcodeIdentifier?.ToDelimitedString(),
                                PharmacyOrderType,
                                AdministerAt?.ToDelimitedString(),
                                AdministeredAtAddress?.ToDelimitedString(),
                                AdministeredTagIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, AdministeredTagIdentifier.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}