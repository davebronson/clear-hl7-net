using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
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
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public Oh2Segment FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetId = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            ActionCode = segments.ElementAtOrDefault(2);
            EnteredDate = segments.ElementAtOrDefault(3)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            Occupation = segments.Length > 4 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(4)) : null;
            Industry = segments.Length > 5 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(5)) : null;
            WorkClassification = segments.Length > 6 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(6)) : null;
            JobStartDate = segments.ElementAtOrDefault(7)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            JobEndDate = segments.ElementAtOrDefault(8)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            WorkSchedule = segments.Length > 9 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(9)) : null;
            AverageHoursWorkedPerDay = segments.ElementAtOrDefault(10)?.ToNullableDecimal();
            AverageDaysWorkedPerWeek = segments.ElementAtOrDefault(11)?.ToNullableDecimal();
            EmployerOrganization = segments.Length > 12 ? new ExtendedCompositeNameAndIdNumberForOrganizations().FromDelimitedString(segments.ElementAtOrDefault(12)) : null;
            EmployerAddress = segments.Length > 13 ? segments.ElementAtOrDefault(13).Split(separator).Select(x => new ExtendedAddress().FromDelimitedString(x)) : null;
            SupervisoryLevel = segments.Length > 14 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(14)) : null;
            JobDuties = segments.Length > 15 ? segments.ElementAtOrDefault(15).Split(separator) : null;
            OccupationalHazards = segments.Length > 16 ? segments.ElementAtOrDefault(16).Split(separator) : null;
            JobUniqueIdentifier = segments.Length > 17 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(17)) : null;
            CurrentJobIndicator = segments.Length > 18 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(18)) : null;
            
            return this;
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