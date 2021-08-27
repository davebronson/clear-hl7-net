using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V280.CodeYesNoIndicator</para>
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
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ProviderProductServiceGroupNumber = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[1], false) : null;
            PayerProductServiceGroupNumber = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[2], false) : null;
            ProductServiceGroupSequenceNumber = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableUInt() : null;
            AdjudicateAsGroup = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            ProductServiceGroupBilledAmount = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<CompositePrice>(segments[5], false) : null;
            ProductServiceGroupDescription = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
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