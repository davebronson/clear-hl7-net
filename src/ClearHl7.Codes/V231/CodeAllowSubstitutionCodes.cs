namespace ClearHl7.Codes.V231
{
    /// <summary>
    /// HL7 Version 2 Table 0279 - Allow Substitution Codes.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0279</remarks>
    public enum CodeAllowSubstitutionCodes
    {
        /// <summary>
        /// Confirm - Contact the Placer Contact Person prior to making any substitutions of this resource.
        /// </summary>
        ContactPlacerPriorToSubstitution,

        /// <summary>
        /// No - Substitution of this resource is not allowed.
        /// </summary>
        SubstitutionIsNotAllowed,

        /// <summary>
        /// Notify - Notify the Placer Contact Person, through normal institutional procedures, that a substitution of this resource has been made.
        /// </summary>
        NotifyPlacerThatSubstitutionHasBeenMade,

        /// <summary>
        /// Yes - Substitution of this resource is allowed.
        /// </summary>
        SubstitutionOfThisResourceIsAllowed
    }
}
