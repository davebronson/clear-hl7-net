using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
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
        /// <para>Suggested: 0034 Site Administered</para>
        /// </summary>
        public string DisabledPersonCode { get; set; }

        /// <summary>
        /// DB1.3 - Disabled Person Identifier.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> DisabledPersonIdentifier { get; set; }

        /// <summary>
        /// DB1.4 - Disability Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V230.CodeYesNoIndicator</para>
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
        public void FromDelimitedString(string delimitedString, Separators separators)
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

            SetIdDb1 = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            DisabledPersonCode = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            DisabledPersonIdentifier = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false, seps)) : null;
            DisabilityIndicator = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            DisabilityStartDate = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDateTime() : null;
            DisabilityEndDate = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
            DisabilityReturnToWorkDate = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            DisabilityUnableToWorkDate = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDateTime() : null;
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
                                DisabledPersonCode,
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