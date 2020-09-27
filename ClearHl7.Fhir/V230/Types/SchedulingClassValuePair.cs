using System;

namespace ClearHl7.Fhir.V230.Types
{
    /// <summary>
    /// HL7 Version 2 SCV - Scheduling Class Value Pair.
    /// </summary>
    public class SchedulingClassValuePair : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// SCV.1 - Parameter Class.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0294</remarks>
        public string ParameterClass { get; set; }

        /// <summary>
        /// SCV.2 - Parameter Value.
        /// </summary>
        public string ParameterValue { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}" : "{0}^{1}",
                                ParameterClass,
                                ParameterValue
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
