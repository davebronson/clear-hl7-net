using System;
using ClearHl7;
using ClearHl7.Extensions;
using ClearHl7.V251.Segments;
using ClearHl7.V251.Types;

namespace ClearHl7.Examples
{
    /// <summary>
    /// Example demonstrating the configurable DateTime precision feature with per-field configuration.
    /// </summary>
    public class DateTimePrecisionExample
    {
        /// <summary>
        /// Runs a DateTime precision configuration example.
        /// </summary>
        public static void RunExample()
        {
            DateTime sampleDateTime = new DateTime(2024, 3, 15, 14, 30, 45);
            
            Console.WriteLine("ClearHL7 Per-Field DateTime Precision Configuration Example");
            Console.WriteLine("=========================================================");
            Console.WriteLine($"Sample DateTime: {sampleDateTime}");
            Console.WriteLine();

            // Demonstrate different precision levels using extension methods
            Console.WriteLine("Extension Method Examples:");
            Console.WriteLine($"Year precision:   {sampleDateTime.ToHl7DateTimeString(DateTimePrecision.Year)}");
            Console.WriteLine($"Month precision:  {sampleDateTime.ToHl7DateTimeString(DateTimePrecision.Month)}");
            Console.WriteLine($"Day precision:    {sampleDateTime.ToHl7DateTimeString(DateTimePrecision.Day)}");
            Console.WriteLine($"Hour precision:   {sampleDateTime.ToHl7DateTimeString(DateTimePrecision.Hour)}");
            Console.WriteLine($"Minute precision: {sampleDateTime.ToHl7DateTimeString(DateTimePrecision.Minute)}");
            Console.WriteLine($"Second precision: {sampleDateTime.ToHl7DateTimeString(DateTimePrecision.Second)}");
            Console.WriteLine();

            // Demonstrate global default and per-field configuration
            Console.WriteLine("Per-Field Configuration Examples:");
            
            // Save original default
            var originalGlobalOverride = Hl7DateTimeFormatConfig.GlobalDateTimeFormatOverride;

            try
            {
                // Set global override to minute precision
                Hl7DateTimeFormatConfig.GlobalDateTimeFormatOverride = Consts.DateTimeFormatPrecisionMinute;
                
                // Configure specific fields to use different precision
                Hl7DateTimeFormatConfig.SetPrecision<MshSegment>(x => x.DateTimeOfMessage, Consts.DateFormatPrecisionDay);
                Hl7DateTimeFormatConfig.SetPrecision<EvnSegment>(x => x.RecordedDateTime, Consts.DateTimeFormatPrecisionHour);

                Console.WriteLine($"Global override (minute):     {sampleDateTime.ToHl7DateTimeString(typeof(object), "AnyField", Consts.DateTimeFormatPrecisionSecond, null)}");
                Console.WriteLine($"MSH.DateTimeOfMessage (day): {sampleDateTime.ToHl7DateTimeString(typeof(MshSegment), "DateTimeOfMessage", Consts.DateTimeFormatPrecisionSecond, null)}");
                Console.WriteLine($"EVN.RecordedDateTime (hour): {sampleDateTime.ToHl7DateTimeString(typeof(EvnSegment), "RecordedDateTime", Consts.DateTimeFormatPrecisionSecond, null)}");
                Console.WriteLine();

                // Demonstrate with actual segments
                Console.WriteLine("Segment Examples:");

                var messageType = new MessageType
                {
                    MessageCode = "ADT",
                    TriggerEvent = "A01",
                    MessageStructure = "ADT_A01"
                };

                var processingType = new ProcessingType
                {
                    ProcessingId = "P"
                };

                var mshSegment = new MshSegment(sampleDateTime, messageType, "MSG001", processingType);
                var evnSegment = new EvnSegment
                {
                    EventTypeCode = "A01",
                    RecordedDateTime = sampleDateTime
                };

                Console.WriteLine($"MSH Segment (day precision):  {mshSegment.ToDelimitedString()}");
                Console.WriteLine($"EVN Segment (hour precision): {evnSegment.ToDelimitedString()}");
                Console.WriteLine();

                // Demonstrate type-safe configuration
                Console.WriteLine("Type-Safe Configuration API:");
                Console.WriteLine("// Global override");
                Console.WriteLine("Hl7DateTimeFormatConfig.GlobalDateTimeFormatOverride = Consts.DateTimeFormatPrecisionMinute;");
                Console.WriteLine();
                Console.WriteLine("// Per-field configuration (type-safe)");
                Console.WriteLine("Hl7DateTimeFormatConfig.SetPrecision<MshSegment>(x => x.DateTimeOfMessage, Consts.DateFormatPrecisionDay);");
                Console.WriteLine("Hl7DateTimeFormatConfig.SetPrecision<EvnSegment>(x => x.RecordedDateTime, Consts.DateTimeFormatPrecisionHour);");
            }
            finally
            {
                // Restore original configuration
                Hl7DateTimeFormatConfig.ClearGlobalOverride();
                Hl7DateTimeFormatConfig.ClearFieldPrecisions();
            }

            Console.WriteLine();
            Console.WriteLine("Key Features:");
            Console.WriteLine("- Global default precision setting");
            Console.WriteLine("- Type-safe per-field configuration overrides");
            Console.WriteLine("- Preserves existing field-specific precision requirements");
            Console.WriteLine("- Full backward compatibility");
        }
    }
}