using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class SftSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
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
