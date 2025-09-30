using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PTH - Pathway.
    /// </summary>
    public class PthSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PthSegment"/> class.
        /// </summary>
        public PthSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PthSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public PthSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "PTH";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// PTH.1 - Action Code.
        /// <para>Suggested: 0287 Problem/Goal Action Code -&gt; ClearHl7.Codes.V231.CodeProblemGoalActionCode</para>
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// PTH.2 - Pathway ID.
        /// </summary>
        public CodedElement PathwayId { get; set; }

        /// <summary>
        /// PTH.3 - Pathway Instance ID.
        /// </summary>
        public EntityIdentifier PathwayInstanceId { get; set; }

        /// <summary>
        /// PTH.4 - Pathway Established Date/Time.
        /// </summary>
        public DateTime? PathwayEstablishedDateTime { get; set; }

        /// <summary>
        /// PTH.5 - Pathway Life Cycle Status.
        /// </summary>
        public CodedElement PathwayLifeCycleStatus { get; set; }

        /// <summary>
        /// PTH.6 - Change Pathway Life Cycle Status Date/Time.
        /// </summary>
        public DateTime? ChangePathwayLifeCycleStatusDateTime { get; set; }

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

            ActionCode = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            PathwayId = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[2], false, seps) : null;
            PathwayInstanceId = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[3], false, seps) : null;
            PathwayEstablishedDateTime = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            PathwayLifeCycleStatus = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[5], false, seps) : null;
            ChangePathwayLifeCycleStatusDateTime = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 7, Configuration.FieldSeparator),
                                Id,
                                ActionCode,
                                PathwayId?.ToDelimitedString(),
                                PathwayInstanceId?.ToDelimitedString(),
                                PathwayEstablishedDateTime?.ToHl7DateTimeString(typeof(PthSegment), nameof(PathwayEstablishedDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                PathwayLifeCycleStatus?.ToDelimitedString(),
                                ChangePathwayLifeCycleStatusDateTime?.ToHl7DateTimeString(typeof(PthSegment), nameof(ChangePathwayLifeCycleStatusDateTime), Consts.DateTimeFormatPrecisionSecond, culture)
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
