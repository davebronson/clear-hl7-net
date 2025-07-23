using System;
using System.Linq;
using ClearHl7;
using ClearHl7.Serialization;
using ClearHl7.V281;
using ClearHl7.V281.Types;
using ClearHl7.Extensions;

namespace ClearHl7.Examples
{
    /// <summary>
    /// Advanced custom segment implementation demonstrating proper field parsing and typed properties.
    /// This example shows a custom ZDS (Z-segment for Data Storage) segment with complex HL7 data types.
    /// </summary>
    public class ZdsSegment : ISegment
    {
        public string Id => "ZDS";
        public int Ordinal { get; set; }

        /// <summary>
        /// ZDS.1 - Record ID (string field).
        /// </summary>
        public string RecordId { get; set; }

        /// <summary>
        /// ZDS.2 - Data Source (coded with exceptions - supports complex HL7 data type).
        /// </summary>
        public CodedWithExceptions DataSource { get; set; }

        /// <summary>
        /// ZDS.3 - Processing Status (coded with exceptions).
        /// </summary>
        public CodedWithExceptions ProcessingStatus { get; set; }

        /// <summary>
        /// ZDS.4 - Contact Information (extended telecommunications - supports repetition).
        /// This field demonstrates repetition support for complex data types.
        /// </summary>
        public ExtendedTelecommunicationNumber[] ContactInfo { get; set; }

        /// <summary>
        /// ZDS.5 - Data Categories (repeating coded elements).
        /// This shows how to handle repeating simple coded values.
        /// </summary>
        public CodedWithExceptions[] DataCategories { get; set; }

        /// <summary>
        /// ZDS.6 - Last Updated Timestamp (timestamp field).
        /// </summary>
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// ZDS.7 - Comments (text field - can contain escaped HL7 special characters).
        /// </summary>
        public string Comments { get; set; }

        public void FromDelimitedString(string delimitedString) 
        { 
            FromDelimitedString(delimitedString, null);
        }

        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            var seps = separators ?? new Separators();
            var fields = delimitedString?.Split(seps.FieldSeparator, StringSplitOptions.None);
            
            if (fields == null || fields.Length == 0)
                return;

            // Skip field 0 (segment ID "ZDS")
            
            // ZDS.1 - Record ID
            if (fields.Length > 1 && !string.IsNullOrEmpty(fields[1]))
            {
                RecordId = fields[1];
            }

            // ZDS.2 - Data Source (CodedWithExceptions)
            if (fields.Length > 2 && !string.IsNullOrEmpty(fields[2]))
            {
                DataSource = new CodedWithExceptions();
                DataSource.FromDelimitedString(fields[2], seps);
            }

            // ZDS.3 - Processing Status (CodedWithExceptions)
            if (fields.Length > 3 && !string.IsNullOrEmpty(fields[3]))
            {
                ProcessingStatus = new CodedWithExceptions();
                ProcessingStatus.FromDelimitedString(fields[3], seps);
            }

            // ZDS.4 - Contact Information (repeating ExtendedTelecommunicationNumber)
            if (fields.Length > 4 && !string.IsNullOrEmpty(fields[4]))
            {
                var contactElements = fields[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None);
                ContactInfo = new ExtendedTelecommunicationNumber[contactElements.Length];
                for (int i = 0; i < contactElements.Length; i++)
                {
                    ContactInfo[i] = new ExtendedTelecommunicationNumber();
                    ContactInfo[i].FromDelimitedString(contactElements[i], seps);
                }
            }

            // ZDS.5 - Data Categories (repeating CodedWithExceptions)
            if (fields.Length > 5 && !string.IsNullOrEmpty(fields[5]))
            {
                var categoryElements = fields[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None);
                DataCategories = new CodedWithExceptions[categoryElements.Length];
                for (int i = 0; i < categoryElements.Length; i++)
                {
                    DataCategories[i] = new CodedWithExceptions();
                    DataCategories[i].FromDelimitedString(categoryElements[i], seps);
                }
            }

            // ZDS.6 - Last Updated Timestamp
            if (fields.Length > 6 && !string.IsNullOrEmpty(fields[6]))
            {
                if (DateTime.TryParseExact(fields[6], "yyyyMMddHHmmss", null, System.Globalization.DateTimeStyles.None, out DateTime timestamp))
                {
                    LastUpdated = timestamp;
                }
            }

            // ZDS.7 - Comments (text with potential escape sequences)
            if (fields.Length > 7 && !string.IsNullOrEmpty(fields[7]))
            {
                Comments = Helpers.StringHelper.Unescape(fields[7]);
            }
        }

