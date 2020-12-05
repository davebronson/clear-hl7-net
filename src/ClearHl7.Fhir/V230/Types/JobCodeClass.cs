using ClearHl7.Fhir.Helpers;

namespace ClearHl7.Fhir.V230.Types
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0327</remarks>
        public string JobCode { get; set; }

        /// <summary>
        /// JCC.2 - Job Class.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0328</remarks>
        public string JobClass { get; set; }

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
                                JobCode,
                                JobClass
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
