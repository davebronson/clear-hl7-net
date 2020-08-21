﻿using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 OG - Observation Grouper.
    /// </summary>
    public class ObservationGrouper
    {
        /// <summary>
        /// OG.1 - Original Sub-Identifier.
        /// </summary>
        public string OriginalSubIdentifier { get; set; }

        /// <summary>
        /// OG.2 - Group.
        /// </summary>
        public decimal? Group { get; set; }

        /// <summary>
        /// OG.3 - Sequence.
        /// </summary>
        public decimal? Sequence { get; set; }

        /// <summary>
        /// OG.4 - Identifier.
        /// </summary>
        public string Identifier { get; set; }
    }
}
