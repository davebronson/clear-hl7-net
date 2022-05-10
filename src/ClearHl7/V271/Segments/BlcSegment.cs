using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment BLC - Blood Code.
    /// </summary>
    public class BlcSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlcSegment"/> class.
        /// </summary>
        public BlcSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlcSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public BlcSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "BLC";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// BLC.1 - Blood Product Code.
        /// <para>Suggested: 0426 Blood Product Code -&gt; ClearHl7.Codes.V271.CodeBloodProductCode</para>
        /// </summary>
        public CodedWithExceptions BloodProductCode { get; set; }

        /// <summary>
        /// BLC.2 - Blood Amount.
        /// </summary>
        public CompositeQuantityWithUnits BloodAmount { get; set; }

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
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            BloodProductCode = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], false, seps) : null;
            BloodAmount = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[2], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

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
