using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class BhsSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new BhsSegment
            {
                BatchFieldSeparator = "1",
                BatchEncodingCharacters = "2",
                BatchSendingApplication = new HierarchicDesignator
                {
                    NamespaceId = "3"
                },
                BatchSendingFacility = new HierarchicDesignator
                {
                    NamespaceId = "4"
                },
                BatchReceivingApplication = new HierarchicDesignator
                {
                    NamespaceId = "5"
                },
                BatchReceivingFacility = new HierarchicDesignator
                {
                    NamespaceId = "6"
                },
                BatchCreationDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                BatchSecurity = "8",
                BatchNameIdType = "9",
                BatchComment = "10",
                BatchControlId = "11",
                ReferenceBatchControlId = "12",
                BatchSendingNetworkAddress = new HierarchicDesignator
                {
                    NamespaceId = "13"
                },
                BatchReceivingNetworkAddress = new HierarchicDesignator
                {
                    NamespaceId = "14"
                },
                SecurityClassificationTag = new CodedWithExceptions
                {
                    Identifier = "15"
                },
                SecurityHandlingInstructions = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "16"
                    }
                },
                SpecialAccessRestrictionInstructions = new string[]
                {
                    "17"
                }
            };

            ISegment actual = new BhsSegment();
            actual.FromDelimitedString("BHS|1|2|3|4|5|6|20200707000007|8|9|10|11|12|13|14|15|16|17");

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
                ISegment hl7Segment = new BhsSegment();
                hl7Segment.FromDelimitedString("BHA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new BhsSegment
            {
                BatchFieldSeparator = "1",
                BatchEncodingCharacters = "2",
                BatchSendingApplication = new HierarchicDesignator
                {
                    NamespaceId = "3"
                },
                BatchSendingFacility = new HierarchicDesignator
                {
                    NamespaceId = "4"
                },
                BatchReceivingApplication = new HierarchicDesignator
                {
                    NamespaceId = "5"
                },
                BatchReceivingFacility = new HierarchicDesignator
                {
                    NamespaceId = "6"
                },
                BatchCreationDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                BatchSecurity = "8",
                BatchNameIdType = "9",
                BatchComment = "10",
                BatchControlId = "11",
                ReferenceBatchControlId = "12",
                BatchSendingNetworkAddress = new HierarchicDesignator
                {
                    NamespaceId = "13"
                },
                BatchReceivingNetworkAddress = new HierarchicDesignator
                {
                    NamespaceId = "14"
                },
                SecurityClassificationTag = new CodedWithExceptions
                {
                    Identifier = "15"
                },
                SecurityHandlingInstructions = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "16"
                    }
                },
                SpecialAccessRestrictionInstructions = new string[]
                {
                    "17"
                }
            };

            string expected = "BHS|1|2|3|4|5|6|20200707000007|8|9|10|11|12|13|14|15|16|17";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
