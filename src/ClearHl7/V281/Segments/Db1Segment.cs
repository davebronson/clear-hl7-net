using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment DB1 - Disability.
    /// </summary>
    public class Db1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "DB1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// DB1.1 - Set ID - DB1.
        /// </summary>
        public uint? SetIdDb1 { get; set; }

        /// <summary>
        /// DB1.2 - Disabled Person Code.
        /// <para>Suggested: 0334 Disabled Person Code -&gt; ClearHl7.Codes.V281.CodeDisabledPersonCode</para>
        /// </summary>
        public CodedWithExceptions DisabledPersonCode { get; set; }

        /// <summary>
        /// DB1.3 - Disabled Person Identifier.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> DisabledPersonIdentifier { get; set; }

        /// <summary>
        /// DB1.4 - Disability Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeYesNoIndicator</para>
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

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdDb1 = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            DisabledPersonCode = segments.Length > 2 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(2), false) : null;
            DisabledPersonIdentifier = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false)) : null;
            DisabilityIndicator = segments.ElementAtOrDefault(4);
            DisabilityStartDate = segments.ElementAtOrDefault(5)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            DisabilityEndDate = segments.ElementAtOrDefault(6)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            DisabilityReturnToWorkDate = segments.ElementAtOrDefault(7)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            DisabilityUnableToWorkDate = segments.ElementAtOrDefault(8)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
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
                                StringHelper.StringFormatSequence(0, 9, Configuration.FieldSeparator),
                                Id,
                                SetIdDb1.HasValue ? SetIdDb1.Value.ToString(culture) : null,
                                DisabledPersonCode?.ToDelimitedString(),
                                DisabledPersonIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, DisabledPersonIdentifier.Select(x => x.ToDelimitedString())) : null,
                                DisabilityIndicator,
                                DisabilityStartDate.HasValue ? DisabilityStartDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                DisabilityEndDate.HasValue ? DisabilityEndDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                DisabilityReturnToWorkDate.HasValue ? DisabilityReturnToWorkDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                DisabilityUnableToWorkDate.HasValue ? DisabilityUnableToWorkDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}