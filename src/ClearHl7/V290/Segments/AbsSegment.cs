using System;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ABS - Abstract.
    /// </summary>
    public class AbsSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ABS";

        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ABS.1 - Discharge Care Provider.
        /// <para>Suggested: 0010 Physician ID</para>
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons DischargeCareProvider { get; set; }

        /// <summary>
        /// ABS.2 - Transfer Medical Service Code.
        /// <para>Suggested: 0069 Hospital Service -&gt; ClearHl7.Codes.V290.CodeHospitalService</para>
        /// </summary>
        public CodedWithExceptions TransferMedicalServiceCode { get; set; }

        /// <summary>
        /// ABS.3 - Severity of Illness Code.
        /// <para>Suggested: 0421 Severity Of Illness Code -&gt; ClearHl7.Codes.V290.CodeSeverityOfIllnessCode</para>
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
        /// <para>Suggested: 0422 Triage Code -&gt; ClearHl7.Codes.V290.CodeTriageCode</para>
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
        /// <para>Suggested: 0423 Case Category Code -&gt; ClearHl7.Codes.V290.CodeCaseCategoryCode</para>
        /// </summary>
        public CodedWithExceptions CaseCategoryCode { get; set; }

        /// <summary>
        /// ABS.10 - Caesarian Section Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string CaesarianSectionIndicator { get; set; }

        /// <summary>
        /// ABS.11 - Gestation Category Code.
        /// <para>Suggested: 0424 Gestation Category Code -&gt; ClearHl7.Codes.V290.CodeGestationCategoryCode</para>
        /// </summary>
        public CodedWithExceptions GestationCategoryCode { get; set; }

        /// <summary>
        /// ABS.12 - Gestation Period - Weeks.
        /// </summary>
        public decimal? GestationPeriodWeeks { get; set; }

        /// <summary>
        /// ABS.13 - Newborn Code.
        /// <para>Suggested: 0425 Newborn Code -&gt; ClearHl7.Codes.V290.CodeNewbornCode</para>
        /// </summary>
        public CodedWithExceptions NewbornCode { get; set; }

        /// <summary>
        /// ABS.14 - Stillborn Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string StillbornIndicator { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public AbsSegment FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, System.Globalization.CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }
            // run a test to ensure that ABS's types and subtypes get properly populated (several layers deep)
            DischargeCareProvider = segments.Length > 1 ? new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(segments.ElementAtOrDefault(1)) : null;
            TransferMedicalServiceCode = segments.Length > 2 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(2)) : null;
            SeverityOfIllnessCode = segments.Length > 3 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(3)) : null;
            DateTimeOfAttestation = segments.ElementAtOrDefault(4)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            AttestedBy = segments.Length > 5 ? new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(segments.ElementAtOrDefault(5)) : null;
            TriageCode = segments.Length > 6 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(6)) : null;
            AbstractCompletionDateTime = segments.ElementAtOrDefault(7)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            AbstractedBy = segments.Length > 8 ? new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(segments.ElementAtOrDefault(8)) : null;
            CaseCategoryCode = segments.Length > 9 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(9)) : null;
            CaesarianSectionIndicator = segments.ElementAtOrDefault(10);
            GestationCategoryCode = segments.Length > 11 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(11)) : null;
            GestationPeriodWeeks = segments.ElementAtOrDefault(12)?.ToNullableDecimal();
            NewbornCode = segments.Length > 13 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(13)) : null;
            StillbornIndicator = segments.ElementAtOrDefault(14);

            return this;
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 15, Configuration.FieldSeparator),
                                Id,
                                DischargeCareProvider?.ToDelimitedString(),
                                TransferMedicalServiceCode?.ToDelimitedString(),
                                SeverityOfIllnessCode?.ToDelimitedString(),
                                DateTimeOfAttestation.HasValue ? DateTimeOfAttestation.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                AttestedBy?.ToDelimitedString(),
                                TriageCode?.ToDelimitedString(),
                                AbstractCompletionDateTime.HasValue ? AbstractCompletionDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
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