# Per-Field DateTime Precision Configuration

This document describes the per-field DateTime precision configuration feature that allows users to control how DateTime values are formatted in HL7 messages with granular control over individual fields.

## Overview

Previously, all DateTime fields in HL7 messages were hardcoded to use specific precision formatting. With this enhancement, you can now:

1. Set a global default DateTime precision for all fields
2. Override specific fields with type-safe per-field configuration
3. Preserve existing field-specific precision requirements (e.g., some fields that were intentionally using day precision vs. second precision)

## Configuration

### Global Default Configuration

You can configure the global default DateTime precision using the `Hl7DateTimeFormatConfig.DefaultDateTimeFormat` property:

```csharp
using ClearHl7;

// Set global default DateTime format to minute precision
Hl7DateTimeFormatConfig.DefaultDateTimeFormat = Consts.DateTimeFormatPrecisionMinute;
```

### Per-Field Configuration (Type-Safe)

You can configure specific fields using type-safe expressions:

```csharp
// Configure MSH.DateTimeOfMessage to use day precision
Hl7DateTimeFormatConfig.SetPrecision<MshSegment>(x => x.DateTimeOfMessage, Consts.DateFormatPrecisionDay);

// Configure EVN.RecordedDateTime to use hour precision
Hl7DateTimeFormatConfig.SetPrecision<EvnSegment>(x => x.RecordedDateTime, Consts.DateTimeFormatPrecisionHour);
```

### Available Precision Formats

You can use any of the predefined format constants:

- `Consts.DateFormatPrecisionYear` - Year only (yyyy) - e.g., "2024"
- `Consts.DateFormatPrecisionMonth` - Year and month (yyyyMM) - e.g., "202403"
- `Consts.DateFormatPrecisionDay` - Date only (yyyyMMdd) - e.g., "20240315"
- `Consts.DateTimeFormatPrecisionHour` - Date and hour (yyyyMMddHH) - e.g., "2024031514"
- `Consts.DateTimeFormatPrecisionMinute` - Date, hour, and minute (yyyyMMddHHmm) - e.g., "202403151430"
- `Consts.DateTimeFormatPrecisionSecond` - Full precision (yyyyMMddHHmmss) - e.g., "20240315143045" (default)

## Usage Examples

### Basic Usage

```csharp
using System;
using ClearHl7;
using ClearHl7.Extensions;

DateTime sampleDate = new DateTime(2024, 3, 15, 14, 30, 45);

// Using extension methods with explicit precision
string yearFormat = sampleDate.ToHl7DateTimeString(DateTimePrecision.Year);     // "2024"
string dayFormat = sampleDate.ToHl7DateTimeString(DateTimePrecision.Day);       // "20240315"
string minuteFormat = sampleDate.ToHl7DateTimeString(DateTimePrecision.Minute); // "202403151430"

// Using per-field configuration approach
string mshFormat = sampleDate.ToHl7DateTimeString(typeof(MshSegment), "DateTimeOfMessage");
```

### Global Configuration with Per-Field Overrides

```csharp
using ClearHl7;
using ClearHl7.V251.Segments;
using ClearHl7.V251.Types;

// Set global default to minute precision
Hl7DateTimeFormatConfig.DefaultDateTimeFormat = Consts.DateTimeFormatPrecisionMinute;

// Override specific fields
Hl7DateTimeFormatConfig.SetPrecision<MshSegment>(x => x.DateTimeOfMessage, Consts.DateFormatPrecisionDay);
Hl7DateTimeFormatConfig.SetPrecision<EvnSegment>(x => x.RecordedDateTime, Consts.DateTimeFormatPrecisionHour);

// Create segments - they will automatically use the configured precision
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

var mshSegment = new MshSegment(DateTime.Now, messageType, "MSG001", processingType);
// MSH.DateTimeOfMessage will use day precision

var evnSegment = new EvnSegment
{
    EventTypeCode = "A01",
    RecordedDateTime = DateTime.Now
};
// EVN.RecordedDateTime will use hour precision
```

## Key Benefits

1. **Backward Compatibility**: Default behavior is preserved (second precision)
2. **Global Configuration**: Set a default precision that applies to all fields
3. **Per-Field Overrides**: Type-safe configuration for specific fields
4. **Preservation of Intent**: Fields that were intentionally using different precisions remain unaffected
5. **Flexibility**: Can change configuration at runtime as needed

## API Reference

### Hl7DateTimeFormatConfig Class

```csharp
public static class Hl7DateTimeFormatConfig
{
    // Global default format
    public static string DefaultDateTimeFormat { get; set; }
    
    // Type-safe per-field configuration
    public static void SetPrecision<TSegment>(Expression<Func<TSegment, object>> property, string format);
    
    // Get format for a specific field
    public static string GetFormatForField(Type segmentType, string propertyName);
    
    // Clear all field-specific configurations
    public static void ClearFieldPrecisions();
    
    // Get count of configured field-specific precisions
    public static int ConfiguredFieldCount { get; }
}
```

### Extension Methods

```csharp
// Extension methods with explicit precision
public static string ToHl7DateTimeString(this DateTime dateTime, DateTimePrecision precision);
public static string ToHl7DateTimeString(this DateTime? dateTime, DateTimePrecision precision);

// Extension methods using per-field configuration
public static string ToHl7DateTimeString(this DateTime dateTime, Type segmentType, string propertyName);
public static string ToHl7DateTimeString(this DateTime? dateTime, Type segmentType, string propertyName);
```

## Migration from Previous Approach

If you were using the previous global `Configuration.DateTimePrecision` approach, you can migrate by:

1. Setting the global default: `Hl7DateTimeFormatConfig.DefaultDateTimeFormat = desiredFormat`
2. Converting specific field configurations to use the type-safe `SetPrecision` method

## Thread Safety

The configuration is stored in static properties. In multi-threaded environments, ensure proper synchronization when changing the configuration to avoid race conditions.

## Performance

The per-field configuration system uses efficient dictionary lookups and has minimal performance impact compared to the previous implementation.