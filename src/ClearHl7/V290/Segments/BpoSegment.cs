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
        /// <para>Suggested: 0575 BP Universal Service Identifier</para>
        /// </summary>
        public CodedWithExceptions BpUniversalServiceIdentifier { get; set; }

        /// <summary>
        /// BPO.3 - BP Processing Requirements.
        /// <para>Suggested: 0508 Blood Product Processing Requirements -&gt; ClearHl7.Codes.V290.CodeBloodProductProcessingRequirements</para>
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
        /// <para>Suggested: 0576 BP Units</para>
        /// </summary>
        public CodedWithExceptions BpUnits { get; set; }

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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string BpInformedConsentIndicator { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public BpoSegment FromDelimitedString(string delimitedString)
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

            SetIdBpo = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            BpUniversalServiceIdentifier = segments.Length > 2 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(2)) : null;
            BpProcessingRequirements = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            BpQuantity = segments.ElementAtOrDefault(4)?.ToNullableDecimal();
            BpAmount = segments.ElementAtOrDefault(5)?.ToNullableDecimal();
            BpUnits = segments.Length > 6 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(6)) : null;
            BpIntendedUseDateTime = segments.ElementAtOrDefault(7)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            BpIntendedDispenseFromLocation = segments.Length > 8 ? new PersonLocation().FromDelimitedString(segments.ElementAtOrDefault(8)) : null;
            BpIntendedDispenseFromAddress = segments.Length > 9 ? new ExtendedAddress().FromDelimitedString(segments.ElementAtOrDefault(9)) : null;
            BpRequestedDispenseDateTime = segments.ElementAtOrDefault(10)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            BpRequestedDispenseToLocation = segments.Length > 11 ? new PersonLocation().FromDelimitedString(segments.ElementAtOrDefault(11)) : null;
            BpRequestedDispenseToAddress = segments.Length > 12 ? new ExtendedAddress().FromDelimitedString(segments.ElementAtOrDefault(12)) : null;
            BpIndicationForUse = segments.Length > 13 ? segments.ElementAtOrDefault(13).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            BpInformedConsentIndicator = segments.ElementAtOrDefault(14);

            return this;
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