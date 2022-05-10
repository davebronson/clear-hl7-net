using System;
using System.Globalization;
using ClearHl7.Helpers;

namespace ClearHl7.V251.Types
{
    /// <summary>
    /// HL7 Version 2 QIP - Query Input Parameter List.
    /// </summary>
    public class QueryInputParameterList : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryInputParameterList"/> class.
        /// </summary>
        public QueryInputParameterList()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryInputParameterList"/> class.
        /// </summary>
        /// <param name="segmentFieldName">QIP.1 - Segment Field Name.</param>
        /// <param name="values">QIP.2 - Values.</param>
        public QueryInputParameterList(string segmentFieldName, string values)
        {
            SegmentFieldName = segmentFieldName;
            Values = values;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// QIP.1 - Segment Field Name.
        /// </summary>
        public string SegmentFieldName { get; set; }

        /// <summary>
        /// QIP.2 - Values.
        /// </summary>
        public string Values { get; set; }

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
            Values = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                SegmentFieldName,
                                Values
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
