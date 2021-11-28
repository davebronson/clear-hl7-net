﻿using System;
using ClearHl7.Helpers;

namespace ClearHl7.V251.Types
{
    /// <summary>
    /// HL7 Version 2 PT - Processing Type.
    /// </summary>
    public class ProcessingType : IType
    {
        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// PT.1 - Processing ID.
        /// <para>Suggested: 0103 Processing ID -&gt; ClearHl7.Codes.V251.CodeProcessingId</para>
        /// </summary>
        public string ProcessingId { get; set; }

        /// <summary>
        /// PT.2 - Processing Mode.
        /// <para>Suggested: 0207 Processing Mode -&gt; ClearHl7.Codes.V251.CodeProcessingMode</para>
        /// </summary>
        public string ProcessingMode { get; set; }

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

            ProcessingId = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            ProcessingMode = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                ProcessingId,
                                ProcessingMode
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
