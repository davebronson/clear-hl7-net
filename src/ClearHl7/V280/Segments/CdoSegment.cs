using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CDO - Cumulative Dosage.
    /// </summary>
    public class CdoSegment : ISegment
    {
        /// <inheritdoc/>
        public string Id { get; } = "CDO";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// CDO.1 - Set ID - CDO.
        /// </summary>
        public uint? SetIdCdo { get; set; }

        /// <summary>
        /// CDO.2 - Action Code.
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V280.CodeSegmentActionCode</para>
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// CDO.3 - Cumulative Dosage Limit.
        /// </summary>
        public CompositeQuantityWithUnits CumulativeDosageLimit { get; set; }

        /// <summary>
        /// CDO.4 - Cumulative Dosage Limit Time Interval.
        /// <para>Suggested: 0924 Cumulative Dosage Limit UoM -&gt; ClearHl7.Codes.V280.CodeCumulativeDosageLimitUom</para>
        /// </summary>
        public CompositeQuantityWithUnits CumulativeDosageLimitTimeInterval { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdCdo = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            ActionCode = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            CumulativeDosageLimit = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[3], false, seps) : null;
            CumulativeDosageLimitTimeInterval = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[4], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator),
                                Id,
                                SetIdCdo.HasValue ? SetIdCdo.Value.ToString(culture) : null,
                                ActionCode,
                                CumulativeDosageLimit?.ToDelimitedString(),
                                CumulativeDosageLimitTimeInterval?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
