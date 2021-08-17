using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
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
        public CodedWithExceptions PrimaryKeyValuePrc { get; set; }

        /// <summary>
        /// PRC.2 - Facility ID - PRC.
        /// <para>Suggested: 0464 Facility ID</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> FacilityIdPrc { get; set; }

        /// <summary>
        /// PRC.3 - Department.
        /// <para>Suggested: 0184 Department</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> Department { get; set; }

        /// <summary>
        /// PRC.4 - Valid Patient Classes.
        /// <para>Suggested: 0004 Patient Class -&gt; ClearHl7.Codes.V280.CodePatientClass</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ValidPatientClasses { get; set; }

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
        /// <para>Suggested: 0268 Override -&gt; ClearHl7.Codes.V280.CodeOverride</para>
        /// </summary>
        public CodedWithExceptions PriceOverrideFlag { get; set; }

        /// <summary>
        /// PRC.14 - Billing Category.
        /// <para>Suggested: 0293 Billing Category</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> BillingCategory { get; set; }

        /// <summary>
        /// PRC.15 - Chargeable Flag.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V280.CodeYesNoIndicator</para>
        /// </summary>
        public string ChargeableFlag { get; set; }

        /// <summary>
        /// PRC.16 - Active/Inactive Flag.
        /// <para>Suggested: 0183 Active/Inactive -&gt; ClearHl7.Codes.V280.CodeActiveInactive</para>
        /// </summary>
        public string ActiveInactiveFlag { get; set; }

        /// <summary>
        /// PRC.17 - Cost.
        /// </summary>
        public Money Cost { get; set; }

        /// <summary>
        /// PRC.18 - Charge on Indicator.
        /// <para>Suggested: 0269 Charge On Indicator -&gt; ClearHl7.Codes.V280.CodeChargeOnIndicator</para>
        /// </summary>
        public CodedWithExceptions ChargeOnIndicator { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            PrimaryKeyValuePrc = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[1], false) : null;
            FacilityIdPrc = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            Department = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            ValidPatientClasses = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            Price = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(separator).Select(x => TypeHelper.Deserialize<CompositePrice>(x, false)) : null;
            Formula = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(separator) : null;
            MinimumQuantity = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDecimal() : null;
            MaximumQuantity = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDecimal() : null;
            MinimumPrice = segments.Length > 9 && segments[9].Length > 0 ? TypeHelper.Deserialize<Money>(segments[9], false) : null;
            MaximumPrice = segments.Length > 10 && segments[10].Length > 0 ? TypeHelper.Deserialize<Money>(segments[10], false) : null;
            EffectiveStartDate = segments.Length > 11 && segments[11].Length > 0 ? segments[11].ToNullableDateTime() : null;
            EffectiveEndDate = segments.Length > 12 && segments[12].Length > 0 ? segments[12].ToNullableDateTime() : null;
            PriceOverrideFlag = segments.Length > 13 && segments[13].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[13], false) : null;
            BillingCategory = segments.Length > 14 && segments[14].Length > 0 ? segments[14].Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            ChargeableFlag = segments.Length > 15 && segments[15].Length > 0 ? segments[15] : null;
            ActiveInactiveFlag = segments.Length > 16 && segments[16].Length > 0 ? segments[16] : null;
            Cost = segments.Length > 17 && segments[17].Length > 0 ? TypeHelper.Deserialize<Money>(segments[17], false) : null;
            ChargeOnIndicator = segments.Length > 18 && segments[18].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[18], false) : null;
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
                                StringHelper.StringFormatSequence(0, 19, Configuration.FieldSeparator),
                                Id,
                                PrimaryKeyValuePrc?.ToDelimitedString(),
                                FacilityIdPrc != null ? string.Join(Configuration.FieldRepeatSeparator, FacilityIdPrc.Select(x => x.ToDelimitedString())) : null,
                                Department != null ? string.Join(Configuration.FieldRepeatSeparator, Department.Select(x => x.ToDelimitedString())) : null,
                                ValidPatientClasses != null ? string.Join(Configuration.FieldRepeatSeparator, ValidPatientClasses.Select(x => x.ToDelimitedString())) : null,
                                Price != null ? string.Join(Configuration.FieldRepeatSeparator, Price.Select(x => x.ToDelimitedString())) : null,
                                Formula != null ? string.Join(Configuration.FieldRepeatSeparator, Formula) : null,
                                MinimumQuantity.HasValue ? MinimumQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                MaximumQuantity.HasValue ? MaximumQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                MinimumPrice?.ToDelimitedString(),
                                MaximumPrice?.ToDelimitedString(),
                                EffectiveStartDate.HasValue ? EffectiveStartDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EffectiveEndDate.HasValue ? EffectiveEndDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PriceOverrideFlag?.ToDelimitedString(),
                                BillingCategory != null ? string.Join(Configuration.FieldRepeatSeparator, BillingCategory.Select(x => x.ToDelimitedString())) : null,
                                ChargeableFlag,
                                ActiveInactiveFlag,
                                Cost?.ToDelimitedString(),
                                ChargeOnIndicator?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}