﻿using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.TypesTests
{
    public class SortOrderTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new SortOrder
            {
                SortByField = "1",
                Sequencing = "2"
            };

            string expected = "1^2";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
