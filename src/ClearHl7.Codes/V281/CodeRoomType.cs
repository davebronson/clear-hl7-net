namespace ClearHl7.Codes.V281
{
    /// <summary>
    /// HL7 Version 2 Table 0145 - Room Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0145</remarks>
    public enum CodeRoomType
    {
        /// <summary>
        /// 2ICU - Second intensive care unit.
        /// </summary>
        SecondIntensiveCareUnit,

        /// <summary>
        /// 2PRI - Second private room.
        /// </summary>
        SecondPrivateRoom,

        /// <summary>
        /// 2SPR - Second semi-private room.
        /// </summary>
        SecondSemiPrivateRoom,

        /// <summary>
        /// ICU - Intensive care unit.
        /// </summary>
        IntensiveCareUnit,

        /// <summary>
        /// PRI - Private room.
        /// </summary>
        PrivateRoom,

        /// <summary>
        /// SPR - Semi-private room.
        /// </summary>
        SemiPrivateRoom
    }
}
