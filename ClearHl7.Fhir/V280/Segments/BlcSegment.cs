using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V280.Types;

namespace ClearHl7.Fhir.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment BLC - Blood Code.
    /// </summary>
    public class BlcSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "BLC";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// BLC.1 - Blood Product Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0426</remarks>
        public CodedWithExceptions BloodProductCode { get; set; }

        /// <summary>
        /// BLC.2 - Blood Amount.
        /// </summary>
        public CompositeQuantityWithUnits BloodAmount { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}",
                                Id,
                                BloodProductCode?.ToDelimitedString(),
                                BloodAmount?.ToDelimitedString()
                                ).TrimEnd('|');
        }
    }
}