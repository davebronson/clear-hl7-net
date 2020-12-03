﻿using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.TypesTests
{
    public class EntityIdentifierTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new EntityIdentifier
            {
                EntityId = "1",
                NamespaceId = "2",
                UniversalId = "3",
                UniversalIdType = "4"
            };

            string expected = "1^2^3^4";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
