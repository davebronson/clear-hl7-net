using ClearHl7.Helpers;

namespace ClearHl7.V260.Types
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
        /// <para>Suggested: 0524 Sequence Condition</para>
        /// </summary>
        public string SequenceResultsFlag { get; set; }

        /// <summary>
        /// OSD.2 - Placer Order Number: Entity Identifier.
        /// </summary>
        public string PlacerOrderNumberEntityIdentifier { get; set; }

        /// <summary>
        /// OSD.3 - Placer Order Number: Namespace ID.
        /// <para>Suggested: 0363 Assigning Authority -&gt; ClearHl7.Codes.V260.CodeAssigningAuthority</para>
        /// </summary>
        public string PlacerOrderNumberNamespaceId { get; set; }

        /// <summary>
        /// OSD.4 - Filler Order Number: Entity Identifier.
        /// </summary>
        public string FillerOrderNumberEntityIdentifier { get; set; }

        /// <summary>
        /// OSD.5 - Filler Order Number: Namespace ID.
        /// <para>Suggested: 0363 Assigning Authority -&gt; ClearHl7.Codes.V260.CodeAssigningAuthority</para>
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
        /// <para>Suggested: 0301 Universal ID Type -&gt; ClearHl7.Codes.V260.CodeUniversalIdType</para>
        /// </summary>
        public string PlacerOrderNumberUniversalIdType { get; set; }

        /// <summary>
        /// OSD.10 - Filler Order Number: Universal ID.
        /// </summary>
        public string FillerOrderNumberUniversalId { get; set; }

        /// <summary>
        /// OSD.11 - Filler Order Number: Universal ID Type.
        /// <para>Suggested: 0301 Universal ID Type -&gt; ClearHl7.Codes.V260.CodeUniversalIdType</para>
        /// </summary>
        public string FillerOrderNumberUniversalIdType { get; set; }

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