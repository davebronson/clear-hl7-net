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

            SequenceNumberTestObservationMasterFile = segments.ElementAtOrDefault(1)?.ToNullableDecimal();
            DerivedSpecimen = segments.ElementAtOrDefault(2);
            ContainerDescription = segments.Length > 3 ? TypeHelper.Deserialize<Text>(segments.ElementAtOrDefault(3), false) : null;
            ContainerVolume = segments.ElementAtOrDefault(4)?.ToNullableDecimal();
            ContainerUnits = segments.Length > 5 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(5), false) : null;
            Specimen = segments.Length > 6 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(6), false) : null;
            Additive = segments.Length > 7 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(7), false) : null;
            Preparation = segments.Length > 8 ? TypeHelper.Deserialize<Text>(segments.ElementAtOrDefault(8), false) : null;
            SpecialHandlingRequirements = segments.Length > 9 ? TypeHelper.Deserialize<Text>(segments.ElementAtOrDefault(9), false) : null;
            NormalCollectionVolume = segments.Length > 10 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(10), false) : null;
            MinimumCollectionVolume = segments.Length > 11 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(11), false) : null;
            SpecimenRequirements = segments.Length > 12 ? TypeHelper.Deserialize<Text>(segments.ElementAtOrDefault(12), false) : null;
            SpecimenPriorities = segments.Length > 13 ? segments.ElementAtOrDefault(13).Split(separator) : null;
            SpecimenRetentionTime = segments.Length > 14 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(14), false) : null;
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