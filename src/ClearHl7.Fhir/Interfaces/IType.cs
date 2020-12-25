namespace ClearHl7.Fhir
{
    /// <summary>
    /// HL7 Version 2 type.
    /// </summary>
    public interface IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        bool IsSubcomponent { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        string ToDelimitedString();
    }
}
