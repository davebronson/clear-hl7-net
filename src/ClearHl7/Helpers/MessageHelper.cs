using System.Globalization;
using System.Text;

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
        /// <returns>An Hl7Version enuemration value.</returns>
        /// <remarks>A properly formed HL7 message is expected, with the MSH segment appearing first and the version appearing in the 12th delimited position.</remarks>
        public static Hl7Version DetectHl7Version(string delimitedString)
        {
            if (string.IsNullOrEmpty(delimitedString)) { return Hl7Version.None; }

            // The value for HL7 Version lives at position 12
            // Find the starting position of #12
            int startPosition = 0;
            for (int i = 0; i < 11; i++)
            {
                //if (startPosition == delimitedString.Length)
                //{
                //    return Hl7Version.None;
                //}

                startPosition = delimitedString.IndexOf(Consts.DefaultFieldSeparator, startPosition + 1);

                if (startPosition == -1)
                {
                    return Hl7Version.None;
                }
            }

            if (startPosition > -1 && startPosition < delimitedString.Length)
            {
                StringBuilder builder = new();

                // Take chars until we reach 5 chars (max), or a non-numeric char, or a period "."
                for (int i = startPosition + 1; i < startPosition + 6; i++)
                {
                    if (char.IsNumber(delimitedString[i]))
                    {
                        builder.Append(delimitedString[i]);
                        continue;
                    }
                    if (delimitedString[i].Equals('.'))
                    {
                        builder.Append(delimitedString[i]);
                        continue;
                    }

                    break;
                }

                string version = builder.ToString();
                CultureInfo culture = CultureInfo.CurrentCulture;

                // Map and return
                if (string.Compare("2.3", version, false, culture) == 0) { return Hl7Version.V230; }
                if (string.Compare("2.3.1", version, false, culture) == 0) { return Hl7Version.V231; }
                if (string.Compare("2.4", version, false, culture) == 0) { return Hl7Version.V240; }
                if (string.Compare("2.5", version, false, culture) == 0) { return Hl7Version.V250; }
                if (string.Compare("2.5.1", version, false, culture) == 0) { return Hl7Version.V251; }
                if (string.Compare("2.6", version, false, culture) == 0) { return Hl7Version.V260; }
                if (string.Compare("2.7", version, false, culture) == 0) { return Hl7Version.V270; }
                if (string.Compare("2.7.1", version, false, culture) == 0) { return Hl7Version.V271; }
                if (string.Compare("2.8", version, false, culture) == 0) { return Hl7Version.V280; }
                if (string.Compare("2.8.1", version, false, culture) == 0) { return Hl7Version.V281; }
                if (string.Compare("2.8.2", version, false, culture) == 0) { return Hl7Version.V282; }
                if (string.Compare("2.9", version, false, culture) == 0) { return Hl7Version.V290; }
            }

            // Default
            return Hl7Version.None;
        }

        public static IMessage MessageForHl7Version()
        {
            return new V290.Message();
        }
    }
}
