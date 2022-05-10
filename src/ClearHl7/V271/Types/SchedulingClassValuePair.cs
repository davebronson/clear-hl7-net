using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V271.Types
{
    /// <summary>
    /// HL7 Version 2 SCV - Scheduling Class Value Pair.
    /// </summary>
    public class SchedulingClassValuePair : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulingClassValuePair"/> class.
        /// </summary>
        public SchedulingClassValuePair()
        {

        }

        /// <inheritdoc/>
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

            ParameterClass = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[0], true, seps) : null;
            ParameterValue = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
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
