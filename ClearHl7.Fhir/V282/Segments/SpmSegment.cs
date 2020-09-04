using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// SPM.1 - Set ID - SPM.
        ///// </summary>
        //public SetIdSpm { get; set; }

        ///// <summary>
        ///// SPM.2 - Specimen ID.
        ///// </summary>
        //public SpecimenId { get; set; }

        ///// <summary>
        ///// SPM.3 - Specimen Parent IDs.
        ///// </summary>
        //public SpecimenParentIds { get; set; }

        ///// <summary>
        ///// SPM.4 - Specimen Type.
        ///// </summary>
        //public SpecimenType { get; set; }

        ///// <summary>
        ///// SPM.5 - Specimen Type Modifier.
        ///// </summary>
        //public SpecimenTypeModifier { get; set; }

        ///// <summary>
        ///// SPM.6 - Specimen Additives.
        ///// </summary>
        //public SpecimenAdditives { get; set; }

        ///// <summary>
        ///// SPM.7 - Specimen Collection Method.
        ///// </summary>
        //public SpecimenCollectionMethod { get; set; }

        ///// <summary>
        ///// SPM.8 - Specimen Source Site.
        ///// </summary>
        //public SpecimenSourceSite { get; set; }

        ///// <summary>
        ///// SPM.9 - Specimen Source Site Modifier.
        ///// </summary>
        //public SpecimenSourceSiteModifier { get; set; }

        ///// <summary>
        ///// SPM.10 - Specimen Collection Site.
        ///// </summary>
        //public SpecimenCollectionSite { get; set; }

        ///// <summary>
        ///// SPM.11 - Specimen Role.
        ///// </summary>
        //public SpecimenRole { get; set; }

        ///// <summary>
        ///// SPM.12 - Specimen Collection Amount.
        ///// </summary>
        //public SpecimenCollectionAmount { get; set; }

        ///// <summary>
        ///// SPM.13 - Grouped Specimen Count.
        ///// </summary>
        //public GroupedSpecimenCount { get; set; }

        ///// <summary>
        ///// SPM.14 - Specimen Description.
        ///// </summary>
        //public SpecimenDescription { get; set; }

        ///// <summary>
        ///// SPM.15 - Specimen Handling Code.
        ///// </summary>
        //public SpecimenHandlingCode { get; set; }

        ///// <summary>
        ///// SPM.16 - Specimen Risk Code.
        ///// </summary>
        //public SpecimenRiskCode { get; set; }

        ///// <summary>
        ///// SPM.17 - Specimen Collection Date/Time.
        ///// </summary>
        //public SpecimenCollectionDateTime { get; set; }

        ///// <summary>
        ///// SPM.18 - Specimen Received Date/Time *.
        ///// </summary>
        //public SpecimenReceivedDateTime { get; set; }

        ///// <summary>
        ///// SPM.19 - Specimen Expiration Date/Time.
        ///// </summary>
        //public SpecimenExpirationDateTime { get; set; }

        ///// <summary>
        ///// SPM.20 - Specimen Availability.
        ///// </summary>
        //public SpecimenAvailability { get; set; }

        ///// <summary>
        ///// SPM.21 - Specimen Reject Reason.
        ///// </summary>
        //public SpecimenRejectReason { get; set; }

        ///// <summary>
        ///// SPM.22 - Specimen Quality.
        ///// </summary>
        //public SpecimenQuality { get; set; }

        ///// <summary>
        ///// SPM.23 - Specimen Appropriateness.
        ///// </summary>
        //public SpecimenAppropriateness { get; set; }

        ///// <summary>
        ///// SPM.24 - Specimen Condition.
        ///// </summary>
        //public SpecimenCondition { get; set; }

        ///// <summary>
        ///// SPM.25 - Specimen Current Quantity.
        ///// </summary>
        //public SpecimenCurrentQuantity { get; set; }

        ///// <summary>
        ///// SPM.26 - Number of Specimen Containers.
        ///// </summary>
        //public NumberOfSpecimenContainers { get; set; }

        ///// <summary>
        ///// SPM.27 - Container Type.
        ///// </summary>
        //public ContainerType { get; set; }

        ///// <summary>
        ///// SPM.28 - Container Condition.
        ///// </summary>
        //public ContainerCondition { get; set; }

        ///// <summary>
        ///// SPM.29 - Specimen Child Role.
        ///// </summary>
        //public SpecimenChildRole { get; set; }

        ///// <summary>
        ///// SPM.30 - Accession ID.
        ///// </summary>
        //public AccessionId { get; set; }

        ///// <summary>
        ///// SPM.31 - Other Specimen ID.
        ///// </summary>
        //public OtherSpecimenId { get; set; }

        ///// <summary>
        ///// SPM.32 - Shipment ID.
        ///// </summary>
        //public ShipmentId { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}|{30}|{31}|{32}"
                                ).TrimEnd('|');
        }
    }
}