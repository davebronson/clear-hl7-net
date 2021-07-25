using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment BUI - Blood Unit Information.
    /// </summary>
    public class BuiSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "BUI";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// BUI.1 - Set ID - BUI.
        /// </summary>
        public uint? SetIdBui { get; set; }

        /// <summary>
        /// BUI.2 - Blood Unit Identifier.
        /// </summary>
        public EntityIdentifier BloodUnitIdentifier { get; set; }

        /// <summary>
        /// BUI.3 - Blood Unit Type.
        /// <para>Suggested: 0566 Blood Unit Type -&gt; ClearHl7.Codes.V281.CodeBloodUnitType</para>
        /// </summary>
        public CodedWithExceptions BloodUnitType { get; set; }

        /// <summary>
        /// BUI.4 - Blood Unit Weight.
        /// </summary>
        public decimal? BloodUnitWeight { get; set; }

        /// <summary>
        /// BUI.5 - Weight Units.
        /// <para>Suggested: 0929 Weight Units</para>
        /// </summary>
        public CodedWithNoExceptions WeightUnits { get; set; }

        /// <summary>
        /// BUI.6 - Blood Unit Volume.
        /// </summary>
        public decimal? BloodUnitVolume { get; set; }

        /// <summary>
        /// BUI.7 - Volume Units.
        /// <para>Suggested: 0930 Volume Units</para>
        /// </summary>
        public CodedWithNoExceptions VolumeUnits { get; set; }

        /// <summary>
        /// BUI.8 - Container Catalog Number.
        /// </summary>
        public string ContainerCatalogNumber { get; set; }

        /// <summary>
        /// BUI.9 - Container Lot Number.
        /// </summary>
        public string ContainerLotNumber { get; set; }

        /// <summary>
        /// BUI.10 - Container Manufacturer.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations ContainerManufacturer { get; set; }

        /// <summary>
        /// BUI.11 - Transport Temperature.
        /// </summary>
        public NumericRange TransportTemperature { get; set; }

        /// <summary>
        /// BUI.12 - Transport Temperature Units.
        /// <para>Suggested: 0931 Transport Temperature Units</para>
        /// </summary>
        public CodedWithNoExceptions TransportTemperatureUnits { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdBui = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            BloodUnitIdentifier = segments.Length > 2 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(2), false) : null;
            BloodUnitType = segments.Length > 3 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(3), false) : null;
            BloodUnitWeight = segments.ElementAtOrDefault(4)?.ToNullableDecimal();
            WeightUnits = segments.Length > 5 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(5), false) : null;
            BloodUnitVolume = segments.ElementAtOrDefault(6)?.ToNullableDecimal();
            VolumeUnits = segments.Length > 7 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(7), false) : null;
            ContainerCatalogNumber = segments.ElementAtOrDefault(8);
            ContainerLotNumber = segments.ElementAtOrDefault(9);
            ContainerManufacturer = segments.Length > 10 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments.ElementAtOrDefault(10), false) : null;
            TransportTemperature = segments.Length > 11 ? TypeHelper.Deserialize<NumericRange>(segments.ElementAtOrDefault(11), false) : null;
            TransportTemperatureUnits = segments.Length > 12 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(12), false) : null;
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
                                StringHelper.StringFormatSequence(0, 13, Configuration.FieldSeparator),
                                Id,
                                SetIdBui.HasValue ? SetIdBui.Value.ToString(culture) : null,
                                BloodUnitIdentifier?.ToDelimitedString(),
                                BloodUnitType?.ToDelimitedString(),
                                BloodUnitWeight.HasValue ? BloodUnitWeight.Value.ToString(Consts.NumericFormat, culture) : null,
                                WeightUnits?.ToDelimitedString(),
                                BloodUnitVolume.HasValue ? BloodUnitVolume.Value.ToString(Consts.NumericFormat, culture) : null,
                                VolumeUnits?.ToDelimitedString(),
                                ContainerCatalogNumber,
                                ContainerLotNumber,
                                ContainerManufacturer?.ToDelimitedString(),
                                TransportTemperature?.ToDelimitedString(),
                                TransportTemperatureUnits?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}