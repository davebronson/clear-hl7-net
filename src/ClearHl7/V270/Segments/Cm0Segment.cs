using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CM0 - Clinical Study Master.
    /// </summary>
    public class Cm0Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "CM0";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// CM0.1 - Set ID - CM0.
        /// </summary>
        public uint? SetIdCm0 { get; set; }

        /// <summary>
        /// CM0.2 - Sponsor Study ID.
        /// </summary>
        public EntityIdentifier SponsorStudyId { get; set; }

        /// <summary>
        /// CM0.3 - Alternate Study ID.
        /// </summary>
        public IEnumerable<EntityIdentifier> AlternateStudyId { get; set; }

        /// <summary>
        /// CM0.4 - Title of Study.
        /// </summary>
        public string TitleOfStudy { get; set; }

        /// <summary>
        /// CM0.5 - Chairman of Study.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> ChairmanOfStudy { get; set; }

        /// <summary>
        /// CM0.6 - Last IRB Approval Date.
        /// </summary>
        public DateTime? LastIrbApprovalDate { get; set; }

        /// <summary>
        /// CM0.7 - Total Accrual to Date.
        /// </summary>
        public decimal? TotalAccrualToDate { get; set; }

        /// <summary>
        /// CM0.8 - Last Accrual Date.
        /// </summary>
        public DateTime? LastAccrualDate { get; set; }

        /// <summary>
        /// CM0.9 - Contact for Study.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> ContactForStudy { get; set; }

        /// <summary>
        /// CM0.10 - Contact's Telephone Number.
        /// </summary>
        public ExtendedTelecommunicationNumber ContactsTelephoneNumber { get; set; }

        /// <summary>
        /// CM0.11 - Contact's Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> ContactsAddress { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 12, Configuration.FieldSeparator),
                                Id,
                                SetIdCm0.HasValue ? SetIdCm0.Value.ToString(culture) : null,
                                SponsorStudyId?.ToDelimitedString(),
                                AlternateStudyId != null ? string.Join(Configuration.FieldRepeatSeparator, AlternateStudyId.Select(x => x.ToDelimitedString())) : null,
                                TitleOfStudy,
                                ChairmanOfStudy != null ? string.Join(Configuration.FieldRepeatSeparator, ChairmanOfStudy.Select(x => x.ToDelimitedString())) : null,
                                LastIrbApprovalDate.HasValue ? LastIrbApprovalDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                TotalAccrualToDate.HasValue ? TotalAccrualToDate.Value.ToString(Consts.NumericFormat, culture) : null,
                                LastAccrualDate.HasValue ? LastAccrualDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                ContactForStudy != null ? string.Join(Configuration.FieldRepeatSeparator, ContactForStudy.Select(x => x.ToDelimitedString())) : null,
                                ContactsTelephoneNumber?.ToDelimitedString(),
                                ContactsAddress != null ? string.Join(Configuration.FieldRepeatSeparator, ContactsAddress.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}