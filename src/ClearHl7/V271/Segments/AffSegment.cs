using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment AFF - Professional Affiliation.
    /// </summary>
    public class AffSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "AFF";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// AFF.1 - Set ID - AFF.
        /// </summary>
        public uint? SetIdAff { get; set; }

        /// <summary>
        /// AFF.2 - Professional Organization.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations ProfessionalOrganization { get; set; }

        /// <summary>
        /// AFF.3 - Professional Organization Address.
        /// </summary>
        public ExtendedAddress ProfessionalOrganizationAddress { get; set; }

        /// <summary>
        /// AFF.4 - Professional Organization Affiliation Date Range.
        /// </summary>
        public IEnumerable<DateTimeRange> ProfessionalOrganizationAffiliationDateRange { get; set; }

        /// <summary>
        /// AFF.5 - Professional Affiliation Additional Information.
        /// </summary>
        public string ProfessionalAffiliationAdditionalInformation { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdAff = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            ProfessionalOrganization = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[2], false) : null;
            ProfessionalOrganizationAddress = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<ExtendedAddress>(segments[3], false) : null;
            ProfessionalOrganizationAffiliationDateRange = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(separator).Select(x => TypeHelper.Deserialize<DateTimeRange>(x, false)) : null;
            ProfessionalAffiliationAdditionalInformation = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
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
                                StringHelper.StringFormatSequence(0, 6, Configuration.FieldSeparator),
                                Id,
                                SetIdAff.HasValue ? SetIdAff.Value.ToString(culture) : null,
                                ProfessionalOrganization?.ToDelimitedString(),
                                ProfessionalOrganizationAddress?.ToDelimitedString(),
                                ProfessionalOrganizationAffiliationDateRange != null ? string.Join(Configuration.FieldRepeatSeparator, ProfessionalOrganizationAffiliationDateRange.Select(x => x.ToDelimitedString())) : null,
                                ProfessionalAffiliationAdditionalInformation
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}