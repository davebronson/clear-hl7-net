using System.Collections.Generic;

namespace ClearHl7.Fhir
{
    public interface IMessage
    {
        IEnumerable<ISegment> Segments { get; set; }

        string ToDelimitedString();
    }
}