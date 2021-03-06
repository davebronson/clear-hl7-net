﻿using ClearHl7.Helpers;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
        /// </summary>
        public string AutomaticRepeatAllowed { get; set; }

        /// <summary>
        /// TCD.7 - Reflex Allowed.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
        /// </summary>
        public string ReflexAllowed { get; set; }

        /// <summary>
        /// TCD.8 - Analyte Repeat Status.
        /// <para>Suggested: 0389 Analyte Repeat Status -&gt; ClearHl7.Codes.V270.CodeAnalyteRepeatStatus</para>
        /// </summary>
        public CodedWithExceptions AnalyteRepeatStatus { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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