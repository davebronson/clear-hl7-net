using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CER - Certificate Detail.
    /// </summary>
    public class CerSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "CER";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// CER.1 - Set ID - CER.
        /// </summary>
        public uint? SetIdCer { get; set; }

        /// <summary>
        /// CER.2 - Serial Number.
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// CER.3 - Version.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// CER.4 - Granting Authority.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations GrantingAuthority { get; set; }

        /// <summary>
        /// CER.5 - Issuing Authority.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons IssuingAuthority { get; set; }

        /// <summary>
        /// CER.6 - Signature.
        /// </summary>
        public EncapsulatedData Signature { get; set; }

        /// <summary>
        /// CER.7 - Granting Country.
        /// </summary>
        /// <remarks>https://www.iso.org/iso-3166-country-codes.html</remarks>
        public string GrantingCountry { get; set; }

        /// <summary>
        /// CER.8 - Granting State/Province.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0347</remarks>
        public CodedWithExceptions GrantingStateProvince { get; set; }

        /// <summary>
        /// CER.9 - Granting County/Parish.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0289</remarks>
        public CodedWithExceptions GrantingCountyParish { get; set; }

        /// <summary>
        /// CER.10 - Certificate Type.
        /// </summary>
        public CodedWithExceptions CertificateType { get; set; }

        /// <summary>
        /// CER.11 - Certificate Domain.
        /// </summary>
        public CodedWithExceptions CertificateDomain { get; set; }

        /// <summary>
        /// CER.12 - Subject ID.
        /// </summary>
        public EntityIdentifier SubjectId { get; set; }

        /// <summary>
        /// CER.13 - Subject Name.
        /// </summary>
        public string SubjectName { get; set; }

        /// <summary>
        /// CER.14 - Subject Directory Attribute Extension.
        /// </summary>
        public IEnumerable<CodedWithExceptions> SubjectDirectoryAttributeExtension { get; set; }

        /// <summary>
        /// CER.15 - Subject Public Key Info.
        /// </summary>
        public CodedWithExceptions SubjectPublicKeyInfo { get; set; }

        /// <summary>
        /// CER.16 - Authority Key Identifier.
        /// </summary>
        public CodedWithExceptions AuthorityKeyIdentifier { get; set; }

        /// <summary>
        /// CER.17 - Basic Constraint.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string BasicConstraint { get; set; }

        /// <summary>
        /// CER.18 - CRL Distribution Point.
        /// </summary>
        public IEnumerable<CodedWithExceptions> CrlDistributionPoint { get; set; }

        /// <summary>
        /// CER.19 - Jurisdiction Country.
        /// </summary>
        /// <remarks>https://www.iso.org/iso-3166-country-codes.html</remarks>
        public string JurisdictionCountry { get; set; }

        /// <summary>
        /// CER.20 - Jurisdiction State/Province.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0347</remarks>
        public CodedWithExceptions JurisdictionStateProvince { get; set; }

        /// <summary>
        /// CER.21 - Jurisdiction County/Parish.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0289</remarks>
        public CodedWithExceptions JurisdictionCountyParish { get; set; }

        /// <summary>
        /// CER.22 - Jurisdiction Breadth.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0547</remarks>
        public IEnumerable<CodedWithExceptions> JurisdictionBreadth { get; set; }

        /// <summary>
        /// CER.23 - Granting Date.
        /// </summary>
        public DateTime? GrantingDate { get; set; }

        /// <summary>
        /// CER.24 - Issuing Date.
        /// </summary>
        public DateTime? IssuingDate { get; set; }

        /// <summary>
        /// CER.25 - Activation Date.
        /// </summary>
        public DateTime? ActivationDate { get; set; }

        /// <summary>
        /// CER.26 - Inactivation Date.
        /// </summary>
        public DateTime? InactivationDate { get; set; }

        /// <summary>
        /// CER.27 - Expiration Date.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// CER.28 - Renewal Date.
        /// </summary>
        public DateTime? RenewalDate { get; set; }

        /// <summary>
        /// CER.29 - Revocation Date.
        /// </summary>
        public DateTime? RevocationDate { get; set; }

        /// <summary>
        /// CER.30 - Revocation Reason Code.
        /// </summary>
        public CodedWithExceptions RevocationReasonCode { get; set; }

        /// <summary>
        /// CER.31 - Certificate Status Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0536</remarks>
        public CodedWithExceptions CertificateStatusCode { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 32, Configuration.FieldSeparator),
                                Id,
                                SetIdCer.HasValue ? SetIdCer.Value.ToString(culture) : null,
                                SerialNumber,
                                Version,
                                GrantingAuthority?.ToDelimitedString(),
                                IssuingAuthority?.ToDelimitedString(),
                                Signature?.ToDelimitedString(),
                                GrantingCountry,
                                GrantingStateProvince?.ToDelimitedString(),
                                GrantingCountyParish?.ToDelimitedString(),
                                CertificateType?.ToDelimitedString(),
                                CertificateDomain?.ToDelimitedString(),
                                SubjectId?.ToDelimitedString(),
                                SubjectName,
                                SubjectDirectoryAttributeExtension != null ? string.Join(Configuration.FieldRepeatSeparator, SubjectDirectoryAttributeExtension.Select(x => x.ToDelimitedString())) : null,
                                SubjectPublicKeyInfo?.ToDelimitedString(),
                                AuthorityKeyIdentifier?.ToDelimitedString(),
                                BasicConstraint,
                                CrlDistributionPoint != null ? string.Join(Configuration.FieldRepeatSeparator, CrlDistributionPoint.Select(x => x.ToDelimitedString())) : null,
                                JurisdictionCountry,
                                JurisdictionStateProvince?.ToDelimitedString(),
                                JurisdictionCountyParish?.ToDelimitedString(),
                                JurisdictionBreadth != null ? string.Join(Configuration.FieldRepeatSeparator, JurisdictionBreadth.Select(x => x.ToDelimitedString())) : null,
                                GrantingDate.HasValue ? GrantingDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                IssuingDate.HasValue ? IssuingDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ActivationDate.HasValue ? ActivationDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                InactivationDate.HasValue ? InactivationDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ExpirationDate.HasValue ? ExpirationDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                RenewalDate.HasValue ? RenewalDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                RevocationDate.HasValue ? RevocationDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                RevocationReasonCode?.ToDelimitedString(),
                                CertificateStatusCode?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}