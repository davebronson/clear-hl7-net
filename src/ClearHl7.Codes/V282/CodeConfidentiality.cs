namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0907 - Confidentiality.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0907</remarks>
    public enum CodeConfidentiality
    {
        /// <summary>
        /// B - Business - Since the service class can represent knowledge structures that may be considered a trade or business secret, there is sometimes (though rarely) the need to flag those items as of business level confidentiality.  However, no patient related inf.
        /// </summary>
        Business,

        /// <summary>
        /// C - Celebrity - Celebrities are people of public interest (VIP) including employees, whose information require special protection.
        /// </summary>
        Celebrity,

        /// <summary>
        /// D - Clinician - Only clinicians may see this item, billing and administration persons can not access this item without special permission.
        /// </summary>
        ClinicianOnly,

        /// <summary>
        /// ETH - Substance abuse related - Alcohol/drug-abuse related item.
        /// </summary>
        SubstanceAbuseRelated,

        /// <summary>
        /// HIV - HIV Related - HIV and AIDS related item.
        /// </summary>
        HivRelated,

        /// <summary>
        /// I - Individual - Access only to individual persons who are mentioned explicitly as actors of this service and whose actor type warrants that access (cf. to actor typed code).
        /// </summary>
        Individual,

        /// <summary>
        /// L - Low - No patient record item can be of low confidentiality.  However, some service objects are not patient related and therefore may have low confidentiality.
        /// </summary>
        Low,

        /// <summary>
        /// N - Normal - Normal confidentiality rules (according to good health care practice) apply, that is, only authorized individuals with a legitimate medical or business need may access this item.
        /// </summary>
        Normal,

        /// <summary>
        /// PSY - Psychiatry related - Psychiatry related item.
        /// </summary>
        PsychiatryRelated,

        /// <summary>
        /// R - Restricted - Restricted access, e.g. only to providers having a current care relationship to the patient.
        /// </summary>
        Restricted,

        /// <summary>
        /// S - Sensitive - Information for which the patient seeks heightened confidentiality.  Sensitive information is not to be shared with family members.  Information reported by the patient about family members is sensitive by default.  Flag can be set or cleared.
        /// </summary>
        Sensitive,

        /// <summary>
        /// SDV - Sexual and domestic violence related - Sexual assault / domestic violence related item.
        /// </summary>
        SexualAndDomesticViolence,

        /// <summary>
        /// T - Taboo - Information not to be disclosed or discussed with patient except through physician assigned to patient in this case.  This is usually a temporary constraint only; example use is a new fatal diagnosis or finding, such as malignancy or HIV.
        /// </summary>
        Taboo,

        /// <summary>
        /// V - Very restricted - Very restricted access as declared by the Privacy Officer of the record holder.
        /// </summary>
        VeryRestricted
    }
}
