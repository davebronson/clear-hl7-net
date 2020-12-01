using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V260.Types;

namespace ClearHl7.Fhir.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ORC - Common Order.
    /// </summary>
    public class OrcSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ORC";

        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ORC.1 - Order Control.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0119</remarks>
        public string OrderControl { get; set; }

        /// <summary>
        /// ORC.2 - Placer Order Number.
        /// </summary>
        public EntityIdentifier PlacerOrderNumber { get; set; }

        /// <summary>
        /// ORC.3 - Filler Order Number.
        /// </summary>
        public EntityIdentifier FillerOrderNumber { get; set; }

        /// <summary>
        /// ORC.4 - Placer Group Number.
        /// </summary>
        public EntityIdentifierPair PlacerGroupNumber { get; set; }

        /// <summary>
        /// ORC.5 - Order Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0038</remarks>
        public string OrderStatus { get; set; }

        /// <summary>
        /// ORC.6 - Response Flag.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0121</remarks>
        public string ResponseFlag { get; set; }

        /// <summary>
        /// ORC.7 - Quantity/Timing.
        /// </summary>
        public IEnumerable<TimingQuantity> QuantityTiming { get; set; }

        /// <summary>
        /// ORC.8 - Parent Order.
        /// </summary>
        public EntityIdentifierPair ParentOrder { get; set; }

        /// <summary>
        /// ORC.9 - Date/Time of Transaction.
        /// </summary>
        public DateTime? DateTimeOfTransaction { get; set; }

        /// <summary>
        /// ORC.10 - Entered By.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> EnteredBy { get; set; }

        /// <summary>
        /// ORC.11 - Verified By.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> VerifiedBy { get; set; }

        /// <summary>
        /// ORC.12 - Ordering Provider.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> OrderingProvider { get; set; }

        /// <summary>
        /// ORC.13 - Enterer's Location.
        /// </summary>
        public PersonLocation EnterersLocation { get; set; }

        /// <summary>
        /// ORC.14 - Call Back Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> CallBackPhoneNumber { get; set; }

        /// <summary>
        /// ORC.15 - Order Effective Date/Time.
        /// </summary>
        public DateTime? OrderEffectiveDateTime { get; set; }

        /// <summary>
        /// ORC.16 - Order Control Code Reason.
        /// </summary>
        public CodedWithExceptions OrderControlCodeReason { get; set; }

        /// <summary>
        /// ORC.17 - Entering Organization.
        /// </summary>
        public CodedWithExceptions EnteringOrganization { get; set; }

        /// <summary>
        /// ORC.18 - Entering Device.
        /// </summary>
        public CodedWithExceptions EnteringDevice { get; set; }

        /// <summary>
        /// ORC.19 - Action By.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> ActionBy { get; set; }

        /// <summary>
        /// ORC.20 - Advanced Beneficiary Notice Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0339</remarks>
        public CodedWithExceptions AdvancedBeneficiaryNoticeCode { get; set; }

        /// <summary>
        /// ORC.21 - Ordering Facility Name.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> OrderingFacilityName { get; set; }

        /// <summary>
        /// ORC.22 - Ordering Facility Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> OrderingFacilityAddress { get; set; }

        /// <summary>
        /// ORC.23 - Ordering Facility Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> OrderingFacilityPhoneNumber { get; set; }

        /// <summary>
        /// ORC.24 - Ordering Provider Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> OrderingProviderAddress { get; set; }

        /// <summary>
        /// ORC.25 - Order Status Modifier.
        /// </summary>
        public CodedWithExceptions OrderStatusModifier { get; set; }

        /// <summary>
        /// ORC.26 - Advanced Beneficiary Notice Override Reason.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0552</remarks>
        public CodedWithExceptions AdvancedBeneficiaryNoticeOverrideReason { get; set; }

        /// <summary>
        /// ORC.27 - Filler's Expected Availability Date/Time.
        /// </summary>
        public DateTime? FillersExpectedAvailabilityDateTime { get; set; }

        /// <summary>
        /// ORC.28 - Confidentiality Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0177</remarks>
        public CodedWithExceptions ConfidentialityCode { get; set; }

        /// <summary>
        /// ORC.29 - Order Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0482</remarks>
        public CodedWithExceptions OrderType { get; set; }

        /// <summary>
        /// ORC.30 - Enterer Authorization Mode.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0483</remarks>
        public CodedWithNoExceptions EntererAuthorizationMode { get; set; }

        /// <summary>
        /// ORC.31 - Parent Universal Service Identifier.
        /// </summary>
        public CodedWithExceptions ParentUniversalServiceIdentifier { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 32, Configuration.FieldSeparator),
                                Id,
                                OrderControl,
                                PlacerOrderNumber?.ToDelimitedString(),
                                FillerOrderNumber?.ToDelimitedString(),
                                PlacerGroupNumber?.ToDelimitedString(),
                                OrderStatus,
                                ResponseFlag,
                                QuantityTiming != null ? string.Join(Configuration.FieldRepeatSeparator, QuantityTiming.Select(x => x.ToDelimitedString())) : null,
                                ParentOrder?.ToDelimitedString(),
                                DateTimeOfTransaction.HasValue ? DateTimeOfTransaction.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EnteredBy != null ? string.Join(Configuration.FieldRepeatSeparator, EnteredBy.Select(x => x.ToDelimitedString())) : null,
                                VerifiedBy != null ? string.Join(Configuration.FieldRepeatSeparator, VerifiedBy.Select(x => x.ToDelimitedString())) : null,
                                OrderingProvider != null ? string.Join(Configuration.FieldRepeatSeparator, OrderingProvider.Select(x => x.ToDelimitedString())) : null,
                                EnterersLocation?.ToDelimitedString(),
                                CallBackPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, CallBackPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                OrderEffectiveDateTime.HasValue ? OrderEffectiveDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                OrderControlCodeReason?.ToDelimitedString(),
                                EnteringOrganization?.ToDelimitedString(),
                                EnteringDevice?.ToDelimitedString(),
                                ActionBy != null ? string.Join(Configuration.FieldRepeatSeparator, ActionBy.Select(x => x.ToDelimitedString())) : null,
                                AdvancedBeneficiaryNoticeCode?.ToDelimitedString(),
                                OrderingFacilityName != null ? string.Join(Configuration.FieldRepeatSeparator, OrderingFacilityName.Select(x => x.ToDelimitedString())) : null,
                                OrderingFacilityAddress != null ? string.Join(Configuration.FieldRepeatSeparator, OrderingFacilityAddress.Select(x => x.ToDelimitedString())) : null,
                                OrderingFacilityPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, OrderingFacilityPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                OrderingProviderAddress != null ? string.Join(Configuration.FieldRepeatSeparator, OrderingProviderAddress.Select(x => x.ToDelimitedString())) : null,
                                OrderStatusModifier?.ToDelimitedString(),
                                AdvancedBeneficiaryNoticeOverrideReason?.ToDelimitedString(),
                                FillersExpectedAvailabilityDateTime.HasValue ? FillersExpectedAvailabilityDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ConfidentialityCode?.ToDelimitedString(),
                                OrderType?.ToDelimitedString(),
                                EntererAuthorizationMode?.ToDelimitedString(),
                                ParentUniversalServiceIdentifier?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
