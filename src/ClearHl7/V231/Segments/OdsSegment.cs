using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ODS - Dietary Orders, Supplements, And Preferences.
    /// </summary>
    public class OdsSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ODS";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ODS.1 - Type.
        /// <para>Suggested: 0159 Diet Code Specification Type -&gt; ClearHl7.Codes.V231.CodeDietCodeSpecificationType</para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// ODS.2 - Service Period.
        /// </summary>
        public IEnumerable<CodedElement> ServicePeriod { get; set; }

        /// <summary>
        /// ODS.3 - Diet, Supplement, or Preference Code.
        /// </summary>
        public IEnumerable<CodedElement> DietSupplementOrPreferenceCode { get; set; }

        /// <summary>
        /// ODS.4 - Text Instruction.
        /// </summary>
        public IEnumerable<string> TextInstruction { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            Type = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            ServicePeriod = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            DietSupplementOrPreferenceCode = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            TextInstruction = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(separator) : null;
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
                                StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator),
                                Id,
                                Type,
                                ServicePeriod != null ? string.Join(Configuration.FieldRepeatSeparator, ServicePeriod.Select(x => x.ToDelimitedString())) : null,
                                DietSupplementOrPreferenceCode != null ? string.Join(Configuration.FieldRepeatSeparator, DietSupplementOrPreferenceCode.Select(x => x.ToDelimitedString())) : null,
                                TextInstruction != null ? string.Join(Configuration.FieldRepeatSeparator, TextInstruction) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}