using System;
using System.Collections.Generic;
using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class CtdSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new CtdSegment
            {
                ContactRole = new List<CodedWithExceptions>
                {
                    new CodedWithExceptions
                    {
                        Identifier = "1"
                    }
                },
                ContactName = new List<ExtendedPersonName>
                {
                    new ExtendedPersonName
                    {
                        FamilyName =new FamilyName
                        {
                            Surname = "2"
                        }
                    }
                },
                ContactAddress = new List<ExtendedAddress>
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "3"
                        }
                    }
                },
                ContactLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "4"
                    }
                },
                ContactCommunicationInformation = new List<ExtendedTelecommunicationNumber>
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "5"
                    }
                },
                PreferredMethodOfContact = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                ContactIdentifiers = new List<PractitionerLicenseOrOtherIdNumber>
                {
                    new PractitionerLicenseOrOtherIdNumber
                    {
                        IdNumber = "7"
                    }
                }
            };

            string expected = "CTD|1|2|3|4|5|6|7";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
