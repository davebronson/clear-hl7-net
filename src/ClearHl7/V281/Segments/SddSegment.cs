using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SDD - Sterilization Device Data.
    /// </summary>
    public class SddSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "SDD";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// SDD.1 - Lot Number.
        /// </summary>
        public EntityIdentifier LotNumber { get; set; }

        /// <summary>
        /// SDD.2 - Device Number.
        /// </summary>
        public EntityIdentifier DeviceNumber { get; set; }

        /// <summary>
        /// SDD.3 - Device Name.
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// SDD.4 - Device Data State.
        /// <para>Suggested: 0667 Device Data State -&gt; ClearHl7.Codes.V281.CodeDeviceDataState</para>
        /// </summary>
        public CodedWithExceptions DeviceDataState { get; set; }

        /// <summary>
        /// SDD.5 - Load Status.
        /// <para>Suggested: 0669 Load Status -&gt; ClearHl7.Codes.V281.CodeLoadStatus</para>
        /// </summary>
        public CodedWithExceptions LoadStatus { get; set; }

        /// <summary>
        /// SDD.6 - Control Code.
        /// </summary>
        public decimal? ControlCode { get; set; }

        /// <summary>
        /// SDD.7 - Operator Name.
        /// </summary>
        public string OperatorName { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 8, Configuration.FieldSeparator),
                                Id,
                                LotNumber?.ToDelimitedString(),
                                DeviceNumber?.ToDelimitedString(),
                                DeviceName,
                                DeviceDataState?.ToDelimitedString(),
                                LoadStatus?.ToDelimitedString(),
                                ControlCode.HasValue ? ControlCode.Value.ToString(Consts.NumericFormat, culture) : null,
                                OperatorName
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}