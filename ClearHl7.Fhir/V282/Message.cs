using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearHl7.Fhir.V282
{
    public class Message : IMessage
    {
        /// <summary>
        /// Initializes a new instance of the Message class.
        /// </summary>
        public Message(ISegmentHelper segmentHelper)
        {
            _segmentHelper = segmentHelper;
        }

        private ISegmentHelper _segmentHelper;


        /// <summary>
        /// Gets or sets a value that indicates whether this Message instance will automatically handle setting of the IsSubcomponent flag for contained HL7 objects that exist at the subcomponent level.
        /// </summary>
        /// <remarks>
        /// The default value is true.  However, small performance gains can be realized by setting this property to false, and then
        /// manually handling the setting of IsSubcomponent properties as you build up HL7 Message Segments in your own
        /// code.  Doing so prevents this component from having to manually traverse down through the Message object hierarchy
        /// before returning the finished string output.
        /// </remarks>
        public bool AutoSetSubcomponentFlags { get; set; } = true;

        /// <summary>
        /// Gets or sets the list of Message Segments.
        /// </summary>
        public IEnumerable<ISegment> Segments { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            StringBuilder output = new StringBuilder();

            if (Segments?.Any() == true)
            {
                foreach (ISegment item in Segments.OrderBy(x => x.Ordinal))
                {
                    if (AutoSetSubcomponentFlags)
                    {
                        _segmentHelper.SetSubcomponentFlags(item);
                    }

                    output.Append(item.ToDelimitedString());
                    output.Append((char)13);
                }
            }

            return output.ToString();
        }
    }
}
