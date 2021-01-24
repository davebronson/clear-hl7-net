using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment DG1 - Diagnosis.
    /// </summary>
    public class Dg1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "DG1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// DG1.1 - Set ID - DG1.
        /// </summary>
        public uint? SetIdDg1 { get; set; }

        /// <summary>
        /// DG1.2 - Diagnosis Coding Method.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0053</remarks>
        public string DiagnosisCodingMethod { get; set; }

        /// <summary>
        /// DG1.3 - Diagnosis Code - DG1.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0051</remarks>
        public CodedElement DiagnosisCodeDg1 { get; set; }

        /// <summary>
        /// DG1.4 - Diagnosis Description.
        /// </summary>
        public string DiagnosisDescription { get; set; }

        /// <summary>
        /// DG1.5 - Diagnosis Date/Time.
        /// </summary>
        public DateTime? DiagnosisDateTime { get; set; }

        /// <summary>
        /// DG1.6 - Diagnosis Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0052</remarks>
        public string DiagnosisType { get; set; }

        /// <summary>
        /// DG1.7 - Major Diagnostic Category.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0118</remarks>
        public CodedElement MajorDiagnosticCategory { get; set; }

        /// <summary>
        /// DG1.8 - Diagnostic Related Group.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0055</remarks>
        public CodedElement DiagnosticRelatedGroup { get; set; }

        /// <summary>
        /// DG1.9 - DRG Approval Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string DrgApprovalIndicator { get; set; }

        /// <summary>
        /// DG1.10 - DRG Grouper Review Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0056</remarks>
        public string DrgGrouperReviewCode { get; set; }

        /// <summary>
        /// DG1.11 - Outlier Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0083</remarks>
        public CodedElement OutlierType { get; set; }

        /// <summary>
        /// DG1.12 - Outlier Days.
        /// </summary>
        public decimal? OutlierDays { get; set; }

        /// <summary>
        /// DG1.13 - Outlier Cost.
        /// </summary>
        public CompositePrice OutlierCost { get; set; }

        /// <summary>
        /// DG1.14 - Grouper Version And Type.
        /// </summary>
        public string GrouperVersionAndType { get; set; }

        /// <summary>
        /// DG1.15 - Diagnosis Priority.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0359</remarks>
        public string DiagnosisPriority { get; set; }

        /// <summary>
        /// DG1.16 - Diagnosing Clinician.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> DiagnosingClinician { get; set; }

        /// <summary>
        /// DG1.17 - Diagnosis Classification.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0228</remarks>
        public string DiagnosisClassification { get; set; }

        /// <summary>
        /// DG1.18 - Confidential Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string ConfidentialIndicator { get; set; }

        /// <summary>
        /// DG1.19 - Attestation Date/Time.
        /// </summary>
        public DateTime? AttestationDateTime { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 20, Configuration.FieldSeparator),
                                Id,
                                SetIdDg1.HasValue ? SetIdDg1.Value.ToString(culture) : null,
                                DiagnosisCodingMethod,
                                DiagnosisCodeDg1?.ToDelimitedString(),
                                DiagnosisDescription,
                                DiagnosisDateTime.HasValue ? DiagnosisDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DiagnosisType,
                                MajorDiagnosticCategory?.ToDelimitedString(),
                                DiagnosticRelatedGroup?.ToDelimitedString(),
                                DrgApprovalIndicator,
                                DrgGrouperReviewCode,
                                OutlierType?.ToDelimitedString(),
                                OutlierDays.HasValue ? OutlierDays.Value.ToString(Consts.NumericFormat, culture) : null,
                                OutlierCost?.ToDelimitedString(),
                                GrouperVersionAndType,
                                DiagnosisPriority,
                                DiagnosingClinician != null ? string.Join(Configuration.FieldRepeatSeparator, DiagnosingClinician.Select(x => x.ToDelimitedString())) : null,
                                DiagnosisClassification,
                                ConfidentialIndicator,
                                AttestationDateTime.HasValue? AttestationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}