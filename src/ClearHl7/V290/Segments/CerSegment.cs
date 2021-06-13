using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
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
        /// <para>Suggested: 0399 Country Code -&gt; https://www.iso.org/iso-3166-country-codes.html</para>
        /// </summary>
        public string GrantingCountry { get; set; }

        /// <summary>
        /// CER.8 - Granting State/Province.
        /// <para>Suggested: 0347 State/Province</para>
        /// </summary>
        public CodedWithExceptions GrantingStateProvince { get; set; }

        /// <summary>
        /// CER.9 - Granting County/Parish.
        /// <para>Suggested: 0289 County/Parish</para>
        /// </summary>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string BasicConstraint { get; set; }

        /// <summary>
        /// CER.18 - CRL Distribution Point.
        /// </summary>
        public IEnumerable<CodedWithExceptions> CrlDistributionPoint { get; set; }

        /// <summary>
        /// CER.19 - Jurisdiction Country.
        /// <para>Suggested: 0399 Country Code -&gt; https://www.iso.org/iso-3166-country-codes.html</para>
        /// </summary>
        public string JurisdictionCountry { get; set; }

        /// <summary>
        /// CER.20 - Jurisdiction State/Province.
        /// <para>Suggested: 0347 State/Province</para>
        /// </summary>
        public CodedWithExceptions JurisdictionStateProvince { get; set; }

        /// <summary>
        /// CER.21 - Jurisdiction County/Parish.
        /// <para>Suggested: 0289 County/Parish</para>
        /// </summary>
        public CodedWithExceptions JurisdictionCountyParish { get; set; }

        /// <summary>
        /// CER.22 - Jurisdiction Breadth.
        /// <para>Suggested: 0547 Jurisdictional Breadth -&gt; ClearHl7.Codes.V290.CodeJurisdictionalBreadth</para>
        /// </summary>
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
        /// <para>Suggested: 0536 Certificate Status -&gt; ClearHl7.Codes.V290.CodeCertificateStatus</para>
        /// </summary>
        public CodedWithExceptions CertificateStatusCode { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public CerSegment FromDelimitedString(string delimitedString)
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

            SetIdCer = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            SerialNumber = segments.ElementAtOrDefault(2);
            Version = segments.ElementAtOrDefault(3);
            GrantingAuthority = segments.Length > 4 ? new ExtendedCompositeNameAndIdNumberForOrganizations().FromDelimitedString(segments.ElementAtOrDefault(4)) : null;
            IssuingAuthority = segments.Length > 5 ? new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(segments.ElementAtOrDefault(5)) : null;
            Signature = segments.Length > 6 ? new EncapsulatedData().FromDelimitedString(segments.ElementAtOrDefault(6)) : null;
            GrantingCountry = segments.ElementAtOrDefault(7);
            GrantingStateProvince = segments.Length > 8 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(8)) : null;
            GrantingCountyParish = segments.Length > 9 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(9)) : null;
            CertificateType = segments.Length > 10 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(10)) : null;
            CertificateDomain = segments.Length > 11 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(11)) : null;
            SubjectId = segments.Length > 12 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(12)) : null;
            SubjectName = segments.ElementAtOrDefault(13);
            SubjectDirectoryAttributeExtension = segments.Length > 14 ? segments.ElementAtOrDefault(14).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            SubjectPublicKeyInfo = segments.Length > 15 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(15)) : null;
            AuthorityKeyIdentifier = segments.Length > 16 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(16)) : null;
            BasicConstraint = segments.ElementAtOrDefault(17);
            CrlDistributionPoint = segments.Length > 18 ? segments.ElementAtOrDefault(18).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            JurisdictionCountry = segments.ElementAtOrDefault(19);
            JurisdictionStateProvince = segments.Length > 20 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(20)) : null;
            JurisdictionCountyParish = segments.Length > 21 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(21)) : null;
            JurisdictionBreadth = segments.Length > 22 ? segments.ElementAtOrDefault(22).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            GrantingDate = segments.ElementAtOrDefault(23)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            IssuingDate = segments.ElementAtOrDefault(24)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ActivationDate = segments.ElementAtOrDefault(25)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            InactivationDate = segments.ElementAtOrDefault(26)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ExpirationDate = segments.ElementAtOrDefault(27)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            RenewalDate = segments.ElementAtOrDefault(28)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            RevocationDate = segments.ElementAtOrDefault(29)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            RevocationReasonCode = segments.Length > 30 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(30)) : null;
            CertificateStatusCode = segments.Length > 31 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(31)) : null;

            return this;
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