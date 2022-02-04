using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SDD - Sterilization Device Data.
    /// </summary>
    public class SddSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SddSegment"/> class.
        /// </summary>
        public SddSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SddSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public SddSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id { get; } = "SDD";

        /// <inheritdoc/>
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
        /// <para>Suggested: 0667 Device Data State -&gt; ClearHl7.Codes.V260.CodeDeviceDataState</para>
        /// </summary>
        public string DeviceDataState { get; set; }

        /// <summary>
        /// SDD.5 - Load Status.
        /// <para>Suggested: 0669 Load Status -&gt; ClearHl7.Codes.V260.CodeLoadStatus</para>
        /// </summary>
        public string LoadStatus { get; set; }

        /// <summary>
        /// SDD.6 - Control Code.
        /// </summary>
        public decimal? ControlCode { get; set; }

        /// <summary>
        /// SDD.7 - Operator Name.
        /// </summary>
        public string OperatorName { get; set; }

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

            LotNumber = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[1], false, seps) : null;
            DeviceNumber = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[2], false, seps) : null;
            DeviceName = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            DeviceDataState = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            LoadStatus = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            ControlCode = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDecimal() : null;
            OperatorName = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 8, Configuration.FieldSeparator),
                                Id,
                                LotNumber?.ToDelimitedString(),
                                DeviceNumber?.ToDelimitedString(),
                                DeviceName,
                                DeviceDataState,
                                LoadStatus,
                                ControlCode.HasValue ? ControlCode.Value.ToString(Consts.NumericFormat, culture) : null,
                                OperatorName
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
