﻿using System.Collections.Generic;
using ClearHl7.Helpers;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OM4 - Observations That Require Specimens.
    /// </summary>
    public class Om4Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "OM4";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// OM4.1 - Sequence Number - Test/Observation Master File.
        /// </summary>
        public decimal? SequenceNumberTestObservationMasterFile { get; set; }

        /// <summary>
        /// OM4.2 - Derived Specimen.
        /// <para>Suggested: 0170 Derived Specimen -&gt; ClearHl7.Codes.V240.CodeDerivedSpecimen</para>
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
        /// <para>Suggested: 0371 Additive/Preservative -&gt; ClearHl7.Codes.V240.CodeAdditivePreservative</para>
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
        /// <para>Suggested: 0027 Priority -&gt; ClearHl7.Codes.V240.CodePriority</para>
        /// </summary>
        public IEnumerable<string> SpecimenPriorities { get; set; }

        /// <summary>
        /// OM4.14 - Specimen Retention Time.
        /// </summary>
        public CompositeQuantityWithUnits SpecimenRetentionTime { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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