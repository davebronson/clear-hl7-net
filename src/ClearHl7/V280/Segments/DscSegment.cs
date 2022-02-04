using System;
using System.Globalization;
using ClearHl7.Helpers;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment DSC - Continuation Pointer.
    /// </summary>
    public class DscSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DscSegment"/> class.
        /// </summary>
        public DscSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DscSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public DscSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id { get; } = "DSC";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// DSC.1 - Continuation Pointer.
        /// </summary>
        public string ContinuationPointer { get; set; }

        /// <summary>
        /// DSC.2 - Continuation Style.
        /// <para>Suggested: 0398 Continuation Style Code -&gt; ClearHl7.Codes.V280.CodeContinuationStyleCode</para>
        /// </summary>
        public string ContinuationStyle { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ContinuationPointer = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            ContinuationStyle = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
        }

        /// <inheritdoc/>
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
