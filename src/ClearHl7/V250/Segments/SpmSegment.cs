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
    /// HL7 Version 2 Segment SPM - Specimen.
    /// </summary>
    public class SpmSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpmSegment"/> class.
        /// </summary>
        public SpmSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpmSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public SpmSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "SPM";

        /// <inheritdoc/>
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
        /// <para>Suggested: 0487 Specimen Type -&gt; ClearHl7.Codes.V250.CodeSpecimenType</para>
        /// </summary>
        public CodedWithExceptions SpecimenType { get; set; }

        /// <summary>
        /// SPM.5 - Specimen Type Modifier.
        /// <para>Suggested: 0541 Specimen Type Modifier</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> SpecimenTypeModifier { get; set; }

        /// <summary>
        /// SPM.6 - Specimen Additives.
        /// <para>Suggested: 0371 Additive/Preservative -&gt; ClearHl7.Codes.V250.CodeAdditivePreservative</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> SpecimenAdditives { get; set; }

        /// <summary>
        /// SPM.7 - Specimen Collection Method.
        /// <para>Suggested: 0488 Specimen Collection Method -&gt; ClearHl7.Codes.V250.CodeSpecimenCollectionMethod</para>
        /// </summary>
        public CodedWithExceptions SpecimenCollectionMethod { get; set; }

        /// <summary>
        /// SPM.8 - Specimen Source Site.
        /// </summary>
        public CodedWithExceptions SpecimenSourceSite { get; set; }

        /// <summary>
        /// SPM.9 - Specimen Source Site Modifier.
        /// <para>Suggested: 0542 Specimen Source Type Modifier</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> SpecimenSourceSiteModifier { get; set; }

        /// <summary>
        /// SPM.10 - Specimen Collection Site.
        /// <para>Suggested: 0543 Specimen Collection Site</para>
        /// </summary>
        public CodedWithExceptions SpecimenCollectionSite { get; set; }

        /// <summary>
        /// SPM.11 - Specimen Role.
        /// <para>Suggested: 0369 Specimen Role -&gt; ClearHl7.Codes.V250.CodeSpecimenRole</para>
        /// </summary>
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
        /// <para>Suggested: 0376 Special Handling Code -&gt; ClearHl7.Codes.V250.CodeSpecialHandlingCode</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> SpecimenHandlingCode { get; set; }

        /// <summary>
        /// SPM.16 - Specimen Risk Code.
        /// <para>Suggested: 0489 Risk Codes -&gt; ClearHl7.Codes.V250.CodeRiskCodes</para>
        /// </summary>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V250.CodeYesNoIndicator</para>
        /// </summary>
        public string SpecimenAvailability { get; set; }

        /// <summary>
        /// SPM.21 - Specimen Reject Reason.
        /// <para>Suggested: 0490 Specimen Reject Reason -&gt; ClearHl7.Codes.V250.CodeSpecimenRejectReason</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> SpecimenRejectReason { get; set; }

        /// <summary>
        /// SPM.22 - Specimen Quality.
        /// <para>Suggested: 0491 Specimen Quality -&gt; ClearHl7.Codes.V250.CodeSpecimenQuality</para>
        /// </summary>
        public CodedWithExceptions SpecimenQuality { get; set; }

        /// <summary>
        /// SPM.23 - Specimen Appropriateness.
        /// <para>Suggested: 0492 Specimen Appropriateness -&gt; ClearHl7.Codes.V250.CodeSpecimenAppropriateness</para>
        /// </summary>
        public CodedWithExceptions SpecimenAppropriateness { get; set; }

        /// <summary>
        /// SPM.24 - Specimen Condition.
        /// <para>Suggested: 0493 Specimen Condition -&gt; ClearHl7.Codes.V250.CodeSpecimenCondition</para>
        /// </summary>
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
        /// <para>Suggested: 0544 Container Condition</para>
        /// </summary>
        public CodedWithExceptions ContainerCondition { get; set; }

        /// <summary>
        /// SPM.29 - Specimen Child Role.
        /// <para>Suggested: 0494 Specimen Child Role -&gt; ClearHl7.Codes.V250.CodeSpecimenChildRole</para>
        /// </summary>
        public CodedWithExceptions SpecimenChildRole { get; set; }

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

            SetIdSpm = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            SpecimenId = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifierPair>(segments[2], false, seps) : null;
            SpecimenParentIds = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<EntityIdentifierPair>(x, false, seps)) : null;
            SpecimenType = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[4], false, seps) : null;
            SpecimenTypeModifier = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            SpecimenAdditives = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            SpecimenCollectionMethod = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[7], false, seps) : null;
            SpecimenSourceSite = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[8], false, seps) : null;
            SpecimenSourceSiteModifier = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            SpecimenCollectionSite = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[10], false, seps) : null;
            SpecimenRole = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            SpecimenCollectionAmount = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[12], false, seps) : null;
            GroupedSpecimenCount = segments.Length > 13 && segments[13].Length > 0 ? segments[13].ToNullableDecimal() : null;
            SpecimenDescription = segments.Length > 14 && segments[14].Length > 0 ? segments[14].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            SpecimenHandlingCode = segments.Length > 15 && segments[15].Length > 0 ? segments[15].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            SpecimenRiskCode = segments.Length > 16 && segments[16].Length > 0 ? segments[16].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            SpecimenCollectionDateTime = segments.Length > 17 && segments[17].Length > 0 ? TypeSerializer.Deserialize<DateTimeRange>(segments[17], false, seps) : null;
            SpecimenReceivedDateTime = segments.Length > 18 && segments[18].Length > 0 ? segments[18].ToNullableDateTime() : null;
            SpecimenExpirationDateTime = segments.Length > 19 && segments[19].Length > 0 ? segments[19].ToNullableDateTime() : null;
            SpecimenAvailability = segments.Length > 20 && segments[20].Length > 0 ? segments[20] : null;
            SpecimenRejectReason = segments.Length > 21 && segments[21].Length > 0 ? segments[21].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            SpecimenQuality = segments.Length > 22 && segments[22].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[22], false, seps) : null;
            SpecimenAppropriateness = segments.Length > 23 && segments[23].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[23], false, seps) : null;
            SpecimenCondition = segments.Length > 24 && segments[24].Length > 0 ? segments[24].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            SpecimenCurrentQuantity = segments.Length > 25 && segments[25].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[25], false, seps) : null;
            NumberOfSpecimenContainers = segments.Length > 26 && segments[26].Length > 0 ? segments[26].ToNullableDecimal() : null;
            ContainerType = segments.Length > 27 && segments[27].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[27], false, seps) : null;
            ContainerCondition = segments.Length > 28 && segments[28].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[28], false, seps) : null;
            SpecimenChildRole = segments.Length > 29 && segments[29].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[29], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 30, Configuration.FieldSeparator),
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
                                SpecimenReceivedDateTime?.ToHl7DateTimeString(typeof(SpmSegment), nameof(SpecimenReceivedDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                SpecimenExpirationDateTime?.ToHl7DateTimeString(typeof(SpmSegment), nameof(SpecimenExpirationDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                SpecimenAvailability,
                                SpecimenRejectReason != null ? string.Join(Configuration.FieldRepeatSeparator, SpecimenRejectReason.Select(x => x.ToDelimitedString())) : null,
                                SpecimenQuality?.ToDelimitedString(),
                                SpecimenAppropriateness?.ToDelimitedString(),
                                SpecimenCondition != null ? string.Join(Configuration.FieldRepeatSeparator, SpecimenCondition.Select(x => x.ToDelimitedString())) : null,
                                SpecimenCurrentQuantity?.ToDelimitedString(),
                                NumberOfSpecimenContainers.HasValue ? NumberOfSpecimenContainers.Value.ToString(Consts.NumericFormat, culture) : null,
                                ContainerType?.ToDelimitedString(),
                                ContainerCondition?.ToDelimitedString(),
                                SpecimenChildRole?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
