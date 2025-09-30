using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ORC - Common Order.
    /// </summary>
    public class OrcSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrcSegment"/> class.
        /// </summary>
        public OrcSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrcSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public OrcSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "ORC";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// ORC.1 - Order Control.
        /// <para>Suggested: 0119 Order Control Codes -&gt; ClearHl7.Codes.V240.CodeOrderControlCodes</para>
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
        /// <para>Suggested: 0038 Order Status -&gt; ClearHl7.Codes.V240.CodeOrderStatus</para>
        /// </summary>
        public string OrderStatus { get; set; }

        /// <summary>
        /// ORC.6 - Response Flag.
        /// <para>Suggested: 0121 Response Flag -&gt; ClearHl7.Codes.V240.CodeResponseFlag</para>
        /// </summary>
        public string ResponseFlag { get; set; }

        /// <summary>
        /// ORC.7 - Quantity/Timing.
        /// </summary>
        public IEnumerable<TimingQuantity> QuantityTiming { get; set; }

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
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> ActionBy { get; set; }

        /// <summary>
        /// ORC.20 - Advanced Beneficiary Notice Code.
        /// <para>Suggested: 0339 Advanced Beneficiary Notice Code -&gt; ClearHl7.Codes.V240.CodeAdvancedBeneficiaryNoticeCode</para>
        /// </summary>
        public CodedElement AdvancedBeneficiaryNoticeCode { get; set; }

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

            OrderControl = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            PlacerOrderNumber = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[2], false, seps) : null;
            FillerOrderNumber = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[3], false, seps) : null;
            PlacerGroupNumber = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[4], false, seps) : null;
            OrderStatus = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            ResponseFlag = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            QuantityTiming = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<TimingQuantity>(x, false, seps)) : null;
            ParentOrder = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<ParentOrder>(segments[8], false, seps) : null;
            DateTimeOfTransaction = segments.Length > 9 && segments[9].Length > 0 ? segments[9].ToNullableDateTime() : null;
            EnteredBy = segments.Length > 10 && segments[10].Length > 0 ? segments[10].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            VerifiedBy = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            OrderingProvider = segments.Length > 12 && segments[12].Length > 0 ? segments[12].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            EnterersLocation = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<PersonLocation>(segments[13], false, seps) : null;
            CallBackPhoneNumber = segments.Length > 14 && segments[14].Length > 0 ? segments[14].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
            OrderEffectiveDateTime = segments.Length > 15 && segments[15].Length > 0 ? segments[15].ToNullableDateTime() : null;
            OrderControlCodeReason = segments.Length > 16 && segments[16].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[16], false, seps) : null;
            EnteringOrganization = segments.Length > 17 && segments[17].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[17], false, seps) : null;
            EnteringDevice = segments.Length > 18 && segments[18].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[18], false, seps) : null;
            ActionBy = segments.Length > 19 && segments[19].Length > 0 ? segments[19].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            AdvancedBeneficiaryNoticeCode = segments.Length > 20 && segments[20].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[20], false, seps) : null;
            OrderingFacilityName = segments.Length > 21 && segments[21].Length > 0 ? segments[21].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false, seps)) : null;
            OrderingFacilityAddress = segments.Length > 22 && segments[22].Length > 0 ? segments[22].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedAddress>(x, false, seps)) : null;
            OrderingFacilityPhoneNumber = segments.Length > 23 && segments[23].Length > 0 ? segments[23].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
            OrderingProviderAddress = segments.Length > 24 && segments[24].Length > 0 ? segments[24].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedAddress>(x, false, seps)) : null;
            OrderStatusModifier = segments.Length > 25 && segments[25].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[25], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 26, Configuration.FieldSeparator),
                                Id,
                                OrderControl,
                                PlacerOrderNumber?.ToDelimitedString(),
                                FillerOrderNumber?.ToDelimitedString(),
                                PlacerGroupNumber?.ToDelimitedString(),
                                OrderStatus,
                                ResponseFlag,
                                QuantityTiming != null ? string.Join(Configuration.FieldRepeatSeparator, QuantityTiming.Select(x => x.ToDelimitedString())) : null,
                                ParentOrder?.ToDelimitedString(),
                                DateTimeOfTransaction?.ToHl7DateTimeString(typeof(OrcSegment), nameof(DateTimeOfTransaction), Consts.DateTimeFormatPrecisionSecond, culture),
                                EnteredBy != null ? string.Join(Configuration.FieldRepeatSeparator, EnteredBy.Select(x => x.ToDelimitedString())) : null,
                                VerifiedBy != null ? string.Join(Configuration.FieldRepeatSeparator, VerifiedBy.Select(x => x.ToDelimitedString())) : null,
                                OrderingProvider != null ? string.Join(Configuration.FieldRepeatSeparator, OrderingProvider.Select(x => x.ToDelimitedString())) : null,
                                EnterersLocation?.ToDelimitedString(),
                                CallBackPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, CallBackPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                OrderEffectiveDateTime?.ToHl7DateTimeString(typeof(OrcSegment), nameof(OrderEffectiveDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                OrderControlCodeReason?.ToDelimitedString(),
                                EnteringOrganization?.ToDelimitedString(),
                                EnteringDevice?.ToDelimitedString(),
                                ActionBy != null ? string.Join(Configuration.FieldRepeatSeparator, ActionBy.Select(x => x.ToDelimitedString())) : null,
                                AdvancedBeneficiaryNoticeCode?.ToDelimitedString(),
                                OrderingFacilityName != null ? string.Join(Configuration.FieldRepeatSeparator, OrderingFacilityName.Select(x => x.ToDelimitedString())) : null,
                                OrderingFacilityAddress != null ? string.Join(Configuration.FieldRepeatSeparator, OrderingFacilityAddress.Select(x => x.ToDelimitedString())) : null,
                                OrderingFacilityPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, OrderingFacilityPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                OrderingProviderAddress != null ? string.Join(Configuration.FieldRepeatSeparator, OrderingProviderAddress.Select(x => x.ToDelimitedString())) : null,
                                OrderStatusModifier?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
