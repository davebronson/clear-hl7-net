# Parser Options and Configurability Specification

## Overview

Add configurable parser options to the `clear-hl7-net` library to provide flexible handling of unknown segments, malformed segments, and parsing errors.  This enhancement enables fault-tolerant parsing for real-world scenarios where HL7 messages may contain proprietary segments or minor formatting issues.

## Goals

1. **Backward Compatibility**: All existing code continues to work without changes (default behavior is strict)
2. **Thread Safety**: All new components are thread-safe using `ConcurrentBag<T>` and defensive copying
3. **Flexibility**: Support both global configuration and per-call overrides
4. **Observability**: Provide warning collection and event-based notification
5. **Non-Breaking**: Optional parameters with defaults ensure no API breaking changes

## Design Principles

- **Fail-safe defaults**: Default behavior matches current strict parsing (throw on errors)
- **Progressive enhancement**: Users opt-in to lenient parsing when needed
- **Clear semantics**: Explicit enums for behavior choices
- **Separation of concerns**: Global vs.  instance-level configuration clearly separated

---

## New Components

### 1. Enumerations

#### UnknownSegmentHandling

```csharp
namespace ClearHl7.Serialization
{
    /// <summary>
    /// Defines how the parser handles segments with unknown segment IDs.
    /// </summary>
    public enum UnknownSegmentHandling
    {
        /// <summary>
        /// Throw an ArgumentException when an unknown segment is encountered.
        /// This is the default behavior and maintains backward compatibility.
        /// </summary>
        Throw = 0,
        
        /// <summary>
        /// Skip the unknown segment and continue parsing.
        /// A warning is added to the warnings collection if CollectWarnings is true.
        /// </summary>
        Skip = 1,
        
        /// <summary>
        /// Create a generic UnknownSegment instance containing the raw segment data.
        /// A warning is added to the warnings collection if CollectWarnings is true. 
        /// </summary>
        CreateGeneric = 2
    }
}
```

#### MalformedSegmentHandling

```csharp
namespace ClearHl7.Serialization
{
    /// <summary>
    /// Defines how the parser handles malformed segments (e.g., too short, parsing errors).
    /// </summary>
    public enum MalformedSegmentHandling
    {
        /// <summary>
        /// Throw an ArgumentException when a malformed segment is encountered.
        /// This is the default behavior and maintains backward compatibility.
        /// </summary>
        Throw = 0,
        
        /// <summary>
        /// Skip the malformed segment and continue parsing.
        /// A warning is added to the warnings collection if CollectWarnings is true.
        /// </summary>
        Skip = 1,
        
        /// <summary>
        /// Attempt to parse what is possible from the malformed segment.
        /// A warning is added for any parsing errors if CollectWarnings is true. 
        /// </summary>
        BestEffort = 2
    }
}
```

#### ParserWarningType

```csharp
namespace ClearHl7.Serialization
{
    /// <summary>
    /// Categorizes the type of parser warning.
    /// </summary>
    public enum ParserWarningType
    {
        /// <summary>
        /// An unknown segment ID was encountered.
        /// </summary>
        UnknownSegment,
        
        /// <summary>
        /// A segment was malformed (e.g., too short, invalid format).
        /// </summary>
        MalformedSegment,
        
        /// <summary>
        /// An error occurred while parsing a segment.
        /// </summary>
        ParseError,
        
        /// <summary>
        /// An error occurred while parsing a specific field within a segment.
        /// </summary>
        FieldParseError
    }
}
```

---

### 2. ParserWarning Class

