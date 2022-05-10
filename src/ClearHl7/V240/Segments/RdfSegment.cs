using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RDF - Table Row Definition.
    /// </summary>
    public class RdfSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RdfSegment"/> class.
        /// </summary>
        public RdfSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RdfSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public RdfSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "RDF";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// RDF.1 - Number of Columns per Row.
        /// </summary>
        public decimal? NumberOfColumnsPerRow { get; set; }

        /// <summary>
        /// RDF.2 - Column Description.
        /// <para>Suggested: 0440 Data Types -&gt; ClearHl7.Codes.V240.CodeDataTypes</para>
        /// </summary>
        public IEnumerable<RowColumnDefinition> ColumnDescription { get; set; }

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

            NumberOfColumnsPerRow = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            ColumnDescription = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<RowColumnDefinition>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, Configuration.FieldSeparator),
                                Id,
                                NumberOfColumnsPerRow.HasValue ? NumberOfColumnsPerRow.Value.ToString(Consts.NumericFormat, culture) : null,
                                ColumnDescription != null ? string.Join(Configuration.FieldRepeatSeparator, ColumnDescription.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
