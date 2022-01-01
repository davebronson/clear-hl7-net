namespace ClearHl7.Codes.V250
{
    /// <summary>
    /// HL7 Version 2 Table 0483 - Authorization Mode.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0483</remarks>
    public enum CodeAuthorizationMode
    {
        /// <summary>
        /// EL - Electronic.
        /// </summary>
        Electronic,

        /// <summary>
        /// EM - E-mail.
        /// </summary>
        EMail,

        /// <summary>
        /// FX - Fax.
        /// </summary>
        Fax,

        /// <summary>
        /// IP - In Person.
        /// </summary>
        InPerson,

        /// <summary>
        /// MA - Mail.
        /// </summary>
        Mail,

        /// <summary>
        /// PA - Paper.
        /// </summary>
        Paper,

        /// <summary>
        /// PH - Phone.
        /// </summary>
        Phone,

        /// <summary>
        /// RE - Reflexive (Automated system).
        /// </summary>
        ReflexiveAutomatedSystem,

        /// <summary>
        /// VC - Video-conference.
        /// </summary>
        VideoConference,

        /// <summary>
        /// VO - Voice.
        /// </summary>
        Voice
    }
}
