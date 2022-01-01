namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0262 - Privacy Level.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0262</remarks>
    public enum CodePrivacyLevel
    {
        /// <summary>
        /// F - Isolation.
        /// </summary>
        Isolation,

        /// <summary>
        /// J - Private room - medically justified.
        /// </summary>
        PrivateRoomMedicallyJustified,

        /// <summary>
        /// P - Private room.
        /// </summary>
        PrivateRoom,

        /// <summary>
        /// Q - Private room - due to overflow.
        /// </summary>
        PrivateRoomDueToOverflow,

        /// <summary>
        /// S - Semi-private room.
        /// </summary>
        SemiPrivateRoom,

        /// <summary>
        /// W - Ward.
        /// </summary>
        Ward
    }
}
