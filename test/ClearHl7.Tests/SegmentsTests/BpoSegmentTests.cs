using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class BpoSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new BpoSegment
            {
                SetIdBpo = 1,
                BpUniversalServiceIdentifier = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                BpProcessingRequirements = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "3"
                    }
                },
                BpQuantity = 4,
                BpAmount = 5,
                BpUnits = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                BpIntendedUseDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                BpIntendedDispenseFromLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "8"
                    }
                },
                BpIntendedDispenseFromAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "9"
                    }
                },
                BpRequestedDispenseDateTime = new DateTime(2020, 10, 10, 0, 0, 10),
                BpRequestedDispenseToLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "11"
                    }
                },
                BpRequestedDispenseToAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "12"
                    }
                },
                BpIndicationForUse = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "13"
                    }
                },
                BpInformedConsentIndicator = "14"
            };

            ISegment actual = new BpoSegment();
            actual.FromDelimitedString("BPO|1|2|3|4|5|6|20200707000007|8|9|20201010000010|11|12|13|14");

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
                ISegment hl7Segment = new BpoSegment();
                hl7Segment.FromDelimitedString("BPA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new BpoSegment
            {
                SetIdBpo = 1,
                BpUniversalServiceIdentifier = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                BpProcessingRequirements = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "3"
                    }
                },
                BpQuantity = 4,
                BpAmount = 5,
                BpUnits = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                BpIntendedUseDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                BpIntendedDispenseFromLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "8"
                    }
                },
                BpIntendedDispenseFromAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "9"
                    }
                },
                BpRequestedDispenseDateTime = new DateTime(2020, 10, 10, 0, 0, 10),
                BpRequestedDispenseToLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "11"
                    }
                },
                BpRequestedDispenseToAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "12"
                    }
                },
                BpIndicationForUse = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "13"
                    }
                },
                BpInformedConsentIndicator = "14"
            };

            string expected = "BPO|1|2|3|4|5|6|20200707000007|8|9|20201010000010|11|12|13|14";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
