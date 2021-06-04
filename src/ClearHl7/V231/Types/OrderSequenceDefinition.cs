using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V231.Types
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
        /// </summary>
        public string SequenceResultsFlag { get; set; }

        /// <summary>
        /// OSD.2 - Placer Order Number: Entity Identifier.
        /// </summary>
        public string PlacerOrderNumberEntityIdentifier { get; set; }

        /// <summary>
        /// OSD.3 - Placer Order Number: Namespace ID.
        /// </summary>
        public string PlacerOrderNumberNamespaceId { get; set; }

        /// <summary>
        /// OSD.4 - Filler Order Number: Entity Identifier.
        /// </summary>
        public string FillerOrderNumberEntityIdentifier { get; set; }

        /// <summary>
        /// OSD.5 - Filler Order Number: Namespace ID.
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
        /// </summary>
        public string PlacerOrderNumberUniversalIdType { get; set; }

        /// <summary>
        /// OSD.10 - Filler Order Number: Universal ID.
        /// </summary>
        public string FillerOrderNumberUniversalId { get; set; }

        /// <summary>
        /// OSD.11 - Filler Order Number: Universal ID Type.
        /// </summary>
        public string FillerOrderNumberUniversalIdType { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public OrderSequenceDefinition FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            SequenceResultsFlag = segments.ElementAtOrDefault(0);
            PlacerOrderNumberEntityIdentifier = segments.ElementAtOrDefault(1);
            PlacerOrderNumberNamespaceId = segments.ElementAtOrDefault(2);
            FillerOrderNumberEntityIdentifier = segments.ElementAtOrDefault(3);
            FillerOrderNumberNamespaceId = segments.ElementAtOrDefault(4);
            SequenceConditionValue = segments.ElementAtOrDefault(5);
            MaximumNumberOfRepeats = segments.ElementAtOrDefault(6)?.ToNullableDecimal();
            PlacerOrderNumberUniversalId = segments.ElementAtOrDefault(7);
            PlacerOrderNumberUniversalIdType = segments.ElementAtOrDefault(8);
            FillerOrderNumberUniversalId = segments.ElementAtOrDefault(9);
            FillerOrderNumberUniversalIdType = segments.ElementAtOrDefault(10);

            return this;
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
