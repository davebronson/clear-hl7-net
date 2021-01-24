using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V282.Types;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SCP - Sterilizer Configuration (Anti-Microbial Devices).
    /// </summary>
    public class ScpSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "SCP";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// SCP.1 - Number Of Decontamination/Sterilization Devices.
        /// </summary>
        public decimal? NumberOfDecontaminationSterilizationDevices { get; set; }

        /// <summary>
        /// SCP.2 - Labor Calculation Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0651</remarks>
        public CodedWithExceptions LaborCalculationType { get; set; }

        /// <summary>
        /// SCP.3 - Date Format.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0653</remarks>
        public CodedWithExceptions DateFormat { get; set; }

        /// <summary>
        /// SCP.4 - Device Number.
        /// </summary>
        public EntityIdentifier DeviceNumber { get; set; }

        /// <summary>
        /// SCP.5 - Device Name.
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// SCP.6 - Device Model Name.
        /// </summary>
        public string DeviceModelName { get; set; }

        /// <summary>
        /// SCP.7 - Device Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0657</remarks>
        public CodedWithExceptions DeviceType { get; set; }

        /// <summary>
        /// SCP.8 - Lot Control.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0659</remarks>
        public CodedWithExceptions LotControl { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 9, Configuration.FieldSeparator),
                                Id,
                                NumberOfDecontaminationSterilizationDevices.HasValue ? NumberOfDecontaminationSterilizationDevices.Value.ToString(Consts.NumericFormat, culture) : null,
                                LaborCalculationType?.ToDelimitedString(),
                                DateFormat?.ToDelimitedString(),
                                DeviceNumber?.ToDelimitedString(),
                                DeviceName,
                                DeviceModelName,
                                DeviceType?.ToDelimitedString(),
                                LotControl?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}