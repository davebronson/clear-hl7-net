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
    /// HL7 Version 2 Segment BTX - Blood Product Transfusion Disposition.
    /// </summary>
    public class BtxSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "BTX";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// BTX.1 - Set ID - BTX.
        /// </summary>
        public uint? SetIdBtx { get; set; }

        /// <summary>
        /// BTX.2 - BC Donation ID.
        /// </summary>
        public EntityIdentifier BcDonationId { get; set; }

        /// <summary>
        /// BTX.3 - BC Component.
        /// </summary>
        public CodedWithNoExceptions BcComponent { get; set; }

        /// <summary>
        /// BTX.4 - BC Blood Group.
        /// </summary>
        public CodedWithNoExceptions BcBloodGroup { get; set; }

        /// <summary>
        /// BTX.5 - CP Commercial Product.
        /// <para>Suggested: 0512 Commercial Product</para>
        /// </summary>
        public CodedWithExceptions CpCommercialProduct { get; set; }

        /// <summary>
        /// BTX.6 - CP Manufacturer.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations CpManufacturer { get; set; }

        /// <summary>
        /// BTX.7 - CP Lot Number.
        /// </summary>
        public EntityIdentifier CpLotNumber { get; set; }

        /// <summary>
        /// BTX.8 - BP Quantity.
        /// </summary>
        public decimal? BpQuantity { get; set; }

        /// <summary>
        /// BTX.9 - BP Amount.
        /// </summary>
        public decimal? BpAmount { get; set; }

        /// <summary>
        /// BTX.10 - BP Units.
        /// </summary>
        public CodedWithExceptions BpUnits { get; set; }

        /// <summary>
        /// BTX.11 - BP Transfusion/Disposition Status.
        /// <para>Suggested: 0513 Blood Product Transfusion/Disposition Status -&gt; ClearHl7.Codes.V280.CodeBloodProductTransfusionDispositionStatus</para>
        /// </summary>
        public CodedWithExceptions BpTransfusionDispositionStatus { get; set; }

        /// <summary>
        /// BTX.12 - BP Message Status.
        /// <para>Suggested: 0511 BP Observation Status Codes Interpretation -&gt; ClearHl7.Codes.V280.CodeBpObservationStatusCodesInterpretation</para>
        /// </summary>
        public string BpMessageStatus { get; set; }

        /// <summary>
        /// BTX.13 - BP Date/Time of Status.
        /// </summary>
        public DateTime? BpDateTimeOfStatus { get; set; }

        /// <summary>
        /// BTX.14 - BP Transfusion Administrator.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons BpTransfusionAdministrator { get; set; }

        /// <summary>
        /// BTX.15 - BP Transfusion Verifier.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons BpTransfusionVerifier { get; set; }

        /// <summary>
        /// BTX.16 - BP Transfusion Start Date/Time of Status.
        /// </summary>
        public DateTime? BpTransfusionStartDateTimeOfStatus { get; set; }

        /// <summary>
        /// BTX.17 - BP Transfusion End Date/Time of Status.
        /// </summary>
        public DateTime? BpTransfusionEndDateTimeOfStatus { get; set; }

        /// <summary>
        /// BTX.18 - BP Adverse Reaction Type.
        /// <para>Suggested: 0514 Transfusion Adverse Reaction -&gt; ClearHl7.Codes.V280.CodeTransfusionAdverseReaction</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> BpAdverseReactionType { get; set; }

        /// <summary>
        /// BTX.19 - BP Transfusion Interrupted Reason.
        /// <para>Suggested: 0515 Transfusion Interrupted Reason</para>
        /// </summary>
        public CodedWithExceptions BpTransfusionInterruptedReason { get; set; }

        /// <summary>
        /// BTX.20 - BP Unique ID.
        /// </summary>
        public EntityIdentifier BpUniqueId { get; set; }

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

            SetIdBtx = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            BcDonationId = segments.Length > 2 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(2), false) : null;
            BcComponent = segments.Length > 3 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(3), false) : null;
            BcBloodGroup = segments.Length > 4 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(4), false) : null;
            CpCommercialProduct = segments.Length > 5 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(5), false) : null;
            CpManufacturer = segments.Length > 6 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments.ElementAtOrDefault(6), false) : null;
            CpLotNumber = segments.Length > 7 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(7), false) : null;
            BpQuantity = segments.ElementAtOrDefault(8)?.ToNullableDecimal();
            BpAmount = segments.ElementAtOrDefault(9)?.ToNullableDecimal();
            BpUnits = segments.Length > 10 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(10), false) : null;
            BpTransfusionDispositionStatus = segments.Length > 11 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(11), false) : null;
            BpMessageStatus = segments.ElementAtOrDefault(12);
            BpDateTimeOfStatus = segments.ElementAtOrDefault(13)?.ToNullableDateTime();
            BpTransfusionAdministrator = segments.Length > 14 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(14), false) : null;
            BpTransfusionVerifier = segments.Length > 15 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(15), false) : null;
            BpTransfusionStartDateTimeOfStatus = segments.ElementAtOrDefault(16)?.ToNullableDateTime();
            BpTransfusionEndDateTimeOfStatus = segments.ElementAtOrDefault(17)?.ToNullableDateTime();
            BpAdverseReactionType = segments.Length > 18 ? segments.ElementAtOrDefault(18).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            BpTransfusionInterruptedReason = segments.Length > 19 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(19), false) : null;
            BpUniqueId = segments.Length > 20 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(20), false) : null;
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
                                StringHelper.StringFormatSequence(0, 21, Configuration.FieldSeparator),
                                Id,
                                SetIdBtx.HasValue ? SetIdBtx.Value.ToString(culture) : null,
                                BcDonationId?.ToDelimitedString(),
                                BcComponent?.ToDelimitedString(),
                                BcBloodGroup?.ToDelimitedString(),
                                CpCommercialProduct?.ToDelimitedString(),
                                CpManufacturer?.ToDelimitedString(),
                                CpLotNumber?.ToDelimitedString(),
                                BpQuantity.HasValue ? BpQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                BpAmount.HasValue ? BpAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                BpUnits?.ToDelimitedString(),
                                BpTransfusionDispositionStatus?.ToDelimitedString(),
                                BpMessageStatus,
                                BpDateTimeOfStatus.HasValue ? BpDateTimeOfStatus.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                BpTransfusionAdministrator?.ToDelimitedString(),
                                BpTransfusionVerifier?.ToDelimitedString(),
                                BpTransfusionStartDateTimeOfStatus.HasValue ? BpTransfusionStartDateTimeOfStatus.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                BpTransfusionEndDateTimeOfStatus.HasValue ? BpTransfusionEndDateTimeOfStatus.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                BpAdverseReactionType != null ? string.Join(Configuration.FieldRepeatSeparator, BpAdverseReactionType.Select(x => x.ToDelimitedString())) : null,
                                BpTransfusionInterruptedReason?.ToDelimitedString(),
                                BpUniqueId?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}