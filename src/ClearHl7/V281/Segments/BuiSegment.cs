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

            SetIdBui = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            BloodUnitIdentifier = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[2], false) : null;
            BloodUnitType = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[3], false) : null;
            BloodUnitWeight = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDecimal() : null;
            WeightUnits = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[5], false) : null;
            BloodUnitVolume = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDecimal() : null;
            VolumeUnits = segments.Length > 7 && segments[7].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[7], false) : null;
            ContainerCatalogNumber = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            ContainerLotNumber = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            ContainerManufacturer = segments.Length > 10 && segments[10].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[10], false) : null;
            TransportTemperature = segments.Length > 11 && segments[11].Length > 0 ? TypeHelper.Deserialize<NumericRange>(segments[11], false) : null;
            TransportTemperatureUnits = segments.Length > 12 && segments[12].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[12], false) : null;
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