using System.Linq;
using ClearHl7.Helpers;

namespace ClearHl7.V281.Types
{
    /// <summary>
    /// HL7 Version 2 ED - Encapsulated Data.
    /// </summary>
    public class EncapsulatedData : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// ED.1 - Source Application.
        /// </summary>
        public HierarchicDesignator SourceApplication { get; set; }

        /// <summary>
        /// ED.2 - Type of Data.
        /// <para>Suggested: 0834 MIME Types -&gt; ClearHl7.Codes.V281.CodeMimeTypes</para>
        /// </summary>
        public string TypeOfData { get; set; }

        /// <summary>
        /// ED.3 - Data Subtype.
        /// <para>Suggested: 0291 Subtype Of Referenced Data -&gt; ClearHl7.Codes.V281.CodeSubtypeOfReferencedData</para>
        /// </summary>
        public string DataSubtype { get; set; }

        /// <summary>
        /// ED.4 - Encoding.
        /// <para>Suggested: 0299 Encoding -&gt; ClearHl7.Codes.V281.CodeEncoding</para>
        /// </summary>
        public string Encoding { get; set; }

        /// <summary>
        /// ED.5 - Data.
        /// </summary>
        public Text Data { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            SourceApplication = segments.Length > 0 && segments[0].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[0], true) : null;
            TypeOfData = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            DataSubtype = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            Encoding = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            Data = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<Text>(segments[4], true) : null;
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 5, separator),
                                SourceApplication?.ToDelimitedString(),
                                TypeOfData,
                                DataSubtype,
                                Encoding,
                                Data?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
