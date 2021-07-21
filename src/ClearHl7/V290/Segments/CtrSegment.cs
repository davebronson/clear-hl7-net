using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
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
        /// <para>Suggested: 0536 Certificate Status -&gt; ClearHl7.Codes.V290.CodeCertificateStatus</para>
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
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions FreeOnBoardFreightTerms { get; set; }

        /// <summary>
        /// CTR.11 - Price Protection Date.
        /// </summary>
        public DateTime? PriceProtectionDate { get; set; }

        /// <summary>
        /// CTR.12 - Fixed Price Contract Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeExpandedYesNoIndicator</para>
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
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ContractIdentifier = segments.Length > 1 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(1), false) : null;
            ContractDescription = segments.ElementAtOrDefault(2);
            ContractStatus = segments.Length > 3 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(3), false) : null;
            EffectiveDate = segments.ElementAtOrDefault(4)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ExpirationDate = segments.ElementAtOrDefault(5)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ContractOwnerName = segments.Length > 6 ? TypeHelper.Deserialize<ExtendedPersonName>(segments.ElementAtOrDefault(6), false) : null;
            ContractOriginatorName = segments.Length > 7 ? TypeHelper.Deserialize<ExtendedPersonName>(segments.ElementAtOrDefault(7), false) : null;
            SupplierType = segments.Length > 8 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(8), false) : null;
            ContractType = segments.Length > 9 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(9), false) : null;
            FreeOnBoardFreightTerms = segments.Length > 10 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(10), false) : null;
            PriceProtectionDate = segments.ElementAtOrDefault(11)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            FixedPriceContractIndicator = segments.Length > 12 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(12), false) : null;
            GroupPurchasingOrganization = segments.Length > 13 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments.ElementAtOrDefault(13), false) : null;
            MaximumMarkup = segments.Length > 14 ? TypeHelper.Deserialize<MoneyOrPercentage>(segments.ElementAtOrDefault(14), false) : null;
            ActualMarkup = segments.Length > 15 ? TypeHelper.Deserialize<MoneyOrPercentage>(segments.ElementAtOrDefault(15), false) : null;
            Corporation = segments.Length > 16 ? segments.ElementAtOrDefault(16).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            ParentOfCorporation = segments.Length > 17 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments.ElementAtOrDefault(17), false) : null;
            PricingTierLevel = segments.Length > 18 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(18), false) : null;
            ContractPriority = segments.ElementAtOrDefault(19);
            ClassOfTrade = segments.Length > 20 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(20), false) : null;
            AssociatedContractId = segments.Length > 21 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(21), false) : null;
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