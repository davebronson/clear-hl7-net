using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// TCC.1 - Universal Service Identifier.
        ///// </summary>
        //public UniversalServiceIdentifier { get; set; }

        ///// <summary>
        ///// TCC.2 - Equipment Test Application Identifier.
        ///// </summary>
        //public EquipmentTestApplicationIdentifier { get; set; }

        ///// <summary>
        ///// TCC.3 - Specimen Source.
        ///// </summary>
        //public SpecimenSource { get; set; }

        ///// <summary>
        ///// TCC.4 - Auto-Dilution Factor Default.
        ///// </summary>
        //public AutoDilutionFactorDefault { get; set; }

        ///// <summary>
        ///// TCC.5 - Rerun Dilution Factor Default.
        ///// </summary>
        //public RerunDilutionFactorDefault { get; set; }

        ///// <summary>
        ///// TCC.6 - Pre-Dilution Factor Default.
        ///// </summary>
        //public PreDilutionFactorDefault { get; set; }

        ///// <summary>
        ///// TCC.7 - Endogenous Content of Pre-Dilution Diluent.
        ///// </summary>
        //public EndogenousContentOfPreDilutionDiluent { get; set; }

        ///// <summary>
        ///// TCC.8 - Inventory Limits Warning Level.
        ///// </summary>
        //public InventoryLimitsWarningLevel { get; set; }

        ///// <summary>
        ///// TCC.9 - Automatic Rerun Allowed.
        ///// </summary>
        //public AutomaticRerunAllowed { get; set; }

        ///// <summary>
        ///// TCC.10 - Automatic Repeat Allowed.
        ///// </summary>
        //public AutomaticRepeatAllowed { get; set; }

        ///// <summary>
        ///// TCC.11 - Automatic Reflex Allowed.
        ///// </summary>
        //public AutomaticReflexAllowed { get; set; }

        ///// <summary>
        ///// TCC.12 - Equipment Dynamic Range.
        ///// </summary>
        //public EquipmentDynamicRange { get; set; }

        ///// <summary>
        ///// TCC.13 - Units.
        ///// </summary>
        //public Units { get; set; }

        ///// <summary>
        ///// TCC.14 - Processing Type.
        ///// </summary>
        //public ProcessingType { get; set; }

        ///// <summary>
        ///// TCC.15 - Test Criticality.
        ///// </summary>
        //public TestCriticality { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}"
                                ).TrimEnd('|');
        }
    }
}