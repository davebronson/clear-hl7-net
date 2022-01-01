namespace ClearHl7.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0065 - Specimen Action Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0065</remarks>
    public enum CodeSpecimenActionCode
    {
        /// <summary>
        /// A - Add ordered tests to the existing specimen.
        /// </summary>
        AddOrderedTestsToExistingSpecimen,

        /// <summary>
        /// G - Generated order; reflex order.
        /// </summary>
        GeneratedOrderReflexOrder,

        /// <summary>
        /// L - Lab to obtain specimen from patient.
        /// </summary>
        LabToObtainSpecimenFromPatient,

        /// <summary>
        /// O - Specimen obtained by service other than Lab.
        /// </summary>
        SpecimenObtainedByServiceOtherThanLab,

        /// <summary>
        /// P - Pending specimen; Order sent prior to delivery.
        /// </summary>
        PendingSpecimenOrderSentPriorToDelivery,

        /// <summary>
        /// R - Revised order.
        /// </summary>
        RevisedOrder,

        /// <summary>
        /// S - Schedule the tests specified below.
        /// </summary>
        ScheduleTheTestsSpecifiedBelow
    }
}
