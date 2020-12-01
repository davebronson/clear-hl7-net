using ClearHl7.Fhir.Helpers;

namespace ClearHl7.Fhir.V271.Types
{
    /// <summary>
    /// HL7 Version 2 DTN - Day Type And Number.
    /// </summary>
    public class DayTypeAndNumber : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// DTN.1 - Day Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0149</remarks>
        public CodedWithExceptions DayType { get; set; }

        /// <summary>
        /// DTN.2 - Number of Days.
        /// </summary>
        public decimal? NumberOfDays { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            char separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                DayType?.ToDelimitedString(),
                                NumberOfDays.HasValue ? NumberOfDays.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(separator);
        }
    }
}
