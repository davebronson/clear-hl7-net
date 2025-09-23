using System;
using ClearHl7;
using ClearHl7.Extensions;
using ClearHl7.V251.Segments;
using ClearHl7.V251.Types;

namespace DateTimePrecisionExample
{
    /// <summary>
    /// Example demonstrating the configurable DateTime precision feature.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DateTime sampleDateTime = new DateTime(2024, 3, 15, 14, 30, 45);
            
            Console.WriteLine("ClearHL7 DateTime Precision Configuration Example");
            Console.WriteLine("================================================");
            Console.WriteLine($"Sample DateTime: {sampleDateTime}");
            Console.WriteLine();

            // Demonstrate different precision levels
            Console.WriteLine("Extension Method Examples:");
            Console.WriteLine($"Year precision:   {sampleDateTime.ToHl7DateTimeString(DateTimePrecision.Year)}");
            Console.WriteLine($"Month precision:  {sampleDateTime.ToHl7DateTimeString(DateTimePrecision.Month)}");
            Console.WriteLine($"Day precision:    {sampleDateTime.ToHl7DateTimeString(DateTimePrecision.Day)}");
            Console.WriteLine($"Hour precision:   {sampleDateTime.ToHl7DateTimeString(DateTimePrecision.Hour)}");
            Console.WriteLine($"Minute precision: {sampleDateTime.ToHl7DateTimeString(DateTimePrecision.Minute)}");
            Console.WriteLine($"Second precision: {sampleDateTime.ToHl7DateTimeString(DateTimePrecision.Second)}");
            Console.WriteLine();

            // Demonstrate configuration usage
            Console.WriteLine("Configuration-based Examples:");
            
            // Save original configuration
            var originalPrecision = Configuration.DateTimePrecision;

            try
            {
                // Test different configurations
                Configuration.DateTimePrecision = DateTimePrecision.Day;
                Console.WriteLine($"Day precision (configured):    {sampleDateTime.ToHl7DateTimeString()}");

                Configuration.DateTimePrecision = DateTimePrecision.Minute;
                Console.WriteLine($"Minute precision (configured): {sampleDateTime.ToHl7DateTimeString()}");

                // Demonstrate MSH segment with different precisions
                Console.WriteLine();
                Console.WriteLine("MSH Segment Examples:");

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

                Configuration.DateTimePrecision = DateTimePrecision.Second;
                var mshSegment = new MshSegment(sampleDateTime, messageType, "MSG001", processingType);
                Console.WriteLine($"Second precision: {mshSegment.ToDelimitedString()}");

                Configuration.DateTimePrecision = DateTimePrecision.Minute;
                Console.WriteLine($"Minute precision: {mshSegment.ToDelimitedString()}");

                Configuration.DateTimePrecision = DateTimePrecision.Day;
                Console.WriteLine($"Day precision:    {mshSegment.ToDelimitedString()}");
            }
            finally
            {
                // Restore original configuration
                Configuration.DateTimePrecision = originalPrecision;
            }

            Console.WriteLine();
            Console.WriteLine("Note: The default precision is Second for backward compatibility.");
        }
    }
}