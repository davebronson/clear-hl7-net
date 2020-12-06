using System;
using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class FhsSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new FhsSegment
            {
                FileFieldSeparator = "1",
                FileEncodingCharacters = "2",
                FileSendingApplication = new HierarchicDesignator
                {
                    NamespaceId = "3"
                },
                FileSendingFacility = new HierarchicDesignator
                {
                    NamespaceId = "4"
                },
                FileReceivingApplication = new HierarchicDesignator
                {
                    NamespaceId = "5"
                },
                FileReceivingFacility = new HierarchicDesignator
                {
                    NamespaceId = "6"
                },
                FileCreationDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                FileSecurity = "8",
                FileNameId = "9",
                FileHeaderComment = "10",
                FileControlId = "11",
                ReferenceFileControlId = "12",
                FileSendingNetworkAddress = new HierarchicDesignator
                {
                    NamespaceId = "13"
                },
                FileReceivingNetworkAddress = new HierarchicDesignator
                {
                    NamespaceId = "14"
                }
            };

            string expected = "FHS|1|2|3|4|5|6|20200707000007|8|9|10|11|12|13|14";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
