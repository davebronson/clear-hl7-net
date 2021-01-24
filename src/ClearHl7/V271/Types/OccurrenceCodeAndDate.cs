using System;
using ClearHl7.Helpers;

namespace ClearHl7.V271.Types
{
    /// <summary>
    /// HL7 Version 2 OCD - Occurrence Code And Date.
    /// </summary>
    public class OccurrenceCodeAndDate : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// OCD.1 - Occurrence Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0350</remarks>
        public CodedWithNoExceptions OccurrenceCode { get; set; }

        /// <summary>
        /// OCD.2 - Occurrence Date.
        /// </summary>
        public DateTime? OccurrenceDate { get; set; }

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
                                OccurrenceCode?.ToDelimitedString(),
                                OccurrenceDate.HasValue ? OccurrenceDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
