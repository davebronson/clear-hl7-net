using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OH2 - Past or Present Job.
    /// </summary>
    public class Oh2Segment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Oh2Segment"/> class.
        /// </summary>
        public Oh2Segment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Oh2Segment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public Oh2Segment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "OH2";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// OH2.1 - Set ID.
        /// </summary>
        public uint? SetId { get; set; }

        /// <summary>
        /// OH2.2 - Action Code.
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// OH2.3 - Entered Date.
        /// </summary>
        public DateTime? EnteredDate { get; set; }

        /// <summary>
        /// OH2.4 - Occupation.
        /// <para>Suggested: 0958 Occupation</para>
        /// </summary>
        public CodedWithExceptions Occupation { get; set; }

        /// <summary>
        /// OH2.5 - Industry.
        /// <para>Suggested: 0955 Industry</para>
        /// </summary>
        public CodedWithExceptions Industry { get; set; }

        /// <summary>
        /// OH2.6 - Work Classification.
        /// <para>Suggested: 0959 Work Classification</para>
        /// </summary>
        public CodedWithExceptions WorkClassification { get; set; }

        /// <summary>
        /// OH2.7 - Job Start Date.
        /// </summary>
        public DateTime? JobStartDate { get; set; }

        /// <summary>
        /// OH2.8 - Job End Date.
        /// </summary>
        public DateTime? JobEndDate { get; set; }

        /// <summary>
        /// OH2.9 - Work Schedule.
        /// <para>Suggested: 0954 Work Schedule</para>
        /// </summary>
        public CodedWithExceptions WorkSchedule { get; set; }

        /// <summary>
        /// OH2.10 - Average Hours Worked Per Day.
        /// </summary>
        public decimal? AverageHoursWorkedPerDay { get; set; }

        /// <summary>
        /// OH2.11 - Average Days Worked Per Week.
        /// </summary>
        public decimal? AverageDaysWorkedPerWeek { get; set; }

        /// <summary>
        /// OH2.12 - Employer Organization.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations EmployerOrganization { get; set; }

        /// <summary>
        /// OH2.13 - Employer Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> EmployerAddress { get; set; }

        /// <summary>
        /// OH2.14 - Supervisory Level.
        /// <para>Suggested: 0956 Supervisory Level</para>
        /// </summary>
        public CodedWithExceptions SupervisoryLevel { get; set; }

        /// <summary>
        /// OH2.15 - Job Duties.
        /// </summary>
        public IEnumerable<string> JobDuties { get; set; }

        /// <summary>
        /// OH2.16 - Occupational Hazards.
        /// </summary>
        public IEnumerable<string> OccupationalHazards { get; set; }

        /// <summary>
        /// OH2.17 - Job Unique Identifier.
        /// </summary>
        public EntityIdentifier JobUniqueIdentifier { get; set; }

        /// <summary>
        /// OH2.18 - Current Job Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public CodedWithExceptions CurrentJobIndicator { get; set; }

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

            SetId = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            ActionCode = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            EnteredDate = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
            Occupation = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[4], false, seps) : null;
            Industry = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[5], false, seps) : null;
            WorkClassification = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[6], false, seps) : null;
            JobStartDate = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            JobEndDate = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDateTime() : null;
            WorkSchedule = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[9], false, seps) : null;
            AverageHoursWorkedPerDay = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDecimal() : null;
            AverageDaysWorkedPerWeek = segments.Length > 11 && segments[11].Length > 0 ? segments[11].ToNullableDecimal() : null;
            EmployerOrganization = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[12], false, seps) : null;
            EmployerAddress = segments.Length > 13 && segments[13].Length > 0 ? segments[13].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedAddress>(x, false, seps)) : null;
            SupervisoryLevel = segments.Length > 14 && segments[14].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[14], false, seps) : null;
            JobDuties = segments.Length > 15 && segments[15].Length > 0 ? segments[15].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            OccupationalHazards = segments.Length > 16 && segments[16].Length > 0 ? segments[16].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            JobUniqueIdentifier = segments.Length > 17 && segments[17].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[17], false, seps) : null;
            CurrentJobIndicator = segments.Length > 18 && segments[18].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[18], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 19, Configuration.FieldSeparator),
                                Id,
                                SetId.HasValue ? SetId.Value.ToString(culture) : null,
                                ActionCode,
                                EnteredDate.ToHl7DateTimeString(typeof(Oh2Segment), nameof(EnteredDate), Consts.DateFormatPrecisionDay, culture),
                                Occupation?.ToDelimitedString(),
                                Industry?.ToDelimitedString(),
                                WorkClassification?.ToDelimitedString(),
                                JobStartDate.ToHl7DateTimeString(typeof(Oh2Segment), nameof(JobStartDate), Consts.DateFormatPrecisionDay, culture),
                                JobEndDate.ToHl7DateTimeString(typeof(Oh2Segment), nameof(JobEndDate), Consts.DateFormatPrecisionDay, culture),
                                WorkSchedule?.ToDelimitedString(),
                                AverageHoursWorkedPerDay.HasValue ? AverageHoursWorkedPerDay.Value.ToString(Consts.NumericFormat, culture) : null,
                                AverageDaysWorkedPerWeek.HasValue ? AverageDaysWorkedPerWeek.Value.ToString(Consts.NumericFormat, culture) : null,
                                EmployerOrganization?.ToDelimitedString(),
                                EmployerAddress != null ? string.Join(Configuration.FieldRepeatSeparator, EmployerAddress.Select(x => x.ToDelimitedString())) : null,
                                SupervisoryLevel?.ToDelimitedString(),
                                JobDuties != null ? string.Join(Configuration.FieldRepeatSeparator, JobDuties) : null,
                                OccupationalHazards != null ? string.Join(Configuration.FieldRepeatSeparator, OccupationalHazards) : null,
                                JobUniqueIdentifier?.ToDelimitedString(),
                                CurrentJobIndicator?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
