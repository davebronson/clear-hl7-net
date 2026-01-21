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
    public class ParserConfigurationTests
    {
        // Reset to defaults before and after each test to avoid test interference
        public ParserConfigurationTests()
        {
            ParserConfiguration.ResetToDefaults();
        }

        [Fact]
        public void DefaultOptions_InitiallyStrict()
        {
            var defaults = ParserConfiguration.DefaultOptions;
            
            defaults.UnknownSegmentHandling.Should().Be(UnknownSegmentHandling.Throw);
            defaults.MalformedSegmentHandling.Should().Be(MalformedSegmentHandling.Throw);
            defaults.CollectWarnings.Should().BeFalse();
        }

        [Fact]
        public void DefaultOptions_ReturnsDefensiveCopy()
        {
            var options1 = ParserConfiguration.DefaultOptions;
            options1.UnknownSegmentHandling = UnknownSegmentHandling.Skip;

            var options2 = ParserConfiguration.DefaultOptions;

            options2.UnknownSegmentHandling.Should().Be(UnknownSegmentHandling.Throw);
        }

        [Fact]
        public void DefaultOptions_Set_StoresDefensiveCopy()
        {
            var options = new ParserOptions
            {
                UnknownSegmentHandling = UnknownSegmentHandling.Skip
            };

            ParserConfiguration.DefaultOptions = options;
            
            // Modify original
            options.MalformedSegmentHandling = MalformedSegmentHandling.BestEffort;

            // Verify stored copy wasn't affected
            var retrieved = ParserConfiguration.DefaultOptions;
            retrieved.MalformedSegmentHandling.Should().Be(MalformedSegmentHandling.Throw);
        }

        [Fact]
        public void DefaultOptions_SetToNull_CreatesNewDefaults()
        {
            ParserConfiguration.DefaultOptions = new ParserOptions
            {
                UnknownSegmentHandling = UnknownSegmentHandling.Skip
            };

            ParserConfiguration.DefaultOptions = null;

            var defaults = ParserConfiguration.DefaultOptions;
            defaults.UnknownSegmentHandling.Should().Be(UnknownSegmentHandling.Throw);
        }

        [Fact]
        public void GlobalWarnings_InitiallyEmpty()
        {
            ParserConfiguration.GlobalWarnings.Should().BeEmpty();
        }

        [Fact]
        public void ClearGlobalWarnings_RemovesAllWarnings()
        {
            // Enable global collection
            ParserConfiguration.DefaultOptions = new ParserOptions { CollectWarnings = true };
            
            // Trigger warnings via parsing
            var options = new ParserOptions 
            { 
                UnknownSegmentHandling = UnknownSegmentHandling.Skip,
                CollectWarnings = true 
            };
            string delimitedString = $"MSH|^~\\&|SendApp||RecvApp||20240101120000|||||2.9{Consts.LineTerminator}ZZZ|test1{Consts.LineTerminator}YYY|test2{Consts.LineTerminator}";
            MessageSerializer.Deserialize<Message>(delimitedString, options);

            ParserConfiguration.ClearGlobalWarnings();

            ParserConfiguration.GlobalWarnings.Should().BeEmpty();
        }

        [Fact]
        public void ResetToDefaults_RestoresStrictBehavior()
        {
            ParserConfiguration.DefaultOptions = new ParserOptions
            {
                UnknownSegmentHandling = UnknownSegmentHandling.Skip,
                MalformedSegmentHandling = MalformedSegmentHandling.BestEffort,
                CollectWarnings = true
            };

            ParserConfiguration.ResetToDefaults();

            var defaults = ParserConfiguration.DefaultOptions;
            defaults.UnknownSegmentHandling.Should().Be(UnknownSegmentHandling.Throw);
            defaults.MalformedSegmentHandling.Should().Be(MalformedSegmentHandling.Throw);
            defaults.CollectWarnings.Should().BeFalse();
        }

        [Fact]
        public void ResetToDefaults_ClearsGlobalWarnings()
        {
            ParserConfiguration.DefaultOptions = new ParserOptions { CollectWarnings = true };
            
            // Trigger warning via parsing
            var options = new ParserOptions 
            { 
                UnknownSegmentHandling = UnknownSegmentHandling.Skip,
                CollectWarnings = true 
            };
            string delimitedString = $"MSH|^~\\&|SendApp||RecvApp||20240101120000|||||2.9{Consts.LineTerminator}ZZZ|test{Consts.LineTerminator}";
            MessageSerializer.Deserialize<Message>(delimitedString, options);

            ParserConfiguration.ResetToDefaults();

            ParserConfiguration.GlobalWarnings.Should().BeEmpty();
        }

        [Fact]
        public void AddGlobalWarning_WhenCollectWarningsTrue_AddsToGlobalCollection()
        {
            ParserConfiguration.DefaultOptions = new ParserOptions { CollectWarnings = true };
            
            // Trigger warning via parsing
            var options = new ParserOptions 
            { 
                UnknownSegmentHandling = UnknownSegmentHandling.Skip,
                CollectWarnings = true 
            };
            string delimitedString = $"MSH|^~\\&|SendApp||RecvApp||20240101120000|||||2.9{Consts.LineTerminator}ZZZ|test{Consts.LineTerminator}";
            MessageSerializer.Deserialize<Message>(delimitedString, options);

            ParserConfiguration.GlobalWarnings.Should().HaveCount(1);
        }

        [Fact]
        public void AddGlobalWarning_WhenCollectWarningsFalse_DoesNotAddToGlobalCollection()
        {
            ParserConfiguration.DefaultOptions = new ParserOptions { CollectWarnings = false };
            
            // Trigger warning via parsing
            var options = new ParserOptions 
            { 
                UnknownSegmentHandling = UnknownSegmentHandling.Skip,
                CollectWarnings = false 
            };
            string delimitedString = $"MSH|^~\\&|SendApp||RecvApp||20240101120000|||||2.9{Consts.LineTerminator}ZZZ|test{Consts.LineTerminator}";
            MessageSerializer.Deserialize<Message>(delimitedString, options);

            ParserConfiguration.GlobalWarnings.Should().BeEmpty();
        }

        [Fact]
        public void GlobalParserWarning_Event_IsRaisedWhenWarningAdded()
        {
            ParserConfiguration.ResetToDefaults();
            ParserWarning capturedWarning = null;
            EventHandler<ParserWarningEventArgs> handler = (s, e) => capturedWarning = e.Warning;
            ParserConfiguration.ParserWarning += handler;

            try
            {
                // Trigger warning via parsing
                var options = new ParserOptions 
                { 
                    UnknownSegmentHandling = UnknownSegmentHandling.Skip
                };
                string delimitedString = $"MSH|^~\\&|SendApp||RecvApp||20240101120000|||||2.9{Consts.LineTerminator}ZZZ|test{Consts.LineTerminator}";
                MessageSerializer.Deserialize<Message>(delimitedString, options);

                capturedWarning.Should().NotBeNull();
                capturedWarning.SegmentId.Should().Be("ZZZ");
            }
            finally
            {
                ParserConfiguration.ParserWarning -= handler;
            }
        }

        [Fact]
        public void DefaultOptions_AccessIsThreadSafe()
        {
            const int threadCount = 10;
            var results = new ParserOptions[threadCount];

            Parallel.For(0, threadCount, i =>
            {
                if (i % 2 == 0)
                {
                    // Half the threads write
                    ParserConfiguration.DefaultOptions = new ParserOptions
                    {
                        UnknownSegmentHandling = UnknownSegmentHandling.Skip
                    };
                }
                else
                {
                    // Half the threads read
                    results[i] = ParserConfiguration.DefaultOptions;
                }
            });

            // All operations should complete without exception
            results.Where(r => r != null).Should().AllSatisfy(r =>
            {
                r.Should().NotBeNull();
            });
        }

        [Fact]
        public void GlobalWarnings_ReturnsImmutableSnapshot()
        {
            ParserConfiguration.ResetToDefaults();
            ParserConfiguration.DefaultOptions = new ParserOptions { CollectWarnings = true };
            
            // Trigger first warning
            var options1 = new ParserOptions 
            { 
                UnknownSegmentHandling = UnknownSegmentHandling.Skip,
                CollectWarnings = true 
            };
            string delimitedString1 = $"MSH|^~\\&|SendApp||RecvApp||20240101120000|||||2.9{Consts.LineTerminator}ZZZ|test1{Consts.LineTerminator}";
            MessageSerializer.Deserialize<Message>(delimitedString1, options1);
            var snapshot1 = ParserConfiguration.GlobalWarnings;
            
            // Trigger second warning
            string delimitedString2 = $"MSH|^~\\&|SendApp||RecvApp||20240101120000|||||2.9{Consts.LineTerminator}YYY|test2{Consts.LineTerminator}";
            MessageSerializer.Deserialize<Message>(delimitedString2, options1);
            var snapshot2 = ParserConfiguration.GlobalWarnings;

            snapshot1.Should().HaveCount(1);
            snapshot2.Should().HaveCount(2);
        }
    }
}
