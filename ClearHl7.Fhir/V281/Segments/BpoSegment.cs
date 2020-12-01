using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V281.Types;

namespace ClearHl7.Fhir.V281.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0508</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0509</remarks>
        public IEnumerable<CodedWithExceptions> BpIndicationForUse { get; set; }

        /// <summary>
        /// BPO.14 - BP Informed Consent Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string BpInformedConsentIndicator { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}