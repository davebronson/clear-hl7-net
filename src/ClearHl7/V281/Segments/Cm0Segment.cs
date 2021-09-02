using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
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
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
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

            SetIdCm0 = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            SponsorStudyId = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[2], false, seps) : null;
            AlternateStudyId = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<EntityIdentifier>(x, false, seps)) : null;
            TitleOfStudy = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            ChairmanOfStudy = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            LastIrbApprovalDate = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
            TotalAccrualToDate = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDecimal() : null;
            LastAccrualDate = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDateTime() : null;
            ContactForStudy = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            ContactsTelephoneNumber = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(segments[10], false, seps) : null;
            ContactsAddress = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedAddress>(x, false, seps)) : null;
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