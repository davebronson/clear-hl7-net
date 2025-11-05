using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PR1 - Procedures.
    /// </summary>
    public class Pr1Segment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pr1Segment"/> class.
        /// </summary>
        public Pr1Segment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pr1Segment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public Pr1Segment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "PR1";

        /// <inheritdoc/>
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
        /// <para>Suggested: 0088 Procedure Code</para>
        /// </summary>
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
        /// <para>Suggested: 0230 Procedure Functional Type -&gt; ClearHl7.Codes.V270.CodeProcedureFunctionalType</para>
        /// </summary>
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
        /// <para>Suggested: 0019 Anesthesia Code</para>
        /// </summary>
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
        /// <para>Suggested: 0059 Consent Code</para>
        /// </summary>
        public CodedWithExceptions ConsentCode { get; set; }

        /// <summary>
        /// PR1.14 - Procedure Priority.
        /// <para>Suggested: 0418 Procedure Priority -&gt; ClearHl7.Codes.V270.CodeProcedurePriority</para>
        /// </summary>
        public string ProcedurePriority { get; set; }

        /// <summary>
        /// PR1.15 - Associated Diagnosis Code.
        /// <para>Suggested: 0051 Diagnosis Code</para>
        /// </summary>
        public CodedWithExceptions AssociatedDiagnosisCode { get; set; }

        /// <summary>
        /// PR1.16 - Procedure Code Modifier.
        /// <para>Suggested: 0340 Procedure Code Modifier</para>
        /// </summary>
        public IEnumerable<CodedWithNoExceptions> ProcedureCodeModifier { get; set; }

        /// <summary>
        /// PR1.17 - Procedure DRG Type.
        /// <para>Suggested: 0416 Procedure DRG Type -&gt; ClearHl7.Codes.V270.CodeProcedureDrgType</para>
        /// </summary>
        public CodedWithExceptions ProcedureDrgType { get; set; }

        /// <summary>
        /// PR1.18 - Tissue Type Code.
        /// <para>Suggested: 0417 Tissue Type Code -&gt; ClearHl7.Codes.V270.CodeTissueTypeCode</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> TissueTypeCode { get; set; }

        /// <summary>
        /// PR1.19 - Procedure Identifier.
        /// </summary>
        public EntityIdentifier ProcedureIdentifier { get; set; }

        /// <summary>
        /// PR1.20 - Procedure Action Code.
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V270.CodeSegmentActionCode</para>
        /// </summary>
        public string ProcedureActionCode { get; set; }

        /// <summary>
        /// PR1.21 - DRG Procedure Determination Status.
        /// <para>Suggested: 0761 DRG Procedure Determination Status -&gt; ClearHl7.Codes.V270.CodeDrgProcedureDeterminationStatus</para>
        /// </summary>
        public CodedWithExceptions DrgProcedureDeterminationStatus { get; set; }

        /// <summary>
        /// PR1.22 - DRG Procedure Relevance.
        /// <para>Suggested: 0763 DRG Procedure Relevance -&gt; ClearHl7.Codes.V270.CodeDrgProcedureRelevance</para>
        /// </summary>
        public CodedWithExceptions DrgProcedureRelevance { get; set; }

        /// <summary>
        /// PR1.23 - Treating Organizational Unit.
        /// </summary>
        public IEnumerable<PersonLocation> TreatingOrganizationalUnit { get; set; }

        /// <summary>
        /// PR1.24 - Respiratory Within Surgery.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
        /// </summary>
        public string RespiratoryWithinSurgery { get; set; }

        /// <summary>
        /// PR1.25 - Parent Procedure ID.
        /// </summary>
        public EntityIdentifier ParentProcedureId { get; set; }

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

            SetIdPr1 = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            ProcedureCodingMethod = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            ProcedureCode = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[3], false, seps) : null;
            ProcedureDescription = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            ProcedureDateTime = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDateTime() : null;
            ProcedureFunctionalType = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[6], false, seps) : null;
            ProcedureMinutes = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDecimal() : null;
            Anesthesiologist = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[8], false, seps) : null;
            AnesthesiaCode = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[9], false, seps) : null;
            AnesthesiaMinutes = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDecimal() : null;
            Surgeon = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[11], false, seps) : null;
            ProcedurePractitioner = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[12], false, seps) : null;
            ConsentCode = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[13], false, seps) : null;
            ProcedurePriority = segments.Length > 14 && segments[14].Length > 0 ? segments[14] : null;
            AssociatedDiagnosisCode = segments.Length > 15 && segments[15].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[15], false, seps) : null;
            ProcedureCodeModifier = segments.Length > 16 && segments[16].Length > 0 ? segments[16].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithNoExceptions>(x, false, seps)) : null;
            ProcedureDrgType = segments.Length > 17 && segments[17].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[17], false, seps) : null;
            TissueTypeCode = segments.Length > 18 && segments[18].Length > 0 ? segments[18].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            ProcedureIdentifier = segments.Length > 19 && segments[19].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[19], false, seps) : null;
            ProcedureActionCode = segments.Length > 20 && segments[20].Length > 0 ? segments[20] : null;
            DrgProcedureDeterminationStatus = segments.Length > 21 && segments[21].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[21], false, seps) : null;
            DrgProcedureRelevance = segments.Length > 22 && segments[22].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[22], false, seps) : null;
            TreatingOrganizationalUnit = segments.Length > 23 && segments[23].Length > 0 ? segments[23].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<PersonLocation>(x, false, seps)) : null;
            RespiratoryWithinSurgery = segments.Length > 24 && segments[24].Length > 0 ? segments[24] : null;
            ParentProcedureId = segments.Length > 25 && segments[25].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[25], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 26, Configuration.FieldSeparator),
                                Id,
                                SetIdPr1.HasValue ? SetIdPr1.Value.ToString(culture) : null,
                                ProcedureCodingMethod,
                                ProcedureCode?.ToDelimitedString(),
                                ProcedureDescription,
                                ProcedureDateTime?.ToHl7DateTimeString(typeof(Pr1Segment), nameof(ProcedureDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                ProcedureFunctionalType?.ToDelimitedString(),
                                ProcedureMinutes.HasValue ? ProcedureMinutes.Value.ToString(Consts.NumericFormat, culture) : null,
                                Anesthesiologist?.ToDelimitedString(),
                                AnesthesiaCode?.ToDelimitedString(),
                                AnesthesiaMinutes.HasValue ? AnesthesiaMinutes.Value.ToString(Consts.NumericFormat, culture) : null,
                                Surgeon?.ToDelimitedString(),
                                ProcedurePractitioner?.ToDelimitedString(),
                                ConsentCode?.ToDelimitedString(),
                                ProcedurePriority,
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
