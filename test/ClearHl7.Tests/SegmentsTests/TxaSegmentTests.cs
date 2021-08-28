using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class TxaSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new TxaSegment
            {
                SetIdTxa = 1,
                DocumentType = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                DocumentContentPresentation = "3",
                ActivityDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                PrimaryActivityProviderCodeName = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "5"
                    }
                },
                OriginationDateTime = new DateTime(2020, 6, 6, 0, 0, 6),
                TranscriptionDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                EditDateTime = new DateTime[]
                {
                    new DateTime(2020,8,8,0,0,8)
                },
                OriginatorCodeName = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "9"
                    }
                },
                AssignedDocumentAuthenticator = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "10"
                    }
                },
                TranscriptionistCodeName = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "11"
                    }
                },
                UniqueDocumentNumber = new EntityIdentifier
                {
                    EntityId = "12"
                },
                ParentDocumentNumber = new EntityIdentifier
                {
                    EntityId = "13"
                },
                PlacerOrderNumber = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "14"
                    }
                },
                FillerOrderNumber = new EntityIdentifier
                {
                    EntityId = "15"
                },
                UniqueDocumentFileName = "16",
                DocumentCompletionStatus = "17",
                DocumentConfidentialityStatus = "18",
                DocumentAvailabilityStatus = "19",
                DocumentStorageStatus = "20",
                DocumentChangeReason = "21",
                AuthenticationPersonTimeStampSet = new PerformingPersonTimeStamp[]
                {
                    new PerformingPersonTimeStamp
                    {
                        PersonIdentifier = "22"
                    }
                },
                DistributedCopiesCodeAndNameOfRecipients = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "23"
                    }
                },
                FolderAssignment = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "24"
                    }
                },
                DocumentTitle = new string[]
                {
                    "25"
                },
                AgreedDueDateTime = new DateTime(2020, 1, 26, 0, 0, 26),
                CreatingFacility = new HierarchicDesignator
                {
                    NamespaceId = "27"
                },
                CreatingSpecialty = new CodedWithExceptions
                {
                    Identifier = "28"
                }
            };

            ISegment actual = new TxaSegment();
            actual.FromDelimitedString("TXA|1|2|3|20200404000004|5|20200606000006|20200707000007|20200808000008|9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|20200126000026|27|28");

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
                ISegment hl7Segment = new TxaSegment();
                hl7Segment.FromDelimitedString("TAA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new TxaSegment
            {
                SetIdTxa = 1,
                DocumentType = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                DocumentContentPresentation = "3",
                ActivityDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                PrimaryActivityProviderCodeName = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "5"
                    }
                },
                OriginationDateTime = new DateTime(2020, 6, 6, 0, 0, 6),
                TranscriptionDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                EditDateTime = new DateTime[]
                {
                    new DateTime(2020,8,8,0,0,8)
                },
                OriginatorCodeName = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "9"
                    }
                },
                AssignedDocumentAuthenticator = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "10"
                    }
                },
                TranscriptionistCodeName = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "11"
                    }
                },
                UniqueDocumentNumber = new EntityIdentifier
                {
                    EntityId = "12"
                },
                ParentDocumentNumber = new EntityIdentifier
                {
                    EntityId = "13"
                },
                PlacerOrderNumber = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "14"
                    }
                },
                FillerOrderNumber = new EntityIdentifier
                {
                    EntityId = "15"
                },
                UniqueDocumentFileName = "16",
                DocumentCompletionStatus = "17",
                DocumentConfidentialityStatus = "18",
                DocumentAvailabilityStatus = "19",
                DocumentStorageStatus = "20",
                DocumentChangeReason = "21",
                AuthenticationPersonTimeStampSet = new PerformingPersonTimeStamp[]
                {
                    new PerformingPersonTimeStamp
                    {
                        PersonIdentifier = "22"
                    }
                },
                DistributedCopiesCodeAndNameOfRecipients = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "23"
                    }
                },
                FolderAssignment = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "24"
                    }
                },
                DocumentTitle = new string[]
                {
                    "25"
                },
                AgreedDueDateTime = new DateTime(2020, 1, 26, 0, 0, 26),
                CreatingFacility = new HierarchicDesignator
                {
                    NamespaceId = "27"
                },
                CreatingSpecialty = new CodedWithExceptions
                {
                    Identifier = "28"
                }
            };

            string expected = "TXA|1|2|3|20200404000004|5|20200606000006|20200707000007|20200808000008|9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|20200126000026|27|28";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
