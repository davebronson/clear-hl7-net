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
    /// HL7 Version 2 Segment EDU - Educational Detail.
    /// </summary>
    public class EduSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EduSegment"/> class.
        /// </summary>
        public EduSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EduSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public EduSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "EDU";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// EDU.1 - Set ID - EDU.
        /// </summary>
        public uint? SetIdEdu { get; set; }

        /// <summary>
        /// EDU.2 - Academic Degree.
        /// <para>Suggested: 0360 Degree/License/Certificate -&gt; ClearHl7.Codes.V260.CodeDegreeLicenseCertificate</para>
        /// </summary>
        public string AcademicDegree { get; set; }

        /// <summary>
        /// EDU.3 - Academic Degree Program Date Range.
        /// </summary>
        public DateTimeRange AcademicDegreeProgramDateRange { get; set; }

        /// <summary>
        /// EDU.4 - Academic Degree Program Participation Date Range.
        /// </summary>
        public DateTimeRange AcademicDegreeProgramParticipationDateRange { get; set; }

        /// <summary>
        /// EDU.5 - Academic Degree Granted Date.
        /// </summary>
        public DateTime? AcademicDegreeGrantedDate { get; set; }

        /// <summary>
        /// EDU.6 - School.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations School { get; set; }

        /// <summary>
        /// EDU.7 - School Type Code.
        /// <para>Suggested: 0402 School Type -&gt; ClearHl7.Codes.V260.CodeSchoolType</para>
        /// </summary>
        public CodedWithExceptions SchoolTypeCode { get; set; }

        /// <summary>
        /// EDU.8 - School Address.
        /// </summary>
        public ExtendedAddress SchoolAddress { get; set; }

        /// <summary>
        /// EDU.9 - Major Field of Study.
        /// </summary>
        public IEnumerable<CodedWithExceptions> MajorFieldOfStudy { get; set; }

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

            SetIdEdu = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            AcademicDegree = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            AcademicDegreeProgramDateRange = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<DateTimeRange>(segments[3], false, seps) : null;
            AcademicDegreeProgramParticipationDateRange = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<DateTimeRange>(segments[4], false, seps) : null;
            AcademicDegreeGrantedDate = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDateTime() : null;
            School = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[6], false, seps) : null;
            SchoolTypeCode = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[7], false, seps) : null;
            SchoolAddress = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<ExtendedAddress>(segments[8], false, seps) : null;
            MajorFieldOfStudy = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 10, Configuration.FieldSeparator),
                                Id,
                                SetIdEdu.HasValue ? SetIdEdu.Value.ToString(culture) : null,
                                AcademicDegree,
                                AcademicDegreeProgramDateRange?.ToDelimitedString(),
                                AcademicDegreeProgramParticipationDateRange?.ToDelimitedString(),
                                AcademicDegreeGrantedDate?.ToHl7DateTimeString(typeof(EduSegment), nameof(AcademicDegreeGrantedDate), Consts.DateFormatPrecisionDay, culture),
                                School?.ToDelimitedString(),
                                SchoolTypeCode?.ToDelimitedString(),
                                SchoolAddress?.ToDelimitedString(),
                                MajorFieldOfStudy != null ? string.Join(Configuration.FieldRepeatSeparator, MajorFieldOfStudy.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
