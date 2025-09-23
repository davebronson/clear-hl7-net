using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment BTX - Blood Product Transfusion Disposition.
    /// </summary>
    public class BtxSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BtxSegment"/> class.
        /// </summary>
        public BtxSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BtxSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public BtxSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "BTX";

        /// <inheritdoc/>
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

            SetIdBtx = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            BcDonationId = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[2], false, seps) : null;
            BcComponent = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[3], false, seps) : null;
            BcBloodGroup = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[4], false, seps) : null;
            CpCommercialProduct = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[5], false, seps) : null;
            CpManufacturer = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[6], false, seps) : null;
            CpLotNumber = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[7], false, seps) : null;
            BpQuantity = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDecimal() : null;
            BpAmount = segments.Length > 9 && segments[9].Length > 0 ? segments[9].ToNullableDecimal() : null;
            BpUnits = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[10], false, seps) : null;
            BpTransfusionDispositionStatus = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[11], false, seps) : null;
            BpMessageStatus = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            BpDateTimeOfStatus = segments.Length > 13 && segments[13].Length > 0 ? segments[13].ToNullableDateTime() : null;
            BpTransfusionAdministrator = segments.Length > 14 && segments[14].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[14], false, seps) : null;
            BpTransfusionVerifier = segments.Length > 15 && segments[15].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[15], false, seps) : null;
            BpTransfusionStartDateTimeOfStatus = segments.Length > 16 && segments[16].Length > 0 ? segments[16].ToNullableDateTime() : null;
            BpTransfusionEndDateTimeOfStatus = segments.Length > 17 && segments[17].Length > 0 ? segments[17].ToNullableDateTime() : null;
            BpAdverseReactionType = segments.Length > 18 && segments[18].Length > 0 ? segments[18].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            BpTransfusionInterruptedReason = segments.Length > 19 && segments[19].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[19], false, seps) : null;
            BpUniqueId = segments.Length > 20 && segments[20].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[20], false, seps) : null;
        }

        /// <inheritdoc/>
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
                                BpDateTimeOfStatus.ToHl7DateTimeString(typeof(BtxSegment), nameof(BpDateTimeOfStatus), Consts.DateTimeFormatPrecisionSecond, culture),
                                BpTransfusionAdministrator?.ToDelimitedString(),
                                BpTransfusionVerifier?.ToDelimitedString(),
                                BpTransfusionStartDateTimeOfStatus.ToHl7DateTimeString(typeof(BtxSegment), nameof(BpTransfusionStartDateTimeOfStatus), Consts.DateTimeFormatPrecisionSecond, culture),
                                BpTransfusionEndDateTimeOfStatus.ToHl7DateTimeString(typeof(BtxSegment), nameof(BpTransfusionEndDateTimeOfStatus), Consts.DateTimeFormatPrecisionSecond, culture),
                                BpAdverseReactionType != null ? string.Join(Configuration.FieldRepeatSeparator, BpAdverseReactionType.Select(x => x.ToDelimitedString())) : null,
                                BpTransfusionInterruptedReason?.ToDelimitedString(),
                                BpUniqueId?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
