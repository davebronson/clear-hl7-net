using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
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
        /// <para>Suggested: 0119 Order Control Codes -&gt; ClearHl7.Codes.V230.CodeOrderControlCodes</para>
        /// </summary>
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
        /// <para>Suggested: 0038 Order Status -&gt; ClearHl7.Codes.V230.CodeOrderStatus</para>
        /// </summary>
        public string OrderStatus { get; set; }

        /// <summary>
        /// ORC.6 - Response Flag.
        /// <para>Suggested: 0121 Response Flag -&gt; ClearHl7.Codes.V230.CodeResponseFlag</para>
        /// </summary>
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

            OrderControl = segments.ElementAtOrDefault(1);
            PlacerOrderNumber = segments.Length > 2 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(2), false) : null;
            FillerOrderNumber = segments.Length > 3 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(3), false) : null;
            PlacerGroupNumber = segments.Length > 4 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(4), false) : null;
            OrderStatus = segments.ElementAtOrDefault(5);
            ResponseFlag = segments.ElementAtOrDefault(6);
            QuantityTiming = segments.Length > 7 ? TypeHelper.Deserialize<TimingQuantity>(segments.ElementAtOrDefault(7), false) : null;
            ParentOrder = segments.Length > 8 ? TypeHelper.Deserialize<ParentOrder>(segments.ElementAtOrDefault(8), false) : null;
            DateTimeOfTransaction = segments.ElementAtOrDefault(9)?.ToNullableDateTime();
            EnteredBy = segments.Length > 10 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(10), false) : null;
            VerifiedBy = segments.Length > 11 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(11), false) : null;
            OrderingProvider = segments.Length > 12 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(12), false) : null;
            EnterersLocation = segments.Length > 13 ? TypeHelper.Deserialize<PersonLocation>(segments.ElementAtOrDefault(13), false) : null;
            CallBackPhoneNumber = segments.Length > 14 ? segments.ElementAtOrDefault(14).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            OrderEffectiveDateTime = segments.ElementAtOrDefault(15)?.ToNullableDateTime();
            OrderControlCodeReason = segments.Length > 16 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(16), false) : null;
            EnteringOrganization = segments.Length > 17 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(17), false) : null;
            EnteringDevice = segments.Length > 18 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(18), false) : null;
            ActionBy = segments.Length > 19 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(19), false) : null;
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
                                StringHelper.StringFormatSequence(0, 20, Configuration.FieldSeparator),
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
                                CallBackPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, CallBackPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                OrderEffectiveDateTime.HasValue ? OrderEffectiveDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                OrderControlCodeReason?.ToDelimitedString(),
                                EnteringOrganization?.ToDelimitedString(),
                                EnteringDevice?.ToDelimitedString(),
                                ActionBy?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}