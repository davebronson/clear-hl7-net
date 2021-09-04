using System;
using ClearHl7.Serialization;
using ClearHl7.V290;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SerializationTests
{
    public class MessageSerializerTests
    {
        /// <summary>
        /// Validates that Deserialize() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void Deserialize_WithThreeSegments_ReturnsCorrectlyInitializedFields()
        {
            Message expected = new()
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

            string delimitedString = "MSH|^~\\&|Sender 1||Receiver 1||20201202144539|||||2.9\rIN1|15|MNO Healthcare|736HB^^^DES1&UID654&Type 5~AA876^^^LLL098&UID123&Type 7\rCDM||Code 1^ABC~Code 2^ZYX\r";
            Message actual = MessageSerializer.Deserialize<Message>(delimitedString);

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that Serialize() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void Serialize_WithAllThreeSegments_ReturnsCorrectlySequencedFields()
        {
            IMessage hl7Message = new Message
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
            string actual = MessageSerializer.Serialize(hl7Message);

            Assert.Equal(expected, actual);
        }
    }
}
