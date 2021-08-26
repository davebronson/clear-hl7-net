﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SHP - Shipment.
    /// </summary>
    public class ShpSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "SHP";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// SHP.1 - Shipment ID.
        /// </summary>
        public EntityIdentifier ShipmentId { get; set; }

        /// <summary>
        /// SHP.2 - Internal Shipment ID.
        /// </summary>
        public IEnumerable<EntityIdentifier> InternalShipmentId { get; set; }

        /// <summary>
        /// SHP.3 - Shipment Status.
        /// <para>Suggested: 0905 Shipment Status -&gt; ClearHl7.Codes.V271.CodeShipmentStatus</para>
        /// </summary>
        public CodedWithExceptions ShipmentStatus { get; set; }

        /// <summary>
        /// SHP.4 - Shipment Status Date/Time.
        /// </summary>
        public DateTime? ShipmentStatusDateTime { get; set; }

        /// <summary>
        /// SHP.5 - Shipment Status Reason.
        /// </summary>
        public Text ShipmentStatusReason { get; set; }

        /// <summary>
        /// SHP.6 - Shipment Priority.
        /// <para>Suggested: 0906 ActPriority -&gt; ClearHl7.Codes.V271.CodeActPriority</para>
        /// </summary>
        public CodedWithExceptions ShipmentPriority { get; set; }

        /// <summary>
        /// SHP.7 - Shipment Confidentiality.
        /// <para>Suggested: 0907 Confidentiality -&gt; ClearHl7.Codes.V271.CodeConfidentiality</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ShipmentConfidentiality { get; set; }

        /// <summary>
        /// SHP.8 - Number of Packages in Shipment.
        /// </summary>
        public decimal? NumberOfPackagesInShipment { get; set; }

        /// <summary>
        /// SHP.9 - Shipment Condition.
        /// <para>Suggested: 0544 Container Condition -&gt; ClearHl7.Codes.V271.CodeContainerCondition</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ShipmentCondition { get; set; }

        /// <summary>
        /// SHP.10 - Shipment Handling Code.
        /// <para>Suggested: 0376 Special Handling Code -&gt; ClearHl7.Codes.V271.CodeSpecialHandlingCode</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ShipmentHandlingCode { get; set; }

        /// <summary>
        /// SHP.11 - Shipment Risk Code.
        /// <para>Suggested: 0489 Risk Codes -&gt; ClearHl7.Codes.V271.CodeRiskCodes</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ShipmentRiskCode { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        internal void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);
            
            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ShipmentId = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[1], false) : null;
            InternalShipmentId = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<EntityIdentifier>(x, false)) : null;
            ShipmentStatus = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[3], false) : null;
            ShipmentStatusDateTime = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            ShipmentStatusReason = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<Text>(segments[5], false) : null;
            ShipmentPriority = segments.Length > 6 && segments[6].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[6], false) : null;
            ShipmentConfidentiality = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            NumberOfPackagesInShipment = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDecimal() : null;
            ShipmentCondition = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            ShipmentHandlingCode = segments.Length > 10 && segments[10].Length > 0 ? segments[10].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            ShipmentRiskCode = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
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
                                StringHelper.StringFormatSequence(0, 12, Configuration.FieldSeparator),
                                Id,
                                ShipmentId?.ToDelimitedString(),
                                InternalShipmentId != null ? string.Join(Configuration.FieldRepeatSeparator, InternalShipmentId.Select(x => x.ToDelimitedString())) : null,
                                ShipmentStatus?.ToDelimitedString(),
                                ShipmentStatusDateTime.HasValue ? ShipmentStatusDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ShipmentStatusReason?.ToDelimitedString(),
                                ShipmentPriority?.ToDelimitedString(),
                                ShipmentConfidentiality != null ? string.Join(Configuration.FieldRepeatSeparator, ShipmentConfidentiality.Select(x => x.ToDelimitedString())) : null,
                                NumberOfPackagesInShipment.HasValue ? NumberOfPackagesInShipment.Value.ToString(Consts.NumericFormat, culture) : null,
                                ShipmentCondition != null ? string.Join(Configuration.FieldRepeatSeparator, ShipmentCondition.Select(x => x.ToDelimitedString())) : null,
                                ShipmentHandlingCode != null ? string.Join(Configuration.FieldRepeatSeparator, ShipmentHandlingCode.Select(x => x.ToDelimitedString())) : null,
                                ShipmentRiskCode != null ? string.Join(Configuration.FieldRepeatSeparator, ShipmentRiskCode.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}