using System;

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

        ///// <summary>
        ///// SCP.1 - Number Of Decontamination/Sterilization Devices.
        ///// </summary>
        //public NumberOfDecontaminationSterilizationDevices { get; set; }

        ///// <summary>
        ///// SCP.2 - Labor Calculation Type.
        ///// </summary>
        //public LaborCalculationType { get; set; }

        ///// <summary>
        ///// SCP.3 - Date Format.
        ///// </summary>
        //public DateFormat { get; set; }

        ///// <summary>
        ///// SCP.4 - Device Number.
        ///// </summary>
        //public DeviceNumber { get; set; }

        ///// <summary>
        ///// SCP.5 - Device Name.
        ///// </summary>
        //public DeviceName { get; set; }

        ///// <summary>
        ///// SCP.6 - Device Model Name.
        ///// </summary>
        //public DeviceModelName { get; set; }

        ///// <summary>
        ///// SCP.7 - Device Type.
        ///// </summary>
        //public DeviceType { get; set; }

        ///// <summary>
        ///// SCP.8 - Lot Control.
        ///// </summary>
        //public LotControl { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}"
                                ).TrimEnd('|');
        }
    }
}