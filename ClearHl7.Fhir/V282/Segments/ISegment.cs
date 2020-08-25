namespace ClearHl7.Fhir.V282.Segments
{
    public interface ISegment
    {
        string Id { get; }
        int Ordinal { get; set; }

        string ToDelimitedString();
    }
}