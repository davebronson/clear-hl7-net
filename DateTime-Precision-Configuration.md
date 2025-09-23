# Per-Field DateTime Precision Configuration

This document describes the per-field DateTime precision configuration feature that allows users to control how DateTime values are formatted in HL7 messages with granular control over individual fields.

## Overview

The DateTime precision configuration feature allows you to control how DateTime values are formatted in HL7 messages with granular control over individual fields. You can:

1. Set a global DateTime precision for all fields
2. Override specific fields with type-safe per-field configuration
3. Preserve field-specific precision requirements where certain fields need specific formatting

## Configuration

### Global Override Configuration

You can configure the global DateTime precision override using the `Hl7DateTimeFormatConfig.GlobalDateTimeFormatOverride` property. When set to null (default), all fields use their default precision. When set to a format, all fields use this format unless individually overridden:

```csharp
using ClearHl7;

// Set global DateTime format override to minute precision (affects all fields)
Hl7DateTimeFormatConfig.GlobalDateTimeFormatOverride = Consts.DateTimeFormatPrecisionMinute;

// Clear global override to revert to default field precisions
Hl7DateTimeFormatConfig.GlobalDateTimeFormatOverride = null;
// OR use the convenience method:
Hl7DateTimeFormatConfig.ClearGlobalOverride();
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

// Using per-field configuration approach (NEW - with explicit original precision)
string mshFormat = sampleDate.ToHl7DateTimeString(typeof(MshSegment), "DateTimeOfMessage", Consts.DateTimeFormatPrecisionSecond);

// Legacy approach (DEPRECATED - but still works)
string legacyFormat = sampleDate.ToHl7DateTimeString(typeof(MshSegment), "DateTimeOfMessage");
```

## Configuration Behavior

The configuration system works with a clear hierarchy:

### Configuration Hierarchy (Priority Order)

1. **Individual field override** (highest priority) - Set via `SetPrecision<T>()`
2. **Global override** - Set via `GlobalDateTimeFormatOverride` 
3. **Original code-defined precision** - Explicitly specified in the formatting call
4. **No fallback needed** - All fields should specify their original precision

### Important: New Explicit Approach

**The preferred approach is now to explicitly specify the original precision** in the formatting call:

```csharp
// GOOD: Explicit original precision (recommended)
DateTimeOfMessage.ToHl7DateTimeString(typeof(MshSegment), nameof(DateTimeOfMessage), Consts.DateTimeFormatPrecisionSecond)

// DEPRECATED: Implicit precision lookup (still works but generates warnings)
DateTimeOfMessage.ToHl7DateTimeString(typeof(MshSegment), nameof(DateTimeOfMessage))
```

This approach ensures that:
- Original precisions are clearly visible where they're used
- No separate maintenance of precision lists is required
- Code is self-documenting and maintainable

### Behavior Scenarios

#### Scenario 1: No Global Override Set
**Result**: ALL date/time fields will use their **default precision** as defined by the field type.

```csharp
// No configuration set - uses default precisions
var mshSegment = new MshSegment(DateTime.Now, messageType, "MSG001", processingType);
// MSH.DateTimeOfMessage uses default second precision: "20240315143045"
```

#### Scenario 2: Global Override Set
**Result**: ALL date/time fields will be changed to that precision.

```csharp
// Set global override
Hl7DateTimeFormatConfig.GlobalDateTimeFormatOverride = Consts.DateFormatPrecisionDay;

var mshSegment = new MshSegment(DateTime.Now, messageType, "MSG001", processingType);
// MSH.DateTimeOfMessage now uses day precision: "20240315"
```

#### Scenario 3: No Global Override, Individual Field Override Set
**Result**: ONLY that field will change its precision from the default behavior.

```csharp
// No global override, but individual field override
Hl7DateTimeFormatConfig.SetPrecision<MshSegment>(x => x.DateTimeOfMessage, Consts.DateFormatPrecisionDay);

var mshSegment = new MshSegment(DateTime.Now, messageType, "MSG001", processingType);
var evnSegment = new EvnSegment { RecordedDateTime = DateTime.Now };
// MSH.DateTimeOfMessage uses day precision: "20240315" (overridden)
// EVN.RecordedDateTime uses default second precision: "20240315143045"
```

#### Scenario 4: Global Override + Individual Field Overrides
**Result**: ALL date/time fields use the Global Precision Override, except individual fields that have been overridden.

```csharp
// Both global override and individual field override
Hl7DateTimeFormatConfig.GlobalDateTimeFormatOverride = Consts.DateTimeFormatPrecisionMinute;
Hl7DateTimeFormatConfig.SetPrecision<MshSegment>(x => x.DateTimeOfMessage, Consts.DateFormatPrecisionDay);

var mshSegment = new MshSegment(DateTime.Now, messageType, "MSG001", processingType);
var evnSegment = new EvnSegment { RecordedDateTime = DateTime.Now };
// MSH.DateTimeOfMessage uses individual override (day): "20240315"
// EVN.RecordedDateTime uses global override (minute): "202403151430"
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
    // Global override (null = no global override, uses original precisions)
    public static string GlobalDateTimeFormatOverride { get; set; }
    
    // Type-safe per-field configuration
    public static void SetPrecision<TSegment>(Expression<Func<TSegment, object>> property, string format);
    
    // Get format for a specific field (respects hierarchy) - NEW: with explicit original format
    public static string GetFormatForField(Type segmentType, string propertyName, string originalFormat);
    
    // Get format for a specific field (respects hierarchy) - DEPRECATED: uses fallback
    [Obsolete] public static string GetFormatForField(Type segmentType, string propertyName);
    
    // Clear configurations
    public static void ClearFieldPrecisions();
    public static void ClearGlobalOverride();
    
    // Status properties
    public static int ConfiguredFieldCount { get; }
    public static bool HasGlobalOverride { get; }
}
```

### Extension Methods

```csharp
// Extension methods with explicit precision
public static string ToHl7DateTimeString(this DateTime dateTime, DateTimePrecision precision);
public static string ToHl7DateTimeString(this DateTime? dateTime, DateTimePrecision precision);

// Extension methods using per-field configuration - NEW: with explicit original format
public static string ToHl7DateTimeString(this DateTime dateTime, Type segmentType, string propertyName, string originalFormat);
public static string ToHl7DateTimeString(this DateTime? dateTime, Type segmentType, string propertyName, string originalFormat);

// Extension methods using per-field configuration - DEPRECATED: uses fallback lookup
[Obsolete] public static string ToHl7DateTimeString(this DateTime dateTime, Type segmentType, string propertyName);
[Obsolete] public static string ToHl7DateTimeString(this DateTime? dateTime, Type segmentType, string propertyName);
```

## Migration Guide

### From Old Static Constructor Approach

If you have segments using the old configuration approach:

```csharp
// OLD (generates warnings)
DateTimeOfMessage.ToHl7DateTimeString(typeof(MshSegment), nameof(DateTimeOfMessage))

// NEW (recommended)
DateTimeOfMessage.ToHl7DateTimeString(typeof(MshSegment), nameof(DateTimeOfMessage), Consts.DateTimeFormatPrecisionSecond)
```

### Finding Original Precisions

Look for the original precision in:
1. The old static constructor in `Hl7DateTimeFormatConfig` 
2. Direct `ToString()` calls with `Consts.DateTimeFormatPrecision*` constants
3. Documentation or specifications for the field

## Thread Safety

The configuration is stored in static properties. In multi-threaded environments, ensure proper synchronization when changing the configuration to avoid race conditions.

## Performance

The per-field configuration system uses efficient dictionary lookups and has minimal performance impact.