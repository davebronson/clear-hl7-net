namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0127 - Allergen Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0127</remarks>
    public enum CodeAllergenType
    {
        /// <summary>
        /// AA - Animal Allergy.
        /// </summary>
        AnimalAllergy,

        /// <summary>
        /// DA - Drug allergy.
        /// </summary>
        DrugAllergy,

        /// <summary>
        /// EA - Environmental Allergy.
        /// </summary>
        EnvironmentalAllergy,

        /// <summary>
        /// FA - Food allergy.
        /// </summary>
        FoodAllergy,

        /// <summary>
        /// LA - Pollen Allergy.
        /// </summary>
        PollenAllergy,

        /// <summary>
        /// MA - Miscellaneous allergy.
        /// </summary>
        MiscellaneousAllergy,

        /// <summary>
        /// MC - Miscellaneous contraindication.
        /// </summary>
        MiscellaneousContraindication,

        /// <summary>
        /// PA - Plant Allergy.
        /// </summary>
        PlantAllergy
    }
}
