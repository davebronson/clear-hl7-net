using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PAC - Shipment Package.
    /// </summary>
    public class PacSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PAC";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// PAC.1 - Set Id - PAC.
        ///// </summary>
        //public SetIdPac { get; set; }

        ///// <summary>
        ///// PAC.2 - Package ID.
        ///// </summary>
        //public PackageId { get; set; }

        ///// <summary>
        ///// PAC.3 - Parent Package ID.
        ///// </summary>
        //public ParentPackageId { get; set; }

        ///// <summary>
        ///// PAC.4 - Position in Parent Package.
        ///// </summary>
        //public PositionInParentPackage { get; set; }

        ///// <summary>
        ///// PAC.5 - Package Type.
        ///// </summary>
        //public PackageType { get; set; }

        ///// <summary>
        ///// PAC.6 - Package Condition.
        ///// </summary>
        //public PackageCondition { get; set; }

        ///// <summary>
        ///// PAC.7 - Package Handling Code.
        ///// </summary>
        //public PackageHandlingCode { get; set; }

        ///// <summary>
        ///// PAC.8 - Package Risk Code.
        ///// </summary>
        //public PackageRiskCode { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}"
                                ).TrimEnd('|');
        }
    }
}