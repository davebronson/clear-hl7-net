using System;

namespace ClearHl7
{
    /// <summary>
    /// Represents a lightweight structure for passing separator characters.
    /// </summary>
    public class Separators
    {
        /// <summary>
        /// Gets or sets the character used to separate fields.
        /// </summary>
        public string[] FieldSeparator { get; set; }

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
            FieldSeparator = new[] { Configuration.FieldSeparator };
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
        /// The input string must contain exactly five characters, with an expected ordering:
        /// 1) FieldSeparator
        /// 2) ComponentSeparator
        /// 3) FieldRepeatSeparator
        /// 4) EscapeCharacter
        /// 5) SubcomponentSeparator
        /// </remarks>
        /// <exception cref="ArgumentException">input does not contain exactly five encoding characters.</exception>
        public Separators UsingInput(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length != 5)
            {
                throw new ArgumentException($"{ nameof(input) } does not contains exactly five characters.", nameof(input));
            }

            FieldSeparator = new[] { input[0].ToString() };
            ComponentSeparator = new[] { input[1].ToString() };
            FieldRepeatSeparator = new[] { input[2].ToString() };
            EscapeCharacter = new[] { input[3].ToString() };
            SubcomponentSeparator = new[] { input[4].ToString() };

            return this;
        }
    }
}
