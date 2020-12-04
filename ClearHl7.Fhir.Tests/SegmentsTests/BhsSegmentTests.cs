using System;
using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class BhsSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
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
                }
            };

            string expected = "BHS|1|2|3|4|5|6|20200707000007|8|9|10|11|12|13|14";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
