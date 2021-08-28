using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class CerSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new CerSegment
            {
                SetIdCer = 1,
                SerialNumber = "2",
                Version = "3",
                GrantingAuthority = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "4"
                },
                IssuingAuthority = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "5"
                },
                Signature = new EncapsulatedData
                {
                    SourceApplication = new HierarchicDesignator
                    {
                        NamespaceId = "6"
                    }
                },
                GrantingCountry = "7",
                GrantingStateProvince = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                GrantingCountyParish = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                CertificateType = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                CertificateDomain = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                SubjectId = new EntityIdentifier
                {
                    EntityId = "12"
                },
                SubjectName = "13",
                SubjectDirectoryAttributeExtension = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "14"
                    }
                },
                SubjectPublicKeyInfo = new CodedWithExceptions
                {
                    Identifier = "15"
                },
                AuthorityKeyIdentifier = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                BasicConstraint = "17",
                CrlDistributionPoint = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "18"
                    }
                },
                JurisdictionCountry = "19",
                JurisdictionStateProvince = new CodedWithExceptions
                {
                    Identifier = "20"
                },
                JurisdictionCountyParish = new CodedWithExceptions
                {
                    Identifier = "21"
                },
                JurisdictionBreadth = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "22"
                    }
                },
                GrantingDate = new DateTime(2020, 1, 23, 0, 0, 23),
                IssuingDate = new DateTime(2020, 1, 24, 0, 0, 24),
                ActivationDate = new DateTime(2020, 1, 25, 0, 0, 25),
                InactivationDate = new DateTime(2020, 1, 26, 0, 0, 26),
                ExpirationDate = new DateTime(2020, 1, 27, 0, 0, 27),
                RenewalDate = new DateTime(2020, 1, 28, 0, 0, 28),
                RevocationDate = new DateTime(2020, 1, 29, 0, 0, 29),
                RevocationReasonCode = new CodedWithExceptions
                {
                    Identifier = "30"
                },
                CertificateStatusCode = new CodedWithExceptions
                {
                    Identifier = "31"
                }
            };

            ISegment actual = new CerSegment();
            actual.FromDelimitedString("CER|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15|16|17|18|19|20|21|22|20200123000023|20200124000024|20200125000025|20200126000026|20200127000027|20200128000028|20200129000029|30|31");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that calling FromDelimitedString() with a string input containing an incorrect segment ID results in an ArgumentException being thrown.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithIncorrectSegmentId_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ISegment hl7Segment = new CerSegment();
                hl7Segment.FromDelimitedString("CEA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new CerSegment
            {
                SetIdCer = 1,
                SerialNumber = "2",
                Version = "3",
                GrantingAuthority = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "4"
                },
                IssuingAuthority = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "5"
                },
                Signature = new EncapsulatedData
                {
                    SourceApplication = new HierarchicDesignator
                    {
                        NamespaceId = "6"
                    }
                },
                GrantingCountry = "7",
                GrantingStateProvince = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                GrantingCountyParish = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                CertificateType = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                CertificateDomain = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                SubjectId = new EntityIdentifier
                {
                    EntityId = "12"
                },
                SubjectName = "13",
                SubjectDirectoryAttributeExtension = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "14"
                    }
                },
                SubjectPublicKeyInfo = new CodedWithExceptions
                {
                    Identifier = "15"
                },
                AuthorityKeyIdentifier = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                BasicConstraint = "17",
                CrlDistributionPoint = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "18"
                    }
                },
                JurisdictionCountry = "19",
                JurisdictionStateProvince = new CodedWithExceptions
                {
                    Identifier = "20"
                },
                JurisdictionCountyParish = new CodedWithExceptions
                {
                    Identifier = "21"
                },
                JurisdictionBreadth = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "22"
                    }
                },
                GrantingDate = new DateTime(2020, 1, 23, 0, 0, 23),
                IssuingDate = new DateTime(2020, 1, 24, 0, 0, 24),
                ActivationDate = new DateTime(2020, 1, 25, 0, 0, 25),
                InactivationDate = new DateTime(2020, 1, 26, 0, 0, 26),
                ExpirationDate = new DateTime(2020, 1, 27, 0, 0, 27),
                RenewalDate = new DateTime(2020, 1, 28, 0, 0, 28),
                RevocationDate = new DateTime(2020, 1, 29, 0, 0, 29),
                RevocationReasonCode = new CodedWithExceptions
                {
                    Identifier = "30"
                },
                CertificateStatusCode = new CodedWithExceptions
                {
                    Identifier = "31"
                }
            };

            string expected = "CER|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15|16|17|18|19|20|21|22|20200123000023|20200124000024|20200125000025|20200126000026|20200127000027|20200128000028|20200129000029|30|31";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
