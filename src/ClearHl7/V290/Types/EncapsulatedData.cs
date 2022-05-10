using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V290.Types
{
    /// <summary>
    /// HL7 Version 2 ED - Encapsulated Data.
    /// </summary>
    public class EncapsulatedData : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EncapsulatedData"/> class.
        /// </summary>
        public EncapsulatedData()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EncapsulatedData"/> class.
        /// </summary>
        /// <param name="data">ED.5 - Data.</param>
        public EncapsulatedData(Text data)
        {
            Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EncapsulatedData"/> class.
        /// </summary>
        /// <param name="data">ED.5 - Data.</param>
        /// <param name="typeOfData">ED.2 - Type of Data.</param>
        /// <param name="encoding">ED.4 - Encoding.</param>
        public EncapsulatedData(Text data, string typeOfData, string encoding)
        {
            Data = data;
            TypeOfData = typeOfData;
            Encoding = encoding;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// ED.1 - Source Application.
        /// </summary>
        public HierarchicDesignator SourceApplication { get; set; }

        /// <summary>
        /// ED.2 - Type of Data.
        /// <para>Suggested: 0834 MIME Types -&gt; ClearHl7.Codes.V290.CodeMimeTypes</para>
        /// </summary>
        public string TypeOfData { get; set; }

        /// <summary>
        /// ED.3 - Data Subtype.
        /// <para>Suggested: 0291 Subtype Of Referenced Data -&gt; ClearHl7.Codes.V290.CodeSubtypeOfReferencedData</para>
        /// </summary>
        public string DataSubtype { get; set; }

        /// <summary>
        /// ED.4 - Encoding.
        /// <para>Suggested: 0299 Encoding -&gt; ClearHl7.Codes.V290.CodeEncoding</para>
        /// </summary>
        public string Encoding { get; set; }

        /// <summary>
        /// ED.5 - Data.
        /// </summary>
        public Text Data { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(separator, StringSplitOptions.None);

            SourceApplication = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[0], true, seps) : null;
            TypeOfData = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            DataSubtype = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            Encoding = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            Data = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[4], true, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
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
