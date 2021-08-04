using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PSG - Product Service Group.
    /// </summary>
    public class PsgSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PSG";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// PSG.1 - Provider Product/Service Group Number.
        /// </summary>
        public EntityIdentifier ProviderProductServiceGroupNumber { get; set; }

        /// <summary>
        /// PSG.2 - Payer Product/Service Group Number.
        /// </summary>
        public EntityIdentifier PayerProductServiceGroupNumber { get; set; }

        /// <summary>
        /// PSG.3 - Product/Service Group Sequence Number.
        /// </summary>
        public uint? ProductServiceGroupSequenceNumber { get; set; }

        /// <summary>
        /// PSG.4 - Adjudicate as Group.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
        /// </summary>
        public string AdjudicateAsGroup { get; set; }

        /// <summary>
        /// PSG.5 - Product/Service Group Billed Amount.
        /// </summary>
        public CompositePrice ProductServiceGroupBilledAmount { get; set; }

        /// <summary>
        /// PSG.6 - Product/Service Group Description.
        /// </summary>
        public string ProductServiceGroupDescription { get; set; }

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
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ProviderProductServiceGroupNumber = segments.Length > 1 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(1), false) : null;
            PayerProductServiceGroupNumber = segments.Length > 2 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(2), false) : null;
            ProductServiceGroupSequenceNumber = segments.ElementAtOrDefault(3)?.ToNullableUInt();
            AdjudicateAsGroup = segments.ElementAtOrDefault(4);
            ProductServiceGroupBilledAmount = segments.Length > 5 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(5), false) : null;
            ProductServiceGroupDescription = segments.ElementAtOrDefault(6);
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
                                StringHelper.StringFormatSequence(0, 7, Configuration.FieldSeparator),
                                Id,
                                ProviderProductServiceGroupNumber?.ToDelimitedString(),
                                PayerProductServiceGroupNumber?.ToDelimitedString(),
                                ProductServiceGroupSequenceNumber.HasValue ? ProductServiceGroupSequenceNumber.Value.ToString(culture) : null,
                                AdjudicateAsGroup,
                                ProductServiceGroupBilledAmount?.ToDelimitedString(),
                                ProductServiceGroupDescription
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}