        public string ToDelimitedString()
        {
            var seps = new Separators();
            var fields = new string[8]; // ZDS has 7 fields (index 0 is segment ID)
            
            fields[0] = Id;
            fields[1] = RecordId;
            fields[2] = DataSource?.ToDelimitedString();
            fields[3] = ProcessingStatus?.ToDelimitedString();
            
            // Handle repeating contact info
            if (ContactInfo?.Length > 0)
            {
                fields[4] = string.Join(seps.FieldRepeatSeparator.ToString(), 
                    ContactInfo.Select(ci => ci?.ToDelimitedString() ?? string.Empty));
            }
            
            // Handle repeating data categories
            if (DataCategories?.Length > 0)
            {
                fields[5] = string.Join(seps.FieldRepeatSeparator.ToString(), 
                    DataCategories.Select(dc => dc?.ToDelimitedString() ?? string.Empty));
            }
            
            // Handle timestamp
            fields[6] = LastUpdated?.ToString("yyyyMMddHHmmss");
            
            // Handle comments with escaping
            fields[7] = !string.IsNullOrEmpty(Comments) ? Helpers.StringHelper.Escape(Comments) : null;

            return string.Join(seps.FieldSeparator.ToString(), fields);
        }
    }

    /// <summary>
    /// Simple custom segment implementation for demonstration.
    /// This shows a basic implementation without complex data types.
    /// </summary>
    public class ZpdSegment : ISegment
    {
        public string Id => "ZPD";
        public int Ordinal { get; set; }

        /// <summary>
        /// ZPD.1 - Patient Preference Code.
        /// </summary>
        public string PreferenceCode { get; set; }

        /// <summary>
        /// ZPD.2 - Preference Value.
        /// </summary>
        public string PreferenceValue { get; set; }

        /// <summary>
        /// ZPD.3 - Effective Date.
        /// </summary>
        public DateTime? EffectiveDate { get; set; }

        public void FromDelimitedString(string delimitedString) 
        { 
            FromDelimitedString(delimitedString, null);
        }

        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            var seps = separators ?? new Separators();
            var fields = delimitedString?.Split(seps.FieldSeparator, StringSplitOptions.None);
            
            if (fields == null || fields.Length == 0)
                return;

            // ZPD.1 - Preference Code
            if (fields.Length > 1)
                PreferenceCode = fields[1];

            // ZPD.2 - Preference Value  
            if (fields.Length > 2)
                PreferenceValue = fields[2];

            // ZPD.3 - Effective Date
            if (fields.Length > 3 && !string.IsNullOrEmpty(fields[3]))
            {
                if (DateTime.TryParseExact(fields[3], "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out DateTime date))
                {
                    EffectiveDate = date;
                }
            }
        }

        public string ToDelimitedString()
        {
            var seps = new Separators();
            return $"{Id}{seps.FieldSeparator}{PreferenceCode}{seps.FieldSeparator}{PreferenceValue}{seps.FieldSeparator}{EffectiveDate?.ToString("yyyyMMdd")}";
        }
    }

    /// <summary>
    /// Comprehensive example demonstrating the SegmentFactory usage and advanced custom segment features.
    /// </summary>
    public class SegmentFactoryExample
    {
        public static void RunExample()
        {
            Console.WriteLine("SegmentFactory Custom Segment Registration Example");
            Console.WriteLine("=================================================");

            // Register custom segments once at app startup or before parsing
            Console.WriteLine("1. Registering custom segments...");
            SegmentFactory.RegisterSegment<ZdsSegment>("ZDS");   // registers in all versions of hl7
            SegmentFactory.RegisterSegment<ZpdSegment>("ZPD");   // registers simple segment globally
            SegmentFactory.RegisterSegment<Hl7Version, ZdsSegment>("ZDS");   // registers in specific version of hl7

            Console.WriteLine("   ✓ Registered ZdsSegment globally and for specific HL7 versions");
            Console.WriteLine("   ✓ Registered ZpdSegment globally");

            // Test creating segments directly
            Console.WriteLine("\n2. Testing direct segment creation...");
            var zdsSegment = SegmentFactory.CreateSegment("ZDS");
            var zpdSegment = SegmentFactory.CreateSegment("ZPD");
            Console.WriteLine($"   ✓ Created ZDS segment: {zdsSegment?.Id} (Type: {zdsSegment?.GetType().Name})");
            Console.WriteLine($"   ✓ Created ZPD segment: {zpdSegment?.Id} (Type: {zpdSegment?.GetType().Name})");

            // Test comprehensive message parsing with multiple custom segments
            Console.WriteLine("\n3. Testing message parsing with complex custom segments...");
            string complexHl7Message = 
                "MSH|^~\\&|SYSTEM|SENDER|RECEIVER|DESTINATION|20240101120000||ADT^A01|MSG001|P|2.8.1||||\r" +
                "PID|1||12345^^^^MR||Doe^John^J||19800101|M||2106-3|123 Main St^^Anytown^ST^12345^USA||(555)123-4567^PRN^PH|\r" +
                "ZDS|REC001|SRC^Data Source^L|PROC^Processing^L|555-1234^WPN^PH~john@email.com^^^EMAIL|CAT1^Category1^L~CAT2^Category2^L|20240101120000|This is a comment with special chars: Test \\T\\ Data\r" +
                "ZPD|PREF001|Vegetarian|20240101\r" +
                "ZDS|REC002|SRC2^Another Source^L|COMP^Completed^L|||20240101130000|Second ZDS segment\r";

            var message = MessageSerializer.Deserialize<Message>(complexHl7Message);
            
            Console.WriteLine($"   ✓ Parsed message with {message.Segments.Count()} segments");

            // Test the new extension methods for accessing segments
            Console.WriteLine("\n4. Testing segment access via new extension methods...");
            
            // Access specific segments by ID
            var mshSegment = message.GetSegment("MSH");
            var pidSegment = message.GetSegment("PID");
            Console.WriteLine($"   ✓ Found MSH segment: {mshSegment?.Id}");
            Console.WriteLine($"   ✓ Found PID segment: {pidSegment?.Id}");

            // Access custom segments - multiple ZDS segments
            var zdsSegments = message.GetCustomSegments("ZDS").ToList();
            Console.WriteLine($"   ✓ Found {zdsSegments.Count} ZDS custom segments");
            
            foreach (var zds in zdsSegments.Cast<ZdsSegment>())
            {
                Console.WriteLine($"     - ZDS Record ID: {zds.RecordId}");
                Console.WriteLine($"     - Data Source: {zds.DataSource?.Identifier}");
                Console.WriteLine($"     - Processing Status: {zds.ProcessingStatus?.Identifier}");
                Console.WriteLine($"     - Last Updated: {zds.LastUpdated}");
                Console.WriteLine($"     - Comments: {zds.Comments}");
                if (zds.DataCategories?.Length > 0)
                {
                    Console.WriteLine($"     - Data Categories: {string.Join(", ", zds.DataCategories.Select(dc => dc.Identifier))}");
                }
                Console.WriteLine();
            }

            // Access single custom segment - ZPD
            var zpdCustomSegment = message.GetCustomSegment("ZPD") as ZpdSegment;
            if (zpdCustomSegment != null)
            {
                Console.WriteLine($"   ✓ Found ZPD custom segment:");
                Console.WriteLine($"     - Preference Code: {zpdCustomSegment.PreferenceCode}");
                Console.WriteLine($"     - Preference Value: {zpdCustomSegment.PreferenceValue}");
                Console.WriteLine($"     - Effective Date: {zpdCustomSegment.EffectiveDate?.ToString("yyyy-MM-dd")}");
            }

            // Test typed access to custom segments
            Console.WriteLine("\n5. Testing typed segment access...");
            var typedZdsSegments = message.GetSegments<ZdsSegment>("ZDS").ToList();
            var typedZpdSegment = message.GetSegment<ZpdSegment>("ZPD");
            
            Console.WriteLine($"   ✓ Found {typedZdsSegments.Count} ZDS segments via typed access");
            Console.WriteLine($"   ✓ Found ZPD segment via typed access: {typedZpdSegment?.PreferenceCode}");

            // Test serialization back to HL7 string
            Console.WriteLine("\n6. Testing serialization back to HL7...");
            string serializedMessage = message.ToDelimitedString();
            Console.WriteLine("   ✓ Successfully serialized message back to HL7 format");
            Console.WriteLine($"   ✓ Total message length: {serializedMessage.Length} characters");
            
            // Verify custom segments are preserved in serialization
            var lines = serializedMessage.Split('\r');
            var zdsLines = lines.Where(l => l.StartsWith("ZDS")).ToList();
            var zpdLines = lines.Where(l => l.StartsWith("ZPD")).ToList();
            Console.WriteLine($"   ✓ Serialized message contains {zdsLines.Count} ZDS segments and {zpdLines.Count} ZPD segments");

            Console.WriteLine("\n7. Example completed successfully!");
            Console.WriteLine("   Custom segments are now fully integrated with the HL7 message processing pipeline.");
            Console.WriteLine("   Both simple and complex custom segments with typed properties are supported.");
        }
    }
}