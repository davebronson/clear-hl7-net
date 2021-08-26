﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
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
        /// <para>Suggested: 0230 Procedure Functional Type -&gt; ClearHl7.Codes.V271.CodeProcedureFunctionalType</para>
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
        /// <para>Suggested: 0418 Procedure Priority -&gt; ClearHl7.Codes.V271.CodeProcedurePriority</para>
        /// </summary>
        public decimal? ProcedurePriority { get; set; }

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
        /// <para>Suggested: 0416 Procedure DRG Type -&gt; ClearHl7.Codes.V271.CodeProcedureDrgType</para>
        /// </summary>
        public CodedWithExceptions ProcedureDrgType { get; set; }

        /// <summary>
        /// PR1.18 - Tissue Type Code.
        /// <para>Suggested: 0417 Tissue Type Code -&gt; ClearHl7.Codes.V271.CodeTissueTypeCode</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> TissueTypeCode { get; set; }

        /// <summary>
        /// PR1.19 - Procedure Identifier.
        /// </summary>
        public EntityIdentifier ProcedureIdentifier { get; set; }

        /// <summary>
        /// PR1.20 - Procedure Action Code.
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V271.CodeSegmentActionCode</para>
        /// </summary>
        public string ProcedureActionCode { get; set; }

        /// <summary>
        /// PR1.21 - DRG Procedure Determination Status.
        /// <para>Suggested: 0761 DRG Procedure Determination Status -&gt; ClearHl7.Codes.V271.CodeDrgProcedureDeterminationStatus</para>
        /// </summary>
        public CodedWithExceptions DrgProcedureDeterminationStatus { get; set; }

        /// <summary>
        /// PR1.22 - DRG Procedure Relevance.
        /// <para>Suggested: 0763 DRG Procedure Relevance -&gt; ClearHl7.Codes.V271.CodeDrgProcedureRelevance</para>
        /// </summary>
        public CodedWithExceptions DrgProcedureRelevance { get; set; }

        /// <summary>
        /// PR1.23 - Treating Organizational Unit.
        /// </summary>
        public IEnumerable<PersonLocation> TreatingOrganizationalUnit { get; set; }

        /// <summary>
        /// PR1.24 - Respiratory Within Surgery.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V271.CodeYesNoIndicator</para>
        /// </summary>
        public string RespiratoryWithinSurgery { get; set; }

        /// <summary>
        /// PR1.25 - Parent Procedure ID.
        /// </summary>
        public EntityIdentifier ParentProcedureId { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        internal void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);
            
            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdPr1 = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            ProcedureCodingMethod = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            ProcedureCode = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[3], false) : null;
            ProcedureDescription = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            ProcedureDateTime = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDateTime() : null;
            ProcedureFunctionalType = segments.Length > 6 && segments[6].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[6], false) : null;
            ProcedureMinutes = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDecimal() : null;
            Anesthesiologist = segments.Length > 8 && segments[8].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[8], false) : null;
            AnesthesiaCode = segments.Length > 9 && segments[9].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[9], false) : null;
            AnesthesiaMinutes = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDecimal() : null;
            Surgeon = segments.Length > 11 && segments[11].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[11], false) : null;
            ProcedurePractitioner = segments.Length > 12 && segments[12].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[12], false) : null;
            ConsentCode = segments.Length > 13 && segments[13].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[13], false) : null;
            ProcedurePriority = segments.Length > 14 && segments[14].Length > 0 ? segments[14].ToNullableDecimal() : null;
            AssociatedDiagnosisCode = segments.Length > 15 && segments[15].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[15], false) : null;
            ProcedureCodeModifier = segments.Length > 16 && segments[16].Length > 0 ? segments[16].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithNoExceptions>(x, false)) : null;
            ProcedureDrgType = segments.Length > 17 && segments[17].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[17], false) : null;
            TissueTypeCode = segments.Length > 18 && segments[18].Length > 0 ? segments[18].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            ProcedureIdentifier = segments.Length > 19 && segments[19].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[19], false) : null;
            ProcedureActionCode = segments.Length > 20 && segments[20].Length > 0 ? segments[20] : null;
            DrgProcedureDeterminationStatus = segments.Length > 21 && segments[21].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[21], false) : null;
            DrgProcedureRelevance = segments.Length > 22 && segments[22].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[22], false) : null;
            TreatingOrganizationalUnit = segments.Length > 23 && segments[23].Length > 0 ? segments[23].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<PersonLocation>(x, false)) : null;
            RespiratoryWithinSurgery = segments.Length > 24 && segments[24].Length > 0 ? segments[24] : null;
            ParentProcedureId = segments.Length > 25 && segments[25].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[25], false) : null;
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