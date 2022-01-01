namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0653 - Date Format.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0653</remarks>
    public enum CodeDateFormat
    {
        /// <summary>
        /// 1 - mm/dd/yy.
        /// </summary>
        MmDdYyWithSlashes,

        /// <summary>
        /// 2 - yy.mm.dd.
        /// </summary>
        YyMmDdWithPeriods,

        /// <summary>
        /// 3 - dd/mm/yy.
        /// </summary>
        DdMmYyWithSlashes,

        /// <summary>
        /// 4 - dd.mm.yy.
        /// </summary>
        DdMmYyWithPeriods,

        /// <summary>
        /// 5 - yy/mm/dd.
        /// </summary>
        YyMmDdWithSlashes,

        /// <summary>
        /// 6 - Yymmdd.
        /// </summary>
        Yymmdd
    }
}
