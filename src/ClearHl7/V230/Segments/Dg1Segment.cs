using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment DG1 - Diagnosis.
    /// </summary>
    public class Dg1Segment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dg1Segment"/> class.
        /// </summary>
        public Dg1Segment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dg1Segment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public Dg1Segment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "DG1";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// DG1.1 - Set ID - DG1.
        /// </summary>
        public uint? SetIdDg1 { get; set; }

        /// <summary>
        /// DG1.2 - Diagnosis Coding Method.
        /// <para>Suggested: 0053 Diagnosis Coding Method</para>
        /// </summary>
        public string DiagnosisCodingMethod { get; set; }

        /// <summary>
        /// DG1.3 - Diagnosis Code - DG1.
        /// <para>Suggested: 0051 Diagnosis Code</para>
        /// </summary>
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
        /// <para>Suggested: 0052 Diagnosis Type -&gt; ClearHl7.Codes.V230.CodeDiagnosisType</para>
        /// </summary>
        public string DiagnosisType { get; set; }

        /// <summary>
        /// DG1.7 - Major Diagnostic Category.
        /// <para>Suggested: 0118 Major Diagnostic Category</para>
        /// </summary>
        public CodedElement MajorDiagnosticCategory { get; set; }

        /// <summary>
        /// DG1.8 - Diagnostic Related Group.
        /// <para>Suggested: 0055 Diagnosis Related Group</para>
        /// </summary>
        public CodedElement DiagnosticRelatedGroup { get; set; }

        /// <summary>
        /// DG1.9 - DRG Approval Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V230.CodeYesNoIndicator</para>
        /// </summary>
        public string DrgApprovalIndicator { get; set; }

        /// <summary>
        /// DG1.10 - DRG Grouper Review Code.
        /// <para>Suggested: 0056 DRG Grouper Review Code</para>
        /// </summary>
        public string DrgGrouperReviewCode { get; set; }

        /// <summary>
        /// DG1.11 - Outlier Type.
        /// <para>Suggested: 0083 Outlier Type</para>
        /// </summary>
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
        public decimal? DiagnosisPriority { get; set; }

        /// <summary>
        /// DG1.16 - Diagnosing Clinician.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> DiagnosingClinician { get; set; }

        /// <summary>
        /// DG1.17 - Diagnosis Classification.
        /// <para>Suggested: 0228 Diagnosis Classification -&gt; ClearHl7.Codes.V230.CodeDiagnosisClassification</para>
        /// </summary>
        public string DiagnosisClassification { get; set; }

        /// <summary>
        /// DG1.18 - Confidential Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V230.CodeYesNoIndicator</para>
        /// </summary>
        public string ConfidentialIndicator { get; set; }

        /// <summary>
        /// DG1.19 - Attestation Date/Time.
        /// </summary>
        public DateTime? AttestationDateTime { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdDg1 = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            DiagnosisCodingMethod = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            DiagnosisCodeDg1 = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[3], false, seps) : null;
            DiagnosisDescription = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            DiagnosisDateTime = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDateTime() : null;
            DiagnosisType = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            MajorDiagnosticCategory = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[7], false, seps) : null;
            DiagnosticRelatedGroup = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[8], false, seps) : null;
            DrgApprovalIndicator = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            DrgGrouperReviewCode = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            OutlierType = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[11], false, seps) : null;
            OutlierDays = segments.Length > 12 && segments[12].Length > 0 ? segments[12].ToNullableDecimal() : null;
            OutlierCost = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[13], false, seps) : null;
            GrouperVersionAndType = segments.Length > 14 && segments[14].Length > 0 ? segments[14] : null;
            DiagnosisPriority = segments.Length > 15 && segments[15].Length > 0 ? segments[15].ToNullableDecimal() : null;
            DiagnosingClinician = segments.Length > 16 && segments[16].Length > 0 ? segments[16].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            DiagnosisClassification = segments.Length > 17 && segments[17].Length > 0 ? segments[17] : null;
            ConfidentialIndicator = segments.Length > 18 && segments[18].Length > 0 ? segments[18] : null;
            AttestationDateTime = segments.Length > 19 && segments[19].Length > 0 ? segments[19].ToNullableDateTime() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 20, Configuration.FieldSeparator),
                                Id,
                                SetIdDg1.HasValue ? SetIdDg1.Value.ToString(culture) : null,
                                DiagnosisCodingMethod,
                                DiagnosisCodeDg1?.ToDelimitedString(),
                                DiagnosisDescription,
                                DiagnosisDateTime?.ToHl7DateTimeString(typeof(Dg1Segment), nameof(DiagnosisDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
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
                                AttestationDateTime?.ToHl7DateTimeString(typeof(Dg1Segment), nameof(AttestationDateTime), Consts.DateTimeFormatPrecisionSecond, culture)
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
