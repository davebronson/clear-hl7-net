using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
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
        /// <para>Suggested: 0667 Device Data State -&gt; ClearHl7.Codes.V270.CodeDeviceDataState</para>
        /// </summary>
        public CodedWithExceptions DeviceDataState { get; set; }

        /// <summary>
        /// SDD.5 - Load Status.
        /// <para>Suggested: 0669 Load Status -&gt; ClearHl7.Codes.V270.CodeLoadStatus</para>
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
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            LotNumber = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[1], false) : null;
            DeviceNumber = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[2], false) : null;
            DeviceName = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            DeviceDataState = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[4], false) : null;
            LoadStatus = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[5], false) : null;
            ControlCode = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDecimal() : null;
            OperatorName = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
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