using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OM4 - Observations That Require Specimens.
    /// </summary>
    public class Om4Segment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Om4Segment"/> class.
        /// </summary>
        public Om4Segment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Om4Segment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public Om4Segment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id { get; } = "OM4";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// OM4.1 - Sequence Number - Test/Observation Master File.
        /// </summary>
        public decimal? SequenceNumberTestObservationMasterFile { get; set; }

        /// <summary>
        /// OM4.2 - Derived Specimen.
        /// <para>Suggested: 0170 Derived Specimen -&gt; ClearHl7.Codes.V290.CodeDerivedSpecimen</para>
        /// </summary>
        public string DerivedSpecimen { get; set; }

        /// <summary>
        /// OM4.3 - Container Description.
        /// </summary>
        public IEnumerable<Text> ContainerDescription { get; set; }

        /// <summary>
        /// OM4.4 - Container Volume.
        /// </summary>
        public IEnumerable<decimal> ContainerVolume { get; set; }

        /// <summary>
        /// OM4.5 - Container Units.
        /// <para>Suggested: 0658 Container Units</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ContainerUnits { get; set; }

        /// <summary>
        /// OM4.6 - Specimen.
        /// <para>Suggested: 0660 Specimen</para>
        /// </summary>
        public CodedWithExceptions Specimen { get; set; }

        /// <summary>
        /// OM4.7 - Additive.
        /// <para>Suggested: 0371 Additive/Preservative -&gt; ClearHl7.Codes.V290.CodeAdditivePreservative</para>
        /// </summary>
        public CodedWithExceptions Additive { get; set; }

        /// <summary>
        /// OM4.8 - Preparation.
        /// </summary>
        public Text Preparation { get; set; }

        /// <summary>
        /// OM4.9 - Special Handling Requirements.
        /// </summary>
        public Text SpecialHandlingRequirements { get; set; }

        /// <summary>
        /// OM4.10 - Normal Collection Volume.
        /// </summary>
        public CompositeQuantityWithUnits NormalCollectionVolume { get; set; }

        /// <summary>
        /// OM4.11 - Minimum Collection Volume.
        /// </summary>
        public CompositeQuantityWithUnits MinimumCollectionVolume { get; set; }

        /// <summary>
        /// OM4.12 - Specimen Requirements.
        /// </summary>
        public Text SpecimenRequirements { get; set; }

        /// <summary>
        /// OM4.13 - Specimen Priorities.
        /// <para>Suggested: 0027 Priority -&gt; ClearHl7.Codes.V290.CodePriority</para>
        /// </summary>
        public IEnumerable<string> SpecimenPriorities { get; set; }

        /// <summary>
        /// OM4.14 - Specimen Retention Time.
        /// </summary>
        public CompositeQuantityWithUnits SpecimenRetentionTime { get; set; }

        /// <summary>
        /// OM4.15 - Specimen Handling Code.
        /// <para>Suggested: 0376 Special Handling Code -&gt; ClearHl7.Codes.V290.CodeSpecialHandlingCode</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> SpecimenHandlingCode { get; set; }

        /// <summary>
        /// OM4.16 - Specimen Preference.
        /// <para>Suggested: 0920 Preferred Specimen/Attribute Status -&gt; ClearHl7.Codes.V290.CodePreferredSpecimenAttributeStatus</para>
        /// </summary>
        public string SpecimenPreference { get; set; }

        /// <summary>
        /// OM4.17 - Preferred Specimen/Attribture Sequence ID.
        /// </summary>
        public decimal? PreferredSpecimenAttribtureSequenceId { get; set; }

        /// <summary>
        /// OM4.18 - Taxonomic Classification Code.
        /// </summary>
        public IEnumerable<CodedWithExceptions> TaxonomicClassificationCode { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SequenceNumberTestObservationMasterFile = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            DerivedSpecimen = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            ContainerDescription = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<Text>(x, false, seps)) : null;
            ContainerVolume = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => x.ToDecimal()) : null;
            ContainerUnits = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            Specimen = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[6], false, seps) : null;
            Additive = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[7], false, seps) : null;
            Preparation = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[8], false, seps) : null;
            SpecialHandlingRequirements = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[9], false, seps) : null;
            NormalCollectionVolume = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[10], false, seps) : null;
            MinimumCollectionVolume = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[11], false, seps) : null;
            SpecimenRequirements = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[12], false, seps) : null;
            SpecimenPriorities = segments.Length > 13 && segments[13].Length > 0 ? segments[13].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            SpecimenRetentionTime = segments.Length > 14 && segments[14].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[14], false, seps) : null;
            SpecimenHandlingCode = segments.Length > 15 && segments[15].Length > 0 ? segments[15].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            SpecimenPreference = segments.Length > 16 && segments[16].Length > 0 ? segments[16] : null;
            PreferredSpecimenAttribtureSequenceId = segments.Length > 17 && segments[17].Length > 0 ? segments[17].ToNullableDecimal() : null;
            TaxonomicClassificationCode = segments.Length > 18 && segments[18].Length > 0 ? segments[18].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 19, Configuration.FieldSeparator),
                                Id,
                                SequenceNumberTestObservationMasterFile.HasValue ? SequenceNumberTestObservationMasterFile.Value.ToString(Consts.NumericFormat, culture) : null,
                                DerivedSpecimen,
                                ContainerDescription != null ? string.Join(Configuration.FieldRepeatSeparator, ContainerDescription.Select(x => x.ToDelimitedString())) : null,
                                ContainerVolume != null ? string.Join(Configuration.FieldRepeatSeparator, ContainerVolume.Select(x => x.ToString(Consts.NumericFormat, culture))) : null,
                                ContainerUnits != null ? string.Join(Configuration.FieldRepeatSeparator, ContainerUnits.Select(x => x.ToDelimitedString())) : null,
                                Specimen?.ToDelimitedString(),
                                Additive?.ToDelimitedString(),
                                Preparation?.ToDelimitedString(),
                                SpecialHandlingRequirements?.ToDelimitedString(),
                                NormalCollectionVolume?.ToDelimitedString(),
                                MinimumCollectionVolume?.ToDelimitedString(),
                                SpecimenRequirements?.ToDelimitedString(),
                                SpecimenPriorities != null ? string.Join(Configuration.FieldRepeatSeparator, SpecimenPriorities) : null,
                                SpecimenRetentionTime?.ToDelimitedString(),
                                SpecimenHandlingCode != null ? string.Join(Configuration.FieldRepeatSeparator, SpecimenHandlingCode.Select(x => x.ToDelimitedString())) : null,
                                SpecimenPreference,
                                PreferredSpecimenAttribtureSequenceId.HasValue ? PreferredSpecimenAttribtureSequenceId.Value.ToString(Consts.NumericFormat, culture) : null,
                                TaxonomicClassificationCode != null ? string.Join(Configuration.FieldRepeatSeparator, TaxonomicClassificationCode.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
