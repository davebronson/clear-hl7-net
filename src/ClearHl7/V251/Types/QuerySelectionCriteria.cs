using System;
using System.Globalization;
using ClearHl7.Helpers;

namespace ClearHl7.V251.Types
{
    /// <summary>
    /// HL7 Version 2 QSC - Query Selection Criteria.
    /// </summary>
    public class QuerySelectionCriteria : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuerySelectionCriteria"/> class.
        /// </summary>
        public QuerySelectionCriteria()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuerySelectionCriteria"/> class.
        /// </summary>
        /// <param name="segmentFieldName">QSC.1 - Segment Field Name.</param>
        public QuerySelectionCriteria(string segmentFieldName)
        {
            SegmentFieldName = segmentFieldName;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// QSC.1 - Segment Field Name.
        /// </summary>
        public string SegmentFieldName { get; set; }

        /// <summary>
        /// QSC.2 - Relational Operator.
        /// <para>Suggested: 0209 Relational Operator -&gt; ClearHl7.Codes.V251.CodeRelationalOperator</para>
        /// </summary>
        public string RelationalOperator { get; set; }

        /// <summary>
        /// QSC.3 - Value.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// QSC.4 - Relational Conjunction.
        /// <para>Suggested: 0210 Relational Conjunction -&gt; ClearHl7.Codes.V251.CodeRelationalConjunction</para>
        /// </summary>
        public string RelationalConjunction { get; set; }

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

            SegmentFieldName = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            RelationalOperator = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            Value = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            RelationalConjunction = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
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