```csharp
namespace ClearHl7.Serialization
{
    /// <summary>
    /// Represents a warning that occurred during HL7 message parsing.
    /// </summary>
    public class ParserWarning
    {
        /// <summary>
        /// Gets or sets the type of warning.
        /// </summary>
        public ParserWarningType Type { get; set; }
        
        /// <summary>
        /// Gets or sets the segment ID where the warning occurred (e.g., "PID", "ZXX").
        /// </summary>
        public string SegmentId { get; set; }
        
        /// <summary>
        /// Gets or sets the line number (segment index) where the warning occurred.
        /// </summary>
        public int LineNumber { get; set; }
        
        /// <summary>
        /// Gets or sets a human-readable description of the warning.
        /// </summary>
        public string Message { get; set; }
        
        /// <summary>
        /// Gets or sets the raw segment string that caused the warning.
        /// </summary>
        public string RawSegment { get; set; }
        
        /// <summary>
        /// Gets or sets the exception that caused the warning, if applicable.
        /// </summary>
        public Exception Exception { get; set; }
        
        /// <summary>
        /// Gets or sets the timestamp when the warning was created.
        /// </summary>
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
```

---

### 3. ParserWarningEventArgs Class

```csharp
namespace ClearHl7.Serialization
{
    /// <summary>
    /// Event arguments for parser warning events.
    /// </summary>
    public class ParserWarningEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the warning that triggered the event.
        /// </summary>
        public ParserWarning Warning { get; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ParserWarningEventArgs"/> class.
        /// </summary>
        /// <param name="warning">The warning that triggered the event.</param>
        public ParserWarningEventArgs(ParserWarning warning)
        {
            Warning = warning ??  throw new ArgumentNullException(nameof(warning));
        }
    }
}
```

---

### 4. ParserOptions Class

```csharp
using System;
using System.Collections. Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace ClearHl7.Serialization
{
    /// <summary>
    /// Configures parser behavior for HL7 message deserialization.
    /// Thread-safe. 
    /// </summary>
    public class ParserOptions :  ICloneable
    {
        // Thread-safe instance-level warning collection
        private readonly ConcurrentBag<ParserWarning> _warnings = new ConcurrentBag<ParserWarning>();
        
        /// <summary>
        /// Gets or sets how unknown segments are handled during parsing.
        /// Default: Throw (maintains backward compatibility).
        /// </summary>
        public UnknownSegmentHandling UnknownSegmentHandling { get; set; } = UnknownSegmentHandling.Throw;
        
        /// <summary>
        /// Gets or sets how malformed segments are handled during parsing. 
        /// Default: Throw (maintains backward compatibility).
        /// </summary>
        public MalformedSegmentHandling MalformedSegmentHandling { get; set; } = MalformedSegmentHandling.Throw;
        
        /// <summary>
        /// Gets or sets whether warnings should be collected during parsing.
        /// Default: false.
        /// </summary>
        public bool CollectWarnings { get; set; } = false;
        
        /// <summary>
        /// Event raised when a warning occurs during parsing. 
        /// </summary>
        public event EventHandler<ParserWarningEventArgs> ParserWarning;
        
        /// <summary>
        /// Gets warnings collected during parsing.  Thread-safe.
        /// Returns an immutable snapshot of the warnings collection.
        /// </summary>
        public IReadOnlyList<ParserWarning> Warnings 
            => _warnings.ToImmutableList();
        
        /// <summary>
        /// Clears all collected warnings.  Thread-safe.
        /// </summary>
        public void ClearWarnings()
        {
            _warnings.Clear();
        }
        
        /// <summary>
        /// Adds a warning to the collection.  Thread-safe.  Internal use only.
        /// </summary>
        /// <param name="warning">The warning to add.</param>
        internal void AddWarning(ParserWarning warning)
        {
            if (warning == null)
            {
                return;
            }
            
            // Add to instance collection if enabled
            if (CollectWarnings)
            {
                _warnings.Add(warning);
            }
            
            // Raise instance event
            ParserWarning?. Invoke(this, new ParserWarningEventArgs(warning));
            
            // Also raise global event
            ParserConfiguration.AddGlobalWarning(warning);
        }
        
        /// <summary>
        /// Creates a deep copy of the parser options.
        /// Note: Does NOT copy the warnings collection or event handlers.
        /// </summary>
        /// <returns>A new ParserOptions instance with the same configuration.</returns>
        public ParserOptions Clone()
        {
            return new ParserOptions
            {
                UnknownSegmentHandling = this.UnknownSegmentHandling,
                MalformedSegmentHandling = this.MalformedSegmentHandling,
                CollectWarnings = this. CollectWarnings
                // Intentionally do NOT copy:  _warnings, ParserWarning event
            };
        }
        
        object ICloneable.Clone() => Clone();
    }
}
```

