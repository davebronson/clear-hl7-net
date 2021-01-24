using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
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
        /// <para>Suggested: 0510 Blood Product Dispense Status -&gt; ClearHl7.Codes.V290.CodeBloodProductDispenseStatus</para>
        /// </summary>
        public CodedWithExceptions BpDispenseStatus { get; set; }

        /// <summary>
        /// BPX.3 - BP Status.
        /// <para>Suggested: 0511 BP Observation Status Codes Interpretation -&gt; ClearHl7.Codes.V290.CodeBpObservationStatusCodesInterpretation</para>
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
        /// <para>Suggested: 0577 BC Component</para>
        /// </summary>
        public CodedWithNoExceptions BcComponent { get; set; }

        /// <summary>
        /// BPX.7 - BC Donation Type / Intended Use.
        /// <para>Suggested: 0578 BC Donation Type/Intended Use</para>
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
        /// <para>Suggested: 0579 BP Blood Group</para>
        /// </summary>
        public CodedWithNoExceptions BpBloodGroup { get; set; }

        /// <summary>
        /// BPX.12 - BC Special Testing.
        /// <para>Suggested: 0580 BC Special Testing</para>
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
        /// <para>Suggested: 0581 BP Units</para>
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
        /// BPX.22 - Action Code.
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 23, Configuration.FieldSeparator),
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
                                BpDispensingIndividual?.ToDelimitedString(),
                                ActionCode
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}