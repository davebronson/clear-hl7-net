using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
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
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions PrimaryVendorIndicator { get; set; }

        /// <summary>
        /// VND.6 - Corporation.
        /// </summary>
        public IEnumerable<EntityIdentifier> Corporation { get; set; }

        /// <summary>
        /// VND.7 - Primary Contact.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons PrimaryContact { get; set; }

        /// <summary>
        /// VND.8 - Contract Adjustment.
        /// </summary>
        public MoneyOrPercentage ContractAdjustment { get; set; }

        /// <summary>
        /// VND.9 - Associated Contract ID.
        /// </summary>
        public IEnumerable<EntityIdentifier> AssociatedContractId { get; set; }

        /// <summary>
        /// VND.10 - Class of Trade.
        /// </summary>
        public IEnumerable<string> ClassOfTrade { get; set; }

        /// <summary>
        /// VND.11 - Pricing Tier Level.
        /// </summary>
        public CodedWithNoExceptions PricingTierLevel { get; set; }

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

            SetIdVnd = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            VendorIdentifier = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[2], false, seps) : null;
            VendorName = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            VendorCatalogNumber = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[4], false, seps) : null;
            PrimaryVendorIndicator = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[5], false, seps) : null;
            Corporation = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<EntityIdentifier>(x, false, seps)) : null;
            PrimaryContact = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[7], false, seps) : null;
            ContractAdjustment = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<MoneyOrPercentage>(segments[8], false, seps) : null;
            AssociatedContractId = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<EntityIdentifier>(x, false, seps)) : null;
            ClassOfTrade = segments.Length > 10 && segments[10].Length > 0 ? segments[10].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            PricingTierLevel = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[11], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 12, Configuration.FieldSeparator),
                                Id,
                                SetIdVnd.HasValue ? SetIdVnd.Value.ToString(culture) : null,
                                VendorIdentifier?.ToDelimitedString(),
                                VendorName,
                                VendorCatalogNumber?.ToDelimitedString(),
                                PrimaryVendorIndicator?.ToDelimitedString(),
                                Corporation != null ? string.Join(Configuration.FieldRepeatSeparator, Corporation.Select(x => x.ToDelimitedString())) : null,
                                PrimaryContact?.ToDelimitedString(),
                                ContractAdjustment?.ToDelimitedString(),
                                AssociatedContractId != null ? string.Join(Configuration.FieldRepeatSeparator, AssociatedContractId.Select(x => x.ToDelimitedString())) : null,
                                ClassOfTrade != null ? string.Join(Configuration.FieldRepeatSeparator, ClassOfTrade) : null,
                                PricingTierLevel?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
