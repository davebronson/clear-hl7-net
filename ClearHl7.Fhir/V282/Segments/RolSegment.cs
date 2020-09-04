using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// ROL.1 - Role Instance ID.
        ///// </summary>
        //public RoleInstanceId { get; set; }

        ///// <summary>
        ///// ROL.2 - Action Code.
        ///// </summary>
        //public ActionCode { get; set; }

        ///// <summary>
        ///// ROL.3 - Role-ROL.
        ///// </summary>
        //public RoleRol { get; set; }

        ///// <summary>
        ///// ROL.4 - Role Person.
        ///// </summary>
        //public RolePerson { get; set; }

        ///// <summary>
        ///// ROL.5 - Role Begin Date/Time.
        ///// </summary>
        //public RoleBeginDateTime { get; set; }

        ///// <summary>
        ///// ROL.6 - Role End Date/Time.
        ///// </summary>
        //public RoleEndDateTime { get; set; }

        ///// <summary>
        ///// ROL.7 - Role Duration.
        ///// </summary>
        //public RoleDuration { get; set; }

        ///// <summary>
        ///// ROL.8 - Role Action Reason.
        ///// </summary>
        //public RoleActionReason { get; set; }

        ///// <summary>
        ///// ROL.9 - Provider Type.
        ///// </summary>
        //public ProviderType { get; set; }

        ///// <summary>
        ///// ROL.10 - Organization Unit Type.
        ///// </summary>
        //public OrganizationUnitType { get; set; }

        ///// <summary>
        ///// ROL.11 - Office/Home Address/Birthplace.
        ///// </summary>
        //public OfficeHomeAddressBirthplace { get; set; }

        ///// <summary>
        ///// ROL.12 - Phone.
        ///// </summary>
        //public Phone { get; set; }

        ///// <summary>
        ///// ROL.13 - Person's Location.
        ///// </summary>
        //public PersonsLocation { get; set; }

        ///// <summary>
        ///// ROL.14 - Organization.
        ///// </summary>
        //public Organization { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}"
                                ).TrimEnd('|');
        }
    }
}