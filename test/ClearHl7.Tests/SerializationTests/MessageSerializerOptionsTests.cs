using System;
using System.Linq;
using ClearHl7;
using ClearHl7.Serialization;
using ClearHl7.V290;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SerializationTests
{
    public class MessageSerializerOptionsTests
    {
        private const string ValidMshSegment = "MSH|^~\\&|SendApp||RecvApp||20240101120000|||||2.9";

        [Fact]
        public void Deserialize_WithoutOptions_UsesGlobalDefaults()
        {
            ParserConfiguration.ResetToDefaults();
            string delimitedString = $"{ValidMshSegment}{Consts.LineTerminator}PID|1|123{Consts.LineTerminator}";

            var message = MessageSerializer.Deserialize<Message>(delimitedString);

            message.Should().NotBeNull();
            message.Segments.Should().HaveCount(2);
        }

        [Fact]
        public void Deserialize_WithNullOptions_UsesGlobalDefaults()
        {
            ParserConfiguration.ResetToDefaults();
            string delimitedString = $"{ValidMshSegment}{Consts.LineTerminator}PID|1|123{Consts.LineTerminator}";

            var message = MessageSerializer.Deserialize<Message>(delimitedString, null);

            message.Should().NotBeNull();
            message.Segments.Should().HaveCount(2);
        }

        [Fact]
        public void Deserialize_UnknownSegment_ThrowByDefault()
        {
            string delimitedString = $"{ValidMshSegment}{Consts.LineTerminator}ZZZ|unknown{Consts.LineTerminator}";

            Action act = () => MessageSerializer.Deserialize<Message>(delimitedString);

            act.Should().Throw<ArgumentException>()
                .WithMessage("*does not begin with a valid segment ID*ZZZ*");
        }

        [Fact]
        public void Deserialize_UnknownSegment_SkipWhenConfigured()
        {
            var options = new ParserOptions
            {
                UnknownSegmentHandling = UnknownSegmentHandling.Skip,
                CollectWarnings = true
            };
            string delimitedString = $"{ValidMshSegment}{Consts.LineTerminator}PID|1|123{Consts.LineTerminator}ZZZ|unknown{Consts.LineTerminator}";

            var message = MessageSerializer.Deserialize<Message>(delimitedString, options);

            message.Should().NotBeNull();
            message.Segments.Should().HaveCount(2); // MSH + PID, ZZZ skipped
            options.Warnings.Should().HaveCount(1);
            options.Warnings[0].Type.Should().Be(ParserWarningType.UnknownSegment);
            options.Warnings[0].SegmentId.Should().Be("ZZZ");
            options.Warnings[0].Message.Should().Contain("Unknown segment 'ZZZ' skipped");
        }

        [Fact]
        public void Deserialize_UnknownSegment_CreateGenericWhenConfigured()
        {
            var options = new ParserOptions
            {
                UnknownSegmentHandling = UnknownSegmentHandling.CreateGeneric,
                CollectWarnings = true
            };
            string delimitedString = $"{ValidMshSegment}{Consts.LineTerminator}ZZZ|unknown{Consts.LineTerminator}";

            var message = MessageSerializer.Deserialize<Message>(delimitedString, options);

            message.Should().NotBeNull();
            // Currently skips as CreateGeneric is TODO - warning should be generated
            options.Warnings.Should().HaveCount(1);
            options.Warnings[0].Type.Should().Be(ParserWarningType.UnknownSegment);
            options.Warnings[0].Message.Should().Contain("parsed as generic");
        }

        [Fact]
        public void Deserialize_MultipleUnknownSegments_SkipsAll()
        {
            var options = new ParserOptions
            {
                UnknownSegmentHandling = UnknownSegmentHandling.Skip,
                CollectWarnings = true
            };
            string delimitedString = $"{ValidMshSegment}{Consts.LineTerminator}ZZZ|first{Consts.LineTerminator}PID|1|123{Consts.LineTerminator}YYY|second{Consts.LineTerminator}";

            var message = MessageSerializer.Deserialize<Message>(delimitedString, options);

            message.Should().NotBeNull();
            message.Segments.Should().HaveCount(2); // MSH + PID
            options.Warnings.Should().HaveCount(2);
            options.Warnings.Select(w => w.SegmentId).Should().BeEquivalentTo(new[] { "ZZZ", "YYY" });
        }

        [Fact]
        public void Deserialize_MalformedSegment_ThrowByDefault()
        {
            string delimitedString = $"{ValidMshSegment}{Consts.LineTerminator}PI{Consts.LineTerminator}";

            Action act = () => MessageSerializer.Deserialize<Message>(delimitedString);

            act.Should().Throw<ArgumentException>()
                .WithMessage("*incomplete segment string*");
        }

        [Fact]
        public void Deserialize_MalformedSegment_SkipWhenConfigured()
        {
            var options = new ParserOptions
            {
                MalformedSegmentHandling = MalformedSegmentHandling.Skip,
                CollectWarnings = true
            };
            string delimitedString = $"{ValidMshSegment}{Consts.LineTerminator}PI{Consts.LineTerminator}PID|1|123{Consts.LineTerminator}";

            var message = MessageSerializer.Deserialize<Message>(delimitedString, options);

            message.Should().NotBeNull();
            message.Segments.Should().HaveCount(2); // MSH + PID
            options.Warnings.Should().HaveCount(1);
            options.Warnings[0].Type.Should().Be(ParserWarningType.MalformedSegment);
            options.Warnings[0].Message.Should().Contain("Malformed segment skipped");
        }

        [Fact]
        public void Deserialize_MalformedSegment_BestEffortWhenConfigured()
        {
            var options = new ParserOptions
            {
                MalformedSegmentHandling = MalformedSegmentHandling.BestEffort,
                CollectWarnings = true
            };
            string delimitedString = $"{ValidMshSegment}{Consts.LineTerminator}PI{Consts.LineTerminator}";

            var message = MessageSerializer.Deserialize<Message>(delimitedString, options);

            message.Should().NotBeNull();
            options.Warnings.Should().HaveCount(1);
            options.Warnings[0].Type.Should().Be(ParserWarningType.MalformedSegment);
            options.Warnings[0].Message.Should().Contain("best effort");
        }

        [Fact]
        public void Deserialize_MixedValidAndInvalidSegments_HandlesAccordingToOptions()
        {
            var options = new ParserOptions
            {
                UnknownSegmentHandling = UnknownSegmentHandling.Skip,
                MalformedSegmentHandling = MalformedSegmentHandling.Skip,
                CollectWarnings = true
            };
            string delimitedString = $"{ValidMshSegment}{Consts.LineTerminator}PID|1|123{Consts.LineTerminator}ZZ{Consts.LineTerminator}ZZZ|unknown{Consts.LineTerminator}PV1|1{Consts.LineTerminator}";

            var message = MessageSerializer.Deserialize<Message>(delimitedString, options);

            message.Should().NotBeNull();
            message.Segments.Should().HaveCount(3); // MSH + PID + PV1
            options.Warnings.Should().HaveCount(2);
            options.Warnings.Should().Contain(w => w.Type == ParserWarningType.MalformedSegment);
            options.Warnings.Should().Contain(w => w.Type == ParserWarningType.UnknownSegment);
        }

        [Fact]
        public void Deserialize_WithoutCollectWarnings_DoesNotCollectWarnings()
        {
            var options = new ParserOptions
            {
                UnknownSegmentHandling = UnknownSegmentHandling.Skip,
                CollectWarnings = false
            };
            string delimitedString = $"{ValidMshSegment}{Consts.LineTerminator}ZZZ|unknown{Consts.LineTerminator}";

            var message = MessageSerializer.Deserialize<Message>(delimitedString, options);

            message.Should().NotBeNull();
            options.Warnings.Should().BeEmpty();
        }

        [Fact]
        public void Deserialize_WithCollectWarnings_RaisesEvents()
        {
            var options = new ParserOptions
            {
                UnknownSegmentHandling = UnknownSegmentHandling.Skip
            };
            ParserWarning capturedWarning = null;
            options.ParserWarning += (s, e) => capturedWarning = e.Warning;

            string delimitedString = $"{ValidMshSegment}{Consts.LineTerminator}ZZZ|unknown{Consts.LineTerminator}";

            MessageSerializer.Deserialize<Message>(delimitedString, options);

            capturedWarning.Should().NotBeNull();
            capturedWarning.SegmentId.Should().Be("ZZZ");
        }

        [Fact]
        public void Deserialize_WarningsIncludeLineNumbers()
        {
            var options = new ParserOptions
            {
                UnknownSegmentHandling = UnknownSegmentHandling.Skip,
                CollectWarnings = true
            };
            string delimitedString = $"{ValidMshSegment}{Consts.LineTerminator}PID|1|123{Consts.LineTerminator}ZZZ|unknown{Consts.LineTerminator}";

            MessageSerializer.Deserialize<Message>(delimitedString, options);

            options.Warnings[0].LineNumber.Should().Be(2); // ZZZ is at index 2
        }

        [Fact]
        public void Deserialize_WarningsIncludeRawSegment()
        {
            var options = new ParserOptions
            {
                UnknownSegmentHandling = UnknownSegmentHandling.Skip,
                CollectWarnings = true
            };
            string delimitedString = $"{ValidMshSegment}{Consts.LineTerminator}ZZZ|field1|field2{Consts.LineTerminator}";

            MessageSerializer.Deserialize<Message>(delimitedString, options);

            options.Warnings[0].RawSegment.Should().Be("ZZZ|field1|field2");
        }

        [Fact]
        public void DeserializeWithWarnings_ForcesWarningCollection()
        {
            string delimitedString = $"{ValidMshSegment}{Consts.LineTerminator}ZZZ|unknown{Consts.LineTerminator}";
            var options = new ParserOptions
            {
                UnknownSegmentHandling = UnknownSegmentHandling.Skip,
                CollectWarnings = false // Should be overridden
            };

            var result = MessageSerializer.DeserializeWithWarnings<Message>(delimitedString, options);

            result.Message.Should().NotBeNull();
            result.HasWarnings.Should().BeTrue();
            result.Warnings.Should().HaveCount(1);
        }

        [Fact]
        public void DeserializeWithWarnings_WithNullOptions_UsesGlobalDefaults()
        {
            ParserConfiguration.ResetToDefaults();
            ParserConfiguration.DefaultOptions = new ParserOptions
            {
                UnknownSegmentHandling = UnknownSegmentHandling.Skip
            };
            
            string delimitedString = $"{ValidMshSegment}{Consts.LineTerminator}ZZZ|unknown{Consts.LineTerminator}";

            var result = MessageSerializer.DeserializeWithWarnings<Message>(delimitedString, null);

            result.Message.Should().NotBeNull();
            result.HasWarnings.Should().BeTrue();
        }

        [Fact]
        public void DeserializeWithWarnings_WithNoWarnings_HasWarningsIsFalse()
        {
            string delimitedString = $"{ValidMshSegment}{Consts.LineTerminator}PID|1|123{Consts.LineTerminator}";

            var result = MessageSerializer.DeserializeWithWarnings<Message>(delimitedString);

            result.Message.Should().NotBeNull();
            result.HasWarnings.Should().BeFalse();
            result.Warnings.Should().BeEmpty();
        }

        [Fact]
        public void Deserialize_BackwardCompatibility_ExistingCodeStillWorks()
        {
            // This test verifies that existing code without options still works
            string delimitedString = $"{ValidMshSegment}{Consts.LineTerminator}PID|1|123{Consts.LineTerminator}";

            var message = MessageSerializer.Deserialize<Message>(delimitedString);

            message.Should().NotBeNull();
            message.Segments.Should().HaveCount(2);
        }

        [Fact]
        public void Deserialize_OverridesGlobalConfiguration()
        {
            // Set global to be lenient
            ParserConfiguration.DefaultOptions = new ParserOptions
            {
                UnknownSegmentHandling = UnknownSegmentHandling.Skip
            };

            // But use strict options for this specific call
            var strictOptions = new ParserOptions
            {
                UnknownSegmentHandling = UnknownSegmentHandling.Throw
            };

            string delimitedString = $"{ValidMshSegment}{Consts.LineTerminator}ZZZ|unknown{Consts.LineTerminator}";

            Action act = () => MessageSerializer.Deserialize<Message>(delimitedString, strictOptions);

            act.Should().Throw<ArgumentException>();

            // Cleanup
            ParserConfiguration.ResetToDefaults();
        }

        [Fact]
        public void Deserialize_WarningTimestamp_IsSet()
        {
            var options = new ParserOptions
            {
                UnknownSegmentHandling = UnknownSegmentHandling.Skip,
                CollectWarnings = true
            };
            string delimitedString = $"{ValidMshSegment}{Consts.LineTerminator}ZZZ|unknown{Consts.LineTerminator}";

            var before = DateTime.UtcNow;
            MessageSerializer.Deserialize<Message>(delimitedString, options);
            var after = DateTime.UtcNow;

            options.Warnings[0].Timestamp.Should().BeOnOrAfter(before).And.BeOnOrBefore(after);
        }
    }
}
