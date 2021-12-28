﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RDF - Table Row Definition.
    /// </summary>
    public class RdfSegment : ISegment
    {
        /// <inheritdoc/>
        public string Id { get; } = "RDF";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// RDF.1 - Number of Columns per Row.
        /// </summary>
        public decimal? NumberOfColumnsPerRow { get; set; }

        /// <summary>
        /// RDF.2 - Column Description.
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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
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
