namespace ClearHl7.Fhir
{
    public interface ISegment
    {
        string Id { get; }
        int Ordinal { get; }

        string ToDelimitedString();
    }
}