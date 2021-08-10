using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment TCD - Test Code Detail.
    /// </summary>
    public class TcdSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "TCD";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// TCD.1 - Universal Service Identifier.
        /// </summary>
        public CodedWithExceptions UniversalServiceIdentifier { get; set; }

        /// <summary>
        /// TCD.2 - Auto-Dilution Factor.
        /// </summary>
        public StructuredNumeric AutoDilutionFactor { get; set; }

        /// <summary>
        /// TCD.3 - Rerun Dilution Factor.
        /// </summary>
        public StructuredNumeric RerunDilutionFactor { get; set; }

        /// <summary>
        /// TCD.4 - Pre-Dilution Factor.
        /// </summary>
        public StructuredNumeric PreDilutionFactor { get; set; }

        /// <summary>
        /// TCD.5 - Endogenous Content of Pre-Dilution Diluent.
        /// </summary>
        public StructuredNumeric EndogenousContentOfPreDilutionDiluent { get; set; }

        /// <summary>
        /// TCD.6 - Automatic Repeat Allowed.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeYesNoIndicator</para>
        /// </summary>
        public string AutomaticRepeatAllowed { get; set; }

        /// <summary>
        /// TCD.7 - Reflex Allowed.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeYesNoIndicator</para>
        /// </summary>
        public string ReflexAllowed { get; set; }

        /// <summary>
        /// TCD.8 - Analyte Repeat Status.
        /// <para>Suggested: 0389 Analyte Repeat Status -&gt; ClearHl7.Codes.V281.CodeAnalyteRepeatStatus</para>
        /// </summary>
        public CodedWithExceptions AnalyteRepeatStatus { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            UniversalServiceIdentifier = segments.Length > 1 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(1), false) : null;
            AutoDilutionFactor = segments.Length > 2 ? TypeHelper.Deserialize<StructuredNumeric>(segments.ElementAtOrDefault(2), false) : null;
            RerunDilutionFactor = segments.Length > 3 ? TypeHelper.Deserialize<StructuredNumeric>(segments.ElementAtOrDefault(3), false) : null;
            PreDilutionFactor = segments.Length > 4 ? TypeHelper.Deserialize<StructuredNumeric>(segments.ElementAtOrDefault(4), false) : null;
            EndogenousContentOfPreDilutionDiluent = segments.Length > 5 ? TypeHelper.Deserialize<StructuredNumeric>(segments.ElementAtOrDefault(5), false) : null;
            AutomaticRepeatAllowed = segments.ElementAtOrDefault(6);
            ReflexAllowed = segments.ElementAtOrDefault(7);
            AnalyteRepeatStatus = segments.Length > 8 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(8), false) : null;
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
                                StringHelper.StringFormatSequence(0, 9, Configuration.FieldSeparator),
                                Id,
                                UniversalServiceIdentifier?.ToDelimitedString(),
                                AutoDilutionFactor?.ToDelimitedString(),
                                RerunDilutionFactor?.ToDelimitedString(),
                                PreDilutionFactor?.ToDelimitedString(),
                                EndogenousContentOfPreDilutionDiluent?.ToDelimitedString(),
                                AutomaticRepeatAllowed,
                                ReflexAllowed,
                                AnalyteRepeatStatus?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}