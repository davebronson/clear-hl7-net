using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment LCC - Location Charge Code.
    /// </summary>
    public class LccSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "LCC";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// LCC.1 - Primary Key Value - LCC.
        /// </summary>
        public PersonLocation PrimaryKeyValueLcc { get; set; }

        /// <summary>
        /// LCC.2 - Location Department.
        /// <para>Suggested: 0264 Location Department</para>
        /// </summary>
        public string LocationDepartment { get; set; }

        /// <summary>
        /// LCC.3 - Accommodation Type.
        /// </summary>
        public IEnumerable<CodedElement> AccommodationType { get; set; }

        /// <summary>
        /// LCC.4 - Charge Code.
        /// <para>Suggested: 0132 Transaction Code</para>
        /// </summary>
        public IEnumerable<CodedElement> ChargeCode { get; set; }

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

            PrimaryKeyValueLcc = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<PersonLocation>(segments[1], false) : null;
            LocationDepartment = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            AccommodationType = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            ChargeCode = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
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
                                StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator),
                                Id,
                                PrimaryKeyValueLcc?.ToDelimitedString(),
                                LocationDepartment,
                                AccommodationType != null ? string.Join(Configuration.FieldRepeatSeparator, AccommodationType.Select(x => x.ToDelimitedString())) : null,
                                ChargeCode != null ? string.Join(Configuration.FieldRepeatSeparator, ChargeCode.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}