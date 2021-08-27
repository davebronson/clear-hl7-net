using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
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
        public void FromDelimitedString(string delimitedString, Separators separators)
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

            ActionCode = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            UniqueDeviceIdentifier = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[2], false) : null;
            DeviceType = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithNoExceptions>(x, false)) : null;
            DeviceStatus = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithNoExceptions>(x, false)) : null;
            ManufacturerDistributor = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[5], false) : null;
            BrandName = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            ModelIdentifier = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            CatalogueIdentifier = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            UdiDeviceIdentifier = segments.Length > 9 && segments[9].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[9], false) : null;
            DeviceLotNumber = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            DeviceSerialNumber = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            DeviceManufactureDate = segments.Length > 12 && segments[12].Length > 0 ? segments[12].ToNullableDateTime() : null;
            DeviceExpiryDate = segments.Length > 13 && segments[13].Length > 0 ? segments[13].ToNullableDateTime() : null;
            SafetyCharacteristics = segments.Length > 14 && segments[14].Length > 0 ? segments[14].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            DeviceDonationIdentification = segments.Length > 15 && segments[15].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[15], false) : null;
            SoftwareVersionNumber = segments.Length > 16 && segments[16].Length > 0 ? segments[16] : null;
            ImplantationStatus = segments.Length > 17 && segments[17].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[17], false) : null;
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