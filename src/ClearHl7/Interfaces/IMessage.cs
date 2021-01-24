using System.Collections.Generic;

namespace ClearHl7.Fhir
{
    /// <summary>
    /// HL7 Version 2 Message.
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// Gets or sets the list of Message Segments.
        /// </summary>
        IEnumerable<ISegment> Segments { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        string ToDelimitedString();
    }
}