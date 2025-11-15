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

// NEW: Configure a field to use timezone offset format (yyyyMMddHHmmss±HHMM)
Hl7DateTimeFormatConfig.SetPrecision<MshSegment>(x => x.DateTimeOfMessage, Consts.DateTimeFormatPrecisionSecondWithTimezoneOffset);
// This documents that the field should include timezone offset in HL7 format
```

### Available Precision Formats

You can use any of the predefined format constants:

- `Consts.DateFormatPrecisionYear` - Year only (yyyy) - e.g., "2024"
- `Consts.DateFormatPrecisionMonth` - Year and month (yyyyMM) - e.g., "202403"
- `Consts.DateFormatPrecisionDay` - Date only (yyyyMMdd) - e.g., "20240315"
- `Consts.DateTimeFormatPrecisionHour` - Date and hour (yyyyMMddHH) - e.g., "2024031514"
- `Consts.DateTimeFormatPrecisionMinute` - Date, hour, and minute (yyyyMMddHHmm) - e.g., "202403151430"
- `Consts.DateTimeFormatPrecisionSecond` - Full precision (yyyyMMddHHmmss) - e.g., "20240315143045" (default)
- `Consts.DateTimeFormatPrecisionSecondWithTimezoneOffset` - Full precision with timezone (yyyyMMddHHmmss±HHMM) - e.g., "20240315143045+0530" (documentation constant; use helper methods to format)

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
    
    // Timezone offset configuration (default: TimeSpan.Zero for UTC)
    public static TimeSpan TimezoneOffset { get; set; }
    
    // Type-safe per-field configuration
    public static void SetPrecision<TSegment>(Expression<Func<TSegment, object>> property, string format);
    
    // Get format for a specific field (respects hierarchy) - NEW: with explicit original format
    public static string GetFormatForField(Type segmentType, string propertyName, string originalFormat);
    
    // Get format for a specific field (respects hierarchy) - DEPRECATED: uses fallback
    [Obsolete] public static string GetFormatForField(Type segmentType, string propertyName);
    
    // Timezone offset helper methods
    public static string ToHl7OffsetString(TimeSpan offset);
    public static string FormatDateTimeWithConfiguredOffset(DateTime dt);
    public static string FormatDateTimeWithConfiguredOffset(DateTimeOffset dt);
    public static string FormatDateTimeUsingSourceOffset(DateTime dt);
    public static string FormatDateTimeUsingSourceOffset(DateTimeOffset dt);
    
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

## Timezone Offset Support

### Overview

In addition to precision configuration, `Hl7DateTimeFormatConfig` provides support for formatting datetime values with HL7-compliant timezone offsets. HL7 requires timezone offsets in `±HHMM` format (without colon), but .NET's standard format strings produce `"+HH:mm"` (with colon). The library provides helper methods to ensure compliant output.

### Configuration

The timezone offset configuration is managed through a static property:

```csharp
// Default: UTC (TimeSpan.Zero)
Hl7DateTimeFormatConfig.TimezoneOffset = TimeSpan.Zero;

// Configure to use local system timezone
Hl7DateTimeFormatConfig.TimezoneOffset = DateTimeOffset.Now.Offset;

// Configure to use a specific timezone (e.g., IST +05:30)
Hl7DateTimeFormatConfig.TimezoneOffset = new TimeSpan(5, 30, 0);
```

**Default Behavior**: The `TimezoneOffset` property defaults to `TimeSpan.Zero` (UTC, represented as `+0000`), ensuring deterministic behavior across different machines and CI environments.

### Helper Methods

The library provides three helper methods for working with timezone offsets:

#### 1. ToHl7OffsetString(TimeSpan offset)

Converts a TimeSpan to HL7's `±HHMM` format (without colon).

```csharp
// Positive offset
var offset1 = Hl7DateTimeFormatConfig.ToHl7OffsetString(TimeSpan.FromHours(5));
// Returns: "+0500"

// Negative offset
var offset2 = Hl7DateTimeFormatConfig.ToHl7OffsetString(TimeSpan.FromHours(-5));
// Returns: "-0500"

// Offset with minutes
var offset3 = Hl7DateTimeFormatConfig.ToHl7OffsetString(new TimeSpan(5, 30, 0));
// Returns: "+0530"
```

#### 2. FormatDateTimeWithConfiguredOffset(DateTime/DateTimeOffset dt)

Formats a DateTime or DateTimeOffset using the configured `TimezoneOffset` property. The datetime is converted to the configured timezone before formatting.

```csharp
// With DateTime (treated as UTC)
var dt1 = new DateTime(2024, 3, 15, 14, 30, 45);
Hl7DateTimeFormatConfig.TimezoneOffset = TimeSpan.Zero;
var result1 = Hl7DateTimeFormatConfig.FormatDateTimeWithConfiguredOffset(dt1);
// Returns: "20240315143045+0000" (UTC)

