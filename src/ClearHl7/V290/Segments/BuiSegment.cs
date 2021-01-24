using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
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
        /// <para>Suggested: 0566 Blood Unit Type -&gt; ClearHl7.Codes.V290.CodeBloodUnitType</para>
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
        /// BUI.13 - Action Code.
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
                                StringHelper.StringFormatSequence(0, 14, Configuration.FieldSeparator),
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
                                TransportTemperatureUnits?.ToDelimitedString(),
                                ActionCode
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}