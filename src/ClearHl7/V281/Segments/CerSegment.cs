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
    /// HL7 Version 2 Segment CER - Certificate Detail.
    /// </summary>
    public class CerSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CerSegment"/> class.
        /// </summary>
        public CerSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CerSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public CerSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "CER";

        /// <inheritdoc/>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeYesNoIndicator</para>
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
        /// <para>Suggested: 0547 Jurisdictional Breadth -&gt; ClearHl7.Codes.V281.CodeJurisdictionalBreadth</para>
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
        /// <para>Suggested: 0536 Certificate Status -&gt; ClearHl7.Codes.V281.CodeCertificateStatus</para>
        /// </summary>
        public CodedWithExceptions CertificateStatusCode { get; set; }

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
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdCer = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            SerialNumber = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            Version = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            GrantingAuthority = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[4], false, seps) : null;
            IssuingAuthority = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[5], false, seps) : null;
            Signature = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<EncapsulatedData>(segments[6], false, seps) : null;
            GrantingCountry = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            GrantingStateProvince = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[8], false, seps) : null;
            GrantingCountyParish = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[9], false, seps) : null;
            CertificateType = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[10], false, seps) : null;
            CertificateDomain = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[11], false, seps) : null;
            SubjectId = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[12], false, seps) : null;
            SubjectName = segments.Length > 13 && segments[13].Length > 0 ? segments[13] : null;
            SubjectDirectoryAttributeExtension = segments.Length > 14 && segments[14].Length > 0 ? segments[14].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            SubjectPublicKeyInfo = segments.Length > 15 && segments[15].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[15], false, seps) : null;
            AuthorityKeyIdentifier = segments.Length > 16 && segments[16].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[16], false, seps) : null;
            BasicConstraint = segments.Length > 17 && segments[17].Length > 0 ? segments[17] : null;
            CrlDistributionPoint = segments.Length > 18 && segments[18].Length > 0 ? segments[18].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            JurisdictionCountry = segments.Length > 19 && segments[19].Length > 0 ? segments[19] : null;
            JurisdictionStateProvince = segments.Length > 20 && segments[20].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[20], false, seps) : null;
            JurisdictionCountyParish = segments.Length > 21 && segments[21].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[21], false, seps) : null;
            JurisdictionBreadth = segments.Length > 22 && segments[22].Length > 0 ? segments[22].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            GrantingDate = segments.Length > 23 && segments[23].Length > 0 ? segments[23].ToNullableDateTime() : null;
            IssuingDate = segments.Length > 24 && segments[24].Length > 0 ? segments[24].ToNullableDateTime() : null;
            ActivationDate = segments.Length > 25 && segments[25].Length > 0 ? segments[25].ToNullableDateTime() : null;
            InactivationDate = segments.Length > 26 && segments[26].Length > 0 ? segments[26].ToNullableDateTime() : null;
            ExpirationDate = segments.Length > 27 && segments[27].Length > 0 ? segments[27].ToNullableDateTime() : null;
            RenewalDate = segments.Length > 28 && segments[28].Length > 0 ? segments[28].ToNullableDateTime() : null;
            RevocationDate = segments.Length > 29 && segments[29].Length > 0 ? segments[29].ToNullableDateTime() : null;
            RevocationReasonCode = segments.Length > 30 && segments[30].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[30], false, seps) : null;
            CertificateStatusCode = segments.Length > 31 && segments[31].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[31], false, seps) : null;
        }

        /// <inheritdoc/>
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
                                GrantingDate?.ToHl7DateTimeString(typeof(CerSegment), nameof(GrantingDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                IssuingDate?.ToHl7DateTimeString(typeof(CerSegment), nameof(IssuingDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                ActivationDate?.ToHl7DateTimeString(typeof(CerSegment), nameof(ActivationDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                InactivationDate?.ToHl7DateTimeString(typeof(CerSegment), nameof(InactivationDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                ExpirationDate?.ToHl7DateTimeString(typeof(CerSegment), nameof(ExpirationDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                RenewalDate?.ToHl7DateTimeString(typeof(CerSegment), nameof(RenewalDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                RevocationDate?.ToHl7DateTimeString(typeof(CerSegment), nameof(RevocationDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                RevocationReasonCode?.ToDelimitedString(),
                                CertificateStatusCode?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
