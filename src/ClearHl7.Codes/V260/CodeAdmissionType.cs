namespace ClearHl7.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0007 - Admission Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0007</remarks>
    public enum CodeAdmissionType
    {
        /// <summary>
        /// A - Accident.
        /// </summary>
        Accident,

        /// <summary>
        /// C - Elective.
        /// </summary>
        Elective,

        /// <summary>
        /// E - Emergency.
        /// </summary>
        Emergency,

        /// <summary>
        /// L - Labor and Delivery.
        /// </summary>
        LaborAndDelivery,

        /// <summary>
        /// N - Newborn (Birth in healthcare facility).
        /// </summary>
        NewbornBirthInHealthcareFacility,

        /// <summary>
        /// R - Routine.
        /// </summary>
        Routine,

        /// <summary>
        /// U - Urgent.
        /// </summary>
        Urgent
    }
}
