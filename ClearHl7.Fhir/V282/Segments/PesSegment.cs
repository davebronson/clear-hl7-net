using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PES - Product Experience Sender.
    /// </summary>
    public class PesSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PES";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// PES.1 - Sender Organization Name.
        ///// </summary>
        //public SenderOrganizationName { get; set; }

        ///// <summary>
        ///// PES.2 - Sender Individual Name.
        ///// </summary>
        //public SenderIndividualName { get; set; }

        ///// <summary>
        ///// PES.3 - Sender Address.
        ///// </summary>
        //public SenderAddress { get; set; }

        ///// <summary>
        ///// PES.4 - Sender Telephone.
        ///// </summary>
        //public SenderTelephone { get; set; }

        ///// <summary>
        ///// PES.5 - Sender Event Identifier.
        ///// </summary>
        //public SenderEventIdentifier { get; set; }

        ///// <summary>
        ///// PES.6 - Sender Sequence Number.
        ///// </summary>
        //public SenderSequenceNumber { get; set; }

        ///// <summary>
        ///// PES.7 - Sender Event Description.
        ///// </summary>
        //public SenderEventDescription { get; set; }

        ///// <summary>
        ///// PES.8 - Sender Comment.
        ///// </summary>
        //public SenderComment { get; set; }

        ///// <summary>
        ///// PES.9 - Sender Aware Date/Time.
        ///// </summary>
        //public SenderAwareDateTime { get; set; }

        ///// <summary>
        ///// PES.10 - Event Report Date.
        ///// </summary>
        //public EventReportDate { get; set; }

        ///// <summary>
        ///// PES.11 - Event Report Timing/Type.
        ///// </summary>
        //public EventReportTimingType { get; set; }

        ///// <summary>
        ///// PES.12 - Event Report Source.
        ///// </summary>
        //public EventReportSource { get; set; }

        ///// <summary>
        ///// PES.13 - Event Reported To.
        ///// </summary>
        //public EventReportedTo { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}"
                                ).TrimEnd('|');
        }
    }
}