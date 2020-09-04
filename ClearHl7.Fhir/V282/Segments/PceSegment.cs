using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PCE - Patient Charge Cost Center Exceptions.
    /// </summary>
    public class PceSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PCE";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// PCE.1 - Set ID - PCE.
        ///// </summary>
        //public SetIdPce { get; set; }

        ///// <summary>
        ///// PCE.2 - Cost Center Account Number.
        ///// </summary>
        //public CostCenterAccountNumber { get; set; }

        ///// <summary>
        ///// PCE.3 - Transaction Code.
        ///// </summary>
        //public TransactionCode { get; set; }

        ///// <summary>
        ///// PCE.4 - Transaction amount - unit.
        ///// </summary>
        //public TransactionAmountUnit { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}"
                                ).TrimEnd('|');
        }
    }
}