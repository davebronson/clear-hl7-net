using System.Collections.Generic;

namespace ClearHl7
{
    /// <summary>
    /// HL7 Version 2 Message.
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// Gets or sets the list of Segments.
        /// </summary>
        IEnumerable<ISegment> Segments { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        void FromDelimitedString(string delimitedString);

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        string ToDelimitedString();
    }
}
