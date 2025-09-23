using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment DB1 - Disability.
    /// </summary>
    public class Db1Segment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Db1Segment"/> class.
        /// </summary>
        public Db1Segment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Db1Segment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public Db1Segment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "DB1";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// DB1.1 - Set ID - DB1.
        /// </summary>
        public uint? SetIdDb1 { get; set; }

        /// <summary>
        /// DB1.2 - Disabled Person Code.
        /// <para>Suggested: 0334 Disabled Person Code -&gt; ClearHl7.Codes.V282.CodeDisabledPersonCode</para>
        /// </summary>
        public CodedWithExceptions DisabledPersonCode { get; set; }

        /// <summary>
        /// DB1.3 - Disabled Person Identifier.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> DisabledPersonIdentifier { get; set; }

        /// <summary>
        /// DB1.4 - Disability Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V282.CodeYesNoIndicator</para>
        /// </summary>
        public string DisabilityIndicator { get; set; }

        /// <summary>
        /// DB1.5 - Disability Start Date.
        /// </summary>
        public DateTime? DisabilityStartDate { get; set; }

        /// <summary>
        /// DB1.6 - Disability End Date.
        /// </summary>
        public DateTime? DisabilityEndDate { get; set; }

        /// <summary>
        /// DB1.7 - Disability Return to Work Date.
        /// </summary>
        public DateTime? DisabilityReturnToWorkDate { get; set; }

        /// <summary>
        /// DB1.8 - Disability Unable to Work Date.
        /// </summary>
        public DateTime? DisabilityUnableToWorkDate { get; set; }

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

            SetIdDb1 = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            DisabledPersonCode = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            DisabledPersonIdentifier = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false, seps)) : null;
            DisabilityIndicator = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            DisabilityStartDate = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDateTime() : null;
            DisabilityEndDate = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
            DisabilityReturnToWorkDate = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            DisabilityUnableToWorkDate = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDateTime() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 9, Configuration.FieldSeparator),
                                Id,
                                SetIdDb1.HasValue ? SetIdDb1.Value.ToString(culture) : null,
                                DisabledPersonCode?.ToDelimitedString(),
                                DisabledPersonIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, DisabledPersonIdentifier.Select(x => x.ToDelimitedString())) : null,
                                DisabilityIndicator,
                                DisabilityStartDate.ToHl7DateTimeString(typeof(Db1Segment), nameof(DisabilityStartDate), Consts.DateFormatPrecisionDay, culture),
                                DisabilityEndDate.ToHl7DateTimeString(typeof(Db1Segment), nameof(DisabilityEndDate), Consts.DateFormatPrecisionDay, culture),
                                DisabilityReturnToWorkDate.ToHl7DateTimeString(typeof(Db1Segment), nameof(DisabilityReturnToWorkDate), Consts.DateFormatPrecisionDay, culture),
                                DisabilityUnableToWorkDate.ToHl7DateTimeString(typeof(Db1Segment), nameof(DisabilityUnableToWorkDate), Consts.DateFormatPrecisionDay, culture)
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
