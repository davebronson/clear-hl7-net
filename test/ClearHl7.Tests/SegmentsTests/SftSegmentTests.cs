using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class SftSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new SftSegment
            {
                SoftwareVendorOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "1"
                },
                SoftwareCertifiedVersionOrReleaseNumber = "2",
                SoftwareProductName = "3",
                SoftwareBinaryId = "4",
                SoftwareProductInformation = new Text
                {
                    Value = "5"
                },
                SoftwareInstallDate = new DateTime(2020, 6, 6, 0, 0, 6)
            };

            ISegment actual = new SftSegment();
            actual.FromDelimitedString("SFT|1|2|3|4|5|20200606000006");

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
                ISegment hl7Segment = new SftSegment();
                hl7Segment.FromDelimitedString("SFA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new SftSegment
            {
                SoftwareVendorOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "1"
                },
                SoftwareCertifiedVersionOrReleaseNumber = "2",
                SoftwareProductName = "3",
                SoftwareBinaryId = "4",
                SoftwareProductInformation = new Text
                {
                    Value = "5"
                },
                SoftwareInstallDate = new DateTime(2020, 6, 6, 0, 0, 6)
            };

            string expected = "SFT|1|2|3|4|5|20200606000006";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
