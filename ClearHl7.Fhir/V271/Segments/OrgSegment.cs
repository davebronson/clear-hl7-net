using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V271.Types;

namespace ClearHl7.Fhir.V271.Segments
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

        /// <summary>
        /// ORG.1 - Set ID - ORG.
        /// </summary>
        public uint? SetIdOrg { get; set; }

        /// <summary>
        /// ORG.2 - Organization Unit Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0405</remarks>
        public CodedWithExceptions OrganizationUnitCode { get; set; }

        /// <summary>
        /// ORG.3 - Organization Unit Type Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0474</remarks>
        public CodedWithExceptions OrganizationUnitTypeCode { get; set; }

        /// <summary>
        /// ORG.4 - Primary Org Unit Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string PrimaryOrgUnitIndicator { get; set; }

        /// <summary>
        /// ORG.5 - Practitioner Org Unit Identifier.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit PractitionerOrgUnitIdentifier { get; set; }

        /// <summary>
        /// ORG.6 - Health Care Provider Type Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0452</remarks>
        public CodedWithExceptions HealthCareProviderTypeCode { get; set; }

        /// <summary>
        /// ORG.7 - Health Care Provider Classification Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0453</remarks>
        public CodedWithExceptions HealthCareProviderClassificationCode { get; set; }

        /// <summary>
        /// ORG.8 - Health Care Provider Area of Specialization Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0454</remarks>
        public CodedWithExceptions HealthCareProviderAreaOfSpecializationCode { get; set; }

        /// <summary>
        /// ORG.9 - Effective Date Range.
        /// </summary>
        public DateTimeRange EffectiveDateRange { get; set; }

        /// <summary>
        /// ORG.10 - Employment Status Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0066</remarks>
        public CodedWithExceptions EmploymentStatusCode { get; set; }

        /// <summary>
        /// ORG.11 - Board Approval Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string BoardApprovalIndicator { get; set; }

        /// <summary>
        /// ORG.12 - Primary Care Physician Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string PrimaryCarePhysicianIndicator { get; set; }

        /// <summary>
        /// ORG.13 - Cost Center Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0539</remarks>
        public IEnumerable<CodedWithExceptions> CostCenterCode { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}",
                                Id,
                                SetIdOrg.HasValue ? SetIdOrg.Value.ToString(culture) : null,
                                OrganizationUnitCode?.ToDelimitedString(),
                                OrganizationUnitTypeCode?.ToDelimitedString(),
                                PrimaryOrgUnitIndicator,
                                PractitionerOrgUnitIdentifier?.ToDelimitedString(),
                                HealthCareProviderTypeCode?.ToDelimitedString(),
                                HealthCareProviderClassificationCode?.ToDelimitedString(),
                                HealthCareProviderAreaOfSpecializationCode?.ToDelimitedString(),
                                EffectiveDateRange?.ToDelimitedString(),
                                EmploymentStatusCode?.ToDelimitedString(),
                                BoardApprovalIndicator,
                                PrimaryCarePhysicianIndicator,
                                CostCenterCode != null ? string.Join("~", CostCenterCode.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd('|');
        }
    }
}