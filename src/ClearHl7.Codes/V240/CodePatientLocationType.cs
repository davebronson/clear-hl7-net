namespace ClearHl7.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0260 - Patient Location Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0260</remarks>
    public enum CodePatientLocationType
    {
        /// <summary>
        /// B - Bed.
        /// </summary>
        Bed,

        /// <summary>
        /// C - Clinic.
        /// </summary>
        Clinic,

        /// <summary>
        /// D - Department.
        /// </summary>
        Department,

        /// <summary>
        /// E - Exam Room.
        /// </summary>
        ExamRoom,

        /// <summary>
        /// L - Other Location.
        /// </summary>
        OtherLocation,

        /// <summary>
        /// N - Nursing Unit.
        /// </summary>
        NursingUnit,

        /// <summary>
        /// O - Operating Room.
        /// </summary>
        OperatingRoom,

        /// <summary>
        /// R - Room.
        /// </summary>
        Room
    }
}
