namespace ClearHl7.Codes.V250
{
    /// <summary>
    /// HL7 Version 2 Table 0325 - Location Relationship ID.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0325</remarks>
    public enum CodeLocationRelationshipId
    {
        /// <summary>
        /// ALI - Location Alias(es).
        /// </summary>
        LocationAliasEs,

        /// <summary>
        /// DTY - Nearest  dietary location.
        /// </summary>
        NearestDietaryLocation,

        /// <summary>
        /// LAB - Nearest  lab.
        /// </summary>
        NearestLab,

        /// <summary>
        /// LB2 - Second nearest lab.
        /// </summary>
        SecondNearestLab,

        /// <summary>
        /// PAR - Parent location.
        /// </summary>
        ParentLocation,

        /// <summary>
        /// RX - Nearest  pharmacy.
        /// </summary>
        NearestPharmacy,

        /// <summary>
        /// RX2 - Second nearest pharmacy.
        /// </summary>
        SecondNearestPharmacy
    }
}
