using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V260.Types
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
        /// <para>Suggested: 0396 Coding System -&gt; ClearHl7.Codes.V260.CodeCodingSystem</para>
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
        /// <para>Suggested: 0396 Coding System -&gt; ClearHl7.Codes.V260.CodeCodingSystem</para>
        /// </summary>
        public string AlternateUnitOfMeasureCodingSystem { get; set; }

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
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 7, separator),
                                ChannelSensitivity.HasValue ? ChannelSensitivity.Value.ToString(Consts.NumericFormat, culture) : null,
                                UnitOfMeasureIdentifier,
                                UnitOfMeasureDescription,
                                UnitOfMeasureCodingSystem,
                                AlternateUnitOfMeasureIdentifier,
                                AlternateUnitOfMeasureDescription,
                                AlternateUnitOfMeasureCodingSystem
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
