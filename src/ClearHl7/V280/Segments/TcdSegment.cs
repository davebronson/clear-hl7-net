using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment TCD - Test Code Detail.
    /// </summary>
    public class TcdSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TcdSegment"/> class.
        /// </summary>
        public TcdSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TcdSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public TcdSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "TCD";

        /// <inheritdoc/>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V280.CodeYesNoIndicator</para>
        /// </summary>
        public string AutomaticRepeatAllowed { get; set; }

        /// <summary>
        /// TCD.7 - Reflex Allowed.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V280.CodeYesNoIndicator</para>
        /// </summary>
        public string ReflexAllowed { get; set; }

        /// <summary>
        /// TCD.8 - Analyte Repeat Status.
        /// <para>Suggested: 0389 Analyte Repeat Status -&gt; ClearHl7.Codes.V280.CodeAnalyteRepeatStatus</para>
        /// </summary>
        public CodedWithExceptions AnalyteRepeatStatus { get; set; }

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

            UniversalServiceIdentifier = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], false, seps) : null;
            AutoDilutionFactor = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<StructuredNumeric>(segments[2], false, seps) : null;
            RerunDilutionFactor = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<StructuredNumeric>(segments[3], false, seps) : null;
            PreDilutionFactor = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<StructuredNumeric>(segments[4], false, seps) : null;
            EndogenousContentOfPreDilutionDiluent = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<StructuredNumeric>(segments[5], false, seps) : null;
            AutomaticRepeatAllowed = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            ReflexAllowed = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            AnalyteRepeatStatus = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[8], false, seps) : null;
        }

        /// <inheritdoc/>
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
