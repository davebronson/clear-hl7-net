using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class IprSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new IprSegment
            {
                IprIdentifier = new EntityIdentifier
                {
                    EntityId = "1"
                },
                ProviderCrossReferenceIdentifier = new EntityIdentifier
                {
                    EntityId = "2"
                },
                PayerCrossReferenceIdentifier = new EntityIdentifier
                {
                    EntityId = "3"
                },
                IprStatus = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                IprDateTime = new DateTime(2020, 5, 5, 0, 0, 5),
                AdjudicatedPaidAmount = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 6
                    }
                },
                ExpectedPaymentDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                IprChecksum = "8"
            };

            ISegment actual = new IprSegment();
            actual.FromDelimitedString("IPR|1|2|3|4|20200505000005|6|20200707000007|8");

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
                ISegment hl7Segment = new IprSegment();
                hl7Segment.FromDelimitedString("IPA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new IprSegment
            {
                IprIdentifier = new EntityIdentifier
                {
                    EntityId = "1"
                },
                ProviderCrossReferenceIdentifier = new EntityIdentifier
                {
                    EntityId = "2"
                },
                PayerCrossReferenceIdentifier = new EntityIdentifier
                {
                    EntityId = "3"
                },
                IprStatus = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                IprDateTime = new DateTime(2020, 5, 5, 0, 0, 5),
                AdjudicatedPaidAmount = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 6
                    }
                },
                ExpectedPaymentDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                IprChecksum = "8"
            };

            string expected = "IPR|1|2|3|4|20200505000005|6|20200707000007|8";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
