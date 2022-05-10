using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PSS - Product Service Section.
    /// </summary>
    public class PssSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PssSegment"/> class.
        /// </summary>
        public PssSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PssSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public PssSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "PSS";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// PSS.1 - Provider Product/Service Section Number.
        /// </summary>
        public EntityIdentifier ProviderProductServiceSectionNumber { get; set; }

        /// <summary>
        /// PSS.2 - Payer Product/Service Section Number.
        /// </summary>
        public EntityIdentifier PayerProductServiceSectionNumber { get; set; }

        /// <summary>
        /// PSS.3 - Product/Service Section Sequence Number.
        /// </summary>
        public uint? ProductServiceSectionSequenceNumber { get; set; }

        /// <summary>
        /// PSS.4 - Billed Amount.
        /// </summary>
        public CompositePrice BilledAmount { get; set; }

        /// <summary>
        /// PSS.5 - Section Description or Heading.
        /// </summary>
        public string SectionDescriptionOrHeading { get; set; }

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

            ProviderProductServiceSectionNumber = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[1], false, seps) : null;
            PayerProductServiceSectionNumber = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[2], false, seps) : null;
            ProductServiceSectionSequenceNumber = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableUInt() : null;
            BilledAmount = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[4], false, seps) : null;
            SectionDescriptionOrHeading = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 6, Configuration.FieldSeparator),
                                Id,
                                ProviderProductServiceSectionNumber?.ToDelimitedString(),
                                PayerProductServiceSectionNumber?.ToDelimitedString(),
                                ProductServiceSectionSequenceNumber.HasValue ? ProductServiceSectionSequenceNumber.Value.ToString(culture) : null,
                                BilledAmount?.ToDelimitedString(),
                                SectionDescriptionOrHeading
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
