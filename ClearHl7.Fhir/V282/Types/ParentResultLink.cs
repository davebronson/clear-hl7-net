using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 PRL - Parent Result Link.
    /// </summary>
    public class ParentResultLink
    {
        /// <summary>
        /// PRL.1 - Parent Observation Identifier.
        /// </summary>
        public CodedWithExceptions ParentObservationIdentifier { get; set; }

        /// <summary>
        /// PRL.2 - Parent Observation Sub-identifier.
        /// </summary>
        public ObservationGrouper ParentObservationSubIdentifier { get; set; }

        /// <summary>
        /// PRL.3 - Parent Observation Value Descriptor.
        /// </summary>
        public string ParentObservationValueDescriptor { get; set; }
    }
}
