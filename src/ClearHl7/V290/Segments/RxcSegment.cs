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
    /// HL7 Version 2 Segment RXC - Pharmacy Treatment Component Order.
    /// </summary>
    public class RxcSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RxcSegment"/> class.
        /// </summary>
        public RxcSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RxcSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public RxcSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "RXC";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// RXC.1 - RX Component Type.
        /// <para>Suggested: 0166 RX Component Type -&gt; ClearHl7.Codes.V290.CodeRXComponentType</para>
        /// </summary>
        public string RxComponentType { get; set; }

        /// <summary>
        /// RXC.2 - Component Code.
        /// <para>Suggested: 0697 Component Code</para>
        /// </summary>
        public CodedWithExceptions ComponentCode { get; set; }

        /// <summary>
        /// RXC.3 - Component Amount.
        /// </summary>
        public decimal? ComponentAmount { get; set; }

        /// <summary>
        /// RXC.4 - Component Units.
        /// <para>Suggested: 0698 Component Units</para>
        /// </summary>
        public CodedWithExceptions ComponentUnits { get; set; }

        /// <summary>
        /// RXC.5 - Component Strength.
        /// </summary>
        public decimal? ComponentStrength { get; set; }

        /// <summary>
        /// RXC.6 - Component Strength Units.
        /// <para>Suggested: 0699 Component Strength Units</para>
        /// </summary>
        public CodedWithExceptions ComponentStrengthUnits { get; set; }

        /// <summary>
        /// RXC.7 - Supplementary Code.
        /// <para>Suggested: 0700 Supplementary Code</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> SupplementaryCode { get; set; }

        /// <summary>
        /// RXC.8 - Component Drug Strength Volume.
        /// </summary>
        public decimal? ComponentDrugStrengthVolume { get; set; }

        /// <summary>
        /// RXC.9 - Component Drug Strength Volume Units.
        /// <para>Suggested: 0701 Component Drug Strength Volume Units</para>
        /// </summary>
        public CodedWithExceptions ComponentDrugStrengthVolumeUnits { get; set; }

        /// <summary>
        /// RXC.10 - Dispense Amount.
        /// </summary>
        public decimal? DispenseAmount { get; set; }

        /// <summary>
        /// RXC.11 - Dispense Units.
        /// <para>Suggested: 0703 Dispense Units</para>
        /// </summary>
        public CodedWithExceptions DispenseUnits { get; set; }

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

            RxComponentType = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            ComponentCode = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            ComponentAmount = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDecimal() : null;
            ComponentUnits = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[4], false, seps) : null;
            ComponentStrength = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDecimal() : null;
            ComponentStrengthUnits = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[6], false, seps) : null;
            SupplementaryCode = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            ComponentDrugStrengthVolume = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDecimal() : null;
            ComponentDrugStrengthVolumeUnits = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[9], false, seps) : null;
            DispenseAmount = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDecimal() : null;
            DispenseUnits = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[11], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 12, Configuration.FieldSeparator),
                                Id,
                                RxComponentType,
                                ComponentCode?.ToDelimitedString(),
                                ComponentAmount.HasValue ? ComponentAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                ComponentUnits?.ToDelimitedString(),
                                ComponentStrength.HasValue ? ComponentStrength.Value.ToString(Consts.NumericFormat, culture) : null,
                                ComponentStrengthUnits?.ToDelimitedString(),
                                SupplementaryCode != null ? string.Join(Configuration.FieldRepeatSeparator, SupplementaryCode.Select(x => x.ToDelimitedString())) : null,
                                ComponentDrugStrengthVolume.HasValue ? ComponentDrugStrengthVolume.Value.ToString(Consts.NumericFormat, culture) : null,
                                ComponentDrugStrengthVolumeUnits?.ToDelimitedString(),
                                DispenseAmount.HasValue ? DispenseAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                DispenseUnits?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
