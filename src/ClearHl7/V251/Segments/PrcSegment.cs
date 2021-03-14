using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PRC - Pricing.
    /// </summary>
    public class PrcSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PRC";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// PRC.1 - Primary Key Value - PRC.
        /// <para>Suggested: 0132 Transaction Code</para>
        /// </summary>
        public CodedElement PrimaryKeyValuePrc { get; set; }

        /// <summary>
        /// PRC.2 - Facility ID - PRC.
        /// <para>Suggested: 0464 Facility ID</para>
        /// </summary>
        public IEnumerable<CodedElement> FacilityIdPrc { get; set; }

        /// <summary>
        /// PRC.3 - Department.
        /// <para>Suggested: 0184 Department</para>
        /// </summary>
        public IEnumerable<CodedElement> Department { get; set; }

        /// <summary>
        /// PRC.4 - Valid Patient Classes.
        /// <para>Suggested: 0004 Patient Class -&gt; ClearHl7.Codes.V251.CodePatientClass</para>
        /// </summary>
        public IEnumerable<string> ValidPatientClasses { get; set; }

        /// <summary>
        /// PRC.5 - Price.
        /// </summary>
        public IEnumerable<CompositePrice> Price { get; set; }

        /// <summary>
        /// PRC.6 - Formula.
        /// </summary>
        public IEnumerable<string> Formula { get; set; }

        /// <summary>
        /// PRC.7 - Minimum Quantity.
        /// </summary>
        public decimal? MinimumQuantity { get; set; }

        /// <summary>
        /// PRC.8 - Maximum Quantity.
        /// </summary>
        public decimal? MaximumQuantity { get; set; }

        /// <summary>
        /// PRC.9 - Minimum Price.
        /// </summary>
        public Money MinimumPrice { get; set; }

        /// <summary>
        /// PRC.10 - Maximum Price.
        /// </summary>
        public Money MaximumPrice { get; set; }

        /// <summary>
        /// PRC.11 - Effective Start Date.
        /// </summary>
        public DateTime? EffectiveStartDate { get; set; }

        /// <summary>
        /// PRC.12 - Effective End Date.
        /// </summary>
        public DateTime? EffectiveEndDate { get; set; }

        /// <summary>
        /// PRC.13 - Price Override Flag.
        /// <para>Suggested: 0268 Override -&gt; ClearHl7.Codes.V251.CodeOverride</para>
        /// </summary>
        public string PriceOverrideFlag { get; set; }

        /// <summary>
        /// PRC.14 - Billing Category.
        /// <para>Suggested: 0293 Billing Category</para>
        /// </summary>
        public IEnumerable<CodedElement> BillingCategory { get; set; }

        /// <summary>
        /// PRC.15 - Chargeable Flag.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V251.CodeYesNoIndicator</para>
        /// </summary>
        public string ChargeableFlag { get; set; }

        /// <summary>
        /// PRC.16 - Active/Inactive Flag.
        /// <para>Suggested: 0183 Active/Inactive -&gt; ClearHl7.Codes.V251.CodeActiveInactive</para>
        /// </summary>
        public string ActiveInactiveFlag { get; set; }

        /// <summary>
        /// PRC.17 - Cost.
        /// </summary>
        public Money Cost { get; set; }

        /// <summary>
        /// PRC.18 - Charge on Indicator.
        /// <para>Suggested: 0269 Charge On Indicator -&gt; ClearHl7.Codes.V251.CodeChargeOnIndicator</para>
        /// </summary>
        public string ChargeOnIndicator { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 19, Configuration.FieldSeparator),
                                Id,
                                PrimaryKeyValuePrc?.ToDelimitedString(),
                                FacilityIdPrc != null ? string.Join(Configuration.FieldRepeatSeparator, FacilityIdPrc.Select(x => x.ToDelimitedString())) : null,
                                Department != null ? string.Join(Configuration.FieldRepeatSeparator, Department.Select(x => x.ToDelimitedString())) : null,
                                ValidPatientClasses != null ? string.Join(Configuration.FieldRepeatSeparator, ValidPatientClasses) : null,
                                Price != null ? string.Join(Configuration.FieldRepeatSeparator, Price.Select(x => x.ToDelimitedString())) : null,
                                Formula != null ? string.Join(Configuration.FieldRepeatSeparator, Formula) : null,
                                MinimumQuantity.HasValue ? MinimumQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                MaximumQuantity.HasValue ? MaximumQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                MinimumPrice?.ToDelimitedString(),
                                MaximumPrice?.ToDelimitedString(),
                                EffectiveStartDate.HasValue ? EffectiveStartDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EffectiveEndDate.HasValue ? EffectiveEndDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PriceOverrideFlag,
                                BillingCategory != null ? string.Join(Configuration.FieldRepeatSeparator, BillingCategory.Select(x => x.ToDelimitedString())) : null,
                                ChargeableFlag,
                                ActiveInactiveFlag,
                                Cost?.ToDelimitedString(),
                                ChargeOnIndicator
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}