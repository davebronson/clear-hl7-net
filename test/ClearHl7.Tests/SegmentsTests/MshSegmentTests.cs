using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class MshSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new MshSegment
            {
                SendingApplication = new HierarchicDesignator
                {
                    NamespaceId = "3"
                },
                SendingFacility = new HierarchicDesignator
                {
                    NamespaceId = "4"
                },
                ReceivingApplication = new HierarchicDesignator
                {
                    NamespaceId = "5"
                },
                ReceivingFacility = new HierarchicDesignator[]
                {
                    new HierarchicDesignator
                    {
                        NamespaceId = "6"
                    }
                },
                DateTimeOfMessage = new DateTime(2020, 7, 7, 0, 0, 7),
                Security = "8",
                MessageType = new MessageType
                {
                    MessageCode = "9"
                },
                MessageControlId = "10",
                ProcessingId = new ProcessingType
                {
                    ProcessingId = "11"
                },
                VersionId = new VersionIdentifier
                {
                    VersionId = "12"
                },
                SequenceNumber = 13,
                ContinuationPointer = "14",
                AcceptAcknowledgmentType = "15",
                ApplicationAcknowledgmentType = "16",
                CountryCode = "17",
                CharacterSet = new string[]
                {
                    "18"
                },
                PrincipalLanguageOfMessage = new CodedWithExceptions
                {
                    Identifier = "19"
                },
                AlternateCharacterSetHandlingScheme = "20",
                MessageProfileIdentifier = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "21"
                    }
                },
                SendingResponsibleOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "22"
                },
                ReceivingResponsibleOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "23"
                },
                SendingNetworkAddress = new HierarchicDesignator
                {
                    NamespaceId = "24"
                },
                ReceivingNetworkAddress = new HierarchicDesignator
                {
                    NamespaceId = "25"
                },
                SecurityClassificationTag = new CodedWithExceptions
                {
                    Identifier = "26"
                },
                SecurityHandlingInstructions = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "27"
                    }
                },
                SpecialAccessRestrictionInstructions = new string[]
                {
                    "28"
                }
            };

            ISegment actual = new MshSegment();
            actual.FromDelimitedString("MSH|^~\\&|3|4|5|6|20200707000007|8|9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28");

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
                ISegment hl7Segment = new MshSegment();
                hl7Segment.FromDelimitedString("MSA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that calling FromDelimitedString() with a string input containing three encoding characters results in an ArgumentException being thrown.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithThreeEncodingChars_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ISegment hl7Segment = new MshSegment();
                hl7Segment.FromDelimitedString("MSH|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that calling FromDelimitedString() with a string input containing five encoding characters results in an ArgumentException being thrown.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithFiveEncodingChars_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ISegment hl7Segment = new MshSegment();
                hl7Segment.FromDelimitedString("MSH|^~\\&$|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        /// <remarks>Assumes usage of the standard delimiter characters.</remarks>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new MshSegment
            {
                SendingApplication = new HierarchicDesignator
                {
                    NamespaceId = "3"
                },
                SendingFacility = new HierarchicDesignator
                {
                    NamespaceId = "4"
                },
                ReceivingApplication = new HierarchicDesignator
                {
                    NamespaceId = "5"
                },
                ReceivingFacility = new HierarchicDesignator[]
                {
                    new HierarchicDesignator
                    {
                        NamespaceId = "6"
                    }
                },
                DateTimeOfMessage = new DateTime(2020, 7, 7, 0, 0, 7),
                Security = "8",
                MessageType = new MessageType
                {
                    MessageCode = "9"
                },
                MessageControlId = "10",
                ProcessingId = new ProcessingType
                {
                    ProcessingId = "11"
                },
                VersionId = new VersionIdentifier
                {
                    VersionId = "12"
                },
                SequenceNumber = 13,
                ContinuationPointer = "14",
                AcceptAcknowledgmentType = "15",
                ApplicationAcknowledgmentType = "16",
                CountryCode = "17",
                CharacterSet = new string[]
                {
                    "18"
                },
                PrincipalLanguageOfMessage = new CodedWithExceptions
                {
                    Identifier = "19"
                },
                AlternateCharacterSetHandlingScheme = "20",
                MessageProfileIdentifier = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "21"
                    }
                },
                SendingResponsibleOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "22"
                },
                ReceivingResponsibleOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "23"
                },
                SendingNetworkAddress = new HierarchicDesignator
                {
                    NamespaceId = "24"
                },
                ReceivingNetworkAddress = new HierarchicDesignator
                {
                    NamespaceId = "25"
                },
                SecurityClassificationTag = new CodedWithExceptions
                {
                    Identifier = "26"
                },
                SecurityHandlingInstructions = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "27"
                    }
                },
                SpecialAccessRestrictionInstructions = new string[]
                {
                    "28"
                }
            };

            string expected = "MSH|^~\\&|3|4|5|6|20200707000007|8|9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
