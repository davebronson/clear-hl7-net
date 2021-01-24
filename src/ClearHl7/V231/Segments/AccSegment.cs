using System;
using ClearHl7.Helpers;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ACC - Accident.
    /// </summary>
    public class AccSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ACC";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ACC.1 - Accident Date/Time.
        /// </summary>
        public DateTime? AccidentDateTime { get; set; }

        /// <summary>
        /// ACC.2 - Accident Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0050</remarks>
        public CodedElement AccidentCode { get; set; }

        /// <summary>
        /// ACC.3 - Accident Location.
        /// </summary>
        public string AccidentLocation { get; set; }

        /// <summary>
        /// ACC.4 - Auto Accident State.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0347</remarks>
        public CodedElement AutoAccidentState { get; set; }

        /// <summary>
        /// ACC.5 - Accident Job Related Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string AccidentJobRelatedIndicator { get; set; }

        /// <summary>
        /// ACC.6 - Accident Death Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string AccidentDeathIndicator { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 7, Configuration.FieldSeparator),
                                Id,
                                AccidentDateTime.HasValue ? AccidentDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                AccidentCode?.ToDelimitedString(),
                                AccidentLocation,
                                AutoAccidentState?.ToDelimitedString(),
                                AccidentJobRelatedIndicator,
                                AccidentDeathIndicator
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}