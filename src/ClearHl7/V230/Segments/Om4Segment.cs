using System;
using System.Collections.Generic;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
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
        public string Id => "OM4";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// OM4.1 - Sequence Number - Test/Observation Master File.
        /// </summary>
        public decimal? SequenceNumberTestObservationMasterFile { get; set; }

        /// <summary>
        /// OM4.2 - Derived Specimen.
        /// <para>Suggested: 0170 Derived Specimen -&gt; ClearHl7.Codes.V230.CodeDerivedSpecimen</para>
        /// </summary>
        public string DerivedSpecimen { get; set; }

        /// <summary>
        /// OM4.3 - Container Description.
        /// </summary>
        public Text ContainerDescription { get; set; }

        /// <summary>
        /// OM4.4 - Container Volume.
        /// </summary>
        public decimal? ContainerVolume { get; set; }

        /// <summary>
        /// OM4.5 - Container Units.
        /// </summary>
        public CodedElement ContainerUnits { get; set; }

        /// <summary>
        /// OM4.6 - Specimen.
        /// </summary>
        public CodedElement Specimen { get; set; }

        /// <summary>
        /// OM4.7 - Additive.
        /// </summary>
        public CodedElement Additive { get; set; }

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
        /// <para>Suggested: 0027 Priority -&gt; ClearHl7.Codes.V230.CodePriority</para>
        /// </summary>
        public IEnumerable<string> SpecimenPriorities { get; set; }

        /// <summary>
        /// OM4.14 - Specimen Retention Time.
        /// </summary>
        public CompositeQuantityWithUnits SpecimenRetentionTime { get; set; }

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

            SequenceNumberTestObservationMasterFile = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            DerivedSpecimen = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            ContainerDescription = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[3], false, seps) : null;
            ContainerVolume = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDecimal() : null;
            ContainerUnits = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[5], false, seps) : null;
            Specimen = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[6], false, seps) : null;
            Additive = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[7], false, seps) : null;
            Preparation = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[8], false, seps) : null;
            SpecialHandlingRequirements = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[9], false, seps) : null;
            NormalCollectionVolume = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[10], false, seps) : null;
            MinimumCollectionVolume = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[11], false, seps) : null;
            SpecimenRequirements = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[12], false, seps) : null;
            SpecimenPriorities = segments.Length > 13 && segments[13].Length > 0 ? segments[13].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            SpecimenRetentionTime = segments.Length > 14 && segments[14].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[14], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 15, Configuration.FieldSeparator),
                                Id,
                                SequenceNumberTestObservationMasterFile.HasValue ? SequenceNumberTestObservationMasterFile.Value.ToString(Consts.NumericFormat, culture) : null,
                                DerivedSpecimen,
                                ContainerDescription?.ToDelimitedString(),
                                ContainerVolume.HasValue ? ContainerVolume.Value.ToString(Consts.NumericFormat, culture) : null,
                                ContainerUnits?.ToDelimitedString(),
                                Specimen?.ToDelimitedString(),
                                Additive?.ToDelimitedString(),
                                Preparation?.ToDelimitedString(),
                                SpecialHandlingRequirements?.ToDelimitedString(),
                                NormalCollectionVolume?.ToDelimitedString(),
                                MinimumCollectionVolume?.ToDelimitedString(),
                                SpecimenRequirements?.ToDelimitedString(),
                                SpecimenPriorities != null ? string.Join(Configuration.FieldRepeatSeparator, SpecimenPriorities) : null,
                                SpecimenRetentionTime?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
