namespace ClearHl7.Fhir
{
    public static class Configuration
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this Message instance will automatically handle setting of the IsSubcomponent flag for contained HL7 objects that exist at the subcomponent level.
        /// </summary>
        /// <remarks>
        /// The default value is true.  However, small performance gains can be realized by setting this property to false, and then
        /// manually handling the setting of IsSubcomponent properties as you build up HL7 Message Segments in your own
        /// code.  Doing so prevents this component from having to manually traverse down through the Message object hierarchy
        /// before returning the finished string output.
        /// </remarks>
        public static bool AutoSetSubcomponentFlags { get; set; } = true;

        /// <summary>
        /// Gets the character used to separate fields.  This property is read-only.
        /// </summary>
        /// <remarks>The default character | is recommended.</remarks>
        public static char FieldSeparator { get; } = '|';

        /// <summary>
        /// Gets or sets the character used to separate components.
        /// </summary>
        /// <remarks>The default character ^ is recommended.</remarks>
        public static char ComponentSeparator { get; set; } = '^';

        /// <summary>
        /// Gets or sets the character used to separate repeated fields.
        /// </summary>
        /// <remarks>The default character ~ is recommended.</remarks>
        public static char FieldRepeatSeparator { get; set; } = '~';

        /// <summary>
        /// Gets or sets the character used to escape an encoding character.
        /// </summary>
        /// <remarks>The default character \ is recommended.</remarks>
        public static char EscapeCharacter { get; set; } = '\\';

        /// <summary>
        /// Gets or sets the character used to separate subcomponents.
        /// </summary>
        /// <remarks>The default character & is recommended.</remarks>
        public static char SubcomponentSeparator { get; set; } = '&';
    }
}
