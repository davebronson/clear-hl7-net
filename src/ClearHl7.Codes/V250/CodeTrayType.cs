namespace ClearHl7.Codes.V250
{
    /// <summary>
    /// HL7 Version 2 Table 0160 - Tray Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0160</remarks>
    public enum CodeTrayType
    {
        /// <summary>
        /// EARLY - Early tray.
        /// </summary>
        EarlyTray,

        /// <summary>
        /// GUEST - Guest tray.
        /// </summary>
        GuestTray,

        /// <summary>
        /// LATE - Late tray.
        /// </summary>
        LateTray,

        /// <summary>
        /// MSG - Tray message only.
        /// </summary>
        TrayMessageOnly,

        /// <summary>
        /// NO - No tray.
        /// </summary>
        NoTray
    }
}
