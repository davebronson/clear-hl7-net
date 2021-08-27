using System;

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
        /// Initializes properties of this instance using current Configuration class values.
        /// </summary>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public Separators UsingConfigurationValues()
        {
            ComponentSeparator = new[] { Configuration.ComponentSeparator };
            FieldRepeatSeparator = new[] { Configuration.FieldRepeatSeparator };
            EscapeCharacter = new[] { Configuration.EscapeCharacter };
            SubcomponentSeparator = new[] { Configuration.SubcomponentSeparator };

            return this;
        }

        /// <summary>
        /// Initializes properties of this instance using characters parsed from the input string.
        /// </summary>
        /// <param name="input">The string to parse.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <remarks>
        /// The input string must contain exactly four characters, with an expected ordering:
        /// 1) ComponentSeparator
        /// 2) FieldRepeatSeparator
        /// 3) EscapeCharacter
        /// 4) SubcomponentSeparator
        /// </remarks>
        /// <exception cref="ArgumentException">input does not contain exactly four encoding characters.</exception>
        public Separators UsingInput(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length != 4)
            {
                throw new ArgumentException($"{ nameof(input) } does not contains exactly four characters.", nameof(input));
            }

            ComponentSeparator = new[] { input[0].ToString() };
            FieldRepeatSeparator = new[] { input[1].ToString() };
            EscapeCharacter = new[] { input[2].ToString() };
            SubcomponentSeparator = new[] { input[3].ToString() };

            return this;
        }
    }
}
