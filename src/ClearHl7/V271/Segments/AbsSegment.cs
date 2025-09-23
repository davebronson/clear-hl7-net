using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ABS - Abstract.
    /// </summary>
    public class AbsSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbsSegment"/> class.
        /// </summary>
        public AbsSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbsSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public AbsSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "ABS";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// ABS.1 - Discharge Care Provider.
        /// <para>Suggested: 0010 Physician ID</para>
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons DischargeCareProvider { get; set; }

        /// <summary>
        /// ABS.2 - Transfer Medical Service Code.
        /// <para>Suggested: 0069 Hospital Service -&gt; ClearHl7.Codes.V271.CodeHospitalService</para>
        /// </summary>
        public CodedWithExceptions TransferMedicalServiceCode { get; set; }

        /// <summary>
        /// ABS.3 - Severity of Illness Code.
        /// <para>Suggested: 0421 Severity Of Illness Code -&gt; ClearHl7.Codes.V271.CodeSeverityOfIllnessCode</para>
        /// </summary>
        public CodedWithExceptions SeverityOfIllnessCode { get; set; }

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
        /// <para>Suggested: 0422 Triage Code -&gt; ClearHl7.Codes.V271.CodeTriageCode</para>
        /// </summary>
        public CodedWithExceptions TriageCode { get; set; }

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
        /// <para>Suggested: 0423 Case Category Code -&gt; ClearHl7.Codes.V271.CodeCaseCategoryCode</para>
        /// </summary>
        public CodedWithExceptions CaseCategoryCode { get; set; }

        /// <summary>
        /// ABS.10 - Caesarian Section Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V271.CodeYesNoIndicator</para>
        /// </summary>
        public string CaesarianSectionIndicator { get; set; }

        /// <summary>
        /// ABS.11 - Gestation Category Code.
        /// <para>Suggested: 0424 Gestation Category Code -&gt; ClearHl7.Codes.V271.CodeGestationCategoryCode</para>
        /// </summary>
        public CodedWithExceptions GestationCategoryCode { get; set; }

        /// <summary>
        /// ABS.12 - Gestation Period - Weeks.
        /// </summary>
        public decimal? GestationPeriodWeeks { get; set; }

        /// <summary>
        /// ABS.13 - Newborn Code.
        /// <para>Suggested: 0425 Newborn Code -&gt; ClearHl7.Codes.V271.CodeNewbornCode</para>
        /// </summary>
        public CodedWithExceptions NewbornCode { get; set; }

        /// <summary>
        /// ABS.14 - Stillborn Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V271.CodeYesNoIndicator</para>
        /// </summary>
        public string StillbornIndicator { get; set; }

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

            DischargeCareProvider = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[1], false, seps) : null;
            TransferMedicalServiceCode = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            SeverityOfIllnessCode = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[3], false, seps) : null;
            DateTimeOfAttestation = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            AttestedBy = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[5], false, seps) : null;
            TriageCode = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[6], false, seps) : null;
            AbstractCompletionDateTime = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            AbstractedBy = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[8], false, seps) : null;
            CaseCategoryCode = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[9], false, seps) : null;
            CaesarianSectionIndicator = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            GestationCategoryCode = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[11], false, seps) : null;
            GestationPeriodWeeks = segments.Length > 12 && segments[12].Length > 0 ? segments[12].ToNullableDecimal() : null;
            NewbornCode = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[13], false, seps) : null;
            StillbornIndicator = segments.Length > 14 && segments[14].Length > 0 ? segments[14] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 15, Configuration.FieldSeparator),
                                Id,
                                DischargeCareProvider?.ToDelimitedString(),
                                TransferMedicalServiceCode?.ToDelimitedString(),
                                SeverityOfIllnessCode?.ToDelimitedString(),
                                DateTimeOfAttestation.ToHl7DateTimeString(typeof(AbsSegment), nameof(DateTimeOfAttestation), Consts.DateTimeFormatPrecisionSecond, culture),
                                AttestedBy?.ToDelimitedString(),
                                TriageCode?.ToDelimitedString(),
                                AbstractCompletionDateTime.ToHl7DateTimeString(typeof(AbsSegment), nameof(AbstractCompletionDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                AbstractedBy?.ToDelimitedString(),
                                CaseCategoryCode?.ToDelimitedString(),
                                CaesarianSectionIndicator,
                                GestationCategoryCode?.ToDelimitedString(),
                                GestationPeriodWeeks.HasValue ? GestationPeriodWeeks.Value.ToString(Consts.NumericFormat, culture) : null,
                                NewbornCode?.ToDelimitedString(),
                                StillbornIndicator
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
