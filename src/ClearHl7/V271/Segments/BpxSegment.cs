﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
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
        /// <para>Suggested: 0510 Blood Product Dispense Status -&gt; ClearHl7.Codes.V271.CodeBloodProductDispenseStatus</para>
        /// </summary>
        public CodedWithExceptions BpDispenseStatus { get; set; }

        /// <summary>
        /// BPX.3 - BP Status.
        /// <para>Suggested: 0511 BP Observation Status Codes Interpretation -&gt; ClearHl7.Codes.V271.CodeBpObservationStatusCodesInterpretation</para>
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
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        internal void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);
            
            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdBpx = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            BpDispenseStatus = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[2], false) : null;
            BpStatus = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            BpDateTimeOfStatus = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            BcDonationId = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[5], false) : null;
            BcComponent = segments.Length > 6 && segments[6].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[6], false) : null;
            BcDonationTypeIntendedUse = segments.Length > 7 && segments[7].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[7], false) : null;
            CpCommercialProduct = segments.Length > 8 && segments[8].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[8], false) : null;
            CpManufacturer = segments.Length > 9 && segments[9].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[9], false) : null;
            CpLotNumber = segments.Length > 10 && segments[10].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[10], false) : null;
            BpBloodGroup = segments.Length > 11 && segments[11].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[11], false) : null;
            BcSpecialTesting = segments.Length > 12 && segments[12].Length > 0 ? segments[12].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithNoExceptions>(x, false)) : null;
            BpExpirationDateTime = segments.Length > 13 && segments[13].Length > 0 ? segments[13].ToNullableDateTime() : null;
            BpQuantity = segments.Length > 14 && segments[14].Length > 0 ? segments[14].ToNullableDecimal() : null;
            BpAmount = segments.Length > 15 && segments[15].Length > 0 ? segments[15].ToNullableDecimal() : null;
            BpUnits = segments.Length > 16 && segments[16].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[16], false) : null;
            BpUniqueId = segments.Length > 17 && segments[17].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[17], false) : null;
            BpActualDispensedToLocation = segments.Length > 18 && segments[18].Length > 0 ? TypeHelper.Deserialize<PersonLocation>(segments[18], false) : null;
            BpActualDispensedToAddress = segments.Length > 19 && segments[19].Length > 0 ? TypeHelper.Deserialize<ExtendedAddress>(segments[19], false) : null;
            BpDispensedToReceiver = segments.Length > 20 && segments[20].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[20], false) : null;
            BpDispensingIndividual = segments.Length > 21 && segments[21].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[21], false) : null;
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