using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V230.Types;

namespace ClearHl7.Fhir.V230.Segments
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
        public EntityIdentifier PlacerGroupNumber { get; set; }

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
        public TimingQuantity QuantityTiming { get; set; }

        /// <summary>
        /// ORC.8 - Parent Order.
        /// </summary>
        public ParentOrder ParentOrder { get; set; }

        /// <summary>
        /// ORC.9 - Date/Time of Transaction.
        /// </summary>
        public DateTime? DateTimeOfTransaction { get; set; }

        /// <summary>
        /// ORC.10 - Entered By.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons EnteredBy { get; set; }

        /// <summary>
        /// ORC.11 - Verified By.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons VerifiedBy { get; set; }

        /// <summary>
        /// ORC.12 - Ordering Provider.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons OrderingProvider { get; set; }

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
        public CodedElement OrderControlCodeReason { get; set; }

        /// <summary>
        /// ORC.17 - Entering Organization.
        /// </summary>
        public CodedElement EnteringOrganization { get; set; }

        /// <summary>
        /// ORC.18 - Entering Device.
        /// </summary>
        public CodedElement EnteringDevice { get; set; }

        /// <summary>
        /// ORC.19 - Action By.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons ActionBy { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}",
                                Id,
                                OrderControl,
                                PlacerOrderNumber?.ToDelimitedString(),
                                FillerOrderNumber?.ToDelimitedString(),
                                PlacerGroupNumber?.ToDelimitedString(),
                                OrderStatus,
                                ResponseFlag,
                                QuantityTiming?.ToDelimitedString(),
                                ParentOrder?.ToDelimitedString(),
                                DateTimeOfTransaction.HasValue ? DateTimeOfTransaction.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EnteredBy?.ToDelimitedString(),
                                VerifiedBy?.ToDelimitedString(),
                                OrderingProvider?.ToDelimitedString(),
                                EnterersLocation?.ToDelimitedString(),
                                CallBackPhoneNumber != null ? string.Join("~", CallBackPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                OrderEffectiveDateTime.HasValue ? OrderEffectiveDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                OrderControlCodeReason?.ToDelimitedString(),
                                EnteringOrganization?.ToDelimitedString(),
                                EnteringDevice?.ToDelimitedString(),
                                ActionBy?.ToDelimitedString()
                                ).TrimEnd('|');
        }
    }
}