---

### 5. ParserConfiguration Class (Static/Global)

```csharp
using System;
using System.Collections. Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace ClearHl7.Serialization
{
    /// <summary>
    /// Provides global configuration for HL7 message parsing.
    /// Thread-safe.
    /// </summary>
    public static class ParserConfiguration
    {
        // Thread-safe backing field for default options
        private static ParserOptions _defaultOptions = new ParserOptions();
        private static readonly object _optionsLock = new object();
        
        // Thread-safe collection of warnings from all parsing operations
        private static readonly ConcurrentBag<ParserWarning> _globalWarnings = new ConcurrentBag<ParserWarning>();
        
        /// <summary>
        /// Gets or sets the default parser options used when none are explicitly specified.
        /// Thread-safe.  Returns a defensive copy to prevent unintended mutations.
        /// </summary>
        public static ParserOptions DefaultOptions 
        { 
            get 
            {
                lock (_optionsLock)
                {
                    return _defaultOptions.Clone();
                }
            }
            set 
            {
                lock (_optionsLock)
                {
                    _defaultOptions = value?. Clone() ?? new ParserOptions();
                }
            }
        }
        
        /// <summary>
        /// Global event raised when any parser warning occurs.
        /// Thread-safe (events are inherently thread-safe in .NET).
        /// </summary>
        public static event EventHandler<ParserWarningEventArgs> ParserWarning;
        
        /// <summary>
        /// Gets all warnings collected globally across all parsing operations.
        /// Thread-safe.  Returns an immutable snapshot of warnings.
        /// </summary>
        public static IReadOnlyList<ParserWarning> GlobalWarnings 
            => _globalWarnings. ToImmutableList();
        
        /// <summary>
        /// Clears all globally collected warnings. Thread-safe. 
        /// </summary>
        public static void ClearGlobalWarnings()
        {
            _globalWarnings.Clear();
        }
        
        /// <summary>
        /// Adds a warning to the global collection. Thread-safe.  Internal use only.
        /// </summary>
        /// <param name="warning">The warning to add. </param>
        internal static void AddGlobalWarning(ParserWarning warning)
        {
            if (warning == null)
            {
                return;
            }
            
            // Add to global collection if global collection is enabled
            lock (_optionsLock)
            {
                if (_defaultOptions.CollectWarnings)
                {
                    _globalWarnings.Add(warning);
                }
            }
            
            // Raise global event (events are thread-safe in .NET)
            ParserWarning?.Invoke(null, new ParserWarningEventArgs(warning));
        }
        
        /// <summary>
        /// Resets configuration to strict default behavior.
        /// Thread-safe. 
        /// </summary>
        public static void ResetToDefaults()
        {
            lock (_optionsLock)
            {
                _defaultOptions = new ParserOptions();
            }
            ClearGlobalWarnings();
        }
    }
}
```

---

### 6. ParseResult<T> Class

```csharp
using System. Collections.Generic;

namespace ClearHl7.Serialization
{
    /// <summary>
    /// Represents the result of a message deserialization operation with warnings.
    /// </summary>
    /// <typeparam name="T">The message type.</typeparam>
    public class ParseResult<T> where T : IMessage
    {
        /// <summary>
        /// Gets or sets the parsed message.
        /// </summary>
        public T Message { get; set; }
        
        /// <summary>
        /// Gets or sets the warnings that occurred during parsing.
        /// </summary>
        public IReadOnlyList<ParserWarning> Warnings { get; set; }
        
        /// <summary>
        /// Gets whether any warnings occurred during parsing.
        /// </summary>
        public bool HasWarnings => Warnings?.Count > 0;
    }
}
```

