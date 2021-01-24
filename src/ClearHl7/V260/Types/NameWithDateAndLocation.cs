using System;
using ClearHl7.Helpers;

namespace ClearHl7.V260.Types
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0302</remarks>
        public string PointOfCare { get; set; }

        /// <summary>
        /// NDL.5 - Room.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0303</remarks>
        public string Room { get; set; }

        /// <summary>
        /// NDL.6 - Bed.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0304</remarks>
        public string Bed { get; set; }

        /// <summary>
        /// NDL.7 - Facility.
        /// </summary>
        public HierarchicDesignator Facility { get; set; }

        /// <summary>
        /// NDL.8 - Location Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0306</remarks>
        public string LocationStatus { get; set; }

        /// <summary>
        /// NDL.9 - Patient Location Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0305</remarks>
        public string PatientLocationType { get; set; }

        /// <summary>
        /// NDL.10 - Building.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0307</remarks>
        public string Building { get; set; }

        /// <summary>
        /// NDL.11 - Floor.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0308</remarks>
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
