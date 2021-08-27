using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
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
        public CodedElement UniversalServiceIdentifier { get; set; }

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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V250.CodeYesNoIndicator</para>
        /// </summary>
        public string AutomaticRepeatAllowed { get; set; }

        /// <summary>
        /// TCD.7 - Reflex Allowed.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V250.CodeYesNoIndicator</para>
        /// </summary>
        public string ReflexAllowed { get; set; }

        /// <summary>
        /// TCD.8 - Analyte Repeat Status.
        /// <para>Suggested: 0389 Analyte Repeat Status -&gt; ClearHl7.Codes.V250.CodeAnalyteRepeatStatus</para>
        /// </summary>
        public CodedElement AnalyteRepeatStatus { get; set; }

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
        public void FromDelimitedString(string delimitedString, Separators separators)
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

            UniversalServiceIdentifier = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[1], false, seps) : null;
            AutoDilutionFactor = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<StructuredNumeric>(segments[2], false, seps) : null;
            RerunDilutionFactor = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<StructuredNumeric>(segments[3], false, seps) : null;
            PreDilutionFactor = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<StructuredNumeric>(segments[4], false, seps) : null;
            EndogenousContentOfPreDilutionDiluent = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<StructuredNumeric>(segments[5], false, seps) : null;
            AutomaticRepeatAllowed = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            ReflexAllowed = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            AnalyteRepeatStatus = segments.Length > 8 && segments[8].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[8], false, seps) : null;
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