using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
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
        /// </summary>
        public ExtendedPersonName PriorPatientName { get; set; }

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

            PriorPatientIdentifierList = segments.Length > 1 ? segments.ElementAtOrDefault(1).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false)) : null;
            PriorAlternatePatientId = segments.Length > 2 ? segments.ElementAtOrDefault(2).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false)) : null;
            PriorPatientAccountNumber = segments.Length > 3 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments.ElementAtOrDefault(3), false) : null;
            PriorPatientId = segments.Length > 4 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments.ElementAtOrDefault(4), false) : null;
            PriorVisitNumber = segments.Length > 5 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments.ElementAtOrDefault(5), false) : null;
            PriorAlternateVisitId = segments.Length > 6 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments.ElementAtOrDefault(6), false) : null;
            PriorPatientName = segments.Length > 7 ? TypeHelper.Deserialize<ExtendedPersonName>(segments.ElementAtOrDefault(7), false) : null;
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
                                StringHelper.StringFormatSequence(0, 8, Configuration.FieldSeparator),
                                Id,
                                PriorPatientIdentifierList != null ? string.Join(Configuration.FieldRepeatSeparator, PriorPatientIdentifierList.Select(x => x.ToDelimitedString())) : null,
                                PriorAlternatePatientId != null ? string.Join(Configuration.FieldRepeatSeparator, PriorAlternatePatientId.Select(x => x.ToDelimitedString())) : null,
                                PriorPatientAccountNumber?.ToDelimitedString(),
                                PriorPatientId,
                                PriorVisitNumber?.ToDelimitedString(),
                                PriorAlternateVisitId?.ToDelimitedString(),
                                PriorPatientName?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}