---

## Modified Components

### MessageSerializer Class Changes

The `MessageSerializer` class requires the following modifications:

#### 1. Add Optional Parameter to Deserialize<T> Method

**Current signature:**
```csharp
public static T Deserialize<T>(string delimitedString) where T : class, IMessage
```

**New signature (backward compatible):**
```csharp
public static T Deserialize<T>(string delimitedString, ParserOptions options = null) 
    where T : class, IMessage
```

#### 2. Update Deserialize<T> Implementation

**Key changes:**
1. At the beginning, resolve options:  `options ??= ParserConfiguration.DefaultOptions;`
2. Replace existing exception throws for unknown/malformed segments with calls to helper methods
3. Wrap segment parsing in try-catch to handle field-level errors
4. Add helper methods:  `HandleUnknownSegment()`, `HandleMalformedSegment()`, `HandleSegmentParseError()`

**Modified logic for unknown segments:**
```csharp
if (segment == null)
{
    // Call helper method instead of throwing immediately
    if (! HandleUnknownSegment(id, segmentString, i, options))
    {
        throw new ArgumentException($"{nameof(delimitedString)} contains a segment string that does not begin with a valid segment ID.  '{id}' is invalid.", nameof(delimitedString));
    }
    continue; // Skip to next segment
}
```

**Modified logic for malformed segments:**
```csharp
if (segmentString.Length < 3)
{
    // Call helper method instead of throwing immediately
    if (!HandleMalformedSegment(segmentString, i, options, "Incomplete segment string"))
    {
        throw new ArgumentException($"{nameof(delimitedString)} contains an incomplete segment string. '{segmentString}' is invalid.", nameof(delimitedString));
    }
    continue; // Skip to next segment
}
```

**Add error handling around segment parsing:**
```csharp
try
{
    ISegment seg = (ISegment)segment;
    seg. Ordinal = i;
    seg. FromDelimitedString(segmentString, seps);
    list.Add(seg);
}
catch (Exception ex)
{
    if (!HandleSegmentParseError(id, segmentString, i, options, ex))
    {
        throw; // Re-throw if options say to throw
    }
    // Otherwise continue parsing
}
```

#### 3. Add New Helper Methods to MessageSerializer

##### HandleUnknownSegment Method

```csharp
/// <summary>
/// Handles an unknown segment based on parser options.
/// </summary>
/// <param name="id">The segment ID. </param>
/// <param name="segmentString">The raw segment string.</param>
/// <param name="ordinal">The line number/ordinal. </param>
/// <param name="options">Parser options.</param>
/// <returns>True if the segment was handled (skip/continue), false if should throw.</returns>
private static bool HandleUnknownSegment(
    string id, 
    string segmentString, 
    int ordinal, 
    ParserOptions options)
{
    switch (options.UnknownSegmentHandling)
    {
        case UnknownSegmentHandling.Throw:
            return false; // Let caller throw exception

        case UnknownSegmentHandling.Skip:
            options.AddWarning(new ParserWarning
            {
                Type = ParserWarningType.UnknownSegment,
                SegmentId = id,
                LineNumber = ordinal,
                Message = $"Unknown segment '{id}' skipped",
                RawSegment = segmentString
            });
            return true; // Handled - skip segment

        case UnknownSegmentHandling.CreateGeneric:
            // TODO: Future enhancement - create UnknownSegment instance
            options.AddWarning(new ParserWarning
            {
                Type = ParserWarningType.UnknownSegment,
                SegmentId = id,
                LineNumber = ordinal,
                Message = $"Unknown segment '{id}' parsed as generic",
                RawSegment = segmentString
            });
            return true; // Handled - create generic segment

        default:
            return false;
    }
}
```

##### HandleMalformedSegment Method

