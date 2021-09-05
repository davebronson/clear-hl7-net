using System;
using System.Globalization;

namespace ClearHl7.Helpers
{
    /// <summary>
    /// Provides helper methods for interacting with HL7 Messages.
    /// </summary>
    public static class MessageHelper
    {
        /// <summary>
        /// Attempts to detect the HL7 version, given the message's delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation of an HL7 message.</param>
        /// <returns>An Hl7Version enumeration value.</returns>
        /// <remarks>A properly formed HL7 message is expected, with the MSH segment appearing first and the version appearing in the 12th delimited position.</remarks>
        /// <exception cref="ArgumentNullException">delimitedString is null.</exception>
        /// <exception cref="ArgumentException">
        /// delimitedString string does not begin with an MSH segment.
        /// -or-
        /// delimitedString is not valid.
        /// </exception>
        public static Hl7Version DetectVersion(string delimitedString)
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            if (delimitedString == null) { throw new ArgumentNullException($"{ delimitedString } is null.", nameof(delimitedString)); }
            if (delimitedString.Length < 5) { throw new ArgumentException($"{ delimitedString } is not valid.", nameof(delimitedString)); }
            if (!delimitedString.StartsWith("MSH", true, culture)) { throw new ArgumentException($"{ delimitedString } string does not begin with an MSH segment.", nameof(delimitedString)); }

            int delimitedStringEndPosition = delimitedString.Length - 1;
            int startPosition = 0;
            
            // The value for HL7 Version lives at position 12
            // Find the starting position of #12
            for (int i = 0; i < 11; i++)
            {
                startPosition = delimitedString.IndexOf(Consts.DefaultFieldSeparator, startPosition + 1);

                if (startPosition == -1 || startPosition == delimitedStringEndPosition)
                {
                    return Hl7Version.None;
                }
            }

            startPosition++;

            // Find the ending position of the version identifier
            int endPosition = delimitedString.IndexOfAny(new[] { Consts.DefaultFieldSeparator[0], delimitedString[4] }, startPosition);

            if (endPosition == -1)
            {
                endPosition = delimitedStringEndPosition + 1;
            }

            // Extract the version string
            string versionString = delimitedString.Substring(startPosition, endPosition - startPosition);
            
            // Map and return
            if (string.Compare("2.3", versionString, false, culture) == 0) { return Hl7Version.V230; }
            if (string.Compare("2.3.1", versionString, false, culture) == 0) { return Hl7Version.V231; }
            if (string.Compare("2.4", versionString, false, culture) == 0) { return Hl7Version.V240; }
            if (string.Compare("2.5", versionString, false, culture) == 0) { return Hl7Version.V250; }
            if (string.Compare("2.5.1", versionString, false, culture) == 0) { return Hl7Version.V251; }
            if (string.Compare("2.6", versionString, false, culture) == 0) { return Hl7Version.V260; }
            if (string.Compare("2.7", versionString, false, culture) == 0) { return Hl7Version.V270; }
            if (string.Compare("2.7.1", versionString, false, culture) == 0) { return Hl7Version.V271; }
            if (string.Compare("2.8", versionString, false, culture) == 0) { return Hl7Version.V280; }
            if (string.Compare("2.8.1", versionString, false, culture) == 0) { return Hl7Version.V281; }
            if (string.Compare("2.8.2", versionString, false, culture) == 0) { return Hl7Version.V282; }
            if (string.Compare("2.9", versionString, false, culture) == 0) { return Hl7Version.V290; }
            // The following possibilities shouldn't pop up, technically, but we'll account for them to be helpful
            if (string.Compare("2.3.0", versionString, false, culture) == 0) { return Hl7Version.V230; }
            if (string.Compare("2.4.0", versionString, false, culture) == 0) { return Hl7Version.V240; }
            if (string.Compare("2.5.0", versionString, false, culture) == 0) { return Hl7Version.V250; }
            if (string.Compare("2.6.0", versionString, false, culture) == 0) { return Hl7Version.V260; }
            if (string.Compare("2.7.0", versionString, false, culture) == 0) { return Hl7Version.V270; }
            if (string.Compare("2.8.0", versionString, false, culture) == 0) { return Hl7Version.V280; }
            if (string.Compare("2.9.0", versionString, false, culture) == 0) { return Hl7Version.V290; }

            // Default
            return Hl7Version.None;
        }

        /// <summary>
        /// Creates a new instance of the Message class that's appropriate for the given HL7 version.
        /// </summary>
        /// <param name="version">The HL7 version.</param>
        /// <returns>An instance of the Message class.</returns>
        /// <exception cref="ArgumentException">An invalid HL7 version was provided.</exception>
        public static IMessage NewInstance(Hl7Version version)
        {
            return version switch
            {
                Hl7Version.V230 => new V230.Message(),
                Hl7Version.V231 => new V231.Message(),
                Hl7Version.V240 => new V240.Message(),
                Hl7Version.V250 => new V250.Message(),
                Hl7Version.V251 => new V251.Message(),
                Hl7Version.V260 => new V260.Message(),
                Hl7Version.V270 => new V270.Message(),
                Hl7Version.V271 => new V271.Message(),
                Hl7Version.V280 => new V280.Message(),
                Hl7Version.V281 => new V281.Message(),
                Hl7Version.V282 => new V282.Message(),
                Hl7Version.V290 => new V290.Message(),
                _ => throw new ArgumentException("An invalid version was provided.", nameof(version))
            };
        }
    }
}
