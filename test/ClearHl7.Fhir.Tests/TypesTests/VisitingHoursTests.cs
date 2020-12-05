using System;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.TypesTests
{
    public class VisitingHoursTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new VisitingHours
            {
                StartDayRange = "1",
                EndDayRange = "2",
                StartHourRange = new DateTime(2020, 1, 1, 3, 33, 0),
                EndHourRange = new DateTime(2020, 1, 1, 4, 44, 4)
            };

            string expected = "1^2^033300^044404";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
