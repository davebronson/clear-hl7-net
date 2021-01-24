﻿using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0365</remarks>
        public CodedWithExceptions EquipmentState { get; set; }

        /// <summary>
        /// EQU.4 - Local/Remote Control State.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0366</remarks>
        public CodedWithExceptions LocalRemoteControlState { get; set; }

        /// <summary>
        /// EQU.5 - Alert Level.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0367</remarks>
        public CodedWithExceptions AlertLevel { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 6, Configuration.FieldSeparator),
                                Id,
                                EquipmentInstanceIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, EquipmentInstanceIdentifier.Select(x => x.ToDelimitedString())) : null,
                                EventDateTime.HasValue ? EventDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EquipmentState?.ToDelimitedString(),
                                LocalRemoteControlState?.ToDelimitedString(),
                                AlertLevel?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}