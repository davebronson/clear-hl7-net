using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V271.Types;

namespace ClearHl7.Fhir.V271.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0072</remarks>
        public CodedWithExceptions AuthorizingPayorPlanId { get; set; }

        /// <summary>
        /// AUT.2 - Authorizing Payor, Company ID.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0285</remarks>
        public CodedWithExceptions AuthorizingPayorCompanyId { get; set; }

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
        public CompositeQuantityWithUnits RequestedNumberOfTreatments { get; set; }

        /// <summary>
        /// AUT.9 - Authorized Number of Treatments.
        /// </summary>
        public CompositeQuantityWithUnits AuthorizedNumberOfTreatments { get; set; }

        /// <summary>
        /// AUT.10 - Process Date.
        /// </summary>
        public DateTime? ProcessDate { get; set; }

        /// <summary>
        /// AUT.11 - Requested Discipline(s).
        /// </summary>
        public IEnumerable<CodedWithExceptions> RequestedDisciplines { get; set; }

        /// <summary>
        /// AUT.12 - Authorized Discipline(s).
        /// </summary>
        public IEnumerable<CodedWithExceptions> AuthorizedDisciplines { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 13, Configuration.FieldSeparator),
                                Id,
                                AuthorizingPayorPlanId?.ToDelimitedString(),
                                AuthorizingPayorCompanyId?.ToDelimitedString(),
                                AuthorizingPayorCompanyName,
                                AuthorizationEffectiveDate.HasValue ? AuthorizationEffectiveDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                AuthorizationExpirationDate.HasValue ? AuthorizationExpirationDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                AuthorizationIdentifier?.ToDelimitedString(),
                                ReimbursementLimit?.ToDelimitedString(),
                                RequestedNumberOfTreatments?.ToDelimitedString(),
                                AuthorizedNumberOfTreatments?.ToDelimitedString(),
                                ProcessDate.HasValue ? ProcessDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                RequestedDisciplines != null ? string.Join(Configuration.FieldRepeatSeparator, RequestedDisciplines.Select(x => x.ToDelimitedString())) : null,
                                AuthorizedDisciplines != null ? string.Join(Configuration.FieldRepeatSeparator, AuthorizedDisciplines.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}