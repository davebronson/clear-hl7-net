using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
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
        /// <para>Suggested: 0052 Diagnosis Type -&gt; ClearHl7.Codes.V260.CodeDiagnosisType</para>
        /// </summary>
        public string DiagnosisType { get; set; }

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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V260.CodeYesNoIndicator</para>
        /// </summary>
        public string DrgApprovalIndicator { get; set; }

        /// <summary>
        /// DG1.10 - DRG Grouper Review Code.
        /// <para>Suggested: 0056 DRG Grouper Review Code</para>
        /// </summary>
        public string DrgGrouperReviewCode { get; set; }

        /// <summary>
        /// DG1.11 - Outlier Type.
        /// <para>Suggested: 0083 Outlier Type -&gt; ClearHl7.Codes.V260.CodeOutlierType</para>
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
        /// <para>Suggested: 0359 Diagnosis Priority -&gt; ClearHl7.Codes.V260.CodeDiagnosisPriority</para>
        /// </summary>
        public decimal? DiagnosisPriority { get; set; }

        /// <summary>
        /// DG1.16 - Diagnosing Clinician.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> DiagnosingClinician { get; set; }

        /// <summary>
        /// DG1.17 - Diagnosis Classification.
        /// <para>Suggested: 0228 Diagnosis Classification -&gt; ClearHl7.Codes.V260.CodeDiagnosisClassification</para>
        /// </summary>
        public string DiagnosisClassification { get; set; }

        /// <summary>
        /// DG1.18 - Confidential Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V260.CodeYesNoIndicator</para>
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
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V260.CodeSegmentActionCode</para>
        /// </summary>
        public string DiagnosisActionCode { get; set; }

        /// <summary>
        /// DG1.22 - Parent Diagnosis.
        /// </summary>
        public EntityIdentifier ParentDiagnosis { get; set; }

        /// <summary>
        /// DG1.23 - DRG CCL Value Code.
        /// <para>Suggested: 0728 CCL Value -&gt; ClearHl7.Codes.V260.CodeCclValue</para>
        /// </summary>
        public CodedWithExceptions DrgCclValueCode { get; set; }

        /// <summary>
        /// DG1.24 - DRG Grouping Usage.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V260.CodeYesNoIndicator</para>
        /// </summary>
        public string DrgGroupingUsage { get; set; }

        /// <summary>
        /// DG1.25 - DRG Diagnosis Determination Status.
        /// <para>Suggested: 0731 DRG Diagnosis Determination Status -&gt; ClearHl7.Codes.V260.CodeDrgDiagnosisDeterminationStatus</para>
        /// </summary>
        public string DrgDiagnosisDeterminationStatus { get; set; }

        /// <summary>
        /// DG1.26 - Present On Admission(POA) Indicator.
        /// <para>Suggested: 0895 Present On Admission (POA) Indicator -&gt; ClearHl7.Codes.V260.CodePresentOnAdmissionIndicator</para>
        /// </summary>
        public string PresentOnAdmissionPoaIndicator { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
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
            DiagnosisCodeDg1 = segments.Length > 3 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(3), false) : null;
            DiagnosisDescription = segments.ElementAtOrDefault(4);
            DiagnosisDateTime = segments.ElementAtOrDefault(5)?.ToNullableDateTime();
            DiagnosisType = segments.ElementAtOrDefault(6);
            MajorDiagnosticCategory = segments.Length > 7 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(7), false) : null;
            DiagnosticRelatedGroup = segments.Length > 8 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(8), false) : null;
            DrgApprovalIndicator = segments.ElementAtOrDefault(9);
            DrgGrouperReviewCode = segments.ElementAtOrDefault(10);
            OutlierType = segments.Length > 11 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(11), false) : null;
            OutlierDays = segments.ElementAtOrDefault(12)?.ToNullableDecimal();
            OutlierCost = segments.Length > 13 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(13), false) : null;
            GrouperVersionAndType = segments.ElementAtOrDefault(14);
            DiagnosisPriority = segments.ElementAtOrDefault(15)?.ToNullableDecimal();
            DiagnosingClinician = segments.Length > 16 ? segments.ElementAtOrDefault(16).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            DiagnosisClassification = segments.ElementAtOrDefault(17);
            ConfidentialIndicator = segments.ElementAtOrDefault(18);
            AttestationDateTime = segments.ElementAtOrDefault(19)?.ToNullableDateTime();
            DiagnosisIdentifier = segments.Length > 20 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(20), false) : null;
            DiagnosisActionCode = segments.ElementAtOrDefault(21);
            ParentDiagnosis = segments.Length > 22 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(22), false) : null;
            DrgCclValueCode = segments.Length > 23 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(23), false) : null;
            DrgGroupingUsage = segments.ElementAtOrDefault(24);
            DrgDiagnosisDeterminationStatus = segments.ElementAtOrDefault(25);
            PresentOnAdmissionPoaIndicator = segments.ElementAtOrDefault(26);
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
                                DiagnosisType,
                                MajorDiagnosticCategory?.ToDelimitedString(),
                                DiagnosticRelatedGroup?.ToDelimitedString(),
                                DrgApprovalIndicator,
                                DrgGrouperReviewCode,
                                OutlierType?.ToDelimitedString(),
                                OutlierDays.HasValue ? OutlierDays.Value.ToString(Consts.NumericFormat, culture) : null,
                                OutlierCost?.ToDelimitedString(),
                                GrouperVersionAndType,
                                DiagnosisPriority.HasValue ? DiagnosisPriority.Value.ToString(Consts.NumericFormat, culture) : null,
                                DiagnosingClinician != null ? string.Join(Configuration.FieldRepeatSeparator, DiagnosingClinician.Select(x => x.ToDelimitedString())) : null,
                                DiagnosisClassification,
                                ConfidentialIndicator,
                                AttestationDateTime.HasValue? AttestationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DiagnosisIdentifier?.ToDelimitedString(),
                                DiagnosisActionCode,
                                ParentDiagnosis?.ToDelimitedString(),
                                DrgCclValueCode?.ToDelimitedString(),
                                DrgGroupingUsage,
                                DrgDiagnosisDeterminationStatus,
                                PresentOnAdmissionPoaIndicator
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}