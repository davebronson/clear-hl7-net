using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment MRG - Merge Patient Information.
    /// </summary>
    public class MrgSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "MRG";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// MRG.1 - Prior Patient Identifier List.
        /// <para>Suggested: 0061 Check Digit Scheme -&gt; ClearHl7.Fhir.Codes.V281.CodeCheckDigitScheme</para>
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> PriorPatientIdentifierList { get; set; }

        /// <summary>
        /// MRG.2 - Prior Alternate Patient ID.
        /// </summary>
        public string PriorAlternatePatientId { get; set; }

        /// <summary>
        /// MRG.3 - Prior Patient Account Number.
        /// <para>Suggested: 0061 Check Digit Scheme -&gt; ClearHl7.Fhir.Codes.V281.CodeCheckDigitScheme</para>
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit PriorPatientAccountNumber { get; set; }

        /// <summary>
        /// MRG.4 - Prior Patient ID.
        /// </summary>
        public string PriorPatientId { get; set; }

        /// <summary>
        /// MRG.5 - Prior Visit Number.
        /// <para>Suggested: 0061 Check Digit Scheme -&gt; ClearHl7.Fhir.Codes.V281.CodeCheckDigitScheme</para>
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit PriorVisitNumber { get; set; }

        /// <summary>
        /// MRG.6 - Prior Alternate Visit ID.
        /// <para>Suggested: 0061 Check Digit Scheme -&gt; ClearHl7.Fhir.Codes.V281.CodeCheckDigitScheme</para>
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> PriorAlternateVisitId { get; set; }

        /// <summary>
        /// MRG.7 - Prior Patient Name.
        /// <para>Suggested: 0200 Name Type -&gt; ClearHl7.Fhir.Codes.V281.CodeNameType</para>
        /// </summary>
        public IEnumerable<ExtendedPersonName> PriorPatientName { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 8, Configuration.FieldSeparator),
                                Id,
                                PriorPatientIdentifierList != null ? string.Join(Configuration.FieldRepeatSeparator, PriorPatientIdentifierList.Select(x => x.ToDelimitedString())) : null,
                                PriorAlternatePatientId,
                                PriorPatientAccountNumber?.ToDelimitedString(),
                                PriorPatientId,
                                PriorVisitNumber?.ToDelimitedString(),
                                PriorAlternateVisitId != null ? string.Join(Configuration.FieldRepeatSeparator, PriorAlternateVisitId.Select(x => x.ToDelimitedString())) : null,
                                PriorPatientName != null ? string.Join(Configuration.FieldRepeatSeparator, PriorPatientName.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}