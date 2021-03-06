﻿using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OH2 - Past or Present Job.
    /// </summary>
    public class Oh2Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "OH2";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 19, Configuration.FieldSeparator),
                                Id,
                                SetId.HasValue ? SetId.Value.ToString(culture) : null,
                                ActionCode,
                                EnteredDate.HasValue ? EnteredDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                Occupation?.ToDelimitedString(),
                                Industry?.ToDelimitedString(),
                                WorkClassification?.ToDelimitedString(),
                                JobStartDate.HasValue ? JobStartDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                JobEndDate.HasValue ? JobEndDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
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