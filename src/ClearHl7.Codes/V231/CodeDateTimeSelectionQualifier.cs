namespace ClearHl7.Codes.V231
{
    /// <summary>
    /// HL7 Version 2 Table 0158 - Date/Time Selection Qualifier.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0158</remarks>
    public enum CodeDateTimeSelectionQualifier
    {
        /// <summary>
        /// 1ST - First value within range.
        /// </summary>
        FirstValueWithinRange,

        /// <summary>
        /// ALL - All values within the range.
        /// </summary>
        AllValuesWithinTheRange,

        /// <summary>
        /// LST - Last value within the range.
        /// </summary>
        LastValueWithinTheRange,

        /// <summary>
        /// REV - All values within the range returned in reverse chronological order (This is the default if not otherwise specified.).
        /// </summary>
        ValuesWithinRangeInReverseOrder
    }
}
