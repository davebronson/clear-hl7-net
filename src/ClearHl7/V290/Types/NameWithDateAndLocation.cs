using System;
using ClearHl7.Helpers;

namespace ClearHl7.V290.Types
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
        /// <para>Suggested: 0305 Person Location Type -&gt; ClearHl7.Codes.V290.CodePersonLocationType</para>
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
