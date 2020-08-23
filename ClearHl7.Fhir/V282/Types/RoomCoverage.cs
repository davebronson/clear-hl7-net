using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 RMC - Room Coverage.
    /// </summary>
    public class RoomCoverage
    {
        /// <summary>
        /// RMC.1 - Room Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0145</remarks>
        public CodedWithExceptions RoomType { get; set; }

        /// <summary>
        /// RMC.2 - Amount Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0146</remarks>
        public CodedWithExceptions AmountType { get; set; }

        /// <summary>
        /// RMC.3 - Coverage Amount.
        /// </summary>
        public decimal? CoverageAmount { get; set; }

        /// <summary>
        /// RMC.4 - Money or Percentage.
        /// </summary>
        public MoneyOrPercentage MoneyOrPercentage { get; set; }
    }
}
