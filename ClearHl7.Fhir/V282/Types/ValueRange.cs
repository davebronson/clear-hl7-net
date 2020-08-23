using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 VR - Value Range.
    /// </summary>
    public class ValueRange
    {
        /// <summary>
        /// VR.1 - First Data Code Value.
        /// </summary>
        public string FirstDataCodeValue { get; set; }

        /// <summary>
        /// VR.2 - Last Data Code Value.
        /// </summary>
        public string LastDataCodeValue { get; set; }
    }
}
