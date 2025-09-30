using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SHP - Shipment.
    /// </summary>
    public class ShpSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShpSegment"/> class.
        /// </summary>
        public ShpSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShpSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public ShpSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "SHP";

        /// <inheritdoc/>
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
        /// <para>Suggested: 0905 Shipment Status -&gt; ClearHl7.Codes.V290.CodeShipmentStatus</para>
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
        /// <para>Suggested: 0906 ActPriority -&gt; ClearHl7.Codes.V290.CodeActPriority</para>
        /// </summary>
        public CodedWithExceptions ShipmentPriority { get; set; }

        /// <summary>
        /// SHP.7 - Shipment Confidentiality.
        /// <para>Suggested: 0907 Confidentiality -&gt; ClearHl7.Codes.V290.CodeConfidentiality</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ShipmentConfidentiality { get; set; }

        /// <summary>
        /// SHP.8 - Number of Packages in Shipment.
        /// </summary>
        public decimal? NumberOfPackagesInShipment { get; set; }

        /// <summary>
        /// SHP.9 - Shipment Condition.
        /// <para>Suggested: 0544 Container Condition -&gt; ClearHl7.Codes.V290.CodeContainerCondition</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ShipmentCondition { get; set; }

        /// <summary>
        /// SHP.10 - Shipment Handling Code.
        /// <para>Suggested: 0376 Special Handling Code -&gt; ClearHl7.Codes.V290.CodeSpecialHandlingCode</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ShipmentHandlingCode { get; set; }

        /// <summary>
        /// SHP.11 - Shipment Risk Code.
        /// <para>Suggested: 0489 Risk Codes -&gt; ClearHl7.Codes.V290.CodeRiskCodes</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ShipmentRiskCode { get; set; }

        /// <summary>
        /// SHP.12 - Action Code.
        /// </summary>
        public string ActionCode { get; set; }

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

            ShipmentId = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[1], false, seps) : null;
            InternalShipmentId = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<EntityIdentifier>(x, false, seps)) : null;
            ShipmentStatus = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[3], false, seps) : null;
            ShipmentStatusDateTime = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            ShipmentStatusReason = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[5], false, seps) : null;
            ShipmentPriority = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[6], false, seps) : null;
            ShipmentConfidentiality = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            NumberOfPackagesInShipment = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDecimal() : null;
            ShipmentCondition = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            ShipmentHandlingCode = segments.Length > 10 && segments[10].Length > 0 ? segments[10].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            ShipmentRiskCode = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            ActionCode = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 13, Configuration.FieldSeparator),
                                Id,
                                ShipmentId?.ToDelimitedString(),
                                InternalShipmentId != null ? string.Join(Configuration.FieldRepeatSeparator, InternalShipmentId.Select(x => x.ToDelimitedString())) : null,
                                ShipmentStatus?.ToDelimitedString(),
                                ShipmentStatusDateTime?.ToHl7DateTimeString(typeof(ShpSegment), nameof(ShipmentStatusDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                ShipmentStatusReason?.ToDelimitedString(),
                                ShipmentPriority?.ToDelimitedString(),
                                ShipmentConfidentiality != null ? string.Join(Configuration.FieldRepeatSeparator, ShipmentConfidentiality.Select(x => x.ToDelimitedString())) : null,
                                NumberOfPackagesInShipment.HasValue ? NumberOfPackagesInShipment.Value.ToString(Consts.NumericFormat, culture) : null,
                                ShipmentCondition != null ? string.Join(Configuration.FieldRepeatSeparator, ShipmentCondition.Select(x => x.ToDelimitedString())) : null,
                                ShipmentHandlingCode != null ? string.Join(Configuration.FieldRepeatSeparator, ShipmentHandlingCode.Select(x => x.ToDelimitedString())) : null,
                                ShipmentRiskCode != null ? string.Join(Configuration.FieldRepeatSeparator, ShipmentRiskCode.Select(x => x.ToDelimitedString())) : null,
                                ActionCode
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
