using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 DDI - Daily Deductible Information.
    /// </summary>
    public class DailyDeductibleInformation
    {
        /// <summary>
        /// DDI.1 - Delay Days.
        /// </summary>
        public decimal DelayDays { get; set; }

        /// <summary>
        /// DDI.22 - Monetary Amount.
        /// </summary>
        public Money MonetaryAmount { get; set; }

        /// <summary>
        /// DDI.3 - Number of Days.
        /// </summary>
        public decimal NumberOfDays { get; set; }
    }
}
