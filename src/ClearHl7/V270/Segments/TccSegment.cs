using ClearHl7.Helpers;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
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
        public CodedWithExceptions UniversalServiceIdentifier { get; set; }

        /// <summary>
        /// TCC.2 - Equipment Test Application Identifier.
        /// </summary>
        public EntityIdentifier EquipmentTestApplicationIdentifier { get; set; }

        /// <summary>
        /// TCC.3 - Specimen Source.
        /// </summary>
        public string SpecimenSource { get; set; }

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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string AutomaticRerunAllowed { get; set; }

        /// <summary>
        /// TCC.10 - Automatic Repeat Allowed.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string AutomaticRepeatAllowed { get; set; }

        /// <summary>
        /// TCC.11 - Automatic Reflex Allowed.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string AutomaticReflexAllowed { get; set; }

        /// <summary>
        /// TCC.12 - Equipment Dynamic Range.
        /// </summary>
        public StructuredNumeric EquipmentDynamicRange { get; set; }

        /// <summary>
        /// TCC.13 - Units.
        /// </summary>
        public CodedWithExceptions Units { get; set; }

        /// <summary>
        /// TCC.14 - Processing Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0388</remarks>
        public CodedWithExceptions ProcessingType { get; set; }

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
                                UniversalServiceIdentifier?.ToDelimitedString(),
                                EquipmentTestApplicationIdentifier?.ToDelimitedString(),
                                SpecimenSource,
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