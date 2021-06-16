using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment EQU - Equipment Detail.
    /// </summary>
    public class EquSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "EQU";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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
        /// <para>Suggested: 0365 Equipment State -&gt; ClearHl7.Codes.V290.CodeEquipmentState</para>
        /// </summary>
        public CodedWithExceptions EquipmentState { get; set; }

        /// <summary>
        /// EQU.4 - Local/Remote Control State.
        /// <para>Suggested: 0366 Local/Remote Control State -&gt; ClearHl7.Codes.V290.CodeLocalRemoteControlState</para>
        /// </summary>
        public CodedWithExceptions LocalRemoteControlState { get; set; }

        /// <summary>
        /// EQU.5 - Alert Level.
        /// <para>Suggested: 0367 Alert Level -&gt; ClearHl7.Codes.V290.CodeAlertLevel</para>
        /// </summary>
        public CodedWithExceptions AlertLevel { get; set; }

        /// <summary>
        /// EQU.6 - Expected date/time of the next status change.
        /// </summary>
        public DateTime? ExpectedDateTimeOfTheNextStatusChange { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public EquSegment FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            EquipmentInstanceIdentifier = segments.Length > 1 ? segments.ElementAtOrDefault(1).Split(separator).Select(x => new EntityIdentifier().FromDelimitedString(x)) : null;
            EventDateTime = segments.ElementAtOrDefault(2)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            EquipmentState = segments.Length > 3 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(3)) : null;
            LocalRemoteControlState = segments.Length > 4 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(4)) : null;
            AlertLevel = segments.Length > 5 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(5)) : null;
            ExpectedDateTimeOfTheNextStatusChange = segments.ElementAtOrDefault(6)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            
            return this;
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
                                StringHelper.StringFormatSequence(0, 7, Configuration.FieldSeparator),
                                Id,
                                EquipmentInstanceIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, EquipmentInstanceIdentifier.Select(x => x.ToDelimitedString())) : null,
                                EventDateTime.HasValue ? EventDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EquipmentState?.ToDelimitedString(),
                                LocalRemoteControlState?.ToDelimitedString(),
                                AlertLevel?.ToDelimitedString(),
                                ExpectedDateTimeOfTheNextStatusChange.HasValue ? ExpectedDateTimeOfTheNextStatusChange.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}