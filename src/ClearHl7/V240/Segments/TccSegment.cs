using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment TCC - Test Code Configuration.
    /// </summary>
    public class TccSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "TCC";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// TCC.1 - Universal Service Identifier.
        /// </summary>
        public CodedElement UniversalServiceIdentifier { get; set; }

        /// <summary>
        /// TCC.2 - Equipment Test Application Identifier.
        /// </summary>
        public EntityIdentifier EquipmentTestApplicationIdentifier { get; set; }

        /// <summary>
        /// TCC.3 - Specimen Source.
        /// <para>Suggested: 0070 Specimen Source Codes -&gt; ClearHl7.Codes.V240.CodeSpecimenSourceCodes</para>
        /// </summary>
        public SpecimentSource SpecimenSource { get; set; }

        /// <summary>
        /// TCC.4 - Auto-Dilution Factor Default.
        /// </summary>
        public StructuredNumeric AutoDilutionFactorDefault { get; set; }

        /// <summary>
        /// TCC.5 - Rerun Dilution Factor Default.
        /// </summary>
        public StructuredNumeric RerunDilutionFactorDefault { get; set; }

        /// <summary>
        /// TCC.6 - Pre-Dilution Factor Default.
        /// </summary>
        public StructuredNumeric PreDilutionFactorDefault { get; set; }

        /// <summary>
        /// TCC.7 - Endogenous Content of Pre-Dilution Diluent.
        /// </summary>
        public StructuredNumeric EndogenousContentOfPreDilutionDiluent { get; set; }

        /// <summary>
        /// TCC.8 - Inventory Limits Warning Level.
        /// </summary>
        public decimal? InventoryLimitsWarningLevel { get; set; }

        /// <summary>
        /// TCC.9 - Automatic Rerun Allowed.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V240.CodeYesNoIndicator</para>
        /// </summary>
        public string AutomaticRerunAllowed { get; set; }

        /// <summary>
        /// TCC.10 - Automatic Repeat Allowed.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V240.CodeYesNoIndicator</para>
        /// </summary>
        public string AutomaticRepeatAllowed { get; set; }

        /// <summary>
        /// TCC.11 - Automatic Reflex Allowed.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V240.CodeYesNoIndicator</para>
        /// </summary>
        public string AutomaticReflexAllowed { get; set; }

        /// <summary>
        /// TCC.12 - Equipment Dynamic Range.
        /// </summary>
        public StructuredNumeric EquipmentDynamicRange { get; set; }

        /// <summary>
        /// TCC.13 - Units.
        /// </summary>
        public CodedElement Units { get; set; }

        /// <summary>
        /// TCC.14 - Processing Type.
        /// <para>Suggested: 0388 Processing Type -&gt; ClearHl7.Codes.V240.CodeProcessingType</para>
        /// </summary>
        public CodedElement ProcessingType { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            UniversalServiceIdentifier = segments.Length > 1 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(1), false) : null;
            EquipmentTestApplicationIdentifier = segments.Length > 2 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(2), false) : null;
            SpecimenSource = segments.Length > 3 ? TypeHelper.Deserialize<SpecimentSource>(segments.ElementAtOrDefault(3), false) : null;
            AutoDilutionFactorDefault = segments.Length > 4 ? TypeHelper.Deserialize<StructuredNumeric>(segments.ElementAtOrDefault(4), false) : null;
            RerunDilutionFactorDefault = segments.Length > 5 ? TypeHelper.Deserialize<StructuredNumeric>(segments.ElementAtOrDefault(5), false) : null;
            PreDilutionFactorDefault = segments.Length > 6 ? TypeHelper.Deserialize<StructuredNumeric>(segments.ElementAtOrDefault(6), false) : null;
            EndogenousContentOfPreDilutionDiluent = segments.Length > 7 ? TypeHelper.Deserialize<StructuredNumeric>(segments.ElementAtOrDefault(7), false) : null;
            InventoryLimitsWarningLevel = segments.ElementAtOrDefault(8)?.ToNullableDecimal();
            AutomaticRerunAllowed = segments.ElementAtOrDefault(9);
            AutomaticRepeatAllowed = segments.ElementAtOrDefault(10);
            AutomaticReflexAllowed = segments.ElementAtOrDefault(11);
            EquipmentDynamicRange = segments.Length > 12 ? TypeHelper.Deserialize<StructuredNumeric>(segments.ElementAtOrDefault(12), false) : null;
            Units = segments.Length > 13 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(13), false) : null;
            ProcessingType = segments.Length > 14 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(14), false) : null;
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
                                UniversalServiceIdentifier?.ToDelimitedString(),
                                EquipmentTestApplicationIdentifier?.ToDelimitedString(),
                                SpecimenSource?.ToDelimitedString(),
                                AutoDilutionFactorDefault?.ToDelimitedString(),
                                RerunDilutionFactorDefault?.ToDelimitedString(),
                                PreDilutionFactorDefault?.ToDelimitedString(),
                                EndogenousContentOfPreDilutionDiluent?.ToDelimitedString(),
                                InventoryLimitsWarningLevel.HasValue ? InventoryLimitsWarningLevel.Value.ToString(Consts.NumericFormat, culture) : null,
                                AutomaticRerunAllowed,
                                AutomaticRepeatAllowed,
                                AutomaticReflexAllowed,
                                EquipmentDynamicRange?.ToDelimitedString(),
                                Units?.ToDelimitedString(),
                                ProcessingType?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}