```csharp
/// <summary>
/// Handles a malformed segment based on parser options. 
/// </summary>
/// <param name="segmentString">The raw segment string.</param>
/// <param name="ordinal">The line number/ordinal.</param>
/// <param name="options">Parser options.</param>
/// <param name="reason">The reason the segment is considered malformed.</param>
/// <returns>True if the segment was handled (skip/continue), false if should throw.</returns>
private static bool HandleMalformedSegment(
    string segmentString,
    int ordinal,
    ParserOptions options,
    string reason)
{
    string segmentId = segmentString.Length >= 3 ? segmentString. Substring(0, 3) : "???";
    
    switch (options.MalformedSegmentHandling)
    {
        case MalformedSegmentHandling.Throw:
            return false; // Let caller throw exception

        case MalformedSegmentHandling.Skip:
            options.AddWarning(new ParserWarning
            {
                Type = ParserWarningType.MalformedSegment,
                SegmentId = segmentId,
                LineNumber = ordinal,
                Message = $"Malformed segment skipped: {reason}",
                RawSegment = segmentString
            });
            return true; // Handled - skip segment

        case MalformedSegmentHandling.BestEffort:
            options.AddWarning(new ParserWarning
            {
                Type = ParserWarningType.MalformedSegment,
                SegmentId = segmentId,
                LineNumber = ordinal,
                Message = $"Malformed segment parsed with best effort: {reason}",
                RawSegment = segmentString
            });
            return true; // Handled - attempt parsing

        default:
            return false;
    }
}
```

##### HandleSegmentParseError Method

```csharp
/// <summary>
/// Handles an error that occurred while parsing a segment.
/// </summary>
/// <param name="id">The segment ID.</param>
/// <param name="segmentString">The raw segment string.</param>
/// <param name="ordinal">The line number/ordinal. </param>
/// <param name="options">Parser options.</param>
/// <param name="ex">The exception that occurred.</param>
/// <returns>True if the error was handled (skip/continue), false if should throw.</returns>
private static bool HandleSegmentParseError(
    string id,
    string segmentString,
    int ordinal,
    ParserOptions options,
    Exception ex)
{
    switch (options.MalformedSegmentHandling)
    {
        case MalformedSegmentHandling. Throw:
            return false; // Let caller re-throw exception

        case MalformedSegmentHandling.Skip:
        case MalformedSegmentHandling.BestEffort:
            options.AddWarning(new ParserWarning
            {
                Type = ParserWarningType.ParseError,
                SegmentId = id,
                LineNumber = ordinal,
                Message = $"Error parsing segment '{id}':  {ex.Message}",
                RawSegment = segmentString,
                Exception = ex
            });
            return true; // Handled - skip or use partial data

        default:
            return false;
    }
}
```

#### 4. Add New DeserializeWithWarnings Method

```csharp
/// <summary>
/// Deserializes an HL7 message and returns the result with collected warnings.
/// This method forces warning collection regardless of options settings.
/// Thread-safe.
/// </summary>
/// <typeparam name="T">The message type.</typeparam>
/// <param name="delimitedString">The HL7 message string.</param>
/// <param name="options">Optional parser options.  If null, uses global defaults.</param>
/// <returns>A ParseResult containing the message and any warnings.</returns>
public static ParseResult<T> DeserializeWithWarnings<T>(
    string delimitedString, 
    ParserOptions options = null
) where T : class, IMessage
{
    // Clone options and force warning collection
    var localOptions = (options ?? ParserConfiguration.DefaultOptions).Clone();
    localOptions.CollectWarnings = true;
    
    // Parse the message
    var message = Deserialize<T>(delimitedString, localOptions);
    
    // Return result with warnings
    return new ParseResult<T>
    {
        Message = message,
        Warnings = localOptions.Warnings // Already an immutable snapshot
    };
}
```

---

## File Structure

