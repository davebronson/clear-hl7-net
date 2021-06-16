using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
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
        public string DiagnosisCodingMethod { get; set; }

        /// <summary>
        /// DG1.3 - Diagnosis Code - DG1.
        /// <para>Suggested: 0051 Diagnosis Code</para>
        /// </summary>
        public CodedWithExceptions DiagnosisCodeDg1 { get; set; }

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
        /// <para>Suggested: 0052 Diagnosis Type -&gt; ClearHl7.Codes.V290.CodeDiagnosisType</para>
        /// </summary>
        public CodedWithExceptions DiagnosisType { get; set; }

        /// <summary>
        /// DG1.7 - Major Diagnostic Category.
        /// <para>Suggested: 0118 Major Diagnostic Category</para>
        /// </summary>
        public CodedWithNoExceptions MajorDiagnosticCategory { get; set; }

        /// <summary>
        /// DG1.8 - Diagnostic Related Group.
        /// <para>Suggested: 0055 Diagnosis Related Group</para>
        /// </summary>
        public CodedWithNoExceptions DiagnosticRelatedGroup { get; set; }

        /// <summary>
        /// DG1.9 - DRG Approval Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string DrgApprovalIndicator { get; set; }

        /// <summary>
        /// DG1.10 - DRG Grouper Review Code.
        /// <para>Suggested: 0056 DRG Grouper Review Code</para>
        /// </summary>
        public CodedWithExceptions DrgGrouperReviewCode { get; set; }

        /// <summary>
        /// DG1.11 - Outlier Type.
        /// <para>Suggested: 0083 Outlier Type -&gt; ClearHl7.Codes.V290.CodeOutlierType</para>
        /// </summary>
        public CodedWithExceptions OutlierType { get; set; }

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
        /// <para>Suggested: 0359 Diagnosis Priority -&gt; ClearHl7.Codes.V290.CodeDiagnosisPriority</para>
        /// </summary>
        public decimal? DiagnosisPriority { get; set; }

        /// <summary>
        /// DG1.16 - Diagnosing Clinician.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> DiagnosingClinician { get; set; }

        /// <summary>
        /// DG1.17 - Diagnosis Classification.
        /// <para>Suggested: 0228 Diagnosis Classification -&gt; ClearHl7.Codes.V290.CodeDiagnosisClassification</para>
        /// </summary>
        public CodedWithExceptions DiagnosisClassification { get; set; }

        /// <summary>
        /// DG1.18 - Confidential Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string ConfidentialIndicator { get; set; }

        /// <summary>
        /// DG1.19 - Attestation Date/Time.
        /// </summary>
        public DateTime? AttestationDateTime { get; set; }

        /// <summary>
        /// DG1.20 - Diagnosis Identifier.
        /// </summary>
        public EntityIdentifier DiagnosisIdentifier { get; set; }

        /// <summary>
        /// DG1.21 - Diagnosis Action Code.
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V290.CodeSegmentActionCode</para>
        /// </summary>
        public string DiagnosisActionCode { get; set; }

        /// <summary>
        /// DG1.22 - Parent Diagnosis.
        /// </summary>
        public EntityIdentifier ParentDiagnosis { get; set; }

        /// <summary>
        /// DG1.23 - DRG CCL Value Code.
        /// <para>Suggested: 0728 DRG CCL Value Code</para>
        /// </summary>
        public CodedWithExceptions DrgCclValueCode { get; set; }

        /// <summary>
        /// DG1.24 - DRG Grouping Usage.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string DrgGroupingUsage { get; set; }

        /// <summary>
        /// DG1.25 - DRG Diagnosis Determination Status.
        /// <para>Suggested: 0731 DRG Diagnosis Determination Status -&gt; ClearHl7.Codes.V290.CodeDrgDiagnosisDeterminationStatus</para>
        /// </summary>
        public CodedWithExceptions DrgDiagnosisDeterminationStatus { get; set; }

        /// <summary>
        /// DG1.26 - Present On Admission(POA) Indicator.
        /// <para>Suggested: 0895 Present On Admission (POA) Indicator</para>
        /// </summary>
        public CodedWithExceptions PresentOnAdmissionPoaIndicator { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public Dg1Segment FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdDg1 = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            DiagnosisCodingMethod = segments.ElementAtOrDefault(2);
            DiagnosisCodeDg1 = segments.Length > 3 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(3)) : null;
            DiagnosisDescription = segments.ElementAtOrDefault(4);
            DiagnosisDateTime = segments.ElementAtOrDefault(5)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            DiagnosisType = segments.Length > 6 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(6)) : null;
            MajorDiagnosticCategory = segments.Length > 7 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(7)) : null;
            DiagnosticRelatedGroup = segments.Length > 8 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(8)) : null;
            DrgApprovalIndicator = segments.ElementAtOrDefault(9);
            DrgGrouperReviewCode = segments.Length > 10 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(10)) : null;
            OutlierType = segments.Length > 11 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(11)) : null;
            OutlierDays = segments.ElementAtOrDefault(12)?.ToNullableDecimal();
            OutlierCost = segments.Length > 13 ? new CompositePrice().FromDelimitedString(segments.ElementAtOrDefault(13)) : null;
            GrouperVersionAndType = segments.ElementAtOrDefault(14);
            DiagnosisPriority = segments.ElementAtOrDefault(15)?.ToNullableDecimal();
            DiagnosingClinician = segments.Length > 16 ? segments.ElementAtOrDefault(16).Split(separator).Select(x => new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(x)) : null;
            DiagnosisClassification = segments.Length > 17 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(17)) : null;
            ConfidentialIndicator = segments.ElementAtOrDefault(18);
            AttestationDateTime = segments.ElementAtOrDefault(19)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            DiagnosisIdentifier = segments.Length > 20 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(20)) : null;
            DiagnosisActionCode = segments.ElementAtOrDefault(21);
            ParentDiagnosis = segments.Length > 22 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(22)) : null;
            DrgCclValueCode = segments.Length > 23 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(23)) : null;
            DrgGroupingUsage = segments.ElementAtOrDefault(24);
            DrgDiagnosisDeterminationStatus = segments.Length > 25 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(25)) : null;
            PresentOnAdmissionPoaIndicator = segments.Length > 26 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(26)) : null;

            return this;
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 27, Configuration.FieldSeparator),
                                Id,
                                SetIdDg1.HasValue ? SetIdDg1.Value.ToString(culture) : null,
                                DiagnosisCodingMethod,
                                DiagnosisCodeDg1?.ToDelimitedString(),
                                DiagnosisDescription,
                                DiagnosisDateTime.HasValue ? DiagnosisDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DiagnosisType?.ToDelimitedString(),
                                MajorDiagnosticCategory?.ToDelimitedString(),
                                DiagnosticRelatedGroup?.ToDelimitedString(),
                                DrgApprovalIndicator,
                                DrgGrouperReviewCode?.ToDelimitedString(),
                                OutlierType?.ToDelimitedString(),
                                OutlierDays.HasValue ? OutlierDays.Value.ToString(Consts.NumericFormat, culture) : null,
                                OutlierCost?.ToDelimitedString(),
                                GrouperVersionAndType,
                                DiagnosisPriority.HasValue ? DiagnosisPriority.Value.ToString(Consts.NumericFormat, culture) : null,
                                DiagnosingClinician != null ? string.Join(Configuration.FieldRepeatSeparator, DiagnosingClinician.Select(x => x.ToDelimitedString())) : null,
                                DiagnosisClassification?.ToDelimitedString(),
                                ConfidentialIndicator,
                                AttestationDateTime.HasValue? AttestationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DiagnosisIdentifier?.ToDelimitedString(),
                                DiagnosisActionCode,
                                ParentDiagnosis?.ToDelimitedString(),
                                DrgCclValueCode?.ToDelimitedString(),
                                DrgGroupingUsage,
                                DrgDiagnosisDeterminationStatus?.ToDelimitedString(),
                                PresentOnAdmissionPoaIndicator?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}