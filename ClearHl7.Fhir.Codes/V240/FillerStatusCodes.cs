using System;

namespace ClearHl7.Fhir.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0278 - Filler Status Codes.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0278</remarks>
    public enum FillerStatusCodes
    {
        /// <summary>
        /// Blocked - Blocked.
        /// </summary>
        Blocked,
        
        /// <summary>
        /// Booked - Booked.
        /// </summary>
        Booked,
        
        /// <summary>
        /// Cancelled - Cancelled.
        /// </summary>
        Cancelled,
        
        /// <summary>
        /// Complete - Complete.
        /// </summary>
        Complete,
        
        /// <summary>
        /// Deleted - Deleted.
        /// </summary>
        Deleted,
        
        /// <summary>
        /// Discontinued - Discontinued.
        /// </summary>
        Discontinued,
        
        /// <summary>
        /// Overbook - Overbook.
        /// </summary>
        Overbook,
        
        /// <summary>
        /// Pending - Pending.
        /// </summary>
        Pending,
        
        /// <summary>
        /// Started - Started.
        /// </summary>
        Started,
        
        /// <summary>
        /// Waitlist - Waitlist.
        /// </summary>
        Waitlist
    }
}