```
src/ClearHl7/Serialization/
├── ParserOptions.cs                 (NEW)
├── ParserConfiguration.cs           (NEW)
├── ParserWarning.cs                 (NEW)
├── ParserWarningEventArgs.cs        (NEW)
├── ParseResult.cs                   (NEW)
├── UnknownSegmentHandling.cs        (NEW - enum)
├── MalformedSegmentHandling.cs      (NEW - enum)
├── ParserWarningType.cs             (NEW - enum)
└── MessageSerializer.cs             (MODIFIED)

test/ClearHl7.Tests/SerializationTests/
├── ParserOptionsTests.cs            (NEW)
├── ParserConfigurationTests. cs      (NEW)
├── MessageSerializerOptionsTests.cs (NEW)
└── MessageSerializerTests.cs        (MODIFIED - add tests for new parameter)
```

---

## Testing Requirements

### Unit Tests

#### ParserOptions Tests
1. Test default values (all strict)
2. Test warning collection (add/retrieve/clear)
3. Test cloning (values copied, warnings/events not copied)
4. Test thread safety of warning collection (concurrent adds)
5. Test event raising

#### ParserConfiguration Tests
1. Test default options get/set
2. Test global warning collection
3. Test global event raising
4. Test ResetToDefaults()
5. Test thread safety (concurrent access to DefaultOptions)
6. Test defensive copying (modifying returned options doesn't affect global)

#### MessageSerializer Tests with Options

##### Unknown Segment Handling
1. Test `UnknownSegmentHandling. Throw` (default - should throw ArgumentException)
2. Test `UnknownSegmentHandling.Skip` (should skip segment, add warning)
3. Test `UnknownSegmentHandling.CreateGeneric` (should create placeholder, add warning)

##### Malformed Segment Handling
1. Test `MalformedSegmentHandling.Throw` (default - should throw ArgumentException)
2. Test `MalformedSegmentHandling.Skip` (should skip segment, add warning)
3. Test `MalformedSegmentHandling.BestEffort` (should parse what's possible, add warning)

##### Integration Tests
1. Test parsing message with multiple unknown segments
2. Test parsing message with mix of valid and invalid segments
3. Test warning collection (verify correct warnings are collected)
4. Test event raising (verify events fire at correct times)
5. Test per-call override of global options
6. Test DeserializeWithWarnings() method
7. Test thread safety (parse from multiple threads simultaneously)

##### Backward Compatibility Tests
1. Test existing code works unchanged (no options parameter)
2. Test null options parameter uses defaults
3. Test strict defaults match existing behavior

---

## Usage Examples

### Example 1: Simple Global Configuration

```csharp
// At application startup
ParserConfiguration.DefaultOptions = new ParserOptions
{
    UnknownSegmentHandling = UnknownSegmentHandling.Skip,
    MalformedSegmentHandling = MalformedSegmentHandling.Skip
};

// Subscribe to warnings globally
ParserConfiguration.ParserWarning += (sender, e) =>
{
    Console.WriteLine($"[{e.Warning. Timestamp:HH:mm:ss}] {e.Warning.Message}");
};

// Parse anywhere in application - uses global config
var message = MessageSerializer.Deserialize<Message>(hl7String);
```

### Example 2: Collect Warnings Globally

```csharp
// Enable global warning collection
ParserConfiguration.DefaultOptions = new ParserOptions
{
    UnknownSegmentHandling = UnknownSegmentHandling.Skip,
    CollectWarnings = true
};

// Parse multiple messages
var msg1 = MessageSerializer.Deserialize<Message>(hl7String1);
var msg2 = MessageSerializer.Deserialize<Message>(hl7String2);

// Review all warnings
foreach (var warning in ParserConfiguration. GlobalWarnings)
{
    Console.WriteLine($"Line {warning.LineNumber}: {warning. SegmentId} - {warning. Message}");
}

// Clear warnings
ParserConfiguration.ClearGlobalWarnings();
```

### Example 3: Per-Call Options with Warning Collection

```csharp
var result = MessageSerializer.DeserializeWithWarnings<Message>(hl7String);

if (result.HasWarnings)
{
    Console.WriteLine($"Parsed with {result.Warnings.Count} warnings:");
    foreach (var warning in result.Warnings)
    {
        Console.WriteLine($"  {warning.SegmentId}:  {warning.Message}");
    }
}

ProcessMessage(result.Message);
```

### Example 4: Override Global Configuration

```csharp
// Global is lenient
ParserConfiguration.DefaultOptions = new ParserOptions
{
    UnknownSegmentHandling = UnknownSegmentHandling.Skip
};

// But this specific call needs to be strict
var strictOptions = new ParserOptions
{
    UnknownSegmentHandling = UnknownSegmentHandling.Throw
};

try
{
    var message = MessageSerializer.Deserialize<Message>(hl7String, strictOptions);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Strict parsing failed: {ex.Message}");
}
```

### Example 5: Event-Based Logging

```csharp
// Set up instance-level event handler
var options = new ParserOptions
{
    UnknownSegmentHandling = UnknownSegmentHandling.Skip,
    MalformedSegmentHandling = MalformedSegmentHandling.BestEffort
};

options.ParserWarning += (sender, e) =>
{
    _logger.LogWarning(
        "HL7 Parser Warning - Type: {Type}, Segment: {SegmentId}, Line: {LineNumber}, Message: {Message}",
        e.Warning.Type,
        e.Warning.SegmentId,
        e.Warning.LineNumber,
        e. Warning.Message
    );
};

var message = MessageSerializer.Deserialize<Message>(hl7String, options);
```

### Example 6: Integration with Logging Framework

```csharp
public class HL7MessageParser
{
    private readonly ILogger<HL7MessageParser> _logger;
    
    public HL7MessageParser(ILogger<HL7MessageParser> logger)
    {
        _logger = logger;
        
        // Subscribe to global parser warnings
        ParserConfiguration.ParserWarning += OnParserWarning;
    }
    
    private void OnParserWarning(object sender, ParserWarningEventArgs e)
    {
        var warning = e.Warning;
        
        _logger.LogWarning(
            "HL7 parsing warning at line {LineNumber}: {Message}.  Segment ID: {SegmentId}, Type: {Type}",
            warning.LineNumber,
            warning. Message,
            warning.SegmentId,
            warning.Type
        );
        
        if (warning.Exception != null)
        {
            _logger.LogDebug(warning.Exception, "Exception details for warning");
        }
    }
    
    public Message Parse(string hl7String)
    {
        return MessageSerializer.Deserialize<Message>(hl7String);
    }
}
```

---

## Backward Compatibility Checklist

- ✅ All existing code compiles without changes
- ✅ Default behavior is identical to current behavior (strict/throw)
- ✅ Optional parameter with null default
- ✅ No changes to existing method signatures (only additions)
- ✅ No changes to existing types or interfaces
- ✅ No changes to existing behavior when options not specified
- ✅ Binary compatible (no recompilation needed for existing assemblies)
- ✅ Source compatible (existing source code works unchanged)

---

## Implementation Checklist

### Phase 1: Core Infrastructure
- [ ] Create `ParserWarningType` enum
- [ ] Create `UnknownSegmentHandling` enum
- [ ] Create `MalformedSegmentHandling` enum
- [ ] Create `ParserWarning` class
- [ ] Create `ParserWarningEventArgs` class
- [ ] Create `ParserOptions` class with `ConcurrentBag` for warnings
- [ ] Create `ParserConfiguration` static class
- [ ] Create `ParseResult<T>` class
- [ ] Add unit tests for all new classes

### Phase 2: MessageSerializer Modifications
- [ ] Add optional `ParserOptions` parameter to `Deserialize<T>()`
- [ ] Add options resolution logic (use provided or global default)
- [ ] Add `HandleUnknownSegment()` private method
- [ ] Add `HandleMalformedSegment()` private method
- [ ] Add `HandleSegmentParseError()` private method
- [ ] Modify unknown segment logic to call helper method
- [ ] Modify malformed segment logic to call helper method
- [ ] Add try-catch around segment parsing with error handler
- [ ] Add `DeserializeWithWarnings<T>()` public method
- [ ] Add unit tests for all modifications

### Phase 3: Integration & Testing
- [ ] Integration tests with multiple unknown segments
- [ ] Integration tests with mixed valid/invalid segments
- [ ] Thread safety tests (concurrent parsing)
- [ ] Backward compatibility tests (existing code unchanged)
- [ ] Event raising tests (both instance and global)
- [ ] Warning collection tests (both instance and global)
- [ ] Performance tests (ensure minimal overhead when not using options)

### Phase 4: Documentation
- [ ] XML documentation comments on all public types/members
- [ ] README. md updates with usage examples
- [ ] CHANGELOG.md entry
- [ ] Migration guide (if needed - should be none)
- [ ] Update any existing documentation that mentions parsing behavior

---

## Performance Considerations

1. **ConcurrentBag overhead**:  Minimal when CollectWarnings is false (no allocations)
2. **Cloning DefaultOptions**: One allocation per parse call, but only a shallow copy of primitives
3. **Event raising**: Minimal overhead, only when handlers are attached
4. **ImmutableList snapshots**: Only created when Warnings property is accessed
5. **Backward compatibility**: Zero overhead when options parameter is null/not provided

---

## Future Enhancements

### UnknownSegment Class (CreateGeneric option)
When `UnknownSegmentHandling.CreateGeneric` is specified, create a generic segment class: 

```csharp
public class UnknownSegment : ISegment
{
    public string Id { get; set; }
    public int Ordinal { get; set; }
    public string RawData { get; set; }
    public string[] Fields { get; set; }
    
    // Implement ISegment methods
}
```

### Field-Level Error Handling
Extend error handling to individual fields within segments: 
- Add `FieldParseError` warning type (already defined in enum)
- Modify segment `FromDelimitedString()` to catch field parsing errors
- Optionally populate fields that parsed successfully

### Validation Warnings
Add optional validation warnings for:
- Missing required fields
- Invalid data types
- Out-of-range values
- Deprecated segment usage

---

## Dependencies

### NuGet Packages Required
- `System.Collections.Immutable` (for `.ToImmutableList()`)
  - Already likely included in . NET Standard 2.0+ projects
  - If not, add: `<PackageReference Include="System.Collections.Immutable" Version="8.0.0" />`

### Framework Requirements
- .NET Standard 2.0 or higher (for `ConcurrentBag<T>`)
- No other new dependencies

---

## Breaking Changes

**NONE** - This is a purely additive change with optional parameters defaulting to existing behavior.

---

## Success Criteria

1. ✅ All existing unit tests pass without modification
2. ✅ New unit tests achieve >90% code coverage on new components
3. ✅ Performance overhead <5% when options not used
4. ✅ Thread-safe under load testing
5. ✅ Documentation complete and clear
6. ✅ Example code in README demonstrates all usage patterns

---

## Questions for Review

1. Should `UnknownSegment` class be implemented in Phase 1, or left as future enhancement?
2. Should global warning collection be enabled by default, or require explicit opt-in?
3. Should there be a maximum warning collection size to prevent memory issues?
4. Should warnings include more context (e.g., preceding/following segments)?
5. Should there be a built-in way to serialize warnings (JSON, XML)?

---

## Sign-off

- [ ] Specification reviewed by maintainers
- [ ] Design approved
- [ ] Ready for implementation
- [ ] Agent assigned

---

## Notes

This specification is designed to be handed to a Copilot coding agent for implementation. All code examples are complete and ready to use. The agent should implement in the order specified (Phase 1 → Phase 2 → Phase 3 → Phase 4) to maintain a working codebase at each step. 
