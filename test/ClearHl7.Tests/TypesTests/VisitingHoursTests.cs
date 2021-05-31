using System;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class VisitingHoursTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            VisitingHours expected = new()
            {
                StartDayRange = "1",
                EndDayRange = "2",
                StartHourRange = new DateTime(2020, 1, 1, 3, 33, 0),
                EndHourRange = new DateTime(2020, 1, 1, 4, 44, 4)
            };
            VisitingHours actual = new VisitingHours().FromDelimitedString("1^2^033300^044404");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
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
