using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V270.Types
{
    /// <summary>
    /// HL7 Version 2 PRL - Parent Result Link.
    /// </summary>
    public class ParentResultLink : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParentResultLink"/> class.
        /// </summary>
        public ParentResultLink()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParentResultLink"/> class.
        /// </summary>
        /// <param name="parentObservationIdentifier">PRL.1 - Parent Observation Identifier.</param>
        public ParentResultLink(CodedWithExceptions parentObservationIdentifier)
        {
            ParentObservationIdentifier = parentObservationIdentifier;
        }

        /// <inheritdoc/>
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

            ParentObservationIdentifier = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[0], true, seps) : null;
            ParentObservationSubIdentifier = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            ParentObservationValueDescriptor = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[2], true, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
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
