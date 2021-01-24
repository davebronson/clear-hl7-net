using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
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
        public string ProcedureCodingMethod { get; set; }

        /// <summary>
        /// PR1.3 - Procedure Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0088</remarks>
        public CodedWithNoExceptions ProcedureCode { get; set; }

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
        public CodedWithExceptions ProcedureFunctionalType { get; set; }

        /// <summary>
        /// PR1.7 - Procedure Minutes.
        /// </summary>
        public decimal? ProcedureMinutes { get; set; }

        /// <summary>
        /// PR1.8 - Anesthesiologist.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons Anesthesiologist { get; set; }

        /// <summary>
        /// PR1.9 - Anesthesia Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0019</remarks>
        public CodedWithExceptions AnesthesiaCode { get; set; }

        /// <summary>
        /// PR1.10 - Anesthesia Minutes.
        /// </summary>
        public decimal? AnesthesiaMinutes { get; set; }

        /// <summary>
        /// PR1.11 - Surgeon.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons Surgeon { get; set; }

        /// <summary>
        /// PR1.12 - Procedure Practitioner.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons ProcedurePractitioner { get; set; }

        /// <summary>
        /// PR1.13 - Consent Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0059</remarks>
        public CodedWithExceptions ConsentCode { get; set; }

        /// <summary>
        /// PR1.14 - Procedure Priority.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0418</remarks>
        public decimal? ProcedurePriority { get; set; }

        /// <summary>
        /// PR1.15 - Associated Diagnosis Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0051</remarks>
        public CodedWithExceptions AssociatedDiagnosisCode { get; set; }

        /// <summary>
        /// PR1.16 - Procedure Code Modifier.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0340</remarks>
        public IEnumerable<CodedWithNoExceptions> ProcedureCodeModifier { get; set; }

        /// <summary>
        /// PR1.17 - Procedure DRG Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0416</remarks>
        public CodedWithExceptions ProcedureDrgType { get; set; }

        /// <summary>
        /// PR1.18 - Tissue Type Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0417</remarks>
        public IEnumerable<CodedWithExceptions> TissueTypeCode { get; set; }

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
        /// PR1.21 - DRG Procedure Determination Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0761</remarks>
        public CodedWithExceptions DrgProcedureDeterminationStatus { get; set; }

        /// <summary>
        /// PR1.22 - DRG Procedure Relevance.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0763</remarks>
        public CodedWithExceptions DrgProcedureRelevance { get; set; }

        /// <summary>
        /// PR1.23 - Treating Organizational Unit.
        /// </summary>
        public IEnumerable<PersonLocation> TreatingOrganizationalUnit { get; set; }

        /// <summary>
        /// PR1.24 - Respiratory Within Surgery.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string RespiratoryWithinSurgery { get; set; }

        /// <summary>
        /// PR1.25 - Parent Procedure ID.
        /// </summary>
        public EntityIdentifier ParentProcedureId { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 26, Configuration.FieldSeparator),
                                Id,
                                SetIdPr1.HasValue ? SetIdPr1.Value.ToString(culture) : null,
                                ProcedureCodingMethod,
                                ProcedureCode?.ToDelimitedString(),
                                ProcedureDescription,
                                ProcedureDateTime.HasValue ? ProcedureDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ProcedureFunctionalType?.ToDelimitedString(),
                                ProcedureMinutes.HasValue ? ProcedureMinutes.Value.ToString(Consts.NumericFormat, culture) : null,
                                Anesthesiologist?.ToDelimitedString(),
                                AnesthesiaCode?.ToDelimitedString(),
                                AnesthesiaMinutes.HasValue ? AnesthesiaMinutes.Value.ToString(Consts.NumericFormat, culture) : null,
                                Surgeon?.ToDelimitedString(),
                                ProcedurePractitioner?.ToDelimitedString(),
                                ConsentCode?.ToDelimitedString(),
                                ProcedurePriority.HasValue ? ProcedurePriority.Value.ToString(Consts.NumericFormat, culture) : null,
                                AssociatedDiagnosisCode?.ToDelimitedString(),
                                ProcedureCodeModifier != null ? string.Join(Configuration.FieldRepeatSeparator, ProcedureCodeModifier.Select(x => x.ToDelimitedString())) : null,
                                ProcedureDrgType?.ToDelimitedString(),
                                TissueTypeCode != null ? string.Join(Configuration.FieldRepeatSeparator, TissueTypeCode.Select(x => x.ToDelimitedString())) : null,
                                ProcedureIdentifier?.ToDelimitedString(),
                                ProcedureActionCode,
                                DrgProcedureDeterminationStatus?.ToDelimitedString(),
                                DrgProcedureRelevance?.ToDelimitedString(),
                                TreatingOrganizationalUnit != null ? string.Join(Configuration.FieldRepeatSeparator, TreatingOrganizationalUnit.Select(x => x.ToDelimitedString())) : null,
                                RespiratoryWithinSurgery,
                                ParentProcedureId?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}