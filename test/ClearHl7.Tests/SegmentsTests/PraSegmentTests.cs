using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class PraSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new PraSegment
            {
                PrimaryKeyValuePra = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                PractitionerGroup = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "2"
                    }
                },
                PractitionerCategory = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "3"
                    }
                },
                ProviderBilling = "4",
                Specialty = new SpecialtyDescription[]
                {
                    new SpecialtyDescription
                    {
                        SpecialtyName = "5"
                    }
                },
                PractitionerIdNumbers = new PractitionerLicenseOrOtherIdNumber[]
                {
                    new PractitionerLicenseOrOtherIdNumber
                    {
                        IdNumber = "6"
                    }
                },
                Privileges = new PractitionerInstitutionalPrivileges[]
                {
                    new PractitionerInstitutionalPrivileges
                    {
                        Privilege = new CodedWithExceptions
                        {
                            Identifier = "7"
                        }
                    }
                },
                DateEnteredPractice = new DateTime(2020, 8, 8),
                Institution = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                DateLeftPractice = new DateTime(2020, 10, 10),
                GovernmentReimbursementBillingEligibility = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "11"
                    }
                },
                SetIdPra = 12
            };

            ISegment actual = new PraSegment();
            actual.FromDelimitedString("PRA|1|2|3|4|5|6|7|20200808|9|20201010|11|12");

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
                ISegment hl7Segment = new PraSegment();
                hl7Segment.FromDelimitedString("PAA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new PraSegment
            {
                PrimaryKeyValuePra = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                PractitionerGroup = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "2"
                    }
                },
                PractitionerCategory = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "3"
                    }
                },
                ProviderBilling = "4",
                Specialty = new SpecialtyDescription[]
                {
                    new SpecialtyDescription
                    {
                        SpecialtyName = "5"
                    }
                },
                PractitionerIdNumbers = new PractitionerLicenseOrOtherIdNumber[]
                {
                    new PractitionerLicenseOrOtherIdNumber
                    {
                        IdNumber = "6"
                    }
                },
                Privileges = new PractitionerInstitutionalPrivileges[]
                {
                    new PractitionerInstitutionalPrivileges
                    {
                        Privilege = new CodedWithExceptions
                        {
                            Identifier = "7"
                        }
                    }
                },
                DateEnteredPractice = new DateTime(2020, 8, 8),
                Institution = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                DateLeftPractice = new DateTime(2020, 10, 10),
                GovernmentReimbursementBillingEligibility = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "11"
                    }
                },
                SetIdPra = 12
            };

            string expected = "PRA|1|2|3|4|5|6|7|20200808|9|20201010|11|12";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
