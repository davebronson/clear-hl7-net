using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Dg1SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Dg1Segment
            {
                SetIdDg1 = 1,
                DiagnosisCodingMethod = "2",
                DiagnosisCodeDg1 = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                DiagnosisDescription = "4",
                DiagnosisDateTime = new DateTime(2020, 5, 5, 0, 0, 5),
                DiagnosisType = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                MajorDiagnosticCategory = new CodedWithNoExceptions
                {
                    Identifier = "7"
                },
                DiagnosticRelatedGroup = new CodedWithNoExceptions
                {
                    Identifier = "8"
                },
                DrgApprovalIndicator = "9",
                DrgGrouperReviewCode = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                OutlierType = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                OutlierDays = 12,
                OutlierCost = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 13
                    }
                },
                GrouperVersionAndType = "14",
                DiagnosisPriority = 15,
                DiagnosingClinician = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "16"
                    }
                },
                DiagnosisClassification = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                ConfidentialIndicator = "18",
                AttestationDateTime = new DateTime(2020, 1, 19, 0, 0, 19),
                DiagnosisIdentifier = new EntityIdentifier
                {
                    EntityId = "20"
                },
                DiagnosisActionCode = "21",
                ParentDiagnosis = new EntityIdentifier
                {
                    EntityId = "22"
                },
                DrgCclValueCode = new CodedWithExceptions
                {
                    Identifier = "23"
                },
                DrgGroupingUsage = "24",
                DrgDiagnosisDeterminationStatus = new CodedWithExceptions
                {
                    Identifier = "25"
                },
                PresentOnAdmissionPoaIndicator = new CodedWithExceptions
                {
                    Identifier = "26"
                }
            };

            ISegment actual = new Dg1Segment();
            actual.FromDelimitedString("DG1|1|2|3|4|20200505000005|6|7|8|9|10|11|12|13|14|15|16|17|18|20200119000019|20|21|22|23|24|25|26");

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
                ISegment hl7Segment = new Dg1Segment();
                hl7Segment.FromDelimitedString("DGA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Dg1Segment
            {
                SetIdDg1 = 1,
                DiagnosisCodingMethod = "2",
                DiagnosisCodeDg1 = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                DiagnosisDescription = "4",
                DiagnosisDateTime = new DateTime(2020, 5, 5, 0, 0, 5),
                DiagnosisType = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                MajorDiagnosticCategory = new CodedWithNoExceptions
                {
                    Identifier = "7"
                },
                DiagnosticRelatedGroup = new CodedWithNoExceptions
                {
                    Identifier = "8"
                },
                DrgApprovalIndicator = "9",
                DrgGrouperReviewCode = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                OutlierType = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                OutlierDays = 12,
                OutlierCost = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 13
                    }
                },
                GrouperVersionAndType = "14",
                DiagnosisPriority = 15,
                DiagnosingClinician = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "16"
                    }
                },
                DiagnosisClassification = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                ConfidentialIndicator = "18",
                AttestationDateTime = new DateTime(2020, 1, 19, 0, 0, 19),
                DiagnosisIdentifier = new EntityIdentifier
                {
                    EntityId = "20"
                },
                DiagnosisActionCode = "21",
                ParentDiagnosis = new EntityIdentifier
                {
                    EntityId = "22"
                },
                DrgCclValueCode = new CodedWithExceptions
                {
                    Identifier = "23"
                },
                DrgGroupingUsage = "24",
                DrgDiagnosisDeterminationStatus = new CodedWithExceptions
                {
                    Identifier = "25"
                },
                PresentOnAdmissionPoaIndicator = new CodedWithExceptions
                {
                    Identifier = "26"
                }
            };

            string expected = "DG1|1|2|3|4|20200505000005|6|7|8|9|10|11|12|13|14|15|16|17|18|20200119000019|20|21|22|23|24|25|26";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
