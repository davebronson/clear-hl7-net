namespace ClearHl7.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0344 - Patient's Relationship to Insured.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0344</remarks>
    public enum CodePatientsRelationshiptoInsured
    {
        /// <summary>
        /// 01 - Patient is insured.
        /// </summary>
        PatientIsInsured,

        /// <summary>
        /// 02 - Spouse.
        /// </summary>
        Spouse,

        /// <summary>
        /// 03 - Natural child/insured financial responsibility.
        /// </summary>
        NaturalChildInsuredFinancialResponsibility,

        /// <summary>
        /// 04 - Natural child/Insured does not have financial responsibility.
        /// </summary>
        NaturalChildInsuredDoesNotHaveFinancialResponsibility,

        /// <summary>
        /// 05 - Step child.
        /// </summary>
        StepChild,

        /// <summary>
        /// 06 - Foster child.
        /// </summary>
        FosterChild,

        /// <summary>
        /// 07 - Ward of the court.
        /// </summary>
        WardOfTheCourt,

        /// <summary>
        /// 08 - Employee.
        /// </summary>
        Employee,

        /// <summary>
        /// 09 - Unknown.
        /// </summary>
        Unknown,

        /// <summary>
        /// 10 - Handicapped dependent.
        /// </summary>
        HandicappedDependent,

        /// <summary>
        /// 11 - Organ donor.
        /// </summary>
        OrganDonor,

        /// <summary>
        /// 12 - Cadaver donor.
        /// </summary>
        CadaverDonor,

        /// <summary>
        /// 13 - Grandchild.
        /// </summary>
        Grandchild,

        /// <summary>
        /// 14 - Niece/nephew.
        /// </summary>
        NieceNephew,

        /// <summary>
        /// 15 - Injured plaintiff.
        /// </summary>
        InjuredPlaintiff,

        /// <summary>
        /// 16 - Sponsored dependent.
        /// </summary>
        SponsoredDependent,

        /// <summary>
        /// 17 - Minor dependent of a minor dependent.
        /// </summary>
        MinorDependentOfAMinorDependent,

        /// <summary>
        /// 18 - Parent.
        /// </summary>
        Parent,

        /// <summary>
        /// 19 - Grandparent.
        /// </summary>
        Grandparent
    }
}
