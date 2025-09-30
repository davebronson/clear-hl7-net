using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PRC - Pricing.
    /// </summary>
    public class PrcSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrcSegment"/> class.
        /// </summary>
        public PrcSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrcSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public PrcSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "PRC";

        /// <inheritdoc/>
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
        /// <para>Suggested: 0004 Patient Class -&gt; ClearHl7.Codes.V271.CodePatientClass</para>
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
        /// <para>Suggested: 0268 Override -&gt; ClearHl7.Codes.V271.CodeOverride</para>
        /// </summary>
        public CodedWithExceptions PriceOverrideFlag { get; set; }

        /// <summary>
        /// PRC.14 - Billing Category.
        /// <para>Suggested: 0293 Billing Category</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> BillingCategory { get; set; }

        /// <summary>
        /// PRC.15 - Chargeable Flag.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V271.CodeYesNoIndicator</para>
        /// </summary>
        public string ChargeableFlag { get; set; }

        /// <summary>
        /// PRC.16 - Active/Inactive Flag.
        /// <para>Suggested: 0183 Active/Inactive -&gt; ClearHl7.Codes.V271.CodeActiveInactive</para>
        /// </summary>
        public string ActiveInactiveFlag { get; set; }

        /// <summary>
        /// PRC.17 - Cost.
        /// </summary>
        public Money Cost { get; set; }

        /// <summary>
        /// PRC.18 - Charge on Indicator.
        /// <para>Suggested: 0269 Charge On Indicator -&gt; ClearHl7.Codes.V271.CodeChargeOnIndicator</para>
        /// </summary>
        public CodedWithExceptions ChargeOnIndicator { get; set; }

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

            PrimaryKeyValuePrc = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], false, seps) : null;
            FacilityIdPrc = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            Department = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            ValidPatientClasses = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            Price = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CompositePrice>(x, false, seps)) : null;
            Formula = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            MinimumQuantity = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDecimal() : null;
            MaximumQuantity = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDecimal() : null;
            MinimumPrice = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<Money>(segments[9], false, seps) : null;
            MaximumPrice = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<Money>(segments[10], false, seps) : null;
            EffectiveStartDate = segments.Length > 11 && segments[11].Length > 0 ? segments[11].ToNullableDateTime() : null;
            EffectiveEndDate = segments.Length > 12 && segments[12].Length > 0 ? segments[12].ToNullableDateTime() : null;
            PriceOverrideFlag = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[13], false, seps) : null;
            BillingCategory = segments.Length > 14 && segments[14].Length > 0 ? segments[14].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            ChargeableFlag = segments.Length > 15 && segments[15].Length > 0 ? segments[15] : null;
            ActiveInactiveFlag = segments.Length > 16 && segments[16].Length > 0 ? segments[16] : null;
            Cost = segments.Length > 17 && segments[17].Length > 0 ? TypeSerializer.Deserialize<Money>(segments[17], false, seps) : null;
            ChargeOnIndicator = segments.Length > 18 && segments[18].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[18], false, seps) : null;
        }

        /// <inheritdoc/>
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
                                EffectiveStartDate?.ToHl7DateTimeString(typeof(PrcSegment), nameof(EffectiveStartDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                EffectiveEndDate?.ToHl7DateTimeString(typeof(PrcSegment), nameof(EffectiveEndDate), Consts.DateTimeFormatPrecisionSecond, culture),
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
