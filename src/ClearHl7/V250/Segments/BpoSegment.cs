using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment BPO - Blood Product Order.
    /// </summary>
    public class BpoSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "BPO";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// BPO.1 - Set ID - BPO.
        /// </summary>
        public uint? SetIdBpo { get; set; }

        /// <summary>
        /// BPO.2 - BP Universal Service Identifier.
        /// </summary>
        public CodedWithExceptions BpUniversalServiceIdentifier { get; set; }

        /// <summary>
        /// BPO.3 - BP Processing Requirements.
        /// <para>Suggested: 0508 Blood Product Processing Requirements -&gt; ClearHl7.Codes.V250.CodeBloodProductProcessingRequirements</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> BpProcessingRequirements { get; set; }

        /// <summary>
        /// BPO.4 - BP Quantity.
        /// </summary>
        public decimal? BpQuantity { get; set; }

        /// <summary>
        /// BPO.5 - BP Amount.
        /// </summary>
        public decimal? BpAmount { get; set; }

        /// <summary>
        /// BPO.6 - BP Units.
        /// </summary>
        public CodedElement BpUnits { get; set; }

        /// <summary>
        /// BPO.7 - BP Intended Use Date/Time.
        /// </summary>
        public DateTime? BpIntendedUseDateTime { get; set; }

        /// <summary>
        /// BPO.8 - BP Intended Dispense From Location.
        /// </summary>
        public PersonLocation BpIntendedDispenseFromLocation { get; set; }

        /// <summary>
        /// BPO.9 - BP Intended Dispense From Address.
        /// </summary>
        public ExtendedAddress BpIntendedDispenseFromAddress { get; set; }

        /// <summary>
        /// BPO.10 - BP Requested Dispense Date/Time.
        /// </summary>
        public DateTime? BpRequestedDispenseDateTime { get; set; }

        /// <summary>
        /// BPO.11 - BP Requested Dispense To Location.
        /// </summary>
        public PersonLocation BpRequestedDispenseToLocation { get; set; }

        /// <summary>
        /// BPO.12 - BP Requested Dispense To Address.
        /// </summary>
        public ExtendedAddress BpRequestedDispenseToAddress { get; set; }

        /// <summary>
        /// BPO.13 - BP Indication for Use.
        /// <para>Suggested: 0509 Indication for Use</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> BpIndicationForUse { get; set; }

        /// <summary>
        /// BPO.14 - BP Informed Consent Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V250.CodeYesNoIndicator</para>
        /// </summary>
        public string BpInformedConsentIndicator { get; set; }

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

            SetIdBpo = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            BpUniversalServiceIdentifier = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[2], false) : null;
            BpProcessingRequirements = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            BpQuantity = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDecimal() : null;
            BpAmount = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDecimal() : null;
            BpUnits = segments.Length > 6 && segments[6].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[6], false) : null;
            BpIntendedUseDateTime = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            BpIntendedDispenseFromLocation = segments.Length > 8 && segments[8].Length > 0 ? TypeHelper.Deserialize<PersonLocation>(segments[8], false) : null;
            BpIntendedDispenseFromAddress = segments.Length > 9 && segments[9].Length > 0 ? TypeHelper.Deserialize<ExtendedAddress>(segments[9], false) : null;
            BpRequestedDispenseDateTime = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDateTime() : null;
            BpRequestedDispenseToLocation = segments.Length > 11 && segments[11].Length > 0 ? TypeHelper.Deserialize<PersonLocation>(segments[11], false) : null;
            BpRequestedDispenseToAddress = segments.Length > 12 && segments[12].Length > 0 ? TypeHelper.Deserialize<ExtendedAddress>(segments[12], false) : null;
            BpIndicationForUse = segments.Length > 13 && segments[13].Length > 0 ? segments[13].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            BpInformedConsentIndicator = segments.Length > 14 && segments[14].Length > 0 ? segments[14] : null;
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
                                StringHelper.StringFormatSequence(0, 15, Configuration.FieldSeparator),
                                Id,
                                SetIdBpo.HasValue ? SetIdBpo.Value.ToString(culture) : null,
                                BpUniversalServiceIdentifier?.ToDelimitedString(),
                                BpProcessingRequirements != null ? string.Join(Configuration.FieldRepeatSeparator, BpProcessingRequirements.Select(x => x.ToDelimitedString())) : null,
                                BpQuantity.HasValue ? BpQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                BpAmount.HasValue ? BpAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                BpUnits?.ToDelimitedString(),
                                BpIntendedUseDateTime.HasValue ? BpIntendedUseDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                BpIntendedDispenseFromLocation?.ToDelimitedString(),
                                BpIntendedDispenseFromAddress?.ToDelimitedString(),
                                BpRequestedDispenseDateTime.HasValue ? BpRequestedDispenseDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                BpRequestedDispenseToLocation?.ToDelimitedString(),
                                BpRequestedDispenseToAddress?.ToDelimitedString(),
                                BpIndicationForUse != null ? string.Join(Configuration.FieldRepeatSeparator, BpIndicationForUse.Select(x => x.ToDelimitedString())) : null,
                                BpInformedConsentIndicator
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}