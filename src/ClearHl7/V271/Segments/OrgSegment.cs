using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ORG - Practitioner Organization Unit.
    /// </summary>
    public class OrgSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgSegment"/> class.
        /// </summary>
        public OrgSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public OrgSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "ORG";

        /// <inheritdoc/>
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
        /// <para>Suggested: 0474 Practitioner Organization Unit Type -&gt; ClearHl7.Codes.V271.CodePractitionerOrganizationUnitType</para>
        /// </summary>
        public CodedWithExceptions OrganizationUnitTypeCode { get; set; }

        /// <summary>
        /// ORG.4 - Primary Org Unit Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V271.CodeYesNoIndicator</para>
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
        /// <para>Suggested: 0066 Employment Status -&gt; ClearHl7.Codes.V271.CodeEmploymentStatus</para>
        /// </summary>
        public CodedWithExceptions EmploymentStatusCode { get; set; }

        /// <summary>
        /// ORG.11 - Board Approval Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V271.CodeYesNoIndicator</para>
        /// </summary>
        public string BoardApprovalIndicator { get; set; }

        /// <summary>
        /// ORG.12 - Primary Care Physician Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V271.CodeYesNoIndicator</para>
        /// </summary>
        public string PrimaryCarePhysicianIndicator { get; set; }

        /// <summary>
        /// ORG.13 - Cost Center Code.
        /// <para>Suggested: 0539 Cost Center Code</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> CostCenterCode { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdOrg = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            OrganizationUnitCode = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            OrganizationUnitTypeCode = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[3], false, seps) : null;
            PrimaryOrgUnitIndicator = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            PractitionerOrgUnitIdentifier = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[5], false, seps) : null;
            HealthCareProviderTypeCode = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[6], false, seps) : null;
            HealthCareProviderClassificationCode = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[7], false, seps) : null;
            HealthCareProviderAreaOfSpecializationCode = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[8], false, seps) : null;
            EffectiveDateRange = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<DateTimeRange>(segments[9], false, seps) : null;
            EmploymentStatusCode = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[10], false, seps) : null;
            BoardApprovalIndicator = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            PrimaryCarePhysicianIndicator = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            CostCenterCode = segments.Length > 13 && segments[13].Length > 0 ? segments[13].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
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
