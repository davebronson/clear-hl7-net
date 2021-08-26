using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment MFI - Master File Identification.
    /// </summary>
    public class MfiSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "MFI";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// MFI.1 - Master File Identifier.
        /// <para>Suggested: 0175 Master File Identifier Code -&gt; ClearHl7.Codes.V280.CodeMasterFileIdentifierCode</para>
        /// </summary>
        public CodedWithExceptions MasterFileIdentifier { get; set; }

        /// <summary>
        /// MFI.2 - Master File Application Identifier.
        /// <para>Suggested: 0361 Application</para>
        /// </summary>
        public IEnumerable<HierarchicDesignator> MasterFileApplicationIdentifier { get; set; }

        /// <summary>
        /// MFI.3 - File-Level Event Code.
        /// <para>Suggested: 0178 File Level Event Code -&gt; ClearHl7.Codes.V280.CodeFileLevelEventCode</para>
        /// </summary>
        public string FileLevelEventCode { get; set; }

        /// <summary>
        /// MFI.4 - Entered Date/Time.
        /// </summary>
        public DateTime? EnteredDateTime { get; set; }

        /// <summary>
        /// MFI.5 - Effective Date/Time.
        /// </summary>
        public DateTime? EffectiveDateTime { get; set; }

        /// <summary>
        /// MFI.6 - Response Level Code.
        /// <para>Suggested: 0179 Response Level -&gt; ClearHl7.Codes.V280.CodeResponseLevel</para>
        /// </summary>
        public string ResponseLevelCode { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        internal void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);
            
            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            MasterFileIdentifier = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[1], false) : null;
            MasterFileApplicationIdentifier = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<HierarchicDesignator>(x, false)) : null;
            FileLevelEventCode = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            EnteredDateTime = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            EffectiveDateTime = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDateTime() : null;
            ResponseLevelCode = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 7, Configuration.FieldSeparator),
                                Id,
                                MasterFileIdentifier?.ToDelimitedString(),
                                MasterFileApplicationIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, MasterFileApplicationIdentifier.Select(x => x.ToDelimitedString())) : null,
                                FileLevelEventCode,
                                EnteredDateTime.HasValue ? EnteredDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EffectiveDateTime.HasValue ? EffectiveDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ResponseLevelCode
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}