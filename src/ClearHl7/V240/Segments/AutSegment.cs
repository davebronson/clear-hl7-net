using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment AUT - Authorization Information.
    /// </summary>
    public class AutSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "AUT";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// AUT.1 - Authorizing Payor, Plan ID.
        /// <para>Suggested: 0072 Insurance Plan ID</para>
        /// </summary>
        public CodedElement AuthorizingPayorPlanId { get; set; }

        /// <summary>
        /// AUT.2 - Authorizing Payor, Company ID.
        /// <para>Suggested: 0285 Insurance Company ID Codes</para>
        /// </summary>
        public CodedElement AuthorizingPayorCompanyId { get; set; }

        /// <summary>
        /// AUT.3 - Authorizing Payor, Company Name.
        /// </summary>
        public string AuthorizingPayorCompanyName { get; set; }

        /// <summary>
        /// AUT.4 - Authorization Effective Date.
        /// </summary>
        public DateTime? AuthorizationEffectiveDate { get; set; }

        /// <summary>
        /// AUT.5 - Authorization Expiration Date.
        /// </summary>
        public DateTime? AuthorizationExpirationDate { get; set; }

        /// <summary>
        /// AUT.6 - Authorization Identifier.
        /// </summary>
        public EntityIdentifier AuthorizationIdentifier { get; set; }

        /// <summary>
        /// AUT.7 - Reimbursement Limit.
        /// </summary>
        public CompositePrice ReimbursementLimit { get; set; }

        /// <summary>
        /// AUT.8 - Requested Number of Treatments.
        /// </summary>
        public decimal? RequestedNumberOfTreatments { get; set; }

        /// <summary>
        /// AUT.9 - Authorized Number of Treatments.
        /// </summary>
        public decimal? AuthorizedNumberOfTreatments { get; set; }

        /// <summary>
        /// AUT.10 - Process Date.
        /// </summary>
        public DateTime? ProcessDate { get; set; }

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

            AuthorizingPayorPlanId = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[1], false) : null;
            AuthorizingPayorCompanyId = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[2], false) : null;
            AuthorizingPayorCompanyName = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            AuthorizationEffectiveDate = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            AuthorizationExpirationDate = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDateTime() : null;
            AuthorizationIdentifier = segments.Length > 6 && segments[6].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[6], false) : null;
            ReimbursementLimit = segments.Length > 7 && segments[7].Length > 0 ? TypeHelper.Deserialize<CompositePrice>(segments[7], false) : null;
            RequestedNumberOfTreatments = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDecimal() : null;
            AuthorizedNumberOfTreatments = segments.Length > 9 && segments[9].Length > 0 ? segments[9].ToNullableDecimal() : null;
            ProcessDate = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDateTime() : null;
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
                                StringHelper.StringFormatSequence(0, 11, Configuration.FieldSeparator),
                                Id,
                                AuthorizingPayorPlanId?.ToDelimitedString(),
                                AuthorizingPayorCompanyId?.ToDelimitedString(),
                                AuthorizingPayorCompanyName,
                                AuthorizationEffectiveDate.HasValue ? AuthorizationEffectiveDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                AuthorizationExpirationDate.HasValue ? AuthorizationExpirationDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                AuthorizationIdentifier?.ToDelimitedString(),
                                ReimbursementLimit?.ToDelimitedString(),
                                RequestedNumberOfTreatments.HasValue ? RequestedNumberOfTreatments.Value.ToString(Consts.NumericFormat) : null,
                                AuthorizedNumberOfTreatments.HasValue ? AuthorizedNumberOfTreatments.Value.ToString(Consts.NumericFormat) : null,
                                ProcessDate.HasValue ? ProcessDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}