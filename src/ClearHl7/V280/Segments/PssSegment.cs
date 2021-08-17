using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PSS - Product Service Section.
    /// </summary>
    public class PssSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PSS";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ProviderProductServiceSectionNumber = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[1], false) : null;
            PayerProductServiceSectionNumber = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[2], false) : null;
            ProductServiceSectionSequenceNumber = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableUInt() : null;
            BilledAmount = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<CompositePrice>(segments[4], false) : null;
            SectionDescriptionOrHeading = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
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