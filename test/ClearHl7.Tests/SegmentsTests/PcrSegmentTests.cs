using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class PcrSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new PcrSegment
            {
                ImplicatedProduct = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                GenericProduct = "2",
                ProductClass = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                TotalDurationOfTherapy = new CompositeQuantityWithUnits
                {
                    Quantity = 4
                },
                ProductManufactureDate = new DateTime(2020, 5, 5, 0, 0, 5),
                ProductExpirationDate = new DateTime(2020, 6, 6, 0, 0, 6),
                ProductImplantationDate = new DateTime(2020, 7, 7, 0, 0, 7),
                ProductExplantationDate = new DateTime(2020, 8, 8, 0, 0, 8),
                SingleUseDevice = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                IndicationForProductUse = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                ProductProblem = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                ProductSerialLotNumber = new string[]
                {
                    "12"
                },
                ProductAvailableForInspection = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                ProductEvaluationPerformed = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                ProductEvaluationStatus = new CodedWithExceptions
                {
                    Identifier = "15"
                },
                ProductEvaluationResults = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                EvaluatedProductSource = "17",
                DateProductReturnedToManufacturer = new DateTime(2020, 1, 18, 0, 0, 18),
                DeviceOperatorQualifications = "19",
                RelatednessAssessment = "20",
                ActionTakenInResponseToTheEvent = new string[]
                {
                    "21"
                },
                EventCausalityObservations = new string[]
                {
                    "22"
                },
                IndirectExposureMechanism = new string[]
                {
                    "23"
                }
            };

            ISegment actual = new PcrSegment();
            actual.FromDelimitedString("PCR|1|2|3|4|20200505000005|20200606000006|20200707000007|20200808000008|9|10|11|12|13|14|15|16|17|20200118000018|19|20|21|22|23");

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
                ISegment hl7Segment = new PcrSegment();
                hl7Segment.FromDelimitedString("PCA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new PcrSegment
            {
                ImplicatedProduct = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                GenericProduct = "2",
                ProductClass = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                TotalDurationOfTherapy = new CompositeQuantityWithUnits
                {
                    Quantity = 4
                },
                ProductManufactureDate = new DateTime(2020, 5, 5, 0, 0, 5),
                ProductExpirationDate = new DateTime(2020, 6, 6, 0, 0, 6),
                ProductImplantationDate = new DateTime(2020, 7, 7, 0, 0, 7),
                ProductExplantationDate = new DateTime(2020, 8, 8, 0, 0, 8),
                SingleUseDevice = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                IndicationForProductUse = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                ProductProblem = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                ProductSerialLotNumber = new string[]
                {
                    "12"
                },
                ProductAvailableForInspection = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                ProductEvaluationPerformed = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                ProductEvaluationStatus = new CodedWithExceptions
                {
                    Identifier = "15"
                },
                ProductEvaluationResults = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                EvaluatedProductSource = "17",
                DateProductReturnedToManufacturer = new DateTime(2020, 1, 18, 0, 0, 18),
                DeviceOperatorQualifications = "19",
                RelatednessAssessment = "20",
                ActionTakenInResponseToTheEvent = new string[]
                {
                    "21"
                },
                EventCausalityObservations = new string[]
                {
                    "22"
                },
                IndirectExposureMechanism = new string[]
                {
                    "23"
                }
            };

            string expected = "PCR|1|2|3|4|20200505000005|20200606000006|20200707000007|20200808000008|9|10|11|12|13|14|15|16|17|20200118000018|19|20|21|22|23";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
