using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V250.Types;

namespace ClearHl7.Fhir.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PR1 - Procedures.
    /// </summary>
    public class Pr1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PR1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// PR1.1 - Set ID - PR1.
        /// </summary>
        public uint? SetIdPr1 { get; set; }

        /// <summary>
        /// PR1.2 - Procedure Coding Method.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0089</remarks>
        public string ProcedureCodingMethod { get; set; }

        /// <summary>
        /// PR1.3 - Procedure Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0088</remarks>
        public CodedElement ProcedureCode { get; set; }

        /// <summary>
        /// PR1.4 - Procedure Description.
        /// </summary>
        public string ProcedureDescription { get; set; }

        /// <summary>
        /// PR1.5 - Procedure Date/Time.
        /// </summary>
        public DateTime? ProcedureDateTime { get; set; }

        /// <summary>
        /// PR1.6 - Procedure Functional Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0230</remarks>
        public string ProcedureFunctionalType { get; set; }

        /// <summary>
        /// PR1.7 - Procedure Minutes.
        /// </summary>
        public decimal? ProcedureMinutes { get; set; }

        /// <summary>
        /// PR1.8 - Anesthesiologist.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> Anesthesiologist { get; set; }

        /// <summary>
        /// PR1.9 - Anesthesia Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0019</remarks>
        public string AnesthesiaCode { get; set; }

        /// <summary>
        /// PR1.10 - Anesthesia Minutes.
        /// </summary>
        public decimal? AnesthesiaMinutes { get; set; }

        /// <summary>
        /// PR1.11 - Surgeon.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> Surgeon { get; set; }

        /// <summary>
        /// PR1.12 - Procedure Practitioner.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> ProcedurePractitioner { get; set; }

        /// <summary>
        /// PR1.13 - Consent Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0059</remarks>
        public CodedElement ConsentCode { get; set; }

        /// <summary>
        /// PR1.14 - Procedure Priority.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0418</remarks>
        public string ProcedurePriority { get; set; }

        /// <summary>
        /// PR1.15 - Associated Diagnosis Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0051</remarks>
        public CodedElement AssociatedDiagnosisCode { get; set; }

        /// <summary>
        /// PR1.16 - Procedure Code Modifier.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0340</remarks>
        public IEnumerable<CodedElement> ProcedureCodeModifier { get; set; }

        /// <summary>
        /// PR1.17 - Procedure DRG Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0416</remarks>
        public string ProcedureDrgType { get; set; }

        /// <summary>
        /// PR1.18 - Tissue Type Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0417</remarks>
        public IEnumerable<CodedElement> TissueTypeCode { get; set; }

        /// <summary>
        /// PR1.19 - Procedure Identifier.
        /// </summary>
        public EntityIdentifier ProcedureIdentifier { get; set; }

        /// <summary>
        /// PR1.20 - Procedure Action Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0206</remarks>
        public string ProcedureActionCode { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}",
                                Id,
                                SetIdPr1.HasValue ? SetIdPr1.Value.ToString(culture) : null,
                                ProcedureCodingMethod,
                                ProcedureCode?.ToDelimitedString(),
                                ProcedureDescription,
                                ProcedureDateTime.HasValue ? ProcedureDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ProcedureFunctionalType,
                                ProcedureMinutes.HasValue ? ProcedureMinutes.Value.ToString(Consts.NumericFormat, culture) : null,
                                Anesthesiologist != null ? string.Join("~", Anesthesiologist.Select(x => x.ToDelimitedString())) : null,
                                AnesthesiaCode,
                                AnesthesiaMinutes.HasValue ? AnesthesiaMinutes.Value.ToString(Consts.NumericFormat, culture) : null,
                                Surgeon != null ? string.Join("~", Surgeon.Select(x => x.ToDelimitedString())) : null,
                                ProcedurePractitioner != null ? string.Join("~", ProcedurePractitioner.Select(x => x.ToDelimitedString())) : null,
                                ConsentCode?.ToDelimitedString(),
                                ProcedurePriority,
                                AssociatedDiagnosisCode?.ToDelimitedString(),
                                ProcedureCodeModifier != null ? string.Join("~", ProcedureCodeModifier.Select(x => x.ToDelimitedString())) : null,
                                ProcedureDrgType,
                                TissueTypeCode != null ? string.Join("~", TissueTypeCode.Select(x => x.ToDelimitedString())) : null,
                                ProcedureIdentifier?.ToDelimitedString(),
                                ProcedureActionCode
                                ).TrimEnd('|');
        }
    }
}