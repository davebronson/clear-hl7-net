using System;
using ClearHl7.Fhir.V290;
using ClearHl7.Fhir.V290.Segments;
using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.MessagesTests
{
    public class MessageTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all segments populated and in order.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithThreeSegments_ReturnsCorrectMessage()
        {
            Message message = new Message
            {
                Segments = new ISegment[]
                {
                    new MshSegment
                    {
                        SendingApplication = new HierarchicDesignator
                        {
                            NamespaceId = "Sender 1"
                        },
                        ReceivingApplication = new HierarchicDesignator
                        {
                            NamespaceId = "Receiver 1"
                        },
                        DateTimeOfMessage = new DateTime(2020, 12, 2, 14, 45, 39)
                    },

                    new CdmSegment
                    {
                        Ordinal = 2,

                        // Repeating component, with separated values
                        ChargeCodeAlias = new CodedWithExceptions[]
                        {
                            new CodedWithExceptions
                            {
                                Identifier = "Code 1",
                                Text = "ABC"
                            },
                            new CodedWithExceptions
                            {
                                Identifier = "Code 2",
                                Text = "ZYX"
                            }
                        }
                    },

                    new In1Segment
                    {
                        Ordinal = 1,

                        SetIdIn1 = 15,
                        HealthPlanId = new CodedWithExceptions
                        {
                            Identifier = "MNO Healthcare"
                        },

                        // Component with subcomponents
                        InsuranceCompanyId = new ExtendedCompositeIdWithCheckDigit[]
                        {
                            new ExtendedCompositeIdWithCheckDigit
                            {
                                IdNumber = "736HB",
                                AssigningAuthority = new HierarchicDesignator
                                {
                                    NamespaceId = "DES1",
                                    UniversalId = "UID654",
                                    UniversalIdType = "Type 5"
                                }
                            },
                            new ExtendedCompositeIdWithCheckDigit
                            {
                                IdNumber = "AA876",
                                AssigningAuthority = new HierarchicDesignator
                                {
                                    NamespaceId = "LLL098",
                                    UniversalId = "UID123",
                                    UniversalIdType = "Type 7"
                                }
                            }
                        }
                    }
                }
            };

            string expected = "MSH|^~\\&|Sender 1||Receiver 1||20201202144539|||||2.9\rIN1|15|MNO Healthcare|736HB^^^DES1&UID654&Type 5~AA876^^^LLL098&UID123&Type 7\rCDM||Code 1^ABC~Code 2^ZYX\r";
            string actual = message.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
