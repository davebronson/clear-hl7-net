﻿using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class JobCodeClassTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new JobCodeClass
            {
                JobCode = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                JobClass = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                JobDescriptionText = new Text
                {
                    Value = "3"
                }
            };

            string expected = "1^2^3";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
