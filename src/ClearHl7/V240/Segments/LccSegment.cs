using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment LCC - Location Charge Code.
    /// </summary>
    public class LccSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LccSegment"/> class.
        /// </summary>
        public LccSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LccSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public LccSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "LCC";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// LCC.1 - Primary Key Value - LCC.
        /// </summary>
        public PersonLocation PrimaryKeyValueLcc { get; set; }

        /// <summary>
        /// LCC.2 - Location Department.
        /// <para>Suggested: 0264 Location Department</para>
        /// </summary>
        public CodedElement LocationDepartment { get; set; }

        /// <summary>
        /// LCC.3 - Accommodation Type.
        /// <para>Suggested: 0129 Accomodation Code</para>
        /// </summary>
        public IEnumerable<CodedElement> AccommodationType { get; set; }

        /// <summary>
        /// LCC.4 - Charge Code.
        /// <para>Suggested: 0132 Transaction Code</para>
        /// </summary>
        public IEnumerable<CodedElement> ChargeCode { get; set; }

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

            PrimaryKeyValueLcc = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<PersonLocation>(segments[1], false, seps) : null;
            LocationDepartment = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[2], false, seps) : null;
            AccommodationType = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            ChargeCode = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator),
                                Id,
                                PrimaryKeyValueLcc?.ToDelimitedString(),
                                LocationDepartment?.ToDelimitedString(),
                                AccommodationType != null ? string.Join(Configuration.FieldRepeatSeparator, AccommodationType.Select(x => x.ToDelimitedString())) : null,
                                ChargeCode != null ? string.Join(Configuration.FieldRepeatSeparator, ChargeCode.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
