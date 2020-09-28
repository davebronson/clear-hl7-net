using System;
using ClearHl7.Fhir.V281.Types;

namespace ClearHl7.Fhir.V281.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0566</remarks>
        public CodedWithExceptions BloodUnitType { get; set; }

        /// <summary>
        /// BUI.4 - Blood Unit Weight.
        /// </summary>
        public decimal? BloodUnitWeight { get; set; }

        /// <summary>
        /// BUI.5 - Weight Units.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0929</remarks>
        public CodedWithNoExceptions WeightUnits { get; set; }

        /// <summary>
        /// BUI.6 - Blood Unit Volume.
        /// </summary>
        public decimal? BloodUnitVolume { get; set; }

        /// <summary>
        /// BUI.7 - Volume Units.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0930</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0931</remarks>
        public CodedWithNoExceptions TransportTemperatureUnits { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}",
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
                                ).TrimEnd('|');
        }
    }
}