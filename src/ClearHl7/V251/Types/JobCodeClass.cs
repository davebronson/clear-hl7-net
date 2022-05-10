using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V251.Types
{
    /// <summary>
    /// HL7 Version 2 JCC - Job Code Class.
    /// </summary>
    public class JobCodeClass : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobCodeClass"/> class.
        /// </summary>
        public JobCodeClass()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobCodeClass"/> class.
        /// </summary>
        /// <param name="jobCode">JCC.1 - Job Code.</param>
        public JobCodeClass(string jobCode)
        {
            JobCode = jobCode;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// JCC.1 - Job Code.
        /// <para>Suggested: 0327 Job Code</para>
        /// </summary>
        public string JobCode { get; set; }

        /// <summary>
        /// JCC.2 - Job Class.
        /// <para>Suggested: 0328 Job Class</para>
        /// </summary>
        public string JobClass { get; set; }

        /// <summary>
        /// JCC.3 - Job Description Text.
        /// </summary>
        public Text JobDescriptionText { get; set; }

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

            JobCode = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            JobClass = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            JobDescriptionText = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[2], true, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, separator),
                                JobCode,
                                JobClass,
                                JobDescriptionText?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
