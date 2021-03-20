using ClearHl7.Helpers;

namespace ClearHl7.V271.Types
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
        /// <para>Suggested: 0294 Time Selection Criteria Parameter Class Codes -&gt; ClearHl7.Codes.V271.CodeTimeSelectionCriteriaParameterClassCodes</para>
        /// </summary>
        public CodedWithExceptions ParameterClass { get; set; }

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
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                ParameterClass?.ToDelimitedString(),
                                ParameterValue
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
