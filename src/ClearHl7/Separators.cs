namespace ClearHl7
{
    /// <summary>
    /// Represents a lightweight structure for passing separator characters.
    /// </summary>
    public class Separators
    {
        /// <summary>
        /// Gets the character used to separate fields.  This property is read-only.
        /// </summary>
        public string[] FieldSeparator { get; } = { Consts.DefaultFieldSeparator };

        /// <summary>
        /// Gets or sets the character used to separate components.
        /// </summary>
        public string[] ComponentSeparator { get; set; }

        /// <summary>
        /// Gets or sets the character used to separate repeated fields.
        /// </summary>
        public string[] FieldRepeatSeparator { get; set; }

        /// <summary>
        /// Gets or sets the character used to escape an encoding character.
        /// </summary>
        public string[] EscapeCharacter { get; set; }

        /// <summary>
        /// Gets or sets the character used to separate subcomponents.
        /// </summary>
        public string[] SubcomponentSeparator { get; set; }

        /// <summary>
        /// Sets properties using current Configuration class values.
        /// </summary>
        public Separators UsingConfigurationValues()
        {
            ComponentSeparator = new[] { Configuration.ComponentSeparator };
            FieldRepeatSeparator = new[] { Configuration.FieldRepeatSeparator };
            EscapeCharacter = new[] { Configuration.EscapeCharacter };
            SubcomponentSeparator = new[] { Configuration.SubcomponentSeparator };

            return this;
        }
    }
}
