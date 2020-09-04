using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ORG - Practitioner Organization Unit.
    /// </summary>
    public class OrgSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ORG";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// ORG.1 - Set ID - ORG.
        ///// </summary>
        //public SetIdOrg { get; set; }

        ///// <summary>
        ///// ORG.2 - Organization Unit Code.
        ///// </summary>
        //public OrganizationUnitCode { get; set; }

        ///// <summary>
        ///// ORG.3 - Organization Unit Type Code.
        ///// </summary>
        //public OrganizationUnitTypeCode { get; set; }

        ///// <summary>
        ///// ORG.4 - Primary Org Unit Indicator.
        ///// </summary>
        //public PrimaryOrgUnitIndicator { get; set; }

        ///// <summary>
        ///// ORG.5 - Practitioner Org Unit Identifier.
        ///// </summary>
        //public PractitionerOrgUnitIdentifier { get; set; }

        ///// <summary>
        ///// ORG.6 - Health Care Provider Type Code.
        ///// </summary>
        //public HealthCareProviderTypeCode { get; set; }

        ///// <summary>
        ///// ORG.7 - Health Care Provider Classification Code.
        ///// </summary>
        //public HealthCareProviderClassificationCode { get; set; }

        ///// <summary>
        ///// ORG.8 - Health Care Provider Area of Specialization Code.
        ///// </summary>
        //public HealthCareProviderAreaOfSpecializationCode { get; set; }

        ///// <summary>
        ///// ORG.9 - Effective Date Range.
        ///// </summary>
        //public EffectiveDateRange { get; set; }

        ///// <summary>
        ///// ORG.10 - Employment Status Code.
        ///// </summary>
        //public EmploymentStatusCode { get; set; }

        ///// <summary>
        ///// ORG.11 - Board Approval Indicator.
        ///// </summary>
        //public BoardApprovalIndicator { get; set; }

        ///// <summary>
        ///// ORG.12 - Primary Care Physician Indicator.
        ///// </summary>
        //public PrimaryCarePhysicianIndicator { get; set; }

        ///// <summary>
        ///// ORG.13 - Cost Center Code.
        ///// </summary>
        //public CostCenterCode { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}"
                                ).TrimEnd('|');
        }
    }
}