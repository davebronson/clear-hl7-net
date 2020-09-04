using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SHP - Shipment.
    /// </summary>
    public class ShpSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "SHP";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// SHP.1 - Shipment ID.
        ///// </summary>
        //public ShipmentId { get; set; }

        ///// <summary>
        ///// SHP.2 - Internal Shipment ID.
        ///// </summary>
        //public InternalShipmentId { get; set; }

        ///// <summary>
        ///// SHP.3 - Shipment Status.
        ///// </summary>
        //public ShipmentStatus { get; set; }

        ///// <summary>
        ///// SHP.4 - Shipment Status Date/Time.
        ///// </summary>
        //public ShipmentStatusDateTime { get; set; }

        ///// <summary>
        ///// SHP.5 - Shipment Status Reason.
        ///// </summary>
        //public ShipmentStatusReason { get; set; }

        ///// <summary>
        ///// SHP.6 - Shipment Priority.
        ///// </summary>
        //public ShipmentPriority { get; set; }

        ///// <summary>
        ///// SHP.7 - Shipment Confidentiality.
        ///// </summary>
        //public ShipmentConfidentiality { get; set; }

        ///// <summary>
        ///// SHP.8 - Number of Packages in Shipment.
        ///// </summary>
        //public NumberOfPackagesInShipment { get; set; }

        ///// <summary>
        ///// SHP.9 - Shipment Condition.
        ///// </summary>
        //public ShipmentCondition { get; set; }

        ///// <summary>
        ///// SHP.10 - Shipment Handling Code.
        ///// </summary>
        //public ShipmentHandlingCode { get; set; }

        ///// <summary>
        ///// SHP.11 - Shipment Risk Code.
        ///// </summary>
        //public ShipmentRiskCode { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}"
                                ).TrimEnd('|');
        }
    }
}