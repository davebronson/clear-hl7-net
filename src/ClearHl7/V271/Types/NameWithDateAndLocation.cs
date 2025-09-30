using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V271.Types
{
    /// <summary>
    /// HL7 Version 2 NDL - Name With Date And Location.
    /// </summary>
    public class NameWithDateAndLocation : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameWithDateAndLocation"/> class.
        /// </summary>
        public NameWithDateAndLocation()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NameWithDateAndLocation"/> class.
        /// </summary>
        /// <param name="name">NDL.1 - Name.</param>
        public NameWithDateAndLocation(CompositeIdNumberAndNameSimplified name)
        {
            Name = name;
        }

        /// <inheritdoc/>
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
        /// <para>Suggested: 0305 Person Location Type -&gt; ClearHl7.Codes.V271.CodePersonLocationType</para>
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

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 11, separator),
                                Name?.ToDelimitedString(),
                                StartDateTime?.ToHl7DateTimeString(typeof(NameWithDateAndLocation), nameof(StartDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                EndDateTime?.ToHl7DateTimeString(typeof(NameWithDateAndLocation), nameof(EndDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
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