// With DateTimeOffset
var dt2 = new DateTimeOffset(2024, 3, 15, 14, 30, 45, TimeSpan.FromHours(-5));
var result2 = Hl7DateTimeFormatConfig.FormatDateTimeWithConfiguredOffset(dt2);
// Returns: "20240315193045+0000" (converted to UTC from EST)

// Change to a different timezone
Hl7DateTimeFormatConfig.TimezoneOffset = new TimeSpan(5, 30, 0);
result1 = Hl7DateTimeFormatConfig.FormatDateTimeWithConfiguredOffset(dt1);
// Returns: "20240315200045+0530" (converted to IST)
```

#### 3. FormatDateTimeUsingSourceOffset(DateTime/DateTimeOffset dt)

Formats a DateTime or DateTimeOffset using the configured timezone offset. For DateTimeOffset, it preserves the source timezone.

```csharp
// With DateTime (uses configured offset)
var dt1 = new DateTime(2024, 3, 15, 14, 30, 45);
Hl7DateTimeFormatConfig.TimezoneOffset = new TimeSpan(5, 30, 0);
var result1 = Hl7DateTimeFormatConfig.FormatDateTimeUsingSourceOffset(dt1);
// Returns: "20240315143045+0530" (uses configured offset)

// With DateTimeOffset (preserves source offset)
var dt2 = new DateTimeOffset(2024, 3, 15, 14, 30, 45, TimeSpan.FromHours(5));
var result2 = Hl7DateTimeFormatConfig.FormatDateTimeUsingSourceOffset(dt2);
// Returns: "20240315143045+0500" (preserves the +05:00 offset)

var dt3 = new DateTimeOffset(2024, 3, 15, 14, 30, 45, TimeSpan.FromHours(-5));
var result3 = Hl7DateTimeFormatConfig.FormatDateTimeUsingSourceOffset(dt3);
// Returns: "20240315143045-0500" (preserves the -05:00 offset)
```

### Usage Examples

#### Scenario 1: Deterministic UTC Output (Default)

```csharp
// No configuration needed - uses UTC by default
var dt = DateTimeOffset.Now; // Any timezone
var hl7String = Hl7DateTimeFormatConfig.FormatDateTimeWithConfiguredOffset(dt);
// Always produces UTC time with +0000 offset
```

#### Scenario 2: Application-Wide Local Timezone

```csharp
// Set once at application startup
Hl7DateTimeFormatConfig.TimezoneOffset = DateTimeOffset.Now.Offset;

// All subsequent calls use the local timezone
var dt1 = new DateTimeOffset(2024, 3, 15, 14, 30, 45, TimeSpan.Zero);
var hl7String1 = Hl7DateTimeFormatConfig.FormatDateTimeWithConfiguredOffset(dt1);
// Converts from UTC to local timezone

var dt2 = new DateTimeOffset(2024, 6, 20, 10, 15, 30, TimeSpan.FromHours(3));
var hl7String2 = Hl7DateTimeFormatConfig.FormatDateTimeWithConfiguredOffset(dt2);
// Converts from +03:00 to local timezone
```

#### Scenario 3: Preserving Source Timezone Information

```csharp
// When you need to preserve the original timezone information
var dt = new DateTimeOffset(2024, 3, 15, 14, 30, 45, TimeSpan.FromHours(8));
var hl7String = Hl7DateTimeFormatConfig.FormatDateTimeUsingSourceOffset(dt);
// Keeps the +08:00 timezone: "20240315143045+0800"
```

### HL7 Compliance

The library ensures that all timezone offsets are formatted according to HL7 requirements:
- Format: `±HHMM` (without colon)
- Examples:
  - UTC: `+0000`
  - EST: `-0500`
  - IST: `+0530`
  - ACDT: `+1030`
  - PST: `-0800`

### Thread Safety

The `TimezoneOffset` property is thread-safe and uses locks for concurrent access. However, it's recommended to set this configuration once at application startup rather than changing it frequently during runtime.

## Thread Safety

The configuration is stored in static properties. In multi-threaded environments, ensure proper synchronization when changing the configuration to avoid race conditions.

## Performance

The per-field configuration system uses efficient dictionary lookups and has minimal performance impact.