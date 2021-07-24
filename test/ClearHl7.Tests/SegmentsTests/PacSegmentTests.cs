using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class PacSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new PacSegment
            {
                SetIdPac = 1,
                PackageId = new EntityIdentifier
                {
                    EntityId = "2"
                },
                ParentPackageId = new EntityIdentifier
                {
                    EntityId = "3"
                },
                PositionInParentPackage = new NumericArray
                {
                    Value1 = 4
                },
                PackageType = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                PackageCondition = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "6"
                    }
                },
                PackageHandlingCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "7"
                    }
                },
                PackageRiskCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "8"
                    }
                },
                ActionCode = "9"
            };

            ISegment actual = new PacSegment();
            actual.FromDelimitedString("PAC|1|2|3|4|5|6|7|8|9");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new PacSegment
            {
                SetIdPac = 1,
                PackageId = new EntityIdentifier
                {
                    EntityId = "2"
                },
                ParentPackageId = new EntityIdentifier
                {
                    EntityId = "3"
                },
                PositionInParentPackage = new NumericArray
                {
                    Value1 = 4
                },
                PackageType = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                PackageCondition = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "6"
                    }
                },
                PackageHandlingCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "7"
                    }
                },
                PackageRiskCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "8"
                    }
                },
                ActionCode = "9"
            };

            string expected = "PAC|1|2|3|4|5|6|7|8|9";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
