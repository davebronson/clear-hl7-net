using System;

namespace ClearHl7.Fhir.Helpers
{
    public class StringHelper
    {
        /// <summary>
        /// Escapes a string for HL7 encoding characters.
        /// </summary>
        /// <param name="input">The string to escape.</param>
        /// <returns>A string.</returns>
        public string Escape(string input)
        {
            if (input == null)
            {
                return null;
            }
            if (input.Length == 0)
            {
                return input;
            }

            return input
                .Replace(Configuration.EscapeCharacter.ToString(), @"\E\")
                .Replace(Configuration.FieldSeparator.ToString(), @"\F\")
                .Replace(Configuration.ComponentSeparator.ToString(), @"\S\")
                .Replace(Configuration.SubcomponentSeparator.ToString(), @"\T\")
                .Replace(Configuration.FieldRepeatSeparator.ToString(), @"\R\");
        }

        /// <summary>
        /// Unescapes a string for HL7 encoding characters.
        /// </summary>
        /// <param name="input">The string to unescape.</param>
        /// <returns>A string.</returns>
        public string Unescape(string input)
        {
            if (input == null)
            {
                return null;
            }
            if (input.Length == 0)
            {
                return input;
            }

            return input
                .Replace(@"\F\", Configuration.FieldSeparator.ToString())
                .Replace(@"\S\", Configuration.ComponentSeparator.ToString())
                .Replace(@"\T\", Configuration.SubcomponentSeparator.ToString())
                .Replace(@"\R\", Configuration.FieldRepeatSeparator.ToString())
                .Replace(@"\E\", Configuration.EscapeCharacter.ToString());
        }
    }
}
