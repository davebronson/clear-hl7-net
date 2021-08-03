using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
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
        /// <para>Suggested: 0405 Organization Unit</para>
        /// </summary>
        public CodedWithExceptions OrganizationUnitCode { get; set; }

        /// <summary>
        /// ORG.3 - Organization Unit Type Code.
        /// <para>Suggested: 0474 Practitioner Organization Unit Type -&gt; ClearHl7.Codes.V270.CodePractitionerOrganizationUnitType</para>
        /// </summary>
        public CodedWithExceptions OrganizationUnitTypeCode { get; set; }

        /// <summary>
        /// ORG.4 - Primary Org Unit Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
        /// </summary>
        public string PrimaryOrgUnitIndicator { get; set; }

        /// <summary>
        /// ORG.5 - Practitioner Org Unit Identifier.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit PractitionerOrgUnitIdentifier { get; set; }

        /// <summary>
        /// ORG.6 - Health Care Provider Type Code.
        /// <para>Suggested: 0452 Health Care Provider Type Code</para>
        /// </summary>
        public CodedWithExceptions HealthCareProviderTypeCode { get; set; }

        /// <summary>
        /// ORG.7 - Health Care Provider Classification Code.
        /// <para>Suggested: 0453 Health Care Provider Classification</para>
        /// </summary>
        public CodedWithExceptions HealthCareProviderClassificationCode { get; set; }

        /// <summary>
        /// ORG.8 - Health Care Provider Area of Specialization Code.
        /// <para>Suggested: 0454 Health Care Provider Area Of Specialization</para>
        /// </summary>
        public CodedWithExceptions HealthCareProviderAreaOfSpecializationCode { get; set; }

        /// <summary>
        /// ORG.9 - Effective Date Range.
        /// </summary>
        public DateTimeRange EffectiveDateRange { get; set; }

        /// <summary>
        /// ORG.10 - Employment Status Code.
        /// <para>Suggested: 0066 Employment Status -&gt; ClearHl7.Codes.V270.CodeEmploymentStatus</para>
        /// </summary>
        public CodedWithExceptions EmploymentStatusCode { get; set; }

        /// <summary>
        /// ORG.11 - Board Approval Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
        /// </summary>
        public string BoardApprovalIndicator { get; set; }

        /// <summary>
        /// ORG.12 - Primary Care Physician Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
        /// </summary>
        public string PrimaryCarePhysicianIndicator { get; set; }

        /// <summary>
        /// ORG.13 - Cost Center Code.
        /// <para>Suggested: 0539 Cost Center Code</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> CostCenterCode { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
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

            SetIdOrg = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            OrganizationUnitCode = segments.Length > 2 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(2), false) : null;
            OrganizationUnitTypeCode = segments.Length > 3 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(3), false) : null;
            PrimaryOrgUnitIndicator = segments.ElementAtOrDefault(4);
            PractitionerOrgUnitIdentifier = segments.Length > 5 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments.ElementAtOrDefault(5), false) : null;
            HealthCareProviderTypeCode = segments.Length > 6 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(6), false) : null;
            HealthCareProviderClassificationCode = segments.Length > 7 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(7), false) : null;
            HealthCareProviderAreaOfSpecializationCode = segments.Length > 8 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(8), false) : null;
            EffectiveDateRange = segments.Length > 9 ? TypeHelper.Deserialize<DateTimeRange>(segments.ElementAtOrDefault(9), false) : null;
            EmploymentStatusCode = segments.Length > 10 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(10), false) : null;
            BoardApprovalIndicator = segments.ElementAtOrDefault(11);
            PrimaryCarePhysicianIndicator = segments.ElementAtOrDefault(12);
            CostCenterCode = segments.Length > 13 ? segments.ElementAtOrDefault(13).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
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
                                StringHelper.StringFormatSequence(0, 14, Configuration.FieldSeparator),
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
                                CostCenterCode != null ? string.Join(Configuration.FieldRepeatSeparator, CostCenterCode.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}