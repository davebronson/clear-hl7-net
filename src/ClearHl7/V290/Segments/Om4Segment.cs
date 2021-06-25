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

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public Om4Segment FromDelimitedString(string delimitedString)
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
            ContainerDescription = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => new Text().FromDelimitedString(x)) : null;
            ContainerVolume = segments.Length > 4 ? segments.ElementAtOrDefault(4).Split(separator).Select(x => x.ToDecimal()) : null;
            ContainerUnits = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            Specimen = segments.Length > 6 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(6)) : null;
            Additive = segments.Length > 7 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(7)) : null;
            Preparation = segments.Length > 8 ? new Text().FromDelimitedString(segments.ElementAtOrDefault(8)) : null;
            SpecialHandlingRequirements = segments.Length > 9 ? new Text().FromDelimitedString(segments.ElementAtOrDefault(9)) : null;
            NormalCollectionVolume = segments.Length > 10 ? new CompositeQuantityWithUnits().FromDelimitedString(segments.ElementAtOrDefault(10)) : null;
            MinimumCollectionVolume = segments.Length > 11 ? new CompositeQuantityWithUnits().FromDelimitedString(segments.ElementAtOrDefault(11)) : null;
            SpecimenRequirements = segments.Length > 12 ? new Text().FromDelimitedString(segments.ElementAtOrDefault(12)) : null;
            SpecimenPriorities = segments.Length > 13 ? segments.ElementAtOrDefault(13).Split(separator) : null;
            SpecimenRetentionTime = segments.Length > 14 ? new CompositeQuantityWithUnits().FromDelimitedString(segments.ElementAtOrDefault(14)) : null;
            SpecimenHandlingCode = segments.Length > 15 ? segments.ElementAtOrDefault(15).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            SpecimenPreference = segments.ElementAtOrDefault(16);
            PreferredSpecimenAttribtureSequenceId = segments.ElementAtOrDefault(17)?.ToNullableDecimal();
            TaxonomicClassificationCode = segments.Length > 18 ? segments.ElementAtOrDefault(18).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            
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