using System;
using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class Pr1SegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Pr1Segment
            {
                SetIdPr1 = 1,
                ProcedureCodingMethod = "2",
                ProcedureCode = new CodedWithNoExceptions
                {
                    Identifier = "3"
                },
                ProcedureDescription = "4",
                ProcedureDateTime = new DateTime(2020, 5, 5, 0, 0, 5),
                ProcedureFunctionalType = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                ProcedureMinutes = 7,
                Anesthesiologist = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "8"
                },
                AnesthesiaCode = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                AnesthesiaMinutes = 10,
                Surgeon = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "11"
                },
                ProcedurePractitioner = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "12"
                },
                ConsentCode = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                ProcedurePriority = 14,
                AssociatedDiagnosisCode = new CodedWithExceptions
                {
                    Identifier = "15"
                },
                ProcedureCodeModifier = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "16"
                    }
                },
                ProcedureDrgType = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                TissueTypeCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "18"
                    }
                },
                ProcedureIdentifier = new EntityIdentifier
                {
                    EntityId = "19"
                },
                ProcedureActionCode = "20",
                DrgProcedureDeterminationStatus = new CodedWithExceptions
                {
                    Identifier = "21"
                },
                DrgProcedureRelevance = new CodedWithExceptions
                {
                    Identifier = "22"
                },
                TreatingOrganizationalUnit = new PersonLocation[]
                {
                    new PersonLocation
                    {
                        PointOfCare = new HierarchicDesignator
                        {
                            NamespaceId = "23"
                        }
                    }
                },
                RespiratoryWithinSurgery = "24",
                ParentProcedureId = new EntityIdentifier
                {
                    EntityId = "25"
                }
            };

            string expected = "PR1|1|2|3|4|20200505000005|6|7|8|9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
