using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 RFR - Reference Range.
    /// </summary>
    public class ReferenceRange
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// RFR.1 - Numeric Range.
        /// </summary>
        public NumericRange NumericRange { get; set; }

        /// <summary>
        /// RFR.2 - Administrative Sex.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0001</remarks>
        public CodedWithExceptions AdministrativeSex { get; set; }

        /// <summary>
        /// RFR.3 - Age Range.
        /// </summary>
        public NumericRange AgeRange { get; set; }

        /// <summary>
        /// RFR.4 - Gestational Age Range.
        /// </summary>
        public NumericRange GestationalAgeRange { get; set; }

        /// <summary>
        /// RFR.5 - Species.
        /// </summary>
        public string Species { get; set; }

        /// <summary>
        /// RFR.6 - Race/subspecies.
        /// </summary>
        public string RaceSubspecies { get; set; }

        /// <summary>
        /// RFR.7 - Conditions.
        /// </summary>
        public string Conditions { get; set; }
    }
}
