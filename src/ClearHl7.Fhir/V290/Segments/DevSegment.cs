using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V290.Types;

namespace ClearHl7.Fhir.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment DEV - Device.
    /// </summary>
    public class DevSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "DEV";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// DEV.1 - Action Code.
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// DEV.2 - Unique Device Identifier.
        /// </summary>
        public EntityIdentifier UniqueDeviceIdentifier { get; set; }

        /// <summary>
        /// DEV.3 - Device Type.
        /// <para>Suggested: 0961 Device Type</para>
        /// </summary>
        public IEnumerable<CodedWithNoExceptions> DeviceType { get; set; }

        /// <summary>
        /// DEV.4 - Device Status.
        /// <para>Suggested: 0962 Device Status</para>
        /// </summary>
        public IEnumerable<CodedWithNoExceptions> DeviceStatus { get; set; }

        /// <summary>
        /// DEV.5 - Manufacturer/Distributor.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations ManufacturerDistributor { get; set; }

        /// <summary>
        /// DEV.6 - Brand Name.
        /// </summary>
        public string BrandName { get; set; }

        /// <summary>
        /// DEV.7 - Model Identifier.
        /// </summary>
        public string ModelIdentifier { get; set; }

        /// <summary>
        /// DEV.8 - Catalogue Identifier.
        /// </summary>
        public string CatalogueIdentifier { get; set; }

        /// <summary>
        /// DEV.9 - UDI Device Identifier.
        /// </summary>
        public EntityIdentifier UdiDeviceIdentifier { get; set; }

        /// <summary>
        /// DEV.10 - Device Lot Number.
        /// </summary>
        public string DeviceLotNumber { get; set; }

        /// <summary>
        /// DEV.11 - Device Serial Number.
        /// </summary>
        public string DeviceSerialNumber { get; set; }

        /// <summary>
        /// DEV.12 - Device Manufacture Date.
        /// </summary>
        public DateTime? DeviceManufactureDate { get; set; }

        /// <summary>
        /// DEV.13 - Device Expiry Date.
        /// </summary>
        public DateTime? DeviceExpiryDate { get; set; }

        /// <summary>
        /// DEV.14 - Safety Characteristics.
        /// <para>Suggested: 0963 Safety Characteristics</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> SafetyCharacteristics { get; set; }

        /// <summary>
        /// DEV.15 - Device Donation Identification.
        /// </summary>
        public EntityIdentifier DeviceDonationIdentification { get; set; }

        /// <summary>
        /// DEV.16 - Software Version Number.
        /// </summary>
        public string SoftwareVersionNumber { get; set; }

        /// <summary>
        /// DEV.17 - Implantation Status.
        /// <para>Suggested: 0795 Implantation Status</para>
        /// </summary>
        public CodedWithNoExceptions ImplantationStatus { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 18, Configuration.FieldSeparator),
                                Id,
                                ActionCode,
                                UniqueDeviceIdentifier?.ToDelimitedString(),
                                DeviceType != null ? string.Join(Configuration.FieldRepeatSeparator, DeviceType.Select(x => x.ToDelimitedString())) : null,
                                DeviceStatus != null ? string.Join(Configuration.FieldRepeatSeparator, DeviceStatus.Select(x => x.ToDelimitedString())) : null,
                                ManufacturerDistributor?.ToDelimitedString(),
                                BrandName,
                                ModelIdentifier,
                                CatalogueIdentifier,
                                UdiDeviceIdentifier?.ToDelimitedString(),
                                DeviceLotNumber,
                                DeviceSerialNumber,
                                DeviceManufactureDate.HasValue ? DeviceManufactureDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DeviceExpiryDate.HasValue ? DeviceExpiryDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                SafetyCharacteristics != null ? string.Join(Configuration.FieldRepeatSeparator, SafetyCharacteristics.Select(x => x.ToDelimitedString())) : null,
                                DeviceDonationIdentification?.ToDelimitedString(),
                                SoftwareVersionNumber,
                                ImplantationStatus?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}