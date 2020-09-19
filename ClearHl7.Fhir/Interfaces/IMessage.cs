using System.Collections.Generic;

namespace ClearHl7.Fhir
{
    public interface IMessage
    {
        bool AutoSetSubcomponentFlags { get; set; }
        IEnumerable<ISegment> Segments { get; set; }

        string ToDelimitedString();
    }
}