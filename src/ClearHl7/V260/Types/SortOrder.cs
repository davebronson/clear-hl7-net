using ClearHl7.Helpers;

namespace ClearHl7.V260.Types
{
    /// <summary>
    /// HL7 Version 2 SRT - Sort Order.
    /// </summary>
    public class SortOrder : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// SRT.1 - Sort-by Field.
        /// </summary>
        public string SortByField { get; set; }

        /// <summary>
        /// SRT.2 - Sequencing.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0397</remarks>
        public string Sequencing { get; set; }

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
                                StringHelper.StringFormatSequence(0, 2, separator),
                                SortByField,
                                Sequencing
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
