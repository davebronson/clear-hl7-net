using System;
using System.Linq;
using ClearHl7.Serialization;
using ClearHl7.V290;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SerializationTests
{
    [Collection("SegmentFactoryNonParallelCollection")]
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

            string delimitedString = $"MSH|^~\\&|Sender 1||Receiver 1||20201202144539|||||2.9{ Consts.LineTerminator }IN1|15|MNO Healthcare|736HB^^^DES1&UID654&Type 5~AA876^^^LLL098&UID123&Type 7{ Consts.LineTerminator }CDM||Code 1^ABC~Code 2^ZYX{ Consts.LineTerminator }";
            Message actual = MessageSerializer.Deserialize<Message>(delimitedString);

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that Deserialize() returns the object instance with all properties correctly initialized when a custom field separator is used.
        /// </summary>
        [Fact]
        public void Deserialize_WithCustomFieldSeparator_ReturnsCorrectlyInitializedFields()
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

            string delimitedString = $"MSH$^~\\&$Sender 1$$Receiver 1$$20201202144539$$$$$2.9{ Consts.LineTerminator }IN1$15$MNO Healthcare$736HB^^^DES1&UID654&Type 5~AA876^^^LLL098&UID123&Type 7{ Consts.LineTerminator }CDM$$Code 1^ABC~Code 2^ZYX{ Consts.LineTerminator }";
            Message actual = MessageSerializer.Deserialize<Message>(delimitedString);

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that Deserialize() throws an ArgumentNullException when a null input is provided.
        /// </summary>
        [Fact]
        public void Deserialize_WithNullInput_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                IMessage result = MessageSerializer.Deserialize(null);
            });
        }

        /// <summary>
        /// Validates that Deserialize() throws an ArgumentException when an invalid HL7 version is specified.
        /// </summary>
        [Fact]
        public void Deserialize_WithInvalidVersionSpecified_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                MessageSerializer.Deserialize($"{ @"MSH|^~\&||||||||||2.2.7||" }{ Consts.LineTerminator }");
            });
        }

        /// <summary>
        /// Validates that Deserialize() returns the correct Message instance when V2.3 is specified.
        /// </summary>
        [Fact]
        public void Deserialize_With23Specified_ReturnsCorrectMesssageVersion()
        {
            Assert.IsType<V230.Message>(MessageSerializer.Deserialize($"{ @"MSH|^~\&||||||||||2.3||" }{ Consts.LineTerminator }"));
        }

        /// <summary>
        /// Validates that Deserialize() returns the correct Message instance when V2.3.1 is specified.
        /// </summary>
        [Fact]
        public void Deserialize_With231Specified_ReturnsCorrectMesssageVersion()
        {
            Assert.IsType<V231.Message>(MessageSerializer.Deserialize($"{ @"MSH|^~\&||||||||||2.3.1||" }{ Consts.LineTerminator }"));
        }

        /// <summary>
        /// Validates that Deserialize() returns the correct Message instance when V2.4 is specified.
        /// </summary>
        [Fact]
        public void Deserialize_With24Specified_ReturnsCorrectMesssageVersion()
        {
            Assert.IsType<V240.Message>(MessageSerializer.Deserialize($"{ @"MSH|^~\&||||||||||2.4||" }{ Consts.LineTerminator }"));
        }

        /// <summary>
        /// Validates that Deserialize() returns the correct Message instance when V2.5 is specified.
        /// </summary>
        [Fact]
        public void Deserialize_With25Specified_ReturnsCorrectMesssageVersion()
        {
            Assert.IsType<V250.Message>(MessageSerializer.Deserialize($"{ @"MSH|^~\&||||||||||2.5||" }{ Consts.LineTerminator }"));
        }

        /// <summary>
        /// Validates that Deserialize() returns the correct Message instance when V2.5.1 is specified.
        /// </summary>
        [Fact]
        public void Deserialize_With251Specified_ReturnsCorrectMesssageVersion()
        {
            Assert.IsType<V251.Message>(MessageSerializer.Deserialize($"{ @"MSH|^~\&||||||||||2.5.1||" }{ Consts.LineTerminator }"));
        }

        /// <summary>
        /// Validates that Deserialize() returns the correct Message instance when V2.6 is specified.
        /// </summary>
        [Fact]
        public void Deserialize_With26Specified_ReturnsCorrectMesssageVersion()
        {
            Assert.IsType<V260.Message>(MessageSerializer.Deserialize($"{ @"MSH|^~\&||||||||||2.6||" }{ Consts.LineTerminator }"));
        }

        /// <summary>
        /// Validates that Deserialize() returns the correct Message instance when V2.7 is specified.
        /// </summary>
        [Fact]
        public void Deserialize_With27Specified_ReturnsCorrectMesssageVersion()
        {
            Assert.IsType<V270.Message>(MessageSerializer.Deserialize($"{ @"MSH|^~\&||||||||||2.7||" }{ Consts.LineTerminator }"));
        }

        /// <summary>
        /// Validates that Deserialize() returns the correct Message instance when V2.7.1 is specified.
        /// </summary>
        [Fact]
        public void Deserialize_With271Specified_ReturnsCorrectMesssageVersion()
        {
            Assert.IsType<V271.Message>(MessageSerializer.Deserialize($"{ @"MSH|^~\&||||||||||2.7.1||" }{ Consts.LineTerminator }"));
        }

        /// <summary>
        /// Validates that Deserialize() returns the correct Message instance when V2.8 is specified.
        /// </summary>
        [Fact]
        public void Deserialize_With28Specified_ReturnsCorrectMesssageVersion()
        {
            Assert.IsType<V280.Message>(MessageSerializer.Deserialize($"{ @"MSH|^~\&||||||||||2.8||" }{ Consts.LineTerminator }"));
        }

        /// <summary>
        /// Validates that Deserialize() returns the correct Message instance when V2.8.1 is specified.
        /// </summary>
        [Fact]
        public void Deserialize_With281Specified_ReturnsCorrectMesssageVersion()
        {
            Assert.IsType<V281.Message>(MessageSerializer.Deserialize($"{ @"MSH|^~\&||||||||||2.8.1||" }{ Consts.LineTerminator }"));
        }

        /// <summary>
        /// Validates that Deserialize() returns the correct Message instance when V2.8.2 is specified.
        /// </summary>
        [Fact]
        public void Deserialize_With282Specified_ReturnsCorrectMesssageVersion()
        {
            Assert.IsType<V282.Message>(MessageSerializer.Deserialize($"{ @"MSH|^~\&||||||||||2.8.2||" }{ Consts.LineTerminator }"));
        }

        /// <summary>
        /// Validates that Deserialize() returns the correct Message instance when V2.9 is specified.
        /// </summary>
        [Fact]
        public void Deserialize_With29Specified_ReturnsCorrectMesssageVersion()
        {
            Assert.IsType<V290.Message>(MessageSerializer.Deserialize($"{ @"MSH|^~\&||||||||||2.9||" }{ Consts.LineTerminator }"));
        }

        /// <summary>
        /// Validates that Serialize() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void Serialize_WithThreeSegments_ReturnsCorrectlySequencedFields()
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

            string expected = $"MSH|^~\\&|Sender 1||Receiver 1||20201202144539|||||2.9{ Consts.LineTerminator }IN1|15|MNO Healthcare|736HB^^^DES1&UID654&Type 5~AA876^^^LLL098&UID123&Type 7{ Consts.LineTerminator }CDM||Code 1^ABC~Code 2^ZYX{ Consts.LineTerminator }";
            string actual = MessageSerializer.Serialize(hl7Message);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that calling Serialize() with a null input results in an ArgumentNullException being thrown.
        /// </summary>
        [Fact]
        public void Serialize_WithNullInput_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                string result = MessageSerializer.Serialize(null);
            });
        }

        // -----------------------------------------------------------------------
        // BestEffort / Skip parse-error handling tests
        // -----------------------------------------------------------------------

        /// <summary>
        /// Validates that BestEffort successfully parses a custom Z-segment after blanking the field
        /// that caused the parse error.  The resulting message contains the segment with the bad field
        /// nulled out, and the warning carries the correct 1-based FieldIndex and RawFieldValue.
        /// </summary>
        [Fact]
        public void DeserializeWithWarnings_BestEffort_CustomSegment_SuccessfullyBlanksFieldAndPopulatesPartialSegment()
        {
            SegmentFactory.RegisterSegment<ZtsSegment>("ZTS");
            try
            {
                var options = new ParserOptions
                {
                    MalformedSegmentHandling = MalformedSegmentHandling.BestEffort,
                    CollectWarnings = true
                };

                // ZTS field 2 = "BADFIELD" triggers an exception in ZtsSegment.FromDelimitedString.
                // Field 1 and field 3 are valid and should be populated in the recovered segment.
                string delimitedString =
                    $"MSH|^~\\&|Sender||Receiver||20201202144539|||||2.9{Consts.LineTerminator}" +
                    $"ZTS|GoodField1|BADFIELD|GoodField3{Consts.LineTerminator}";

                ParseResult<Message> result = MessageSerializer.DeserializeWithWarnings<Message>(delimitedString, options);

                // The message should contain MSH + the recovered ZTS segment.
                result.Message.Segments.Should().HaveCount(2);
                result.HasWarnings.Should().BeTrue();
                result.Warnings.Should().HaveCount(1);

                ParserWarning warning = result.Warnings[0];
                warning.SegmentId.Should().Be("ZTS");
                warning.FieldIndex.Should().Be(2);
                warning.RawFieldValue.Should().Be("BADFIELD");
                warning.Exception.Should().NotBeNull();

                // The recovered segment should have fields before and after the bad one populated.
                ZtsSegment recovered = result.Message.Segments.ElementAt(1).Should().BeOfType<ZtsSegment>().Subject;
                recovered.Field1.Should().Be("GoodField1");
                recovered.Field2.Should().BeNull();   // blanked during recovery
                recovered.Field3.Should().Be("GoodField3");
            }
            finally
            {
                SegmentFactory.ClearRegistrations();
            }
        }

        /// <summary>
        /// Validates that BestEffort falls back to Skip behaviour (segment dropped, warning added
        /// without FieldIndex) when no single-field retry succeeds for a custom Z-segment that
        /// always throws regardless of field content.
        /// </summary>
        [Fact]
        public void DeserializeWithWarnings_BestEffort_CustomSegment_FallsBackToSkipWhenAllFieldsFail()
        {
            SegmentFactory.RegisterSegment<ZtfSegment>("ZTF");
            try
            {
                var options = new ParserOptions
                {
                    MalformedSegmentHandling = MalformedSegmentHandling.BestEffort,
                    CollectWarnings = true
                };

                string delimitedString =
                    $"MSH|^~\\&|Sender||Receiver||20201202144539|||||2.9{Consts.LineTerminator}" +
                    $"ZTF|field1|field2|field3{Consts.LineTerminator}";

                ParseResult<Message> result = MessageSerializer.DeserializeWithWarnings<Message>(delimitedString, options);

                // ZTF always throws, so the segment must be absent but a warning must be present.
                result.Message.Segments.Should().HaveCount(1, "only MSH should survive");
                result.HasWarnings.Should().BeTrue();
                result.Warnings.Should().HaveCount(1);

                ParserWarning warning = result.Warnings[0];
                warning.SegmentId.Should().Be("ZTF");
                warning.FieldIndex.Should().BeNull("no field was successfully blanked");
                warning.RawFieldValue.Should().BeNull();
            }
            finally
            {
                SegmentFactory.ClearRegistrations();
            }
        }

        /// <summary>
        /// Validates that Skip drops a custom Z-segment entirely and produces a warning without
        /// FieldIndex information (regression check).
        /// </summary>
        [Fact]
        public void DeserializeWithWarnings_Skip_CustomSegment_DropsSegmentEntirely()
        {
            SegmentFactory.RegisterSegment<ZtsSegment>("ZTS");
            try
            {
                var options = new ParserOptions
                {
                    MalformedSegmentHandling = MalformedSegmentHandling.Skip,
                    CollectWarnings = true
                };

                string delimitedString =
                    $"MSH|^~\\&|Sender||Receiver||20201202144539|||||2.9{Consts.LineTerminator}" +
                    $"ZTS|GoodField1|BADFIELD|GoodField3{Consts.LineTerminator}";

                ParseResult<Message> result = MessageSerializer.DeserializeWithWarnings<Message>(delimitedString, options);

                // Segment must be dropped and only MSH present.
                result.Message.Segments.Should().HaveCount(1);
                result.HasWarnings.Should().BeTrue();

                ParserWarning warning = result.Warnings[0];
                warning.SegmentId.Should().Be("ZTS");
                warning.FieldIndex.Should().BeNull("Skip does not perform field-level recovery");
                warning.RawFieldValue.Should().BeNull();
            }
            finally
            {
                SegmentFactory.ClearRegistrations();
            }
        }

        /// <summary>
        /// Validates that BestEffort never stops after the first recovered field: a segment with
        /// two bad fields produces two warnings (one per field, in order), and the recovered segment
        /// has both bad fields nulled out while all good fields are fully preserved.
        /// </summary>
        [Fact]
        public void DeserializeWithWarnings_BestEffort_CustomSegment_MultipleInvalidFields_ProducesOneWarningPerBadField()
        {
            SegmentFactory.RegisterSegment<ZtsSegment>("ZTS");
            try
            {
                var options = new ParserOptions
                {
                    MalformedSegmentHandling = MalformedSegmentHandling.BestEffort,
                    CollectWarnings = true
                };

                // Both field 2 and field 3 contain "BADFIELD".  The null-boundary technique
                // identifies field 2 first (it is null in the partial segment after the initial
                // failure), blanks it, then the next retry fails at field 3 which is identified
                // the same way.  A third retry with both fields blank succeeds.
                string delimitedString =
                    $"MSH|^~\\&|Sender||Receiver||20201202144539|||||2.9{Consts.LineTerminator}" +
                    $"ZTS|GoodField1|BADFIELD|BADFIELD|GoodField4{Consts.LineTerminator}";

                ParseResult<Message> result = MessageSerializer.DeserializeWithWarnings<Message>(delimitedString, options);

                // MSH + recovered ZTS should both be present.
                result.Message.Segments.Should().HaveCount(2);
                result.HasWarnings.Should().BeTrue();
                result.Warnings.Should().HaveCount(2, "one warning per bad field");

                // Both warnings must exist with correct field index and raw value.
                // Order is not asserted because the underlying ConcurrentBag has LIFO
                // enumeration order, but all per-field data must be correct.
                result.Warnings.Should().ContainSingle(w => w.FieldIndex == 2 && w.RawFieldValue == "BADFIELD",
                    "field 2 was the first null boundary");
                result.Warnings.Should().ContainSingle(w => w.FieldIndex == 3 && w.RawFieldValue == "BADFIELD",
                    "field 3 was revealed as the next null boundary after field 2 was blanked");
                result.Warnings.Should().AllSatisfy(w => w.SegmentId.Should().Be("ZTS"));

                // The recovered segment: bad fields are null, good fields are preserved.
                ZtsSegment recovered = result.Message.Segments.ElementAt(1).Should().BeOfType<ZtsSegment>().Subject;
                recovered.Field1.Should().Be("GoodField1");
                recovered.Field2.Should().BeNull();
                recovered.Field3.Should().BeNull();
                recovered.Field4.Should().Be("GoodField4");
            }
            finally
            {
                SegmentFactory.ClearRegistrations();
            }
        }

        /// <summary>
        /// Validates BestEffort behaviour against the real IN2 segment (V2.9): when field 72
        /// (PatientsRelationshipToInsured) is present but empty, the library throws because the
        /// field guard is missing.  BestEffort correctly tries to blank each non-empty field but
        /// cannot fix the root cause (the bad field is already empty), so it falls back gracefully —
        /// the segment is dropped and a warning is added without FieldIndex / RawFieldValue.
        /// </summary>
        [Fact]
        public void DeserializeWithWarnings_BestEffort_RealIn2Segment_FallsBackGracefullyWhenRootCauseIsEmptyField()
        {
            var options = new ParserOptions
            {
                MalformedSegmentHandling = MalformedSegmentHandling.BestEffort,
                CollectWarnings = true
            };

            // IN2 with fields 1-3 populated and 69 trailing pipes so that field index 72
            // (PatientsRelationshipToInsured) is present but empty, triggering the parse error.
            string in2Segment = "IN2|Smith|Jones|123" + new string('|', 69);
            string delimitedString =
                $"MSH|^~\\&|Sender||Receiver||20201202144539|||||2.9{Consts.LineTerminator}" +
                in2Segment + Consts.LineTerminator;

            ParseResult<Message> result = MessageSerializer.DeserializeWithWarnings<Message>(delimitedString, options);

            // IN2 cannot be recovered (empty field 72 remains the trigger regardless of which
            // non-empty field is blanked), so it must be absent and only MSH should remain.
            result.Message.Segments.Should().HaveCount(1, "only MSH should survive");
            result.HasWarnings.Should().BeTrue();
            result.Warnings.Should().HaveCount(1);

            ParserWarning warning = result.Warnings[0];
            warning.SegmentId.Should().Be("IN2");
            warning.FieldIndex.Should().BeNull("no individual field blanking can fix an empty-field parse error");
            warning.RawFieldValue.Should().BeNull();
            warning.Exception.Should().NotBeNull();
        }

        /// <summary>
        /// Validates that Skip drops the real IN2 segment entirely when it triggers a parse error
        /// due to the missing guard on field 72 (regression check for normal segments).
        /// </summary>
        [Fact]
        public void DeserializeWithWarnings_Skip_RealIn2Segment_DropsSegmentEntirely()
        {
            var options = new ParserOptions
            {
                MalformedSegmentHandling = MalformedSegmentHandling.Skip,
                CollectWarnings = true
            };

            string in2Segment = "IN2|Smith|Jones|123" + new string('|', 69);
            string delimitedString =
                $"MSH|^~\\&|Sender||Receiver||20201202144539|||||2.9{Consts.LineTerminator}" +
                in2Segment + Consts.LineTerminator;

            ParseResult<Message> result = MessageSerializer.DeserializeWithWarnings<Message>(delimitedString, options);

            result.Message.Segments.Should().HaveCount(1, "Skip must drop the malformed IN2");
            result.HasWarnings.Should().BeTrue();

            ParserWarning warning = result.Warnings[0];
            warning.SegmentId.Should().Be("IN2");
            warning.FieldIndex.Should().BeNull();
            warning.RawFieldValue.Should().BeNull();
        }

        // -----------------------------------------------------------------------
        // Private test-only segment implementations
        // -----------------------------------------------------------------------

        /// <summary>
        /// A controllable custom segment used to exercise the BestEffort retry loop.
        /// FromDelimitedString throws when field 2 or field 3 contains the sentinel value "BADFIELD",
        /// with distinct messages per field so the null-boundary O(1) detection can be verified.
        /// </summary>
        private sealed class ZtsSegment : ISegment
        {
            public string Id => "ZTS";
            public int Ordinal { get; set; }
            public string Field1 { get; set; }
            public string Field2 { get; set; }
            public string Field3 { get; set; }
            public string Field4 { get; set; }

            public void FromDelimitedString(string delimitedString) =>
                FromDelimitedString(delimitedString, null);

            public void FromDelimitedString(string delimitedString, Separators separators)
            {
                Separators seps = separators ?? new Separators().UsingConfigurationValues();
                string[] segments = (delimitedString ?? string.Empty)
                    .Split(seps.FieldSeparator, StringSplitOptions.None);

                if (segments.Length > 0 && !string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                    throw new ArgumentException(
                        $"{nameof(delimitedString)} does not begin with the proper segment Id.", nameof(delimitedString));

                Field1 = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;

                if (segments.Length > 2 && segments[2] == "BADFIELD")
                    throw new ArgumentException("Field 2 contains an invalid value.", nameof(delimitedString));

                Field2 = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;

                if (segments.Length > 3 && segments[3] == "BADFIELD")
                    throw new ArgumentException("Field 3 contains an invalid value.", nameof(delimitedString));

                Field3 = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
                Field4 = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            }

            public string ToDelimitedString() =>
                string.Join(Configuration.FieldSeparator, Id, Field1, Field2, Field3, Field4);
        }

        /// <summary>
        /// A custom segment that always throws during FromDelimitedString, used to exercise the
        /// BestEffort all-fields-fail fallback path.
        /// </summary>
        private sealed class ZtfSegment : ISegment
        {
            public string Id => "ZTF";
            public int Ordinal { get; set; }

            public void FromDelimitedString(string delimitedString) =>
                FromDelimitedString(delimitedString, null);

            public void FromDelimitedString(string delimitedString, Separators separators) =>
                throw new ArgumentException("This segment always fails to parse.", nameof(delimitedString));

            public string ToDelimitedString() => Id;
        }
    }
}
