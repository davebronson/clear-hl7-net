using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;

namespace ClearHl7.V290.Segments
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
        /// <para>Suggested: 0398 Continuation Style Code -&gt; ClearHl7.Codes.V290.CodeContinuationStyleCode</para>
        /// </summary>
        public string ContinuationStyle { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public DscSegment FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ContinuationPointer = segments.ElementAtOrDefault(1);
            ContinuationStyle = segments.ElementAtOrDefault(2);
            
            return this;
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

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