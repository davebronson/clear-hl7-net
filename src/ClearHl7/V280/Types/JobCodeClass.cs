using ClearHl7.Helpers;

namespace ClearHl7.V280.Types
{
    /// <summary>
    /// HL7 Version 2 JCC - Job Code Class.
    /// </summary>
    public class JobCodeClass : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// JCC.1 - Job Code.
        /// <para>Suggested: 0327 Job Code</para>
        /// </summary>
        public CodedWithExceptions JobCode { get; set; }

        /// <summary>
        /// JCC.2 - Job Class.
        /// <para>Suggested: 0328 Job Class</para>
        /// </summary>
        public CodedWithExceptions JobClass { get; set; }

        /// <summary>
        /// JCC.3 - Job Description Text.
        /// </summary>
        public Text JobDescriptionText { get; set; }

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
                                StringHelper.StringFormatSequence(0, 3, separator),
                                JobCode?.ToDelimitedString(),
                                JobClass?.ToDelimitedString(),
                                JobDescriptionText?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
