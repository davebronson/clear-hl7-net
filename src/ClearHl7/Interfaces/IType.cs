namespace ClearHl7
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
