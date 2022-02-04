using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment MRG - Merge Patient Information.
    /// </summary>
    public class MrgSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MrgSegment"/> class.
        /// </summary>
        public MrgSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MrgSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public MrgSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "MRG";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// MRG.1 - Prior Patient Identifier List.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> PriorPatientIdentifierList { get; set; }

        /// <summary>
        /// MRG.2 - Prior Alternate Patient ID.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> PriorAlternatePatientId { get; set; }

        /// <summary>
        /// MRG.3 - Prior Patient Account Number.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit PriorPatientAccountNumber { get; set; }

        /// <summary>
        /// MRG.4 - Prior Patient ID.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit PriorPatientId { get; set; }

        /// <summary>
        /// MRG.5 - Prior Visit Number.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit PriorVisitNumber { get; set; }

        /// <summary>
        /// MRG.6 - Prior Alternate Visit ID.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit PriorAlternateVisitId { get; set; }

        /// <summary>
        /// MRG.7 - Prior Patient Name.
        /// <para>Suggested: 0200 Name Type -&gt; ClearHl7.Codes.V260.CodeNameType</para>
        /// </summary>
        public IEnumerable<ExtendedPersonName> PriorPatientName { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            PriorPatientIdentifierList = segments.Length > 1 && segments[1].Length > 0 ? segments[1].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false, seps)) : null;
            PriorAlternatePatientId = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false, seps)) : null;
            PriorPatientAccountNumber = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[3], false, seps) : null;
            PriorPatientId = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[4], false, seps) : null;
            PriorVisitNumber = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[5], false, seps) : null;
            PriorAlternateVisitId = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[6], false, seps) : null;
            PriorPatientName = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedPersonName>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 8, Configuration.FieldSeparator),
                                Id,
                                PriorPatientIdentifierList != null ? string.Join(Configuration.FieldRepeatSeparator, PriorPatientIdentifierList.Select(x => x.ToDelimitedString())) : null,
                                PriorAlternatePatientId != null ? string.Join(Configuration.FieldRepeatSeparator, PriorAlternatePatientId.Select(x => x.ToDelimitedString())) : null,
                                PriorPatientAccountNumber?.ToDelimitedString(),
                                PriorPatientId,
                                PriorVisitNumber?.ToDelimitedString(),
                                PriorAlternateVisitId?.ToDelimitedString(),
                                PriorPatientName != null ? string.Join(Configuration.FieldRepeatSeparator, PriorPatientName.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
