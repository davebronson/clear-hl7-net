using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 QIP - Query Input Parameter List.
    /// </summary>
    public class QueryInputParameterList
    {
        /// <summary>
        /// QIP.1 - Segment Field Name.
        /// </summary>
        public string SegmentFieldName { get; set; }

        /// <summary>
        /// QIP.2 - Values.
        /// </summary>
        public string Values { get; set; }
    }
}
