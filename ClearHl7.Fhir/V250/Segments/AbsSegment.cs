using System;
using ClearHl7.Fhir.V250.Types;

namespace ClearHl7.Fhir.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ABS - Abstract.
    /// </summary>
    public class AbsSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ABS";

        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ABS.1 - Discharge Care Provider.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0010</remarks>
        public ExtendedCompositeIdNumberAndNameForPersons DischargeCareProvider { get; set; }

        /// <summary>
        /// ABS.2 - Transfer Medical Service Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0069</remarks>
        public CodedElement TransferMedicalServiceCode { get; set; }

        /// <summary>
        /// ABS.3 - Severity of Illness Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0421</remarks>
        public CodedElement SeverityOfIllnessCode { get; set; }

        /// <summary>
        /// ABS.4 - Date/Time of Attestation.
        /// </summary>
        public DateTime? DateTimeOfAttestation { get; set; }

        /// <summary>
        /// ABS.5 - Attested By.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons AttestedBy { get; set; }

        /// <summary>
        /// ABS.6 - Triage Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0422</remarks>
        public CodedElement TriageCode { get; set; }

        /// <summary>
        /// ABS.7 - Abstract Completion Date/Time.
        /// </summary>
        public DateTime? AbstractCompletionDateTime { get; set; }

        /// <summary>
        /// ABS.8 - Abstracted By.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons AbstractedBy { get; set; }

        /// <summary>
        /// ABS.9 - Case Category Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0423</remarks>
        public CodedElement CaseCategoryCode { get; set; }

        /// <summary>
        /// ABS.10 - Caesarian Section Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string CaesarianSectionIndicator { get; set; }

        /// <summary>
        /// ABS.11 - Gestation Category Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0424</remarks>
        public CodedElement GestationCategoryCode { get; set; }

        /// <summary>
        /// ABS.12 - Gestation Period - Weeks.
        /// </summary>
        public decimal? GestationPeriodWeeks { get; set; }

        /// <summary>
        /// ABS.13 - Newborn Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0425</remarks>
        public CodedElement NewbornCode { get; set; }

        /// <summary>
        /// ABS.14 - Stillborn Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string StillbornIndicator { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}",
                                Id,
                                DischargeCareProvider?.ToDelimitedString(),
                                TransferMedicalServiceCode?.ToDelimitedString(),
                                SeverityOfIllnessCode?.ToDelimitedString(),
                                DateTimeOfAttestation.HasValue ? DateTimeOfAttestation.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                AttestedBy?.ToDelimitedString(),
                                TriageCode?.ToDelimitedString(),
                                AbstractCompletionDateTime.HasValue ? AbstractCompletionDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                AbstractedBy?.ToDelimitedString(),
                                CaseCategoryCode?.ToDelimitedString(),
                                CaesarianSectionIndicator,
                                GestationCategoryCode?.ToDelimitedString(),
                                GestationPeriodWeeks.HasValue ? GestationPeriodWeeks.Value.ToString(Consts.NumericFormat, culture) : null,
                                NewbornCode?.ToDelimitedString(),
                                StillbornIndicator
                                ).TrimEnd('|');
        }
    }
}