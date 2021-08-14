using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment BPX - Blood Product Dispense Status.
    /// </summary>
    public class BpxSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "BPX";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// BPX.1 - Set ID - BPX.
        /// </summary>
        public uint? SetIdBpx { get; set; }

        /// <summary>
        /// BPX.2 - BP Dispense Status.
        /// <para>Suggested: 0510 Blood Product Dispense Status -&gt; ClearHl7.Codes.V281.CodeBloodProductDispenseStatus</para>
        /// </summary>
        public CodedWithExceptions BpDispenseStatus { get; set; }

        /// <summary>
        /// BPX.3 - BP Status.
        /// <para>Suggested: 0511 BP Observation Status Codes Interpretation -&gt; ClearHl7.Codes.V281.CodeBpObservationStatusCodesInterpretation</para>
        /// </summary>
        public string BpStatus { get; set; }

        /// <summary>
        /// BPX.4 - BP Date/Time of Status.
        /// </summary>
        public DateTime? BpDateTimeOfStatus { get; set; }

        /// <summary>
        /// BPX.5 - BC Donation ID.
        /// </summary>
        public EntityIdentifier BcDonationId { get; set; }

        /// <summary>
        /// BPX.6 - BC Component.
        /// </summary>
        public CodedWithNoExceptions BcComponent { get; set; }

        /// <summary>
        /// BPX.7 - BC Donation Type / Intended Use.
        /// </summary>
        public CodedWithNoExceptions BcDonationTypeIntendedUse { get; set; }

        /// <summary>
        /// BPX.8 - CP Commercial Product.
        /// <para>Suggested: 0512 Commercial Product</para>
        /// </summary>
        public CodedWithExceptions CpCommercialProduct { get; set; }

        /// <summary>
        /// BPX.9 - CP Manufacturer.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations CpManufacturer { get; set; }

        /// <summary>
        /// BPX.10 - CP Lot Number.
        /// </summary>
        public EntityIdentifier CpLotNumber { get; set; }

        /// <summary>
        /// BPX.11 - BP Blood Group.
        /// </summary>
        public CodedWithNoExceptions BpBloodGroup { get; set; }

        /// <summary>
        /// BPX.12 - BC Special Testing.
        /// </summary>
        public IEnumerable<CodedWithNoExceptions> BcSpecialTesting { get; set; }

        /// <summary>
        /// BPX.13 - BP Expiration Date/Time.
        /// </summary>
        public DateTime? BpExpirationDateTime { get; set; }

        /// <summary>
        /// BPX.14 - BP Quantity.
        /// </summary>
        public decimal? BpQuantity { get; set; }

        /// <summary>
        /// BPX.15 - BP Amount.
        /// </summary>
        public decimal? BpAmount { get; set; }

        /// <summary>
        /// BPX.16 - BP Units.
        /// </summary>
        public CodedWithExceptions BpUnits { get; set; }

        /// <summary>
        /// BPX.17 - BP Unique ID.
        /// </summary>
        public EntityIdentifier BpUniqueId { get; set; }

        /// <summary>
        /// BPX.18 - BP Actual Dispensed To Location.
        /// </summary>
        public PersonLocation BpActualDispensedToLocation { get; set; }

        /// <summary>
        /// BPX.19 - BP Actual Dispensed To Address.
        /// </summary>
        public ExtendedAddress BpActualDispensedToAddress { get; set; }

        /// <summary>
        /// BPX.20 - BP Dispensed to Receiver.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons BpDispensedToReceiver { get; set; }

        /// <summary>
        /// BPX.21 - BP Dispensing Individual.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons BpDispensingIndividual { get; set; }

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

            SetIdBpx = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            BpDispenseStatus = segments.Length > 2 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(2), false) : null;
            BpStatus = segments.ElementAtOrDefault(3);
            BpDateTimeOfStatus = segments.ElementAtOrDefault(4)?.ToNullableDateTime();
            BcDonationId = segments.Length > 5 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(5), false) : null;
            BcComponent = segments.Length > 6 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(6), false) : null;
            BcDonationTypeIntendedUse = segments.Length > 7 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(7), false) : null;
            CpCommercialProduct = segments.Length > 8 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(8), false) : null;
            CpManufacturer = segments.Length > 9 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments.ElementAtOrDefault(9), false) : null;
            CpLotNumber = segments.Length > 10 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(10), false) : null;
            BpBloodGroup = segments.Length > 11 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(11), false) : null;
            BcSpecialTesting = segments.Length > 12 ? segments.ElementAtOrDefault(12).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithNoExceptions>(x, false)) : null;
            BpExpirationDateTime = segments.ElementAtOrDefault(13)?.ToNullableDateTime();
            BpQuantity = segments.ElementAtOrDefault(14)?.ToNullableDecimal();
            BpAmount = segments.ElementAtOrDefault(15)?.ToNullableDecimal();
            BpUnits = segments.Length > 16 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(16), false) : null;
            BpUniqueId = segments.Length > 17 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(17), false) : null;
            BpActualDispensedToLocation = segments.Length > 18 ? TypeHelper.Deserialize<PersonLocation>(segments.ElementAtOrDefault(18), false) : null;
            BpActualDispensedToAddress = segments.Length > 19 ? TypeHelper.Deserialize<ExtendedAddress>(segments.ElementAtOrDefault(19), false) : null;
            BpDispensedToReceiver = segments.Length > 20 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(20), false) : null;
            BpDispensingIndividual = segments.Length > 21 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(21), false) : null;
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
                                StringHelper.StringFormatSequence(0, 22, Configuration.FieldSeparator),
                                Id,
                                SetIdBpx.HasValue ? SetIdBpx.Value.ToString(culture) : null,
                                BpDispenseStatus?.ToDelimitedString(),
                                BpStatus,
                                BpDateTimeOfStatus.HasValue ? BpDateTimeOfStatus.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                BcDonationId?.ToDelimitedString(),
                                BcComponent?.ToDelimitedString(),
                                BcDonationTypeIntendedUse?.ToDelimitedString(),
                                CpCommercialProduct?.ToDelimitedString(),
                                CpManufacturer?.ToDelimitedString(),
                                CpLotNumber?.ToDelimitedString(),
                                BpBloodGroup?.ToDelimitedString(),
                                BcSpecialTesting != null ? string.Join(Configuration.FieldRepeatSeparator, BcSpecialTesting.Select(x => x.ToDelimitedString())) : null,
                                BpExpirationDateTime.HasValue ? BpExpirationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                BpQuantity.HasValue ? BpQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                BpAmount.HasValue ? BpAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                BpUnits?.ToDelimitedString(),
                                BpUniqueId?.ToDelimitedString(),
                                BpActualDispensedToLocation?.ToDelimitedString(),
                                BpActualDispensedToAddress?.ToDelimitedString(),
                                BpDispensedToReceiver?.ToDelimitedString(),
                                BpDispensingIndividual?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}