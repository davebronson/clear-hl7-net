using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment VND - Purchasing Vendor.
    /// </summary>
    public class VndSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "VND";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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