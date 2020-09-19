namespace ClearHl7.Fhir
{
    public interface IType
    {
        bool IsSubcomponent { get; set; }

        string ToDelimitedString();
    }
}
