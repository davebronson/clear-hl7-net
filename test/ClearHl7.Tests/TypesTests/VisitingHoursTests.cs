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
            DateTime today = DateTime.Today;

            IType expected = new VisitingHours
            {
                StartDayRange = "1",
                EndDayRange = "2",
                StartHourRange = new DateTime(today.Year, today.Month, today.Day, 3, 33, 0),
                EndHourRange = new DateTime(today.Year, today.Month, today.Day, 4, 44, 4)
            };

            IType actual = new VisitingHours();
            actual.FromDelimitedString("1^2^033300^044404");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            DateTime today = DateTime.Today;

            IType hl7Type = new VisitingHours
            {
                StartDayRange = "1",
                EndDayRange = "2",
                StartHourRange = new DateTime(today.Year, today.Month, today.Day, 3, 33, 0),
                EndHourRange = new DateTime(today.Year, today.Month, today.Day, 4, 44, 4)
            };

            string expected = "1^2^033300^044404";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
