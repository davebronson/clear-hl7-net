namespace ClearHl7.Codes.V231
{
    /// <summary>
    /// HL7 Version 2 Table 0174 - Nature Of Service/Test/Observation.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0174</remarks>
    public enum CodeNatureOfServiceTestObservation
    {
        /// <summary>
        /// A - Atomic service/test/observation (test code or treatment code).
        /// </summary>
        AtomicServiceTestObservation,

        /// <summary>
        /// C - Single observation calculated via a rule or formula from other independent observations (e.g., Alveolar-arterial ratio, cardiac output).
        /// </summary>
        SingleObservation,

        /// <summary>
        /// F - Functional procedure that may consist of one or more interrelated measures (e.g., glucose tolerance test, creatinine clearance), usually done at different times and/or on different specimens.
        /// </summary>
        FunctionalProcedure,

        /// <summary>
        /// P - Profile or battery consisting of many independent atomic observations (e.g., SMA12, electrolytes), usually done at one instrument on one specimen.
        /// </summary>
        ProfileFromAtomicObservation,

        /// <summary>
        /// S - Superset-a set of batteries or procedures ordered under a single code unit but processed as separate batteries (e.g., routines = CBC, UA, electrolytes)pThis set indicates that the code being described is used to order multiple service/test/observation b.
        /// </summary>
        Superset
    }
}
