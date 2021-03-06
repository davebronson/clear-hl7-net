﻿using System;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class PractitionerLicenseOrOtherIdNumberTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new PractitionerLicenseOrOtherIdNumber
            {
                IdNumber = "1",
                TypeOfIdNumber = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                StateOtherQualifyingInformation = "3",
                ExpirationDate = new DateTime(2020, 4, 4)
            };

            string expected = "1^2^3^20200404";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
