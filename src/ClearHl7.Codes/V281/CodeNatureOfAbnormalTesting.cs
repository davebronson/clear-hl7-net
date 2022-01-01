namespace ClearHl7.Codes.V281
{
    /// <summary>
    /// HL7 Version 2 Table 0080 - Nature Of Abnormal Testing.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0080</remarks>
    public enum CodeNatureOfAbnormalTesting
    {
        /// <summary>
        /// A - An age-based population.
        /// </summary>
        AgeBasedPopulation,

        /// <summary>
        /// B - Breed.
        /// </summary>
        Breed,

        /// <summary>
        /// N - None - generic normal range.
        /// </summary>
        None,

        /// <summary>
        /// R - A race-based population.
        /// </summary>
        RaceBasedPopulation,

        /// <summary>
        /// S - A sex-based population.
        /// </summary>
        SexBasedPopulation,

        /// <summary>
        /// SP - Species.
        /// </summary>
        Species,

        /// <summary>
        /// ST - Strain.
        /// </summary>
        Strain
    }
}
