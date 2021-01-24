using System;
using System.Collections.Generic;
using System.Linq;
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
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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