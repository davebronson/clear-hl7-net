namespace ClearHl7.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0167 - Substitution Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0167</remarks>
    public enum CodeSubstitutionStatus
    {
        /// <summary>
        /// 0 - No product selection indicated.
        /// </summary>
        NoProductSelectionIndicated,

        /// <summary>
        /// 1 - Substitution not allowed by prescriber.
        /// </summary>
        SubstitutionNotAllowedByPrescriber,

        /// <summary>
        /// 2 - Substitution allowed - patient requested product dispensed.
        /// </summary>
        SubstitutionAllowedPatientRequested,

        /// <summary>
        /// 3 - Substitution allowed - pharmacist selected product dispensed.
        /// </summary>
        SubstitutionAllowedPharmacistSelected,

        /// <summary>
        /// 4 - Substitution allowed - generic drug not in stock.
        /// </summary>
        SubstitutionAllowedGenericDrugNotInStock,

        /// <summary>
        /// 5 - Substitution allowed - brand drug dispensed as a generic.
        /// </summary>
        SubstitutionAllowedDispensedAsGeneric,

        /// <summary>
        /// 7 - Substitution not allowed - brand drug mandated by law.
        /// </summary>
        SubstitutionNotAllowedBrandMandatedByLaw,

        /// <summary>
        /// 8 - Substitution allowed - generic drug not available in marketplace.
        /// </summary>
        SubstitutionAllowedGenericNotAvailable,

        /// <summary>
        /// G - A generic substitution was dispensed.
        /// </summary>
        AGenericSubstitutionWasDispensed,

        /// <summary>
        /// N - No substitute was dispensed.  This is equivalent to the default (null) value.
        /// </summary>
        NoSubstituteWasDispensed,

        /// <summary>
        /// T - A therapeutic substitution was dispensed.
        /// </summary>
        TherapeuticSubstitutionWasDispensed
    }
}
