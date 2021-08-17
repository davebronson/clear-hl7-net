using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment URD - Results/Update Definition.
    /// </summary>
    public class UrdSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "URD";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// URD.1 - R/U Date/Time.
        /// </summary>
        public DateTime? RuDateTime { get; set; }

        /// <summary>
        /// URD.2 - Report Priority.
        /// <para>Suggested: 0109 Report Priority -&gt; ClearHl7.Codes.V240.CodeReportPriority</para>
        /// </summary>
        public string ReportPriority { get; set; }

        /// <summary>
        /// URD.3 - R/U Who Subject Definition.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> RuWhoSubjectDefinition { get; set; }

        /// <summary>
        /// URD.4 - R/U What Subject Definition.
        /// <para>Suggested: 0048 What Subject Filter -&gt; ClearHl7.Codes.V240.CodeWhatSubjectFilter</para>
        /// </summary>
        public IEnumerable<CodedElement> RuWhatSubjectDefinition { get; set; }

        /// <summary>
        /// URD.5 - R/U What Department Code.
        /// </summary>
        public IEnumerable<CodedElement> RuWhatDepartmentCode { get; set; }

        /// <summary>
        /// URD.6 - R/U Display/Print Locations.
        /// </summary>
        public IEnumerable<string> RuDisplayPrintLocations { get; set; }

        /// <summary>
        /// URD.7 - R/U Results Level.
        /// <para>Suggested: 0108 Query Results Level -&gt; ClearHl7.Codes.V240.CodeQueryResultsLevel</para>
        /// </summary>
        public string RuResultsLevel { get; set; }

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

            RuDateTime = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDateTime() : null;
            ReportPriority = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            RuWhoSubjectDefinition = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            RuWhatSubjectDefinition = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            RuWhatDepartmentCode = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            RuDisplayPrintLocations = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(separator) : null;
            RuResultsLevel = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
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
                                RuDateTime.HasValue ? RuDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ReportPriority,
                                RuWhoSubjectDefinition != null ? string.Join(Configuration.FieldRepeatSeparator, RuWhoSubjectDefinition.Select(x => x.ToDelimitedString())) : null,
                                RuWhatSubjectDefinition != null ? string.Join(Configuration.FieldRepeatSeparator, RuWhatSubjectDefinition.Select(x => x.ToDelimitedString())) : null,
                                RuWhatDepartmentCode != null ? string.Join(Configuration.FieldRepeatSeparator, RuWhatDepartmentCode.Select(x => x.ToDelimitedString())) : null,
                                RuDisplayPrintLocations != null ? string.Join(Configuration.FieldRepeatSeparator, RuDisplayPrintLocations) : null,
                                RuResultsLevel
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}