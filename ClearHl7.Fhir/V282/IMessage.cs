using System.Collections.Generic;
using ClearHl7.Fhir.V282.Segments;

namespace ClearHl7.Fhir.V282
{
    public interface IMessage
    {
        IEnumerable<ISegment> Segments { get; set; }

        string ToDelimitedString();
    }
}