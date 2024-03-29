﻿namespace ClearHl7.Codes.V290
{
    /// <summary>
    /// HL7 Version 2 Table 0103 - Processing ID.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0103</remarks>
    public enum CodeProcessingId
    {
        /// <summary>
        /// D - Debugging.
        /// </summary>
        Debugging,

        /// <summary>
        /// N - Non-Production Testing.
        /// </summary>
        NonProductionTesting,

        /// <summary>
        /// P - Production.
        /// </summary>
        Production,

        /// <summary>
        /// T - Training.
        /// </summary>
        Training,

        /// <summary>
        /// V - Validation.
        /// </summary>
        Validation
    }
}
