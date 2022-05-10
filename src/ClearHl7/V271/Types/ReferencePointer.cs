using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V271.Types
{
    /// <summary>
    /// HL7 Version 2 RP - Reference Pointer.
    /// </summary>
    public class ReferencePointer : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferencePointer"/> class.
        /// </summary>
        public ReferencePointer()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferencePointer"/> class.
        /// </summary>
        /// <param name="pointer">RP.1 - Pointer.</param>
        public ReferencePointer(string pointer)
        {
            Pointer = pointer;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// RP.1 - Pointer.
        /// </summary>
        public string Pointer { get; set; }

        /// <summary>
        /// RP.2 - Application ID.
        /// </summary>
        public HierarchicDesignator ApplicationId { get; set; }

        /// <summary>
        /// RP.3 - Type of Data.
        /// <para>Suggested: 0834 MIME Types -&gt; ClearHl7.Codes.V271.CodeMimeTypes</para>
        /// </summary>
        public string TypeOfData { get; set; }

        /// <summary>
        /// RP.4 - Subtype.
        /// <para>Suggested: 0291 Subtype Of Referenced Data -&gt; ClearHl7.Codes.V271.CodeSubtypeOfReferencedData</para>
        /// </summary>
        public string Subtype { get; set; }

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

            Pointer = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            ApplicationId = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[1], true, seps) : null;
            TypeOfData = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            Subtype = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, separator),
                                Pointer,
                                ApplicationId?.ToDelimitedString(),
                                TypeOfData,
                                Subtype
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
