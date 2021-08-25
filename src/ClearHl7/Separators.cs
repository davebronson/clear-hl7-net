namespace ClearHl7
{
    /// <summary>
    /// Represents a lightweight structure for passing separator characters.
    /// </summary>
    internal class Separators
    {
        /// <summary>
        /// Gets the character used to separate fields.  This property is read-only.
        /// </summary>
        internal string[] FieldSeparator { get; } = { Consts.DefaultFieldSeparator };

        /// <summary>
        /// Gets or sets the character used to separate components.
        /// </summary>
        internal string[] ComponentSeparator { get; set; }

        /// <summary>
        /// Gets or sets the character used to separate repeated fields.
        /// </summary>
        internal string[] FieldRepeatSeparator { get; set; }

        /// <summary>
        /// Gets or sets the character used to escape an encoding character.
        /// </summary>
        internal string[] EscapeCharacter { get; set; }

        /// <summary>
        /// Gets or sets the character used to separate subcomponents.
        /// </summary>
        internal string[] SubcomponentSeparator { get; set; }

        /// <summary>
        /// Sets properties using current Configuration class values.
        /// </summary>
        internal Separators UsingConfigurationValues()
        {
            ComponentSeparator = new[] { Configuration.ComponentSeparator };
            FieldRepeatSeparator = new[] { Configuration.FieldRepeatSeparator };
            EscapeCharacter = new[] { Configuration.EscapeCharacter };
            SubcomponentSeparator = new[] { Configuration.SubcomponentSeparator };

            return this;
        }
    }
}
