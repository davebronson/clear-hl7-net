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
        /// <para>Suggested: 0089 Procedure Coding Method</para>
        /// </summary>
        public string ProcedureCodingMethod { get; set; }

        /// <summary>
        /// PR1.3 - Procedure Code.
        /// <para>Suggested: 0088 Procedure Code</para>
        /// </summary>
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
        /// <para>Suggested: 0230 Procedure Functional Type -&gt; ClearHl7.Codes.V230.CodeProcedureFunctionalType</para>
        /// </summary>
        public string ProcedureFunctionalType { get; set; }

        /// <summary>
        /// PR1.7 - Procedure Minutes.
        /// </summary>
        public decimal? ProcedureMinutes { get; set; }

        /// <summary>
        /// PR1.8 - Anesthesiologist.
        /// <para>Suggested: 0010 Physician ID</para>
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> Anesthesiologist { get; set; }

        /// <summary>
        /// PR1.9 - Anesthesia Code.
        /// <para>Suggested: 0019 Anesthesia Code</para>
        /// </summary>
        public string AnesthesiaCode { get; set; }

        /// <summary>
        /// PR1.10 - Anesthesia Minutes.
        /// </summary>
        public decimal? AnesthesiaMinutes { get; set; }

        /// <summary>
        /// PR1.11 - Surgeon.
        /// <para>Suggested: 0010 Physician ID</para>
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> Surgeon { get; set; }

        /// <summary>
        /// PR1.12 - Procedure Practitioner.
        /// <para>Suggested: 0010 Physician ID</para>
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> ProcedurePractitioner { get; set; }

        /// <summary>
        /// PR1.13 - Consent Code.
        /// <para>Suggested: 0059 Consent Code</para>
        /// </summary>
        public CodedElement ConsentCode { get; set; }

        /// <summary>
        /// PR1.14 - Procedure Priority.
        /// </summary>
        public string ProcedurePriority { get; set; }

        /// <summary>
        /// PR1.15 - Associated Diagnosis Code.
        /// </summary>
        public CodedElement AssociatedDiagnosisCode { get; set; }

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
            ProcedureCode = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[3], false, seps) : null;
            ProcedureDescription = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            ProcedureDateTime = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDateTime() : null;
            ProcedureFunctionalType = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            ProcedureMinutes = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDecimal() : null;
            Anesthesiologist = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            AnesthesiaCode = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            AnesthesiaMinutes = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDecimal() : null;
            Surgeon = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            ProcedurePractitioner = segments.Length > 12 && segments[12].Length > 0 ? segments[12].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            ConsentCode = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[13], false, seps) : null;
            ProcedurePriority = segments.Length > 14 && segments[14].Length > 0 ? segments[14] : null;
            AssociatedDiagnosisCode = segments.Length > 15 && segments[15].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[15], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 16, Configuration.FieldSeparator),
                                Id,
                                SetIdPr1.HasValue ? SetIdPr1.Value.ToString(culture) : null,
                                ProcedureCodingMethod,
                                ProcedureCode?.ToDelimitedString(),
                                ProcedureDescription,
                                ProcedureDateTime.ToHl7DateTimeString(typeof(Pr1Segment), nameof(ProcedureDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                ProcedureFunctionalType,
                                ProcedureMinutes.HasValue ? ProcedureMinutes.Value.ToString(Consts.NumericFormat, culture) : null,
                                Anesthesiologist != null ? string.Join(Configuration.FieldRepeatSeparator, Anesthesiologist.Select(x => x.ToDelimitedString())) : null,
                                AnesthesiaCode,
                                AnesthesiaMinutes.HasValue ? AnesthesiaMinutes.Value.ToString(Consts.NumericFormat, culture) : null,
                                Surgeon != null ? string.Join(Configuration.FieldRepeatSeparator, Surgeon.Select(x => x.ToDelimitedString())) : null,
                                ProcedurePractitioner != null ? string.Join(Configuration.FieldRepeatSeparator, ProcedurePractitioner.Select(x => x.ToDelimitedString())) : null,
                                ConsentCode?.ToDelimitedString(),
                                ProcedurePriority,
                                AssociatedDiagnosisCode?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
