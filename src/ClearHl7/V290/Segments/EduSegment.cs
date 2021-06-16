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
    /// HL7 Version 2 Segment EDU - Educational Detail.
    /// </summary>
    public class EduSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "EDU";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// EDU.1 - Set ID - EDU.
        /// </summary>
        public uint? SetIdEdu { get; set; }

        /// <summary>
        /// EDU.2 - Academic Degree.
        /// <para>Suggested: 0360 Degree/License/Certificate -&gt; ClearHl7.Codes.V290.CodeDegreeLicenseCertificate</para>
        /// </summary>
        public CodedWithExceptions AcademicDegree { get; set; }

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
        /// <para>Suggested: 0402 School Type -&gt; ClearHl7.Codes.V290.CodeSchoolType</para>
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

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public EduSegment FromDelimitedString(string delimitedString)
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

            SetIdEdu = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            AcademicDegree = segments.Length > 2 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(2)) : null;
            AcademicDegreeProgramDateRange = segments.Length > 3 ? new DateTimeRange().FromDelimitedString(segments.ElementAtOrDefault(3)) : null;
            AcademicDegreeProgramParticipationDateRange = segments.Length > 4 ? new DateTimeRange().FromDelimitedString(segments.ElementAtOrDefault(4)) : null;
            AcademicDegreeGrantedDate = segments.ElementAtOrDefault(5)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            School = segments.Length > 6 ? new ExtendedCompositeNameAndIdNumberForOrganizations().FromDelimitedString(segments.ElementAtOrDefault(6)) : null;
            SchoolTypeCode = segments.Length > 7 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(7)) : null;
            SchoolAddress = segments.Length > 8 ? new ExtendedAddress().FromDelimitedString(segments.ElementAtOrDefault(8)) : null;
            MajorFieldOfStudy = segments.Length > 9 ? segments.ElementAtOrDefault(9).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            
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
                                StringHelper.StringFormatSequence(0, 10, Configuration.FieldSeparator),
                                Id,
                                SetIdEdu.HasValue ? SetIdEdu.Value.ToString(culture) : null,
                                AcademicDegree?.ToDelimitedString(),
                                AcademicDegreeProgramDateRange?.ToDelimitedString(),
                                AcademicDegreeProgramParticipationDateRange?.ToDelimitedString(),
                                AcademicDegreeGrantedDate.HasValue ? AcademicDegreeGrantedDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                School?.ToDelimitedString(),
                                SchoolTypeCode?.ToDelimitedString(),
                                SchoolAddress?.ToDelimitedString(),
                                MajorFieldOfStudy != null ? string.Join(Configuration.FieldRepeatSeparator, MajorFieldOfStudy.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}