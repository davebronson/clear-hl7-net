﻿using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Pm1SegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Pm1Segment
            {
                HealthPlanId = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                InsuranceCompanyId = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "2"
                    }
                },
                InsuranceCompanyName = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "3"
                    }
                },
                InsuranceCompanyAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "4"
                        }
                    }
                },
                InsuranceCoContactPerson = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "5"
                        }
                    }
                },
                InsuranceCoPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "6"
                    }
                },
                GroupNumber = "7",
                GroupName = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "8"
                    }
                },
                PlanEffectiveDate = new DateTime(2020, 9, 9),
                PlanExpirationDate = new DateTime(2020, 10, 10),
                PatientDobRequired = "11",
                PatientGenderRequired = "12",
                PatientRelationshipRequired = "13",
                PatientSignatureRequired = "14",
                DiagnosisRequired = "15",
                ServiceRequired = "16",
                PatientNameRequired = "17",
                PatientAddressRequired = "18",
                SubscribersNameRequired = "19",
                WorkmansCompIndicator = "20",
                BillTypeRequired = "21",
                CommercialCarrierNameAndAddressRequired = "22",
                PolicyNumberPattern = "23",
                GroupNumberPattern = "24"
            };

            string expected = "PM1|1|2|3|4|5|6|7|8|20200909|20201010|11|12|13|14|15|16|17|18|19|20|21|22|23|24";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
