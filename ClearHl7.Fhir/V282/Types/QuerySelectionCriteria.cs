using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 QSC - Query Selection Criteria.
    /// </summary>
    public class QuerySelectionCriteria
    {
        /// <summary>
        /// QSC.1 - Segment Field Name.
        /// </summary>
        public string SegmentFieldName { get; set; }

        /// <summary>
        /// QSC.2 - Relational Operator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0209</remarks>
        public string RelationalOperator { get; set; }

        /// <summary>
        /// QSC.3 - Value.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// QSC.4 - Relational Conjunction.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0210</remarks>
        public string RelationalConjunction { get; set; }
    }
}
