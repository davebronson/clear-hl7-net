namespace ClearHl7.Codes.V281
{
    /// <summary>
    /// HL7 Version 2 Table 0548 - Signatory's Relationship To Subject.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0548</remarks>
    public enum CodeSignatorysRelationshipToSubject
    {
        /// <summary>
        /// 1 - Self.
        /// </summary>
        Self,

        /// <summary>
        /// 2 - Parent.
        /// </summary>
        Parent,

        /// <summary>
        /// 3 - Next of Kin.
        /// </summary>
        NextOfKin,

        /// <summary>
        /// 4 - Durable Power of Attorney in Healthcare Affairs.
        /// </summary>
        DurablePowerOfAttorneyInHealthcareAffairs,

        /// <summary>
        /// 5 - Conservator.
        /// </summary>
        Conservator,

        /// <summary>
        /// 6 - Emergent Practitioner (practitioner judging case as emergency requiring care without a consent).
        /// </summary>
        EmergentPractitioner,

        /// <summary>
        /// 7 - Non-Emergent Practitioner (i.e. medical ethics committee).
        /// </summary>
        NonEmergentPractitioner
    }
}
