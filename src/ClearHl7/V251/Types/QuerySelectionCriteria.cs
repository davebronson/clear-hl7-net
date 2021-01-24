using ClearHl7.Helpers;

namespace ClearHl7.V251.Types
{
    /// <summary>
    /// HL7 Version 2 QSC - Query Selection Criteria.
    /// </summary>
    public class QuerySelectionCriteria : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// QSC.1 - Segment Field Name.
        /// </summary>
        public string SegmentFieldName { get; set; }

        /// <summary>
        /// QSC.2 - Relational Operator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0209</remarks>
        public string RelationalOperator { get; set; }

        /// <summary>
        /// QSC.3 - Value.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// QSC.4 - Relational Conjunction.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0210</remarks>
        public string RelationalConjunction { get; set; }

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
                                StringHelper.StringFormatSequence(0, 4, separator),
                                SegmentFieldName,
                                RelationalOperator,
                                Value,
                                RelationalConjunction
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
