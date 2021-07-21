using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V251.Types
{
    /// <summary>
    /// HL7 Version 2 CSU - Channel Sensitivity And Units.
    /// </summary>
    public class ChannelSensitivityAndUnits : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
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
        /// <para>Suggested: 0396 Coding System -&gt; ClearHl7.Codes.V251.CodeCodingSystem</para>
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
        /// <para>Suggested: 0396 Coding System -&gt; ClearHl7.Codes.V251.CodeCodingSystem</para>
        /// </summary>
        public string AlternateUnitOfMeasureCodingSystem { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            ChannelSensitivity = segments.ElementAtOrDefault(0)?.ToNullableDecimal();
            UnitOfMeasureIdentifier = segments.ElementAtOrDefault(1);
            UnitOfMeasureDescription = segments.ElementAtOrDefault(2);
            UnitOfMeasureCodingSystem = segments.ElementAtOrDefault(3);
            AlternateUnitOfMeasureIdentifier = segments.ElementAtOrDefault(4);
            AlternateUnitOfMeasureDescription = segments.ElementAtOrDefault(5);
            AlternateUnitOfMeasureCodingSystem = segments.ElementAtOrDefault(6);
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
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
