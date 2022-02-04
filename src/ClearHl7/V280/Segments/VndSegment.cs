using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment VND - Purchasing Vendor.
    /// </summary>
    public class VndSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VndSegment"/> class.
        /// </summary>
        public VndSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VndSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public VndSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "VND";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// VND.1 - Set Id - VND.
        /// </summary>
        public uint? SetIdVnd { get; set; }

        /// <summary>
        /// VND.2 - Vendor Identifier.
        /// </summary>
        public EntityIdentifier VendorIdentifier { get; set; }

        /// <summary>
        /// VND.3 - Vendor Name.
        /// </summary>
        public string VendorName { get; set; }

        /// <summary>
        /// VND.4 - Vendor Catalog Number.
        /// </summary>
        public EntityIdentifier VendorCatalogNumber { get; set; }

        /// <summary>
        /// VND.5 - Primary Vendor Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V280.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions PrimaryVendorIndicator { get; set; }

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

            SetIdVnd = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            VendorIdentifier = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[2], false, seps) : null;
            VendorName = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            VendorCatalogNumber = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[4], false, seps) : null;
            PrimaryVendorIndicator = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[5], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 6, Configuration.FieldSeparator),
                                Id,
                                SetIdVnd.HasValue ? SetIdVnd.Value.ToString(culture) : null,
                                VendorIdentifier?.ToDelimitedString(),
                                VendorName,
                                VendorCatalogNumber?.ToDelimitedString(),
                                PrimaryVendorIndicator?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
