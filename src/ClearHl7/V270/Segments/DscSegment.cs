using ClearHl7.Helpers;

namespace ClearHl7.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment DSC - Continuation Pointer.
    /// </summary>
    public class DscSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "DSC";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// DSC.1 - Continuation Pointer.
        /// </summary>
        public string ContinuationPointer { get; set; }

        /// <summary>
        /// DSC.2 - Continuation Style.
        /// <para>Suggested: 0398 Continuation Style Code -&gt; ClearHl7.Codes.V270.CodeContinuationStyleCode</para>
        /// </summary>
        public string ContinuationStyle { get; set; }
        
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
                                ContinuationPointer,
                                ContinuationStyle
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}