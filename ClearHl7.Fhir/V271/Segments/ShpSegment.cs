using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V271.Types;

namespace ClearHl7.Fhir.V271.Segments
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

        /// <summary>
        /// SHP.1 - Shipment ID.
        /// </summary>
        public EntityIdentifier ShipmentId { get; set; }

        /// <summary>
        /// SHP.2 - Internal Shipment ID.
        /// </summary>
        public IEnumerable<EntityIdentifier> InternalShipmentId { get; set; }

        /// <summary>
        /// SHP.3 - Shipment Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0905</remarks>
        public CodedWithExceptions ShipmentStatus { get; set; }

        /// <summary>
        /// SHP.4 - Shipment Status Date/Time.
        /// </summary>
        public DateTime? ShipmentStatusDateTime { get; set; }

        /// <summary>
        /// SHP.5 - Shipment Status Reason.
        /// </summary>
        public Text ShipmentStatusReason { get; set; }

        /// <summary>
        /// SHP.6 - Shipment Priority.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0906</remarks>
        public CodedWithExceptions ShipmentPriority { get; set; }

        /// <summary>
        /// SHP.7 - Shipment Confidentiality.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0907</remarks>
        public IEnumerable<CodedWithExceptions> ShipmentConfidentiality { get; set; }

        /// <summary>
        /// SHP.8 - Number of Packages in Shipment.
        /// </summary>
        public decimal? NumberOfPackagesInShipment { get; set; }

        /// <summary>
        /// SHP.9 - Shipment Condition.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0544</remarks>
        public IEnumerable<CodedWithExceptions> ShipmentCondition { get; set; }

        /// <summary>
        /// SHP.10 - Shipment Handling Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0376</remarks>
        public IEnumerable<CodedWithExceptions> ShipmentHandlingCode { get; set; }

        /// <summary>
        /// SHP.11 - Shipment Risk Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0489</remarks>
        public IEnumerable<CodedWithExceptions> ShipmentRiskCode { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}",
                                Id,
                                ShipmentId?.ToDelimitedString(),
                                InternalShipmentId != null ? string.Join("~", InternalShipmentId.Select(x => x.ToDelimitedString())) : null,
                                ShipmentStatus?.ToDelimitedString(),
                                ShipmentStatusDateTime.HasValue ? ShipmentStatusDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ShipmentStatusReason?.ToDelimitedString(),
                                ShipmentPriority?.ToDelimitedString(),
                                ShipmentConfidentiality != null ? string.Join("~", ShipmentConfidentiality.Select(x => x.ToDelimitedString())) : null,
                                NumberOfPackagesInShipment.HasValue ? NumberOfPackagesInShipment.Value.ToString(Consts.NumericFormat, culture) : null,
                                ShipmentCondition != null ? string.Join("~", ShipmentCondition.Select(x => x.ToDelimitedString())) : null,
                                ShipmentHandlingCode != null ? string.Join("~", ShipmentHandlingCode.Select(x => x.ToDelimitedString())) : null,
                                ShipmentRiskCode != null ? string.Join("~", ShipmentRiskCode.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd('|');
        }
    }
}