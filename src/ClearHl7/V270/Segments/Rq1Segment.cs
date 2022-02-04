using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RQ1 - Requisition Detail-1.
    /// </summary>
    public class Rq1Segment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rq1Segment"/> class.
        /// </summary>
        public Rq1Segment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rq1Segment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public Rq1Segment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "RQ1";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// RQ1.1 - Anticipated Price.
        /// </summary>
        public string AnticipatedPrice { get; set; }

        /// <summary>
        /// RQ1.2 - Manufacturer Identifier.
        /// <para>Suggested: 0385 Manufacturer Identifier</para>
        /// </summary>
        public CodedWithExceptions ManufacturerIdentifier { get; set; }

        /// <summary>
        /// RQ1.3 - Manufacturer's Catalog.
        /// </summary>
        public string ManufacturersCatalog { get; set; }

        /// <summary>
        /// RQ1.4 - Vendor ID.
        /// </summary>
        public CodedWithExceptions VendorId { get; set; }

        /// <summary>
        /// RQ1.5 - Vendor Catalog.
        /// </summary>
        public string VendorCatalog { get; set; }

        /// <summary>
        /// RQ1.6 - Taxable.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
        /// </summary>
        public string Taxable { get; set; }

        /// <summary>
        /// RQ1.7 - Substitute Allowed.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
        /// </summary>
        public string SubstituteAllowed { get; set; }

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

            AnticipatedPrice = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            ManufacturerIdentifier = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            ManufacturersCatalog = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            VendorId = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[4], false, seps) : null;
            VendorCatalog = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            Taxable = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            SubstituteAllowed = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 8, Configuration.FieldSeparator),
                                Id,
                                AnticipatedPrice,
                                ManufacturerIdentifier?.ToDelimitedString(),
                                ManufacturersCatalog,
                                VendorId?.ToDelimitedString(),
                                VendorCatalog,
                                Taxable,
                                SubstituteAllowed
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
