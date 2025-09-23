using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment URD - Results/Update Definition.
    /// </summary>
    public class UrdSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UrdSegment"/> class.
        /// </summary>
        public UrdSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrdSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public UrdSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "URD";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// URD.1 - R/U Date/Time.
        /// </summary>
        public DateTime? RuDateTime { get; set; }

        /// <summary>
        /// URD.2 - Report Priority.
        /// <para>Suggested: 0109 Report Priority</para>
        /// </summary>
        public string ReportPriority { get; set; }

        /// <summary>
        /// URD.3 - R/U Who Subject Definition.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> RuWhoSubjectDefinition { get; set; }

        /// <summary>
        /// URD.4 - R/U What Subject Definition.
        /// <para>Suggested: 0048 What Subject Filter</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> RuWhatSubjectDefinition { get; set; }

        /// <summary>
        /// URD.5 - R/U What Department Code.
        /// </summary>
        public IEnumerable<CodedWithExceptions> RuWhatDepartmentCode { get; set; }

        /// <summary>
        /// URD.6 - R/U Display/Print Locations.
        /// </summary>
        public IEnumerable<string> RuDisplayPrintLocations { get; set; }

        /// <summary>
        /// URD.7 - R/U Results Level.
        /// <para>Suggested: 0108 Query Results Level</para>
        /// </summary>
        public string RuResultsLevel { get; set; }

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

            RuDateTime = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDateTime() : null;
            ReportPriority = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            RuWhoSubjectDefinition = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            RuWhatSubjectDefinition = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            RuWhatDepartmentCode = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            RuDisplayPrintLocations = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            RuResultsLevel = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 8, Configuration.FieldSeparator),
                                Id,
                                RuDateTime.ToHl7DateTimeString(typeof(UrdSegment), nameof(RuDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
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
