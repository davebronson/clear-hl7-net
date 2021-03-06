﻿using ClearHl7.Helpers;

namespace ClearHl7.V260.Types
{
    /// <summary>
    /// HL7 Version 2 RP - Reference Pointer.
    /// </summary>
    public class ReferencePointer : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
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
        /// <para>Suggested: 0834 MIME Types -&gt; ClearHl7.Codes.V260.CodeMimeTypes</para>
        /// </summary>
        public string TypeOfData { get; set; }

        /// <summary>
        /// RP.4 - Subtype.
        /// <para>Suggested: 0291 Subtype Of Referenced Data -&gt; ClearHl7.Codes.V260.CodeSubtypeOfReferencedData</para>
        /// </summary>
        public string Subtype { get; set; }

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
                                StringHelper.StringFormatSequence(0, 4, separator),
                                Pointer,
                                ApplicationId?.ToDelimitedString(),
                                TypeOfData,
                                Subtype
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
