using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V281.Types
{
    /// <summary>
    /// HL7 Version 2 CSU - Channel Sensitivity And Units.
    /// </summary>
    public class ChannelSensitivityAndUnits : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelSensitivityAndUnits"/> class.
        /// </summary>
        public ChannelSensitivityAndUnits()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelSensitivityAndUnits"/> class.
        /// </summary>
        /// <param name="channelSensitivity">CSU.1 - Channel Sensitivity.</param>
        public ChannelSensitivityAndUnits(decimal channelSensitivity)
        {
            ChannelSensitivity = channelSensitivity;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// CSU.1 - Channel Sensitivity.
        /// </summary>
        public decimal? ChannelSensitivity { get; set; }

        /// <summary>
        /// CSU.2 - Unit of Measure Identifier.
        /// </summary>
        public string UnitOfMeasureIdentifier { get; set; }

        /// <summary>
        /// CSU.3 - Unit of Measure Description.
        /// </summary>
        public string UnitOfMeasureDescription { get; set; }

        /// <summary>
        /// CSU.4 - Unit of Measure Coding System.
        /// <para>Suggested: 0396 Coding System -&gt; ClearHl7.Codes.V281.CodeCodingSystem</para>
        /// </summary>
        public string UnitOfMeasureCodingSystem { get; set; }

        /// <summary>
        /// CSU.5 - Alternate Unit of Measure Identifier.
        /// </summary>
        public string AlternateUnitOfMeasureIdentifier { get; set; }

        /// <summary>
        /// CSU.6 - Alternate Unit of Measure Description.
        /// </summary>
        public string AlternateUnitOfMeasureDescription { get; set; }

        /// <summary>
        /// CSU.7 - Alternate Unit of Measure Coding System.
        /// <para>Suggested: 0396 Coding System -&gt; ClearHl7.Codes.V281.CodeCodingSystem</para>
        /// </summary>
        public string AlternateUnitOfMeasureCodingSystem { get; set; }

        /// <summary>
        /// CSU.8 - Unit of Measure Coding System Version ID.
        /// </summary>
        public string UnitOfMeasureCodingSystemVersionId { get; set; }

        /// <summary>
        /// CSU.9 - Alternate Unit of Measure Coding System Version ID.
        /// </summary>
        public string AlternateUnitOfMeasureCodingSystemVersionId { get; set; }

        /// <summary>
        /// CSU.10 - Original Text.
        /// </summary>
        public string OriginalText { get; set; }

        /// <summary>
        /// CSU.11 - Second Alternate Unit of Measure Identifier.
        /// </summary>
        public string SecondAlternateUnitOfMeasureIdentifier { get; set; }

        /// <summary>
        /// CSU.12 - Second Alternate Unit of Measure Text.
        /// </summary>
        public string SecondAlternateUnitOfMeasureText { get; set; }

        /// <summary>
        /// CSU.13 - Name of Second Alternate Unit of Measure Coding System.
        /// <para>Suggested: 0396 Coding System -&gt; ClearHl7.Codes.V281.CodeCodingSystem</para>
        /// </summary>
        public string NameOfSecondAlternateUnitOfMeasureCodingSystem { get; set; }

        /// <summary>
        /// CSU.14 - Second Alternate Unit of Measure Coding System Version ID.
        /// </summary>
        public string SecondAlternateUnitOfMeasureCodingSystemVersionId { get; set; }

        /// <summary>
        /// CSU.15 - Unit of Measure Coding System OID.
        /// </summary>
        public string UnitOfMeasureCodingSystemOid { get; set; }

        /// <summary>
        /// CSU.16 - Unit of Measure Value Set OID.
        /// </summary>
        public string UnitOfMeasureValueSetOid { get; set; }

        /// <summary>
        /// CSU.17 - Unit of MeasureValue Set Version ID.
        /// </summary>
        public DateTime? UnitOfMeasureValueSetVersionId { get; set; }

        /// <summary>
        /// CSU.18 - Alternate Unit of Measure Coding System OID.
        /// </summary>
        public string AlternateUnitOfMeasureCodingSystemOid { get; set; }

        /// <summary>
        /// CSU.19 - Alternate Unit of Measure Value Set OID.
        /// </summary>
        public string AlternateUnitOfMeasureValueSetOid { get; set; }

        /// <summary>
        /// CSU.20 - Alternate Unit of Measure Value Set Version ID.
        /// </summary>
        public DateTime? AlternateUnitOfMeasureValueSetVersionId { get; set; }

        /// <summary>
        /// CSU.21 - Alternate Unit of Measure Coding System OID.
        /// </summary>
        public string AlternateUnitOfMeasureCodingSystemOidAdditional { get; set; }

        /// <summary>
        /// CSU.22 - Alternate Unit of Measure Value Set OID.
        /// </summary>
        public string AlternateUnitOfMeasureValueSetOidAdditional { get; set; }

        /// <summary>
        /// CSU.23 - Alternate Unit of Measure Value Set Version ID.
        /// </summary>
        public string AlternateUnitOfMeasureValueSetVersionIdAdditional { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(separator, StringSplitOptions.None);

            ChannelSensitivity = segments.Length > 0 && segments[0].Length > 0 ? segments[0].ToNullableDecimal() : null;
            UnitOfMeasureIdentifier = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            UnitOfMeasureDescription = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            UnitOfMeasureCodingSystem = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            AlternateUnitOfMeasureIdentifier = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            AlternateUnitOfMeasureDescription = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            AlternateUnitOfMeasureCodingSystem = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            UnitOfMeasureCodingSystemVersionId = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            AlternateUnitOfMeasureCodingSystemVersionId = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            OriginalText = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            SecondAlternateUnitOfMeasureIdentifier = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            SecondAlternateUnitOfMeasureText = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            NameOfSecondAlternateUnitOfMeasureCodingSystem = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            SecondAlternateUnitOfMeasureCodingSystemVersionId = segments.Length > 13 && segments[13].Length > 0 ? segments[13] : null;
            UnitOfMeasureCodingSystemOid = segments.Length > 14 && segments[14].Length > 0 ? segments[14] : null;
            UnitOfMeasureValueSetOid = segments.Length > 15 && segments[15].Length > 0 ? segments[15] : null;
            UnitOfMeasureValueSetVersionId = segments.Length > 16 && segments[16].Length > 0 ? segments[16].ToNullableDateTime() : null;
            AlternateUnitOfMeasureCodingSystemOid = segments.Length > 17 && segments[17].Length > 0 ? segments[17] : null;
            AlternateUnitOfMeasureValueSetOid = segments.Length > 18 && segments[18].Length > 0 ? segments[18] : null;
            AlternateUnitOfMeasureValueSetVersionId = segments.Length > 19 && segments[19].Length > 0 ? segments[19].ToNullableDateTime() : null;
            AlternateUnitOfMeasureCodingSystemOidAdditional = segments.Length > 20 && segments[20].Length > 0 ? segments[20] : null;
            AlternateUnitOfMeasureValueSetOidAdditional = segments.Length > 21 && segments[21].Length > 0 ? segments[21] : null;
            AlternateUnitOfMeasureValueSetVersionIdAdditional = segments.Length > 22 && segments[22].Length > 0 ? segments[22] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 23, separator),
                                ChannelSensitivity.HasValue ? ChannelSensitivity.Value.ToString(Consts.NumericFormat, culture) : null,
                                UnitOfMeasureIdentifier,
                                UnitOfMeasureDescription,
                                UnitOfMeasureCodingSystem,
                                AlternateUnitOfMeasureIdentifier,
                                AlternateUnitOfMeasureDescription,
                                AlternateUnitOfMeasureCodingSystem,
                                UnitOfMeasureCodingSystemVersionId,
                                AlternateUnitOfMeasureCodingSystemVersionId,
                                OriginalText,
                                SecondAlternateUnitOfMeasureIdentifier,
                                SecondAlternateUnitOfMeasureText,
                                NameOfSecondAlternateUnitOfMeasureCodingSystem,
                                SecondAlternateUnitOfMeasureCodingSystemVersionId,
                                UnitOfMeasureCodingSystemOid,
                                UnitOfMeasureValueSetOid,
                                UnitOfMeasureValueSetVersionId?.ToHl7DateTimeString(typeof(ChannelSensitivityAndUnits), nameof(UnitOfMeasureValueSetVersionId), Consts.DateFormatPrecisionDay, culture),
                                AlternateUnitOfMeasureCodingSystemOid,
                                AlternateUnitOfMeasureValueSetOid,
                                AlternateUnitOfMeasureValueSetVersionId?.ToHl7DateTimeString(typeof(ChannelSensitivityAndUnits), nameof(AlternateUnitOfMeasureValueSetVersionId), Consts.DateFormatPrecisionDay, culture),
                                AlternateUnitOfMeasureCodingSystemOidAdditional,
                                AlternateUnitOfMeasureValueSetOidAdditional,
                                AlternateUnitOfMeasureValueSetVersionIdAdditional
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
