using System;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V270.Types
{
    /// <summary>
    /// HL7 Version 2 NDL - Name With Date And Location.
    /// </summary>
    public class NameWithDateAndLocation : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// NDL.1 - Name.
        /// </summary>
        public CompositeIdNumberAndNameSimplified Name { get; set; }

        /// <summary>
        /// NDL.2 - Start Date/time.
        /// </summary>
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// NDL.3 - End Date/time.
        /// </summary>
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// NDL.4 - Point of Care.
        /// <para>Suggested: 0302 Point Of Care</para>
        /// </summary>
        public string PointOfCare { get; set; }

        /// <summary>
        /// NDL.5 - Room.
        /// <para>Suggested: 0303 Room</para>
        /// </summary>
        public string Room { get; set; }

        /// <summary>
        /// NDL.6 - Bed.
        /// <para>Suggested: 0304 Bed</para>
        /// </summary>
        public string Bed { get; set; }

        /// <summary>
        /// NDL.7 - Facility.
        /// </summary>
        public HierarchicDesignator Facility { get; set; }

        /// <summary>
        /// NDL.8 - Location Status.
        /// <para>Suggested: 0306 Location Status</para>
        /// </summary>
        public string LocationStatus { get; set; }

        /// <summary>
        /// NDL.9 - Patient Location Type.
        /// <para>Suggested: 0305 Person Location Type -&gt; ClearHl7.Codes.V270.CodePersonLocationType</para>
        /// </summary>
        public string PatientLocationType { get; set; }

        /// <summary>
        /// NDL.10 - Building.
        /// <para>Suggested: 0307 Building</para>
        /// </summary>
        public string Building { get; set; }

        /// <summary>
        /// NDL.11 - Floor.
        /// <para>Suggested: 0308 Floor</para>
        /// </summary>
        public string Floor { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(separator, StringSplitOptions.None);

            Name = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<CompositeIdNumberAndNameSimplified>(segments[0], true, seps) : null;
            StartDateTime = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDateTime() : null;
            EndDateTime = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDateTime() : null;
            PointOfCare = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            Room = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            Bed = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            Facility = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[6], true, seps) : null;
            LocationStatus = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            PatientLocationType = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            Building = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            Floor = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
        }

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
                                StringHelper.StringFormatSequence(0, 11, separator),
                                Name?.ToDelimitedString(),
                                StartDateTime.HasValue ? StartDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EndDateTime.HasValue ? EndDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PointOfCare,
                                Room,
                                Bed,
                                Facility?.ToDelimitedString(),
                                LocationStatus,
                                PatientLocationType,
                                Building,
                                Floor
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
