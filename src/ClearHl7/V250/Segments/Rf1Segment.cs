using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RF1 - Referral Information.
    /// </summary>
    public class Rf1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RF1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// RF1.1 - Referral Status.
        /// <para>Suggested: 0283 Referral Status -&gt; ClearHl7.Codes.V250.CodeReferralStatus</para>
        /// </summary>
        public CodedElement ReferralStatus { get; set; }

        /// <summary>
        /// RF1.2 - Referral Priority.
        /// <para>Suggested: 0280 Referral Priority -&gt; ClearHl7.Codes.V250.CodeReferralPriority</para>
        /// </summary>
        public CodedElement ReferralPriority { get; set; }

        /// <summary>
        /// RF1.3 - Referral Type.
        /// <para>Suggested: 0281 Referral Type -&gt; ClearHl7.Codes.V250.CodeReferralType</para>
        /// </summary>
        public CodedElement ReferralType { get; set; }

        /// <summary>
        /// RF1.4 - Referral Disposition.
        /// <para>Suggested: 0282 Referral Disposition -&gt; ClearHl7.Codes.V250.CodeReferralDisposition</para>
        /// </summary>
        public IEnumerable<CodedElement> ReferralDisposition { get; set; }

        /// <summary>
        /// RF1.5 - Referral Category.
        /// <para>Suggested: 0284 Referral Category -&gt; ClearHl7.Codes.V250.CodeReferralCategory</para>
        /// </summary>
        public CodedElement ReferralCategory { get; set; }

        /// <summary>
        /// RF1.6 - Originating Referral Identifier.
        /// </summary>
        public EntityIdentifier OriginatingReferralIdentifier { get; set; }

        /// <summary>
        /// RF1.7 - Effective Date.
        /// </summary>
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// RF1.8 - Expiration Date.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// RF1.9 - Process Date.
        /// </summary>
        public DateTime? ProcessDate { get; set; }

        /// <summary>
        /// RF1.10 - Referral Reason.
        /// <para>Suggested: 0336 Referral Reason -&gt; ClearHl7.Codes.V250.CodeReferralReason</para>
        /// </summary>
        public IEnumerable<CodedElement> ReferralReason { get; set; }

        /// <summary>
        /// RF1.11 - External Referral Identifier.
        /// </summary>
        public IEnumerable<EntityIdentifier> ExternalReferralIdentifier { get; set; }

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
        internal void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);
            
            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ReferralStatus = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[1], false) : null;
            ReferralPriority = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[2], false) : null;
            ReferralType = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[3], false) : null;
            ReferralDisposition = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            ReferralCategory = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[5], false) : null;
            OriginatingReferralIdentifier = segments.Length > 6 && segments[6].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[6], false) : null;
            EffectiveDate = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            ExpirationDate = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDateTime() : null;
            ProcessDate = segments.Length > 9 && segments[9].Length > 0 ? segments[9].ToNullableDateTime() : null;
            ReferralReason = segments.Length > 10 && segments[10].Length > 0 ? segments[10].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            ExternalReferralIdentifier = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<EntityIdentifier>(x, false)) : null;
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
                                ReferralStatus?.ToDelimitedString(),
                                ReferralPriority?.ToDelimitedString(),
                                ReferralType?.ToDelimitedString(),
                                ReferralDisposition != null ? string.Join(Configuration.FieldRepeatSeparator, ReferralDisposition.Select(x => x.ToDelimitedString())) : null,
                                ReferralCategory?.ToDelimitedString(),
                                OriginatingReferralIdentifier?.ToDelimitedString(),
                                EffectiveDate.HasValue ? EffectiveDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ExpirationDate.HasValue ? ExpirationDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ProcessDate.HasValue ? ProcessDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ReferralReason != null ? string.Join(Configuration.FieldRepeatSeparator, ReferralReason.Select(x => x.ToDelimitedString())) : null,
                                ExternalReferralIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, ExternalReferralIdentifier.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}