using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V290.Types;

namespace ClearHl7.Fhir.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CTR - Contract Master Outbound.
    /// </summary>
    public class CtrSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "CTR";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// CTR.1 - Contract Identifier.
        /// </summary>
        public EntityIdentifier ContractIdentifier { get; set; }

        /// <summary>
        /// CTR.2 - Contract Description.
        /// </summary>
        public string ContractDescription { get; set; }

        /// <summary>
        /// CTR.3 - Contract Status.
        /// <para>Suggested: 0536 Certificate Status -&gt; ClearHl7.Fhir.Codes.V290.CodeCertificateStatus</para>
        /// </summary>
        public CodedWithExceptions ContractStatus { get; set; }

        /// <summary>
        /// CTR.4 - Effective Date.
        /// </summary>
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// CTR.5 - Expiration Date.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// CTR.6 - Contract Owner Name.
        /// </summary>
        public ExtendedPersonName ContractOwnerName { get; set; }

        /// <summary>
        /// CTR.7 - Contract Originator Name.
        /// </summary>
        public ExtendedPersonName ContractOriginatorName { get; set; }

        /// <summary>
        /// CTR.8 - Supplier Type.
        /// <para>Suggested: 0946 Supplier Type</para>
        /// </summary>
        public CodedWithExceptions SupplierType { get; set; }

        /// <summary>
        /// CTR.9 - Contract Type.
        /// <para>Suggested: 0965 Contract Type</para>
        /// </summary>
        public CodedWithExceptions ContractType { get; set; }

        /// <summary>
        /// CTR.10 - Free On Board Freight Terms.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Fhir.Codes.V290.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions FreeOnBoardFreightTerms { get; set; }

        /// <summary>
        /// CTR.11 - Price Protection Date.
        /// </summary>
        public DateTime? PriceProtectionDate { get; set; }

        /// <summary>
        /// CTR.12 - Fixed Price Contract Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Fhir.Codes.V290.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions FixedPriceContractIndicator { get; set; }

        /// <summary>
        /// CTR.13 - Group Purchasing Organization.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations GroupPurchasingOrganization { get; set; }

        /// <summary>
        /// CTR.14 - Maximum Markup.
        /// </summary>
        public MoneyOrPercentage MaximumMarkup { get; set; }

        /// <summary>
        /// CTR.15 - Actual Markup.
        /// </summary>
        public MoneyOrPercentage ActualMarkup { get; set; }

        /// <summary>
        /// CTR.16 - Corporation.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> Corporation { get; set; }

        /// <summary>
        /// CTR.17 - Parent of Corporation.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations ParentOfCorporation { get; set; }

        /// <summary>
        /// CTR.18 - Pricing Tier Level.
        /// <para>Suggested: 0966 Pricing Tier Level</para>
        /// </summary>
        public CodedWithExceptions PricingTierLevel { get; set; }

        /// <summary>
        /// CTR.19 - Contract Priority.
        /// </summary>
        public string ContractPriority { get; set; }

        /// <summary>
        /// CTR.20 - Class of Trade.
        /// <para>Suggested: 0947 Class of Trade</para>
        /// </summary>
        public CodedWithExceptions ClassOfTrade { get; set; }

        /// <summary>
        /// CTR.21 - Associated Contract ID.
        /// </summary>
        public EntityIdentifier AssociatedContractId { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 22, Configuration.FieldSeparator),
                                Id,
                                ContractIdentifier?.ToDelimitedString(),
                                ContractDescription,
                                ContractStatus?.ToDelimitedString(),
                                EffectiveDate.HasValue ? EffectiveDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ExpirationDate.HasValue ? ExpirationDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ContractOwnerName?.ToDelimitedString(),
                                ContractOriginatorName?.ToDelimitedString(),
                                SupplierType?.ToDelimitedString(),
                                ContractType?.ToDelimitedString(),
                                FreeOnBoardFreightTerms?.ToDelimitedString(),
                                PriceProtectionDate.HasValue ? PriceProtectionDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                FixedPriceContractIndicator?.ToDelimitedString(),
                                GroupPurchasingOrganization?.ToDelimitedString(),
                                MaximumMarkup?.ToDelimitedString(),
                                ActualMarkup?.ToDelimitedString(),
                                Corporation != null ? string.Join(Configuration.FieldRepeatSeparator, Corporation.Select(x => x.ToDelimitedString())) : null,
                                ParentOfCorporation?.ToDelimitedString(),
                                PricingTierLevel?.ToDelimitedString(),
                                ContractPriority,
                                ClassOfTrade?.ToDelimitedString(),
                                AssociatedContractId?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}