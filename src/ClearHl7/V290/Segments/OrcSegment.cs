﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
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
        /// <para>Suggested: 0119 Order Control Codes -&gt; ClearHl7.Codes.V290.CodeOrderControlCodes</para>
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
        public EntityIdentifierPair PlacerGroupNumber { get; set; }

        /// <summary>
        /// ORC.5 - Order Status.
        /// <para>Suggested: 0038 Order Status -&gt; ClearHl7.Codes.V290.CodeOrderStatus</para>
        /// </summary>
        public string OrderStatus { get; set; }

        /// <summary>
        /// ORC.6 - Response Flag.
        /// <para>Suggested: 0121 Response Flag -&gt; ClearHl7.Codes.V290.CodeResponseFlag</para>
        /// </summary>
        public string ResponseFlag { get; set; }

        /// <summary>
        /// ORC.7 - Quantity/Timing.
        /// </summary>
        public IEnumerable<string> QuantityTiming { get; set; }

        /// <summary>
        /// ORC.8 - Parent Order.
        /// </summary>
        public IEnumerable<EntityIdentifierPair> ParentOrder { get; set; }

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
        /// <para>Suggested: 0949 Order Control Code Reason</para>
        /// </summary>
        public CodedWithExceptions OrderControlCodeReason { get; set; }

        /// <summary>
        /// ORC.17 - Entering Organization.
        /// <para>Suggested: 0666 Entering Organization</para>
        /// </summary>
        public CodedWithExceptions EnteringOrganization { get; set; }

        /// <summary>
        /// ORC.18 - Entering Device.
        /// <para>Suggested: 0668 Entering Device</para>
        /// </summary>
        public CodedWithExceptions EnteringDevice { get; set; }

        /// <summary>
        /// ORC.19 - Action By.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> ActionBy { get; set; }

        /// <summary>
        /// ORC.20 - Advanced Beneficiary Notice Code.
        /// <para>Suggested: 0339 Advanced Beneficiary Notice Code -&gt; ClearHl7.Codes.V290.CodeAdvancedBeneficiaryNoticeCode</para>
        /// </summary>
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
        /// <para>Suggested: 0950 Order Status Modifier</para>
        /// </summary>
        public CodedWithExceptions OrderStatusModifier { get; set; }

        /// <summary>
        /// ORC.26 - Advanced Beneficiary Notice Override Reason.
        /// <para>Suggested: 0552 Advanced Beneficiary Notice Override Reason</para>
        /// </summary>
        public CodedWithExceptions AdvancedBeneficiaryNoticeOverrideReason { get; set; }

        /// <summary>
        /// ORC.27 - Filler's Expected Availability Date/Time.
        /// </summary>
        public DateTime? FillersExpectedAvailabilityDateTime { get; set; }

        /// <summary>
        /// ORC.28 - Confidentiality Code.
        /// <para>Suggested: 0177 Confidentiality Code -&gt; ClearHl7.Codes.V290.CodeConfidentialityCode</para>
        /// </summary>
        public CodedWithExceptions ConfidentialityCode { get; set; }

        /// <summary>
        /// ORC.29 - Order Type.
        /// <para>Suggested: 0482 Order Type -&gt; ClearHl7.Codes.V290.CodeOrderType</para>
        /// </summary>
        public CodedWithExceptions OrderType { get; set; }

        /// <summary>
        /// ORC.30 - Enterer Authorization Mode.
        /// <para>Suggested: 0483 Authorization Mode -&gt; ClearHl7.Codes.V290.CodeAuthorizationMode</para>
        /// </summary>
        public CodedWithNoExceptions EntererAuthorizationMode { get; set; }

        /// <summary>
        /// ORC.31 - Parent Universal Service Identifier.
        /// </summary>
        public CodedWithExceptions ParentUniversalServiceIdentifier { get; set; }

        /// <summary>
        /// ORC.32 - Advanced Beneficiary Notice Date.
        /// </summary>
        public DateTime? AdvancedBeneficiaryNoticeDate { get; set; }

        /// <summary>
        /// ORC.33 - Alternate Placer Order Number.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> AlternatePlacerOrderNumber { get; set; }

        /// <summary>
        /// ORC.34 - Order Workflow Profile.
        /// <para>Suggested: 0934 Order Workflow Profile</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> OrderWorkflowProfile { get; set; }

        /// <summary>
        /// ORC.35 - Action Code.
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// ORC.36 - Order Status Date Range.
        /// </summary>
        public DateTimeRange OrderStatusDateRange { get; set; }

        /// <summary>
        /// ORC.37 - Order Creation Date/Time.
        /// </summary>
        public DateTime? OrderCreationDateTime { get; set; }

        /// <summary>
        /// ORC.38 - Filler Order Group Number.
        /// </summary>
        public EntityIdentifier FillerOrderGroupNumber { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public OrcSegment FromDelimitedString(string delimitedString)
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
            PlacerOrderNumber = segments.Length > 2 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(2)) : null;
            FillerOrderNumber = segments.Length > 3 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(3)) : null;
            PlacerGroupNumber = segments.Length > 4 ? new EntityIdentifierPair().FromDelimitedString(segments.ElementAtOrDefault(4)) : null;
            OrderStatus = segments.ElementAtOrDefault(5);
            ResponseFlag = segments.ElementAtOrDefault(6);
            QuantityTiming = segments.Length > 7 ? segments.ElementAtOrDefault(7).Split(separator) : null;
            ParentOrder = segments.Length > 8 ? segments.ElementAtOrDefault(8).Split(separator).Select(x => new EntityIdentifierPair().FromDelimitedString(x)) : null;
            DateTimeOfTransaction = segments.ElementAtOrDefault(9)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            EnteredBy = segments.Length > 10 ? segments.ElementAtOrDefault(10).Split(separator).Select(x => new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(x)) : null;
            VerifiedBy = segments.Length > 11 ? segments.ElementAtOrDefault(11).Split(separator).Select(x => new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(x)) : null;
            OrderingProvider = segments.Length > 12 ? segments.ElementAtOrDefault(12).Split(separator).Select(x => new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(x)) : null;
            EnterersLocation = segments.Length > 13 ? new PersonLocation().FromDelimitedString(segments.ElementAtOrDefault(13)) : null;
            CallBackPhoneNumber = segments.Length > 14 ? segments.ElementAtOrDefault(14).Split(separator).Select(x => new ExtendedTelecommunicationNumber().FromDelimitedString(x)) : null;
            OrderEffectiveDateTime = segments.ElementAtOrDefault(15)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            OrderControlCodeReason = segments.Length > 16 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(16)) : null;
            EnteringOrganization = segments.Length > 17 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(17)) : null;
            EnteringDevice = segments.Length > 18 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(18)) : null;
            ActionBy = segments.Length > 19 ? segments.ElementAtOrDefault(19).Split(separator).Select(x => new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(x)) : null;
            AdvancedBeneficiaryNoticeCode = segments.Length > 20 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(20)) : null;
            OrderingFacilityName = segments.Length > 21 ? segments.ElementAtOrDefault(21).Split(separator).Select(x => new ExtendedCompositeNameAndIdNumberForOrganizations().FromDelimitedString(x)) : null;
            OrderingFacilityAddress = segments.Length > 22 ? segments.ElementAtOrDefault(22).Split(separator).Select(x => new ExtendedAddress().FromDelimitedString(x)) : null;
            OrderingFacilityPhoneNumber = segments.Length > 23 ? segments.ElementAtOrDefault(23).Split(separator).Select(x => new ExtendedTelecommunicationNumber().FromDelimitedString(x)) : null;
            OrderingProviderAddress = segments.Length > 24 ? segments.ElementAtOrDefault(24).Split(separator).Select(x => new ExtendedAddress().FromDelimitedString(x)) : null;
            OrderStatusModifier = segments.Length > 25 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(25)) : null;
            AdvancedBeneficiaryNoticeOverrideReason = segments.Length > 26 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(26)) : null;
            FillersExpectedAvailabilityDateTime = segments.ElementAtOrDefault(27)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ConfidentialityCode = segments.Length > 28 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(28)) : null;
            OrderType = segments.Length > 29 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(29)) : null;
            EntererAuthorizationMode = segments.Length > 30 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(30)) : null;
            ParentUniversalServiceIdentifier = segments.Length > 31 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(31)) : null;
            AdvancedBeneficiaryNoticeDate = segments.ElementAtOrDefault(32)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            AlternatePlacerOrderNumber = segments.Length > 33 ? segments.ElementAtOrDefault(33).Split(separator).Select(x => new ExtendedCompositeIdWithCheckDigit().FromDelimitedString(x)) : null;
            OrderWorkflowProfile = segments.Length > 34 ? segments.ElementAtOrDefault(34).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            ActionCode = segments.ElementAtOrDefault(35);
            OrderStatusDateRange = segments.Length > 36 ? new DateTimeRange().FromDelimitedString(segments.ElementAtOrDefault(36)) : null;
            OrderCreationDateTime = segments.ElementAtOrDefault(37)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            FillerOrderGroupNumber = segments.Length > 38 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(38)) : null;
            
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
                                StringHelper.StringFormatSequence(0, 39, Configuration.FieldSeparator),
                                Id,
                                OrderControl,
                                PlacerOrderNumber?.ToDelimitedString(),
                                FillerOrderNumber?.ToDelimitedString(),
                                PlacerGroupNumber?.ToDelimitedString(),
                                OrderStatus,
                                ResponseFlag,
                                QuantityTiming != null ? string.Join(Configuration.FieldRepeatSeparator, QuantityTiming) : null,
                                ParentOrder != null ? string.Join(Configuration.FieldRepeatSeparator, ParentOrder.Select(x => x.ToDelimitedString())) : null,
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
                                ParentUniversalServiceIdentifier?.ToDelimitedString(),
                                AdvancedBeneficiaryNoticeDate.HasValue ? AdvancedBeneficiaryNoticeDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                AlternatePlacerOrderNumber != null ? string.Join(Configuration.FieldRepeatSeparator, AlternatePlacerOrderNumber.Select(x => x.ToDelimitedString())) : null,
                                OrderWorkflowProfile != null ? string.Join(Configuration.FieldRepeatSeparator, OrderWorkflowProfile.Select(x => x.ToDelimitedString())) : null,
                                ActionCode,
                                OrderStatusDateRange?.ToDelimitedString(),
                                OrderCreationDateTime.HasValue ? OrderCreationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                FillerOrderGroupNumber?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
