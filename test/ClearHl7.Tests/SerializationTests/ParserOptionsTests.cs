using System;
using System.Linq;
using System.Threading.Tasks;
using ClearHl7;
using ClearHl7.Serialization;
using ClearHl7.V290;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SerializationTests
{
    public class ParserOptionsTests
    {
        [Fact]
        public void DefaultValues_AreStrict()
        {
            var options = new ParserOptions();
            
            options.UnknownSegmentHandling.Should().Be(UnknownSegmentHandling.Throw);
            options.MalformedSegmentHandling.Should().Be(MalformedSegmentHandling.Throw);
            options.CollectWarnings.Should().BeFalse();
        }

        [Fact]
        public void Warnings_InitiallyEmpty()
        {
            var options = new ParserOptions();
            
            options.Warnings.Should().BeEmpty();
        }

        [Fact]
        public void ParserWarning_Event_IsRaisedWhenWarningTriggered()
        {
            var options = new ParserOptions
            {
                UnknownSegmentHandling = UnknownSegmentHandling.Skip
            };
            ParserWarning capturedWarning = null;
            options.ParserWarning += (s, e) => capturedWarning = e.Warning;

            // Trigger warning via parsing
            string delimitedString = $"MSH|^~\\&|SendApp||RecvApp||20240101120000|||||2.9{Consts.LineTerminator}ZZZ|test{Consts.LineTerminator}";
            MessageSerializer.Deserialize<Message>(delimitedString, options);

            capturedWarning.Should().NotBeNull();
            capturedWarning.Type.Should().Be(ParserWarningType.UnknownSegment);
        }

        [Fact]
        public void ClearWarnings_RemovesAllWarnings()
        {
            var options = new ParserOptions 
            { 
                UnknownSegmentHandling = UnknownSegmentHandling.Skip,
                CollectWarnings = true 
            };
            
            // Trigger warnings via parsing
            string delimitedString = $"MSH|^~\\&|SendApp||RecvApp||20240101120000|||||2.9{Consts.LineTerminator}ZZZ|test1{Consts.LineTerminator}YYY|test2{Consts.LineTerminator}";
            MessageSerializer.Deserialize<Message>(delimitedString, options);
            options.Warnings.Should().HaveCount(2);
            
            options.ClearWarnings();
            
            options.Warnings.Should().BeEmpty();
        }

        [Fact]
        public void Clone_CopiesProperties()
        {
            var original = new ParserOptions
            {
                UnknownSegmentHandling = UnknownSegmentHandling.Skip,
                MalformedSegmentHandling = MalformedSegmentHandling.BestEffort,
                CollectWarnings = true
            };

            var clone = original.Clone();

            clone.UnknownSegmentHandling.Should().Be(UnknownSegmentHandling.Skip);
            clone.MalformedSegmentHandling.Should().Be(MalformedSegmentHandling.BestEffort);
            clone.CollectWarnings.Should().BeTrue();
        }

        [Fact]
        public void Clone_DoesNotCopyWarnings()
        {
            var original = new ParserOptions 
            { 
                UnknownSegmentHandling = UnknownSegmentHandling.Skip,
                CollectWarnings = true 
            };
            
            // Trigger warning via parsing
            string delimitedString = $"MSH|^~\\&|SendApp||RecvApp||20240101120000|||||2.9{Consts.LineTerminator}ZZZ|test{Consts.LineTerminator}";
            MessageSerializer.Deserialize<Message>(delimitedString, original);

            var clone = original.Clone();

            clone.Warnings.Should().BeEmpty();
        }

        [Fact]
        public void Clone_DoesNotCopyEventHandlers()
        {
            var original = new ParserOptions
            {
                UnknownSegmentHandling = UnknownSegmentHandling.Skip
            };
            bool eventRaised = false;
            original.ParserWarning += (s, e) => eventRaised = true;

            var clone = original.Clone();
            
            // Trigger warning on clone
            string delimitedString = $"MSH|^~\\&|SendApp||RecvApp||20240101120000|||||2.9{Consts.LineTerminator}ZZZ|test{Consts.LineTerminator}";
            MessageSerializer.Deserialize<Message>(delimitedString, clone);

            eventRaised.Should().BeFalse();
        }

        [Fact]
        public void WarningsCollection_IsThreadSafe()
        {
            var options = new ParserOptions 
            { 
                UnknownSegmentHandling = UnknownSegmentHandling.Skip,
                CollectWarnings = true 
            };
            const int threadCount = 10;

            Parallel.For(0, threadCount, i =>
            {
                string delimitedString = $"MSH|^~\\&|SendApp||RecvApp||20240101120000|||||2.9{Consts.LineTerminator}Z{i:D2}|test{i}{Consts.LineTerminator}";
                MessageSerializer.Deserialize<Message>(delimitedString, options);
            });

            options.Warnings.Count.Should().Be(threadCount);
        }

        [Fact]
        public void Warnings_ReturnsImmutableSnapshot()
        {
            var options = new ParserOptions 
            { 
                UnknownSegmentHandling = UnknownSegmentHandling.Skip,
                CollectWarnings = true 
            };
            
            // Trigger first warning
            string delimitedString1 = $"MSH|^~\\&|SendApp||RecvApp||20240101120000|||||2.9{Consts.LineTerminator}ZZZ|test1{Consts.LineTerminator}";
            MessageSerializer.Deserialize<Message>(delimitedString1, options);
            var snapshot1 = options.Warnings;
            
            // Trigger second warning
            string delimitedString2 = $"MSH|^~\\&|SendApp||RecvApp||20240101120000|||||2.9{Consts.LineTerminator}YYY|test2{Consts.LineTerminator}";
            MessageSerializer.Deserialize<Message>(delimitedString2, options);
            var snapshot2 = options.Warnings;

            snapshot1.Should().HaveCount(1);
            snapshot2.Should().HaveCount(2);
        }
    }
}
