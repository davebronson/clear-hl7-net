using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V290.Types;

namespace ClearHl7.Fhir.V290.Segments
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
        /// <para>Suggested: 0651 Labor Calculation Type -&gt; ClearHl7.Fhir.Codes.V290.CodeLaborCalculationType</para>
        /// </summary>
        public CodedWithExceptions LaborCalculationType { get; set; }

        /// <summary>
        /// SCP.3 - Date Format.
        /// <para>Suggested: 0653 Date Format -&gt; ClearHl7.Fhir.Codes.V290.CodeDateFormat</para>
        /// </summary>
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
        /// <para>Suggested: 0657 Device Type -&gt; ClearHl7.Fhir.Codes.V290.CodeDeviceType</para>
        /// </summary>
        public CodedWithExceptions DeviceType { get; set; }

        /// <summary>
        /// SCP.8 - Lot Control.
        /// <para>Suggested: 0659 Lot Control -&gt; ClearHl7.Fhir.Codes.V290.CodeLotControl</para>
        /// </summary>
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