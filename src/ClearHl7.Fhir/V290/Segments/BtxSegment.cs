using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V290.Types;

namespace ClearHl7.Fhir.V290.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0512</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0513</remarks>
        public CodedWithExceptions BpTransfusionDispositionStatus { get; set; }

        /// <summary>
        /// BTX.12 - BP Message Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0511</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0514</remarks>
        public IEnumerable<CodedWithExceptions> BpAdverseReactionType { get; set; }

        /// <summary>
        /// BTX.19 - BP Transfusion Interrupted Reason.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0515</remarks>
        public CodedWithExceptions BpTransfusionInterruptedReason { get; set; }

        /// <summary>
        /// BTX.20 - BP Unique ID.
        /// </summary>
        public EntityIdentifier BpUniqueId { get; set; }

        /// <summary>
        /// BTX.21 - Action Code.
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
                                StringHelper.StringFormatSequence(0, 22, Configuration.FieldSeparator),
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
                                BpUniqueId?.ToDelimitedString(),
                                ActionCode
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}