using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class PdcSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new PdcSegment
            {
                ManufacturerDistributor = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "1"
                    }
                },
                Country = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                BrandName = "3",
                DeviceFamilyName = "4",
                GenericName = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                ModelIdentifier = new string[]
                {
                    "6"
                },
                CatalogueIdentifier = "7",
                OtherIdentifier = new string[]
                {
                    "8"
                },
                ProductCode = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                MarketingBasis = "10",
                MarketingApprovalId = "11",
                LabeledShelfLife = new CompositeQuantityWithUnits
                {
                    Quantity = 12
                },
                ExpectedShelfLife = new CompositeQuantityWithUnits
                {
                    Quantity = 13
                },
                DateFirstMarketed = new DateTime(2020, 1, 14, 0, 0, 14),
                DateLastMarketed = new DateTime(2020, 1, 15, 0, 0, 15)
            };

            ISegment actual = new PdcSegment();
            actual.FromDelimitedString("PDC|1|2|3|4|5|6|7|8|9|10|11|12|13|20200114000014|20200115000015");

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
                ISegment hl7Segment = new PdcSegment();
                hl7Segment.FromDelimitedString("PDA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new PdcSegment
            {
                ManufacturerDistributor = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "1"
                    }
                },
                Country = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                BrandName = "3",
                DeviceFamilyName = "4",
                GenericName = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                ModelIdentifier = new string[]
                {
                    "6"
                },
                CatalogueIdentifier = "7",
                OtherIdentifier = new string[]
                {
                    "8"
                },
                ProductCode = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                MarketingBasis = "10",
                MarketingApprovalId = "11",
                LabeledShelfLife = new CompositeQuantityWithUnits
                {
                    Quantity = 12
                },
                ExpectedShelfLife = new CompositeQuantityWithUnits
                {
                    Quantity = 13
                },
                DateFirstMarketed = new DateTime(2020, 1, 14, 0, 0, 14),
                DateLastMarketed = new DateTime(2020, 1, 15, 0, 0, 15)
            };

            string expected = "PDC|1|2|3|4|5|6|7|8|9|10|11|12|13|20200114000014|20200115000015";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
