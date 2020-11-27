using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V230.Types;

namespace ClearHl7.Fhir.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ROL - Role.
    /// </summary>
    public class RolSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ROL";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ROL.1 - Role Instance ID.
        /// </summary>
        public EntityIdentifier RoleInstanceId { get; set; }

        /// <summary>
        /// ROL.2 - Action Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0287</remarks>
        public string ActionCode { get; set; }

        /// <summary>
        /// ROL.3 - Role-ROL.
        /// </summary>
        public CodedElement RoleRol { get; set; }

        /// <summary>
        /// ROL.4 - Role Person.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons RolePerson { get; set; }

        /// <summary>
        /// ROL.5 - Role Begin Date/Time.
        /// </summary>
        public DateTime? RoleBeginDateTime { get; set; }

        /// <summary>
        /// ROL.6 - Role End Date/Time.
        /// </summary>
        public DateTime? RoleEndDateTime { get; set; }

        /// <summary>
        /// ROL.7 - Role Duration.
        /// </summary>
        public CodedElement RoleDuration { get; set; }

        /// <summary>
        /// ROL.8 - Role Action Reason.
        /// </summary>
        public CodedElement RoleActionReason { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}",
                                Id,
                                RoleInstanceId?.ToDelimitedString(),
                                ActionCode,
                                RoleRol?.ToDelimitedString(),
                                RolePerson?.ToDelimitedString(),
                                RoleBeginDateTime.HasValue ? RoleBeginDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                RoleEndDateTime.HasValue ? RoleEndDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                RoleDuration?.ToDelimitedString(),
                                RoleActionReason?.ToDelimitedString()
                                ).TrimEnd('|');
        }
    }
}