using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SCP - Sterilizer Configuration (Anti-Microbial Devices).
    /// </summary>
    public class ScpSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScpSegment"/> class.
        /// </summary>
        public ScpSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScpSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public ScpSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "SCP";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// SCP.1 - Number Of Decontamination/Sterilization Devices.
        /// </summary>
        public decimal? NumberOfDecontaminationSterilizationDevices { get; set; }

        /// <summary>
        /// SCP.2 - Labor Calculation Type.
        /// <para>Suggested: 0651 Labor Calculation Type -&gt; ClearHl7.Codes.V290.CodeLaborCalculationType</para>
        /// </summary>
        public CodedWithExceptions LaborCalculationType { get; set; }

        /// <summary>
        /// SCP.3 - Date Format.
        /// <para>Suggested: 0653 Date Format -&gt; ClearHl7.Codes.V290.CodeDateFormat</para>
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
        /// <para>Suggested: 0657 Device Type -&gt; ClearHl7.Codes.V290.CodeDeviceType</para>
        /// </summary>
        public CodedWithExceptions DeviceType { get; set; }

        /// <summary>
        /// SCP.8 - Lot Control.
        /// <para>Suggested: 0659 Lot Control -&gt; ClearHl7.Codes.V290.CodeLotControl</para>
        /// </summary>
        public CodedWithExceptions LotControl { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            NumberOfDecontaminationSterilizationDevices = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            LaborCalculationType = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            DateFormat = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[3], false, seps) : null;
            DeviceNumber = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[4], false, seps) : null;
            DeviceName = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            DeviceModelName = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            DeviceType = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[7], false, seps) : null;
            LotControl = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[8], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

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
