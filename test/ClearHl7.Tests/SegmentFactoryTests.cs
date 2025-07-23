using System;
using System.Linq;
using ClearHl7;
using ClearHl7.Serialization;
using ClearHl7.V281;
using ClearHl7.V281.Types;
using ClearHl7.Extensions;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests
{
    public class SegmentFactoryTests
    {
        public SegmentFactoryTests()
        {
            // Clear registrations before each test
            SegmentFactory.ClearRegistrations();
        }

        [Fact]
        public void RegisterSegment_WithValidSegment_RegistersGlobally()
        {
            // Act
            SegmentFactory.RegisterSegment<TestZdsSegment>("ZDS");

            // Assert
            SegmentFactory.GetGlobalRegistrations().Should().Contain("ZDS");
            
            ISegment segment = SegmentFactory.CreateSegment("ZDS");
            segment.Should().NotBeNull();
            segment.Should().BeOfType<TestZdsSegment>();
            segment.Id.Should().Be("ZDS");
        }

        [Fact]
        public void RegisterSegment_WithVersionSpecific_RegistersForSpecificVersion()
        {
            // Act
            SegmentFactory.RegisterSegment<TestZdsSegment>(Hl7Version.V281, "ZDS");

            // Assert
            SegmentFactory.GetVersionRegistrations().Should().Contain("V281|ZDS");
            
            ISegment segment = SegmentFactory.CreateSegment("ZDS", Hl7Version.V281);
            segment.Should().NotBeNull();
            segment.Should().BeOfType<TestZdsSegment>();
            segment.Id.Should().Be("ZDS");
        }

        [Fact]
        public void RegisterSegment_WithGenericVersionTypeApi_RegistersForAllVersions()
        {
            // Act - This tests the API: RegisterSegment<HL7Version, ZdsSegment>("ZDS")
            SegmentFactory.RegisterSegment<Hl7Version, TestZdsSegment>("ZDS");

            // Assert - Should be registered for all HL7 versions
            var registrations = SegmentFactory.GetVersionRegistrations();
            registrations.Should().Contain("V281|ZDS");
            registrations.Should().Contain("V290|ZDS");
            registrations.Should().Contain("V280|ZDS");
            
            ISegment segment = SegmentFactory.CreateSegment("ZDS", Hl7Version.V281);
            segment.Should().NotBeNull();
            segment.Should().BeOfType<TestZdsSegment>();
            segment.Id.Should().Be("ZDS");
        }

        [Fact]
        public void RegisterSegment_WithNullSegmentId_ThrowsArgumentException()
        {
            // Act & Assert
            Action act = () => SegmentFactory.RegisterSegment<TestZdsSegment>(null);
            act.Should().Throw<ArgumentException>()
                .WithMessage("Segment ID cannot be null or empty.*");
        }

        [Fact]
        public void RegisterSegment_WithEmptySegmentId_ThrowsArgumentException()
        {
            // Act & Assert
            Action act = () => SegmentFactory.RegisterSegment<TestZdsSegment>("");
            act.Should().Throw<ArgumentException>()
                .WithMessage("Segment ID cannot be null or empty.*");
        }

        [Fact]
        public void RegisterSegment_WithInvalidSegmentIdLength_ThrowsArgumentException()
        {
            // Act & Assert
            Action act = () => SegmentFactory.RegisterSegment<TestZdsSegment>("ZDSS");
            act.Should().Throw<ArgumentException>()
                .WithMessage("Segment ID must be exactly 3 characters.*");
        }

        [Fact]
        public void RegisterSegment_WithMismatchedSegmentId_ThrowsArgumentException()
        {
            // Act & Assert
            Action act = () => SegmentFactory.RegisterSegment<TestZdsSegment>("ABC");
            act.Should().Throw<ArgumentException>()
                .WithMessage("Segment type TestZdsSegment returns Id 'ZDS' but was registered with ID 'ABC'.*");
        }

        [Fact]
        public void CreateSegment_WithUnregisteredSegment_ReturnsNull()
        {
            // Act
            ISegment segment = SegmentFactory.CreateSegment("XYZ");

            // Assert
            segment.Should().BeNull();
        }

        [Fact]
        public void CreateSegment_WithInvalidSegmentId_ReturnsNull()
        {
            // Act & Assert
            SegmentFactory.CreateSegment(null).Should().BeNull();
            SegmentFactory.CreateSegment("").Should().BeNull();
            SegmentFactory.CreateSegment("AB").Should().BeNull();
            SegmentFactory.CreateSegment("ABCD").Should().BeNull();
        }

        [Fact]
        public void CreateSegment_VersionSpecificTakesPrecedenceOverGlobal()
        {
            // Arrange
            SegmentFactory.RegisterSegment<TestZdsSegment>("ZDS");
            SegmentFactory.RegisterSegment<TestZdsV2Segment>(Hl7Version.V281, "ZDS");

            // Act
            ISegment globalSegment = SegmentFactory.CreateSegment("ZDS");
            ISegment versionSegment = SegmentFactory.CreateSegment("ZDS", Hl7Version.V281);

            // Assert
            globalSegment.Should().BeOfType<TestZdsSegment>();
            versionSegment.Should().BeOfType<TestZdsV2Segment>();
        }

        [Fact]
        public void CreateSegment_CaseInsensitive()
        {
            // Arrange
            SegmentFactory.RegisterSegment<TestZdsSegment>("ZDS");

            // Act & Assert
            SegmentFactory.CreateSegment("zds").Should().NotBeNull();
            SegmentFactory.CreateSegment("Zds").Should().NotBeNull();
            SegmentFactory.CreateSegment("ZDS").Should().NotBeNull();
        }

        [Fact]
        public void ClearRegistrations_RemovesAllRegistrations()
        {
            // Arrange
            SegmentFactory.RegisterSegment<TestZdsSegment>("ZDS");
            SegmentFactory.RegisterSegment<TestAbcSegment>(Hl7Version.V281, "ABC");

            // Act
            SegmentFactory.ClearRegistrations();

            // Assert
            SegmentFactory.GetGlobalRegistrations().Should().BeEmpty();
            SegmentFactory.GetVersionRegistrations().Should().BeEmpty();
            SegmentFactory.CreateSegment("ZDS").Should().BeNull();
            SegmentFactory.CreateSegment("ABC", Hl7Version.V281).Should().BeNull();
        }

        [Fact]
        public void Integration_CustomSegmentInMessageParsing()
        {
            // Arrange
            SegmentFactory.RegisterSegment<TestZdsSegment>("ZDS");
            
            string hl7Message = "MSH|^~\\&|SYSTEM|SENDER|RECEIVER|DESTINATION|20240101120000||ADT^A01|MSG001|P|2.8.1||||\r" +
                               "ZDS|CUSTOM|DATA|HERE|\r";

            // Act
            var message = MessageSerializer.Deserialize<Message>(hl7Message);

            // Assert
            message.Should().NotBeNull();
            message.Segments.Should().HaveCount(2);
            
            var zdsSegment = message.Segments.Should().ContainSingle(s => s.Id == "ZDS").Subject;
            zdsSegment.Should().BeOfType<TestZdsSegment>();
            
            var testZds = (TestZdsSegment)zdsSegment;
            testZds.CustomData.Should().Be("|CUSTOM|DATA|HERE|");
        }

        [Fact]
        public void MessageExtensions_GetSegments_ReturnsCorrectSegments()
        {
            // Arrange
            SegmentFactory.RegisterSegment<TestZdsSegment>("ZDS");
            SegmentFactory.RegisterSegment<TestAbcSegment>("ABC");

            string hl7Message = 
                "MSH|^~\\&|SYSTEM|SENDER|RECEIVER|DEST|20240101120000||ADT^A01|MSG001|P|2.8.1||||\r" +
                "ZDS|FIELD1|FIELD2|FIELD3|\r" +
                "ABC|TEST|DATA|\r" +
                "ZDS|FIELD4|FIELD5|FIELD6|\r";

            var message = MessageSerializer.Deserialize<Message>(hl7Message);

            // Act & Assert
            var zdsSegments = message.GetSegments("ZDS").ToArray();
            zdsSegments.Should().HaveCount(2);
            zdsSegments.All(s => s.Id == "ZDS").Should().BeTrue();

            var abcSegments = message.GetSegments("ABC").ToArray();
            abcSegments.Should().HaveCount(1);
            abcSegments.First().Id.Should().Be("ABC");

            var firstZds = message.GetSegment("ZDS") as TestZdsSegment;
            firstZds.Should().NotBeNull();
            firstZds.CustomData.Should().Be("|FIELD1|FIELD2|FIELD3|");
        }

        [Fact]
        public void MessageExtensions_GetCustomSegments_ReturnsCustomSegmentsOnly()
        {
            // Arrange
            SegmentFactory.RegisterSegment<TestZdsSegment>("ZDS");

            string hl7Message = 
                "MSH|^~\\&|SYSTEM|SENDER|RECEIVER|DEST|20240101120000||ADT^A01|MSG001|P|2.8.1||||\r" +
                "ZDS|FIELD1|FIELD2|FIELD3|\r";

            var message = MessageSerializer.Deserialize<Message>(hl7Message);

            // Act
            var customSegments = message.GetCustomSegments("ZDS").ToArray();
            var customSegment = message.GetCustomSegment("ZDS");

            // Assert
            customSegments.Should().HaveCount(1);
            customSegments.First().Should().BeOfType<TestZdsSegment>();
            
            customSegment.Should().NotBeNull();
            customSegment.Should().BeOfType<TestZdsSegment>();
        }

        [Fact]
        public void MessageExtensions_GetTypedSegments_ReturnsCorrectTypes()
        {
            // Arrange
            SegmentFactory.RegisterSegment<TestZdsSegment>("ZDS");

            string hl7Message = 
                "MSH|^~\\&|SYSTEM|SENDER|RECEIVER|DEST|20240101120000||ADT^A01|MSG001|P|2.8.1||||\r" +
                "ZDS|FIELD1|FIELD2|FIELD3|\r" +
                "ZDS|FIELD4|FIELD5|FIELD6|\r";

            var message = MessageSerializer.Deserialize<Message>(hl7Message);

            // Act
            var typedSegments = message.GetSegments<TestZdsSegment>("ZDS").ToArray();
            var typedSegment = message.GetSegment<TestZdsSegment>("ZDS");

            // Assert
            typedSegments.Should().HaveCount(2);
            typedSegments.All(s => s is TestZdsSegment).Should().BeTrue();
            
            typedSegment.Should().NotBeNull();
            typedSegment.Should().BeOfType<TestZdsSegment>();
            typedSegment.CustomData.Should().Be("|FIELD1|FIELD2|FIELD3|");
        }

        [Fact]
        public void MessageExtensions_WithNullMessage_ThrowsArgumentNullException()
        {
            // Arrange
            IMessage message = null;

            // Act & Assert
            Action act1 = () => message.GetSegments("ZDS");
            Action act2 = () => message.GetCustomSegments("ZDS");
            Action act3 = () => message.GetSegment("ZDS");
            Action act4 = () => message.GetCustomSegment("ZDS");
            Action act5 = () => message.GetAllSegments();

            act1.Should().Throw<ArgumentNullException>();
            act2.Should().Throw<ArgumentNullException>();
            act3.Should().Throw<ArgumentNullException>();
            act4.Should().Throw<ArgumentNullException>();
            act5.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void MessageExtensions_WithInvalidSegmentId_ThrowsArgumentException()
        {
            // Arrange
            var message = new Message();

            // Act & Assert
            Action act1 = () => message.GetSegments(null);
            Action act2 = () => message.GetSegments("");
            Action act3 = () => message.GetSegments("XX");
            Action act4 = () => message.GetSegments("TOOLONG");

            act1.Should().Throw<ArgumentException>().WithMessage("Segment ID cannot be null or empty.*");
            act2.Should().Throw<ArgumentException>().WithMessage("Segment ID cannot be null or empty.*");
            act3.Should().Throw<ArgumentException>().WithMessage("Segment ID must be exactly 3 characters.*");
            act4.Should().Throw<ArgumentException>().WithMessage("Segment ID must be exactly 3 characters.*");
        }

        [Fact]
        public void ComplexCustomSegment_WithAdvancedDataTypes_ParsesCorrectly()
        {
            // Arrange
            SegmentFactory.RegisterSegment<ComplexTestSegment>("ZCX");

            string hl7Message = 
                "MSH|^~\\&|SYSTEM|SENDER|RECEIVER|DEST|20240101120000||ADT^A01|MSG001|P|2.8.1||||\r" +
                "ZCX|REC001|SRC^Data Source^L|555-1234^WPN^PH~john@email.com^^^EMAIL|20240101120000|This is a comment with special chars\r";

            // Act
            var message = MessageSerializer.Deserialize<Message>(hl7Message);
            var complexSegment = message.GetSegment<ComplexTestSegment>("ZCX");

            // Assert
            complexSegment.Should().NotBeNull();
            complexSegment.RecordId.Should().Be("REC001");
            complexSegment.DataSource.Should().NotBeNull();
            complexSegment.DataSource.Identifier.Should().Be("SRC");
            complexSegment.DataSource.Text.Should().Be("Data Source");
            complexSegment.ContactInfo.Should().HaveCount(2);
            complexSegment.ContactInfo[0].TelephoneNumber.Should().Be("555-1234");
            complexSegment.ContactInfo[1].TelephoneNumber.Should().Be("john@email.com");
            complexSegment.LastUpdated.Should().Be(new DateTime(2024, 1, 1, 12, 0, 0));
            complexSegment.Comments.Should().Be("This is a comment with special chars");
        }

        [Fact]
        public void MultipleCustomSegments_InSingleMessage_AllParsedCorrectly()
        {
            // Arrange
            SegmentFactory.RegisterSegment<TestZdsSegment>("ZDS");
            SegmentFactory.RegisterSegment<TestAbcSegment>("ABC");

            string hl7Message = 
                "MSH|^~\\&|SYSTEM|SENDER|RECEIVER|DEST|20240101120000||ADT^A01|MSG001|P|2.8.1||||\r" +
                "ZDS|FIELD1|FIELD2|FIELD3|\r" +
                "ABC|TEST|DATA|\r" +
                "ZDS|FIELD4|FIELD5|FIELD6|\r" +
                "ABC|TEST2|DATA2|\r";

            // Act
            var message = MessageSerializer.Deserialize<Message>(hl7Message);

            // Assert
            message.Segments.Should().HaveCount(5); // MSH + 2 ZDS + 2 ABC
            
            var zdsSegments = message.GetSegments<TestZdsSegment>("ZDS").ToArray();
            zdsSegments.Should().HaveCount(2);
            zdsSegments[0].CustomData.Should().Be("|FIELD1|FIELD2|FIELD3|");
            zdsSegments[1].CustomData.Should().Be("|FIELD4|FIELD5|FIELD6|");

            var abcSegments = message.GetSegments<TestAbcSegment>("ABC").ToArray();
            abcSegments.Should().HaveCount(2);
        }
    }

    /// <summary>
    /// Complex test segment for advanced data type testing.
    /// </summary>
    public class ComplexTestSegment : ISegment
    {
        public string Id => "ZCX";
        public int Ordinal { get; set; }
        
        public string RecordId { get; set; }
        public CodedWithExceptions DataSource { get; set; }
        public ExtendedTelecommunicationNumber[] ContactInfo { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string Comments { get; set; }

        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            var seps = separators ?? new Separators();
            var fields = delimitedString?.Split(seps.FieldSeparator, StringSplitOptions.None);
            
            if (fields == null || fields.Length == 0) return;

            if (fields.Length > 1) RecordId = fields[1];
            
            if (fields.Length > 2 && !string.IsNullOrEmpty(fields[2]))
            {
                DataSource = new CodedWithExceptions();
                DataSource.FromDelimitedString(fields[2], seps);
            }

            if (fields.Length > 3 && !string.IsNullOrEmpty(fields[3]))
            {
                var contactElements = fields[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None);
                ContactInfo = new ExtendedTelecommunicationNumber[contactElements.Length];
                for (int i = 0; i < contactElements.Length; i++)
                {
                    ContactInfo[i] = new ExtendedTelecommunicationNumber();
                    ContactInfo[i].FromDelimitedString(contactElements[i], seps);
                }
            }

            if (fields.Length > 4 && !string.IsNullOrEmpty(fields[4]))
            {
                if (DateTime.TryParseExact(fields[4], "yyyyMMddHHmmss", null, 
                    System.Globalization.DateTimeStyles.None, out DateTime timestamp))
                {
                    LastUpdated = timestamp;
                }
            }

            if (fields.Length > 5 && !string.IsNullOrEmpty(fields[5]))
            {
                Comments = Helpers.StringHelper.Unescape(fields[5]);
            }
        }

        public string ToDelimitedString()
        {
            var seps = new Separators();
            var fields = new string[6];
            
            fields[0] = Id;
            fields[1] = RecordId;
            fields[2] = DataSource?.ToDelimitedString();
            
            if (ContactInfo?.Length > 0)
            {
                fields[3] = string.Join(seps.FieldRepeatSeparator.ToString(), 
                    ContactInfo.Select(ci => ci?.ToDelimitedString() ?? string.Empty));
            }
            
            fields[4] = LastUpdated?.ToString("yyyyMMddHHmmss");
            fields[5] = !string.IsNullOrEmpty(Comments) ? Helpers.StringHelper.Escape(Comments) : null;

            return string.Join(seps.FieldSeparator.ToString(), fields);
        }
    }

    /// <summary>
    /// Test segment for unit testing purposes.
    /// </summary>
    public class TestZdsSegment : ISegment
    {
        public string Id => "ZDS";
        public int Ordinal { get; set; }
        public string CustomData { get; private set; } = string.Empty;

        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            if (string.IsNullOrEmpty(delimitedString))
                throw new ArgumentException("Delimited string cannot be null or empty.");

            if (!delimitedString.StartsWith("ZDS"))
                throw new ArgumentException("Delimited string does not begin with ZDS segment.");

            // Store the part after the segment ID for testing
            if (delimitedString.Length > 3)
                CustomData = delimitedString.Substring(3);
        }

        public string ToDelimitedString()
        {
            return $"ZDS{CustomData}";
        }
    }

    /// <summary>
    /// Alternative test segment for version-specific testing.
    /// </summary>
    public class TestZdsV2Segment : ISegment
    {
        public string Id => "ZDS";
        public int Ordinal { get; set; }

        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            // Minimal implementation for testing
        }

        public string ToDelimitedString()
        {
            return "ZDS|V2|";
        }
    }

    /// <summary>
    /// Test segment with ABC ID for testing.
    /// </summary>
    public class TestAbcSegment : ISegment
    {
        public string Id => "ABC";
        public int Ordinal { get; set; }

        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            // Minimal implementation for testing
        }

        public string ToDelimitedString()
        {
            return "ABC||";
        }
    }
}