using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V281.Types;

namespace ClearHl7.Fhir.V281.Segments
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
        public CodedWithExceptions AccidentCode { get; set; }

        /// <summary>
        /// ACC.3 - Accident Location.
        /// </summary>
        public string AccidentLocation { get; set; }

        /// <summary>
        /// ACC.4 - Auto Accident State.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0347</remarks>
        public CodedWithExceptions AutoAccidentState { get; set; }

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
        /// ACC.7 - Entered By.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons EnteredBy { get; set; }

        /// <summary>
        /// ACC.8 - Accident Description.
        /// </summary>
        public string AccidentDescription { get; set; }

        /// <summary>
        /// ACC.9 - Brought In By.
        /// </summary>
        public string BroughtInBy { get; set; }

        /// <summary>
        /// ACC.10 - Police Notified Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string PoliceNotifiedIndicator { get; set; }

        /// <summary>
        /// ACC.11 - Accident Address.
        /// </summary>
        public ExtendedAddress AccidentAddress { get; set; }

        /// <summary>
        /// ACC.12 - Degree of patient liability.
        /// </summary>
        public decimal? DegreeOfPatientLiability { get; set; }

        /// <summary>
        /// ACC.13 - Accident Identifier.
        /// </summary>
        public IEnumerable<EntityIdentifier> AccidentIdentifier { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}",
                                Id,
                                AccidentDateTime.HasValue ? AccidentDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                AccidentCode?.ToDelimitedString(),
                                AccidentLocation,
                                AutoAccidentState?.ToDelimitedString(),
                                AccidentJobRelatedIndicator,
                                AccidentDeathIndicator,
                                EnteredBy,
                                AccidentDescription,
                                BroughtInBy,
                                PoliceNotifiedIndicator,
                                AccidentAddress?.ToDelimitedString(),
                                DegreeOfPatientLiability.HasValue ? DegreeOfPatientLiability.Value.ToString(Consts.NumericFormat, culture) : null,
                                AccidentIdentifier != null ? string.Join("~", AccidentIdentifier.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd('|');
        }
    }
}