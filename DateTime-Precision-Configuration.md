# DateTime Precision Configuration

This document describes the configurable DateTime precision feature that allows users to control how DateTime values are formatted in HL7 messages.

## Overview

Previously, all DateTime fields in HL7 messages were formatted with second precision (yyyyMMddHHmmss). With this enhancement, you can now configure the precision level globally to match your specific requirements.

## Configuration

### Setting DateTime Precision

You can configure the DateTime precision using the `Configuration.DateTimePrecision` property:

```csharp
using ClearHl7;

// Set global DateTime precision to minute level
Configuration.DateTimePrecision = DateTimePrecision.Minute;
```

### Available Precision Levels

The `DateTimePrecision` enum provides the following options:

- `DateTimePrecision.Year` - Year only (yyyy) - e.g., "2024"
- `DateTimePrecision.Month` - Year and month (yyyyMM) - e.g., "202403"
- `DateTimePrecision.Day` - Date only (yyyyMMdd) - e.g., "20240315"
- `DateTimePrecision.Hour` - Date and hour (yyyyMMddHH) - e.g., "2024031514"
- `DateTimePrecision.Minute` - Date, hour, and minute (yyyyMMddHHmm) - e.g., "202403151430"
- `DateTimePrecision.Second` - Full precision (yyyyMMddHHmmss) - e.g., "20240315143045" (default)

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

// Using configuration-based precision
Configuration.DateTimePrecision = DateTimePrecision.Hour;
string configuredFormat = sampleDate.ToHl7DateTimeString(); // "2024031514"
```

### With HL7 Segments

```csharp
using ClearHl7;
using ClearHl7.V251.Segments;
using ClearHl7.V251.Types;

// Configure precision globally
Configuration.DateTimePrecision = DateTimePrecision.Minute;

// Create MSH segment - will use minute precision
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

var mshSegment = new MshSegment(
    DateTime.Now, 
    messageType, 
    "MSG001", 
    processingType
);

string hl7Message = mshSegment.ToDelimitedString();
// DateTime will be formatted with minute precision
```

## Backward Compatibility

The default precision is `DateTimePrecision.Second`, which maintains full backward compatibility with existing code. No changes are required to existing applications unless you want to use a different precision level.

## Affected Segments

The DateTime precision configuration affects all segments that contain DateTime fields, including but not limited to:

- MSH (Message Header) - DateTimeOfMessage
- EVN (Event Type) - RecordedDateTime, DateTimePlannedEvent, EventOccurred
- And many other segments containing DateTime fields

## Thread Safety

The `Configuration.DateTimePrecision` property is a static property. In multi-threaded environments, ensure proper synchronization when changing the configuration to avoid race conditions.

## Performance

The extension methods use efficient string formatting and have minimal performance impact compared to the previous implementation.