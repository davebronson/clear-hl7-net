using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment EQU - Equipment Detail.
    /// </summary>
    public class EquSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EquSegment"/> class.
        /// </summary>
        public EquSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EquSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public EquSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "EQU";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// EQU.1 - Equipment Instance Identifier.
        /// </summary>
        public IEnumerable<EntityIdentifier> EquipmentInstanceIdentifier { get; set; }

        /// <summary>
        /// EQU.2 - Event Date/Time.
        /// </summary>
        public DateTime? EventDateTime { get; set; }

        /// <summary>
        /// EQU.3 - Equipment State.
        /// <para>Suggested: 0365 Equipment State -&gt; ClearHl7.Codes.V280.CodeEquipmentState</para>
        /// </summary>
        public CodedWithExceptions EquipmentState { get; set; }

        /// <summary>
        /// EQU.4 - Local/Remote Control State.
        /// <para>Suggested: 0366 Local/Remote Control State -&gt; ClearHl7.Codes.V280.CodeLocalRemoteControlState</para>
        /// </summary>
        public CodedWithExceptions LocalRemoteControlState { get; set; }

        /// <summary>
        /// EQU.5 - Alert Level.
        /// <para>Suggested: 0367 Alert Level -&gt; ClearHl7.Codes.V280.CodeAlertLevel</para>
        /// </summary>
        public CodedWithExceptions AlertLevel { get; set; }

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
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            EquipmentInstanceIdentifier = segments.Length > 1 && segments[1].Length > 0 ? segments[1].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<EntityIdentifier>(x, false, seps)) : null;
            EventDateTime = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDateTime() : null;
            EquipmentState = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[3], false, seps) : null;
            LocalRemoteControlState = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[4], false, seps) : null;
            AlertLevel = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[5], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 6, Configuration.FieldSeparator),
                                Id,
                                EquipmentInstanceIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, EquipmentInstanceIdentifier.Select(x => x.ToDelimitedString())) : null,
                                EventDateTime?.ToHl7DateTimeString(typeof(EquSegment), nameof(EventDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                EquipmentState?.ToDelimitedString(),
                                LocalRemoteControlState?.ToDelimitedString(),
                                AlertLevel?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
