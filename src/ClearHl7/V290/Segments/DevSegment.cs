using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment DEV - Device.
    /// </summary>
    public class DevSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DevSegment"/> class.
        /// </summary>
        public DevSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DevSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public DevSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "DEV";

        /// <inheritdoc/>
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

            ActionCode = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            UniqueDeviceIdentifier = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[2], false, seps) : null;
            DeviceType = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithNoExceptions>(x, false, seps)) : null;
            DeviceStatus = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithNoExceptions>(x, false, seps)) : null;
            ManufacturerDistributor = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[5], false, seps) : null;
            BrandName = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            ModelIdentifier = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            CatalogueIdentifier = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            UdiDeviceIdentifier = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[9], false, seps) : null;
            DeviceLotNumber = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            DeviceSerialNumber = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            DeviceManufactureDate = segments.Length > 12 && segments[12].Length > 0 ? segments[12].ToNullableDateTime() : null;
            DeviceExpiryDate = segments.Length > 13 && segments[13].Length > 0 ? segments[13].ToNullableDateTime() : null;
            SafetyCharacteristics = segments.Length > 14 && segments[14].Length > 0 ? segments[14].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            DeviceDonationIdentification = segments.Length > 15 && segments[15].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[15], false, seps) : null;
            SoftwareVersionNumber = segments.Length > 16 && segments[16].Length > 0 ? segments[16] : null;
            ImplantationStatus = segments.Length > 17 && segments[17].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[17], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

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
                                DeviceManufactureDate.ToHl7DateTimeString(typeof(DevSegment), nameof(DeviceManufactureDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                DeviceExpiryDate.ToHl7DateTimeString(typeof(DevSegment), nameof(DeviceExpiryDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                SafetyCharacteristics != null ? string.Join(Configuration.FieldRepeatSeparator, SafetyCharacteristics.Select(x => x.ToDelimitedString())) : null,
                                DeviceDonationIdentification?.ToDelimitedString(),
                                SoftwareVersionNumber,
                                ImplantationStatus?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
