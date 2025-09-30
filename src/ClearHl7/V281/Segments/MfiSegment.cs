using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment MFI - Master File Identification.
    /// </summary>
    public class MfiSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MfiSegment"/> class.
        /// </summary>
        public MfiSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MfiSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public MfiSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "MFI";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// MFI.1 - Master File Identifier.
        /// <para>Suggested: 0175 Master File Identifier Code -&gt; ClearHl7.Codes.V281.CodeMasterFileIdentifierCode</para>
        /// </summary>
        public CodedWithExceptions MasterFileIdentifier { get; set; }

        /// <summary>
        /// MFI.2 - Master File Application Identifier.
        /// <para>Suggested: 0361 Application</para>
        /// </summary>
        public IEnumerable<HierarchicDesignator> MasterFileApplicationIdentifier { get; set; }

        /// <summary>
        /// MFI.3 - File-Level Event Code.
        /// <para>Suggested: 0178 File Level Event Code -&gt; ClearHl7.Codes.V281.CodeFileLevelEventCode</para>
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
        /// <para>Suggested: 0179 Response Level -&gt; ClearHl7.Codes.V281.CodeResponseLevel</para>
        /// </summary>
        public string ResponseLevelCode { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            MasterFileIdentifier = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], false, seps) : null;
            MasterFileApplicationIdentifier = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<HierarchicDesignator>(x, false, seps)) : null;
            FileLevelEventCode = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            EnteredDateTime = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            EffectiveDateTime = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDateTime() : null;
            ResponseLevelCode = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
        }

        /// <inheritdoc/>
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
                                EnteredDateTime?.ToHl7DateTimeString(typeof(MfiSegment), nameof(EnteredDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                EffectiveDateTime?.ToHl7DateTimeString(typeof(MfiSegment), nameof(EffectiveDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                ResponseLevelCode
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
