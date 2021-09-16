using System;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V251.Types
{
    /// <summary>
    /// HL7 Version 2 OSD - Order Sequence Definition.
    /// </summary>
    public class OrderSequenceDefinition : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// OSD.1 - Sequence/Results Flag.
        /// <para>Suggested: 0524 Sequence Condition -&gt; ClearHl7.Codes.V251.CodeSequenceCondition</para>
        /// </summary>
        public string SequenceResultsFlag { get; set; }

        /// <summary>
        /// OSD.2 - Placer Order Number: Entity Identifier.
        /// </summary>
        public string PlacerOrderNumberEntityIdentifier { get; set; }

        /// <summary>
        /// OSD.3 - Placer Order Number: Namespace ID.
        /// <para>Suggested: 0363 Assigning Authority -&gt; ClearHl7.Codes.V251.CodeAssigningAuthority</para>
        /// </summary>
        public string PlacerOrderNumberNamespaceId { get; set; }

        /// <summary>
        /// OSD.4 - Filler Order Number: Entity Identifier.
        /// </summary>
        public string FillerOrderNumberEntityIdentifier { get; set; }

        /// <summary>
        /// OSD.5 - Filler Order Number: Namespace ID.
        /// <para>Suggested: 0363 Assigning Authority -&gt; ClearHl7.Codes.V251.CodeAssigningAuthority</para>
        /// </summary>
        public string FillerOrderNumberNamespaceId { get; set; }

        /// <summary>
        /// OSD.6 - Sequence Condition Value.
        /// </summary>
        public string SequenceConditionValue { get; set; }

        /// <summary>
        /// OSD.7 - Maximum Number of Repeats.
        /// </summary>
        public decimal? MaximumNumberOfRepeats { get; set; }

        /// <summary>
        /// OSD.8 - Placer Order Number: Universal ID.
        /// </summary>
        public string PlacerOrderNumberUniversalId { get; set; }

        /// <summary>
        /// OSD.9 - Placer Order Number: Universal ID Type.
        /// <para>Suggested: 0301 Universal ID Type -&gt; ClearHl7.Codes.V251.CodeUniversalIdType</para>
        /// </summary>
        public string PlacerOrderNumberUniversalIdType { get; set; }

        /// <summary>
        /// OSD.10 - Filler Order Number: Universal ID.
        /// </summary>
        public string FillerOrderNumberUniversalId { get; set; }

        /// <summary>
        /// OSD.11 - Filler Order Number: Universal ID Type.
        /// <para>Suggested: 0301 Universal ID Type -&gt; ClearHl7.Codes.V251.CodeUniversalIdType</para>
        /// </summary>
        public string FillerOrderNumberUniversalIdType { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(separator, StringSplitOptions.None);

            SequenceResultsFlag = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            PlacerOrderNumberEntityIdentifier = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            PlacerOrderNumberNamespaceId = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            FillerOrderNumberEntityIdentifier = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            FillerOrderNumberNamespaceId = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            SequenceConditionValue = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            MaximumNumberOfRepeats = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDecimal() : null;
            PlacerOrderNumberUniversalId = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            PlacerOrderNumberUniversalIdType = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            FillerOrderNumberUniversalId = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            FillerOrderNumberUniversalIdType = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
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
                                StringHelper.StringFormatSequence(0, 11, separator),
                                SequenceResultsFlag,
                                PlacerOrderNumberEntityIdentifier,
                                PlacerOrderNumberNamespaceId,
                                FillerOrderNumberEntityIdentifier,
                                FillerOrderNumberNamespaceId,
                                SequenceConditionValue,
                                MaximumNumberOfRepeats.HasValue ? MaximumNumberOfRepeats.Value.ToString(Consts.NumericFormat, culture) : null,
                                PlacerOrderNumberUniversalId,
                                PlacerOrderNumberUniversalIdType,
                                FillerOrderNumberUniversalId,
                                FillerOrderNumberUniversalIdType
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}