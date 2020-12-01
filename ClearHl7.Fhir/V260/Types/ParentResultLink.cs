using ClearHl7.Fhir.Helpers;

namespace ClearHl7.Fhir.V260.Types
{
    /// <summary>
    /// HL7 Version 2 PRL - Parent Result Link.
    /// </summary>
    public class ParentResultLink : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// PRL.1 - Parent Observation Identifier.
        /// </summary>
        public CodedWithExceptions ParentObservationIdentifier { get; set; }

        /// <summary>
        /// PRL.2 - Parent Observation Sub-identifier.
        /// </summary>
        public string ParentObservationSubIdentifier { get; set; }

        /// <summary>
        /// PRL.3 - Parent Observation Value Descriptor.
        /// </summary>
        public Text ParentObservationValueDescriptor { get; set; }

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
                                ParentObservationIdentifier?.ToDelimitedString(),
                                ParentObservationSubIdentifier,
                                ParentObservationValueDescriptor?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
