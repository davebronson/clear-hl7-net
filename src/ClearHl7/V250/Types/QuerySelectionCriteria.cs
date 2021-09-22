using System;
using ClearHl7.Helpers;

namespace ClearHl7.V250.Types
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
        /// <para>Suggested: 0209 Relational Operator -&gt; ClearHl7.Codes.V250.CodeRelationalOperator</para>
        /// </summary>
        public string RelationalOperator { get; set; }

        /// <summary>
        /// QSC.3 - Value.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// QSC.4 - Relational Conjunction.
        /// <para>Suggested: 0210 Relational Conjunction -&gt; ClearHl7.Codes.V250.CodeRelationalConjunction</para>
        /// </summary>
        public string RelationalConjunction { get; set; }

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

            SegmentFieldName = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            RelationalOperator = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            Value = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            RelationalConjunction = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
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
                                StringHelper.StringFormatSequence(0, 4, separator),
                                SegmentFieldName,
                                RelationalOperator,
                                Value,
                                RelationalConjunction
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
