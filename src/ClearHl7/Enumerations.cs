namespace ClearHl7
{
    /// <summary>
    /// Provides enumerated values that indicate the HL7 version.
    /// </summary>
    public enum Hl7Version
    {
        /// <summary>
        /// The version is indeterminate.
        /// </summary>
        None = 0,

        /// <summary>
        /// The version is 2.3
        /// </summary>
        V230,

        /// <summary>
        /// The version is 2.31
        /// </summary>
        V231,

        /// <summary>
        /// The version is 2.4
        /// </summary>
        V240,

        /// <summary>
        /// The version is 2.5
        /// </summary>
        V250,

        /// <summary>
        /// The version is 2.51
        /// </summary>
        V251,

        /// <summary>
        /// The version is 2.6
        /// </summary>
        V260,

        /// <summary>
        /// The version is 2.7
        /// </summary>
        V270,

        /// <summary>
        /// The version is 2.71
        /// </summary>
        V271,

        /// <summary>
        /// The version is 2.8
        /// </summary>
        V280,

        /// <summary>
        /// The version is 2.81
        /// </summary>
        V281,

        /// <summary>
        /// The version is 2.82
        /// </summary>
        V282,

        /// <summary>
        /// The version is 2.9
        /// </summary>
        V290
    }

    /// <summary>
    /// Provides enumerated values that indicate the DateTime precision level for formatting.
    /// </summary>
    public enum DateTimePrecision
    {
        /// <summary>
        /// Year precision (yyyy).
        /// </summary>
        Year,

        /// <summary>
        /// Month precision (yyyyMM).
        /// </summary>
        Month,

        /// <summary>
        /// Day precision (yyyyMMdd).
        /// </summary>
        Day,

        /// <summary>
        /// Hour precision (yyyyMMddHH).
        /// </summary>
        Hour,

        /// <summary>
        /// Minute precision (yyyyMMddHHmm).
        /// </summary>
        Minute,

        /// <summary>
        /// Second precision (yyyyMMddHHmmss). This is the default precision.
        /// </summary>
        Second
    }
}
