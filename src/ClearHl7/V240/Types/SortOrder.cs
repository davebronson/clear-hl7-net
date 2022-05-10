using System;
using System.Globalization;
using ClearHl7.Helpers;

namespace ClearHl7.V240.Types
{
    /// <summary>
    /// HL7 Version 2 SRT - Sort Order.
    /// </summary>
    public class SortOrder : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SortOrder"/> class.
        /// </summary>
        public SortOrder()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortOrder"/> class.
        /// </summary>
        /// <param name="sortByField">SRT.1 - Sort-by Field.</param>
        public SortOrder(string sortByField)
        {
            SortByField = sortByField;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// SRT.1 - Sort-by Field.
        /// </summary>
        public string SortByField { get; set; }

        /// <summary>
        /// SRT.2 - Sequencing.
        /// <para>Suggested: 0397 Sequencing -&gt; ClearHl7.Codes.V240.CodeSequencing</para>
        /// </summary>
        public string Sequencing { get; set; }

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

            SortByField = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            Sequencing = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                SortByField,
                                Sequencing
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
