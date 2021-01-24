using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V281.Types;

namespace ClearHl7.Fhir.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SPM - Specimen.
    /// </summary>
    public class SpmSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "SPM";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// SPM.1 - Set ID - SPM.
        /// </summary>
        public uint? SetIdSpm { get; set; }

        /// <summary>
        /// SPM.2 - Specimen ID.
        /// </summary>
        public EntityIdentifierPair SpecimenId { get; set; }

        /// <summary>
        /// SPM.3 - Specimen Parent IDs.
        /// </summary>
        public IEnumerable<EntityIdentifierPair> SpecimenParentIds { get; set; }

        /// <summary>
        /// SPM.4 - Specimen Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0487</remarks>
        public CodedWithExceptions SpecimenType { get; set; }

        /// <summary>
        /// SPM.5 - Specimen Type Modifier.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0541</remarks>
        public IEnumerable<CodedWithExceptions> SpecimenTypeModifier { get; set; }

        /// <summary>
        /// SPM.6 - Specimen Additives.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0371</remarks>
        public IEnumerable<CodedWithExceptions> SpecimenAdditives { get; set; }

        /// <summary>
        /// SPM.7 - Specimen Collection Method.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0488</remarks>
        public CodedWithExceptions SpecimenCollectionMethod { get; set; }

        /// <summary>
        /// SPM.8 - Specimen Source Site.
        /// </summary>
        public CodedWithExceptions SpecimenSourceSite { get; set; }

        /// <summary>
        /// SPM.9 - Specimen Source Site Modifier.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0542</remarks>
        public IEnumerable<CodedWithExceptions> SpecimenSourceSiteModifier { get; set; }

        /// <summary>
        /// SPM.10 - Specimen Collection Site.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0543</remarks>
        public CodedWithExceptions SpecimenCollectionSite { get; set; }

        /// <summary>
        /// SPM.11 - Specimen Role.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0369</remarks>
        public IEnumerable<CodedWithExceptions> SpecimenRole { get; set; }

        /// <summary>
        /// SPM.12 - Specimen Collection Amount.
        /// </summary>
        public CompositeQuantityWithUnits SpecimenCollectionAmount { get; set; }

        /// <summary>
        /// SPM.13 - Grouped Specimen Count.
        /// </summary>
        public decimal? GroupedSpecimenCount { get; set; }

        /// <summary>
        /// SPM.14 - Specimen Description.
        /// </summary>
        public IEnumerable<string> SpecimenDescription { get; set; }

        /// <summary>
        /// SPM.15 - Specimen Handling Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0376</remarks>
        public IEnumerable<CodedWithExceptions> SpecimenHandlingCode { get; set; }

        /// <summary>
        /// SPM.16 - Specimen Risk Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0489</remarks>
        public IEnumerable<CodedWithExceptions> SpecimenRiskCode { get; set; }

        /// <summary>
        /// SPM.17 - Specimen Collection Date/Time.
        /// </summary>
        public DateTimeRange SpecimenCollectionDateTime { get; set; }

        /// <summary>
        /// SPM.18 - Specimen Received Date/Time *.
        /// </summary>
        public DateTime? SpecimenReceivedDateTime { get; set; }

        /// <summary>
        /// SPM.19 - Specimen Expiration Date/Time.
        /// </summary>
        public DateTime? SpecimenExpirationDateTime { get; set; }

        /// <summary>
        /// SPM.20 - Specimen Availability.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string SpecimenAvailability { get; set; }

        /// <summary>
        /// SPM.21 - Specimen Reject Reason.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0490</remarks>
        public IEnumerable<CodedWithExceptions> SpecimenRejectReason { get; set; }

        /// <summary>
        /// SPM.22 - Specimen Quality.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0491</remarks>
        public CodedWithExceptions SpecimenQuality { get; set; }

        /// <summary>
        /// SPM.23 - Specimen Appropriateness.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0492</remarks>
        public CodedWithExceptions SpecimenAppropriateness { get; set; }

        /// <summary>
        /// SPM.24 - Specimen Condition.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0493</remarks>
        public IEnumerable<CodedWithExceptions> SpecimenCondition { get; set; }

        /// <summary>
        /// SPM.25 - Specimen Current Quantity.
        /// </summary>
        public CompositeQuantityWithUnits SpecimenCurrentQuantity { get; set; }

        /// <summary>
        /// SPM.26 - Number of Specimen Containers.
        /// </summary>
        public decimal? NumberOfSpecimenContainers { get; set; }

        /// <summary>
        /// SPM.27 - Container Type.
        /// </summary>
        public CodedWithExceptions ContainerType { get; set; }

        /// <summary>
        /// SPM.28 - Container Condition.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0544</remarks>
        public CodedWithExceptions ContainerCondition { get; set; }

        /// <summary>
        /// SPM.29 - Specimen Child Role.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0494</remarks>
        public CodedWithExceptions SpecimenChildRole { get; set; }

        /// <summary>
        /// SPM.30 - Accession ID.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> AccessionId { get; set; }

        /// <summary>
        /// SPM.31 - Other Specimen ID.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> OtherSpecimenId { get; set; }

        /// <summary>
        /// SPM.32 - Shipment ID.
        /// </summary>
        public EntityIdentifier ShipmentId { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 33, Configuration.FieldSeparator),
                                Id,
                                SetIdSpm.HasValue ? SetIdSpm.Value.ToString(culture) : null,
                                SpecimenId?.ToDelimitedString(),
                                SpecimenParentIds != null ? string.Join(Configuration.FieldRepeatSeparator, SpecimenParentIds.Select(x => x.ToDelimitedString())) : null,
                                SpecimenType?.ToDelimitedString(),
                                SpecimenTypeModifier != null ? string.Join(Configuration.FieldRepeatSeparator, SpecimenTypeModifier.Select(x => x.ToDelimitedString())) : null,
                                SpecimenAdditives != null ? string.Join(Configuration.FieldRepeatSeparator, SpecimenAdditives.Select(x => x.ToDelimitedString())) : null,
                                SpecimenCollectionMethod?.ToDelimitedString(),
                                SpecimenSourceSite?.ToDelimitedString(),
                                SpecimenSourceSiteModifier != null ? string.Join(Configuration.FieldRepeatSeparator, SpecimenSourceSiteModifier.Select(x => x.ToDelimitedString())) : null,
                                SpecimenCollectionSite?.ToDelimitedString(),
                                SpecimenRole != null ? string.Join(Configuration.FieldRepeatSeparator, SpecimenRole.Select(x => x.ToDelimitedString())) : null,
                                SpecimenCollectionAmount?.ToDelimitedString(),
                                GroupedSpecimenCount.HasValue ? GroupedSpecimenCount.Value.ToString(Consts.NumericFormat, culture) : null,
                                SpecimenDescription != null ? string.Join(Configuration.FieldRepeatSeparator, SpecimenDescription) : null,
                                SpecimenHandlingCode != null ? string.Join(Configuration.FieldRepeatSeparator, SpecimenHandlingCode.Select(x => x.ToDelimitedString())) : null,
                                SpecimenRiskCode != null ? string.Join(Configuration.FieldRepeatSeparator, SpecimenRiskCode.Select(x => x.ToDelimitedString())) : null,
                                SpecimenCollectionDateTime?.ToDelimitedString(),
                                SpecimenReceivedDateTime.HasValue ? SpecimenReceivedDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                SpecimenExpirationDateTime.HasValue ? SpecimenExpirationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                SpecimenAvailability,
                                SpecimenRejectReason != null ? string.Join(Configuration.FieldRepeatSeparator, SpecimenRejectReason.Select(x => x.ToDelimitedString())) : null,
                                SpecimenQuality?.ToDelimitedString(),
                                SpecimenAppropriateness?.ToDelimitedString(),
                                SpecimenCondition != null ? string.Join(Configuration.FieldRepeatSeparator, SpecimenCondition.Select(x => x.ToDelimitedString())) : null,
                                SpecimenCurrentQuantity?.ToDelimitedString(),
                                NumberOfSpecimenContainers.HasValue ? NumberOfSpecimenContainers.Value.ToString(Consts.NumericFormat, culture) : null,
                                ContainerType?.ToDelimitedString(),
                                ContainerCondition?.ToDelimitedString(),
                                SpecimenChildRole?.ToDelimitedString(),
                                AccessionId != null ? string.Join(Configuration.FieldRepeatSeparator, AccessionId.Select(x => x.ToDelimitedString())) : null,
                                OtherSpecimenId != null ? string.Join(Configuration.FieldRepeatSeparator, OtherSpecimenId.Select(x => x.ToDelimitedString())) : null,
                                ShipmentId?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}