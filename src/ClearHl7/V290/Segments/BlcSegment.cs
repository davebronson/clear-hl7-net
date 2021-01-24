using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
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
        /// <para>Suggested: 0426 Blood Product Code -&gt; ClearHl7.Codes.V290.CodeBloodProductCode</para>
        /// </summary>
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
                                StringHelper.StringFormatSequence(0, 3, Configuration.FieldSeparator),
                                Id,
                                BloodProductCode?.ToDelimitedString(),
                                BloodAmount?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}