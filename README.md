# clear-hl7-net
![GitHub](https://img.shields.io/github/license/davebronson/clear-hl7-net)
![GitHub release (latest by date)](https://img.shields.io/github/v/release/davebronson/clear-hl7-net)
![GitHub last commit](https://img.shields.io/github/last-commit/davebronson/clear-hl7-net?logo=github)
![Nuget](https://img.shields.io/nuget/dt/ClearHl7?logo=nuget)

.NET HL7&reg; message generation and parsing library for the version 2.x standard

Understanding and programmatically building HL7 messages can be difficult.  clear-hl7-net takes pain out of this process by exposing an object hierarchy that is well structured, clearly named, and strongly-typed.

HL7&reg; is the registered trademark of Health Level Seven International, and the use of this trademark does not constitute an endorsement by HL7.

## Important Notes About Version 2 of clear-hl7-net
Upgrading from Version 1.x to Version 2? Please read some important notes about [Version 2](Version2.md) first.

## Getting Started
### Building clear-hl7-net
1. Clone the source code: `git clone https://github.com/davebronson/clear-hl7-net.git`
2. Open ClearHl7.sln in Visual Studio or VS Code, or build from the command line

### Download From NuGet
* https://www.nuget.org/packages/ClearHl7
* https://www.nuget.org/packages/ClearHl7.Codes

### Targets
* .NET Standard 2.0
* .NET Standard 2.1

## Supported HL7 Versions
Several versions exist for the HL7 Version 2.x messaging standard.  clear-hl7-net supports the following:
* 2.3
* 2.31
* 2.4
* 2.5
* 2.51
* 2.6
* 2.7
* 2.71
* 2.8
* 2.81
* 2.82
* 2.9

Use the matching namespace to target your desired HL7 version:
```csharp
using ClearHl7.V282;
using ClearHl7.V282.Segments;
using ClearHl7.V282.Types;
```

## HL7 Messages, Conceptually
HL7 Version 2.x messages consist of a collection of segments, with the MSH segment being required and appearing first.  Each segment is presented as a string on a single line, as a series of field values that are delimited with special characters indicating the position and nesting of each value.  Conceptually simple enough, but not very human-readable, and confusing to build correctly without the right tool.  clear-hl7-net represents this composition using a hierarchical class structure that is easy to interact with.  Pseudo example:
* Message
    * MSH Segment
        * Type
        * Type
    * PID Segment
        * Type
        * Type Collection
        * Type
    * PV1 Segment
        * Type
        * Type Collection
        * Type
            * Sub-Type (just a nested Type)
        * Type
            * Sub-Type

## Example: Building a Message
Let's build a sample `Message` containing the standard MSH `Segment`, and accompanied by PID, PVI, and Zxx `Segment`s.
```csharp
using ClearHl7;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V282;
using ClearHl7.V282.Segments;
using ClearHl7.V282.Types;

// [...]

// Build a new HL7 message
var message = new Message
{
    Segments = new ISegment[]
    {
        // Add an MSH segment - Message Header
        new MshSegment
        {
            SendingApplication = new HierarchicDesignator { NamespaceId = "Company EHR" },
            SendingFacility = new HierarchicDesignator { NamespaceId = "Company ABC" },
            ReceivingApplication = new HierarchicDesignator { NamespaceId = "HIE Application" },
            ReceivingFacility = new HierarchicDesignator { NamespaceId = "State HIE" },
            DateTimeOfMessage = DateTime.UtcNow,
            MessageControlId = "1234567890",

            // ADT message, Admit/visit notification
            MessageType = new MessageType { MessageCode = "ADT", TriggerEvent = "A01", MessageStructure = "ADT_A01" },

            // Production, Current processing transmitted at intervals
            ProcessingId = new ProcessingType { ProcessingId = "P", ProcessingMode = "T" }
        },

        // Add a PID segment - Patient Identification
        new PidSegment
        {
            Ordinal = 1, // Set the ordinal in each segment to indicate the ordering within a message
            SetIdPid = 1,
            PatientIdentifierList = new ExtendedCompositeIdWithCheckDigit[]
            {
                // Patient internal identifier
                new ExtendedCompositeIdWithCheckDigit { IdNumber = "P12345", IdentifierTypeCode = "PI" },

                // Patient external identifier
                new ExtendedCompositeIdWithCheckDigit { IdNumber = "A98765", IdentifierTypeCode = "PT" }
            },
            PatientName = new ExtendedPersonName[]
            {
                new ExtendedPersonName
                {
                    FamilyName = new FamilyName { Surname = "Anderson" },
                    GivenName = "Andy"
                }
            },
            DateTimeOfBirth = DateTime.Parse("1/1/1950 4:52:00"),
            PatientAddress = new ExtendedAddress[]
            {
                // Home address
                new ExtendedAddress
                {
                    StreetAddress = new StreetAddress { StreetOrMailingAddress = "123 Main Street" },
                    City = "Anywhere",
                    StateOrProvince = "FL",
                    ZipOrPostalCode = "33333"
                },

                // Alternate address
                new ExtendedAddress
                {
                    StreetAddress = new StreetAddress { StreetOrMailingAddress = "987 1st Avenue" },
                    City = "Somewhere",
                    StateOrProvince = "FL",
                    ZipOrPostalCode = "33333"
                }
            },
            PatientDeathIndicator = "N", // No
            PatientTelecommunicationInformation = new ExtendedTelecommunicationNumber[]
            {
                // Telephone
                new ExtendedTelecommunicationNumber { TelephoneNumber = "777-888-9999", TelecommunicationEquipmentType = "PH" },

                // Cellular or Mobile Phone
                new ExtendedTelecommunicationNumber { TelephoneNumber = "333-444-5555", TelecommunicationEquipmentType = "CP" }
            }
        },

        // Add a PV1 segment - Patient Visit
        new Pv1Segment
        {
            Ordinal = 2,
            PatientClass = new CodedWithExceptions { Identifier = "I" }, // Inpatient
            AdmissionType = new CodedWithExceptions { Identifier = "E" }, // Emergency
            ReadmissionIndicator = new CodedWithExceptions { Identifier = "R" }, // Re-admission
            AmbulatoryStatus = new CodedWithExceptions[]
            {
                new CodedWithExceptions { Identifier = "A2" }, // Ambulates with assistive device
                new CodedWithExceptions { Identifier = "A5" }, // Vision impaired
                new CodedWithExceptions { Identifier = "A6" }, // Hearing impaired
                new CodedWithExceptions { Identifier = "B3" }, // Amputee
            },
            AdmitDateTime = DateTime.Parse("1/1/2020 13:35:12"),
            CurrentPatientBalance = 1432.87M
        },

        // Add a Zxx segment (custom segment -> "ZPD")
        new ZxxSegment
        {
            Ordinal = 3,
            SegmentSuffix = "PD", // Use PD suffix for 'Patient Details'
            SegmentItems = new IType[]
            {
                new CodedWithExceptions { Identifier = "GREEN" },
                new ExtendedTelecommunicationNumber { CommunicationAddress = "andy.anderson@somewhere.com" },
                new CodedWithExceptions { Identifier = "Code1234" },
                new Text { Value = StringHelper.Escape("Anderson & Sons ~ Piano & Drywall Repair") } // String input? -> Then escape HL7 delimiters
            }
        }
    }
};

// there are two ways that you can serialize the structure into HL7 'pipehat' format:

// 1) Call MessageSerializer.Serialize()
// **********************************
string output = MessageSerializer.Serialize(message);

// 2) Call ToDelimitedString() on the Message instance
// **********************************
string output = message.ToDelimitedString();

// Outputs the following:
//     MSH|^~\&|Company EHR|Company ABC|HIE Application|State HIE|20201209022616||ADT^A01^ADT_A01|1234567890|P^T|2.8.2
//     PID|1||P12345^^^^PI~A98765^^^^PT||Anderson^Andy||19500101045200||||123 Main Street^^Anywhere^FL^33333~987 1st Avenue^^Somewhere^FL^33333|||||||||||||||||||N||||||||||777-888-9999^^PH~333-444-5555^^CP
//     PV1||I||E|||||||||R||A2~A5~A6~B3|||||||||||||||||||||||||||||20200101133512||1432.87
//     ZPD|GREEN|^^^andy.anderson@somewhere.com|Code1234|Anderson \T\ Sons \R\ Piano \T\ Drywall Repair
```

## Example: Parsing an HL7 'pipehat' String into a ClearHl7 Message
We've received an HL7 message string.  Let's deserialize it into a `Message` instance for integration elsewhere.
```csharp
using ClearHl7;
using ClearHl7.Serialization;
using ClearHl7.V282;

// [...]

string messageString = YourApp.ReceiveMessage();

// There are two ways that you can deserialize:

// 1) Call MessageSerializer.Deserialize(), which returns
//    a new Message instance
// **********************************
//    I don't know the HL7 version:
IMessage message = MessageSerializer.Deserialize(messageString);
//    I do know the HL7 version, or want to force a specific version:
IMessage message = MessageSerializer.Deserialize<V282.Message>(messageString);

// 2) Call FromDelimitedString() on an existing Message
//    instance, which performs the conversion in-place
// **********************************
IMessage message = new Message();
message.FromDelimitedString(messageString);
```

## Example: Detecting the HL7 Version for a Message String
Let's detect the HL7 version that is being used in an HL7 message string.
```csharp
using ClearHl7;
using ClearHl7.Helpers;

// [...]

// Where messageString = "MSH|^~\&||||||||||2.3||[...]"
string messageString = YourApp.ReceiveMessage();

// Get the version
Hl7Version version = MessageHelper.DetectVersion(messageString);

// Returns:
//     The enumeration value Hl7Version.V230
```

## Example: Creating an Instance of a ClearHl7 Message for a Specific Version
Let's create a Message instance with a specific HL7 version.
```csharp
using ClearHl7;
using ClearHl7.Helpers;

// [...]

// Create a new Message instance for V2.8.1
IMessage message = MessageHelper.NewInstance(Hl7Version.V281);

// Returns:
//      An instance of ClearHl7.V281.Message
```

## Customizing
### Delimiter Characters
The HL7 specification calls out default delimiters to use for fields (pipe `|`), components (caret `^`), subcomponents (ampersand `&`), escaping (backslash `\`), and repetition (tilde `~`).  Most will use these defaults.  But if the consumer of your messages supports it, it is possible to define your own delimiters.
```csharp
using ClearHl7;

// [...]

Configuration.FieldRepeatSeparator = "%"; // Use percent symbol
Configuration.SubcomponentSeparator = "/"; // Use forward slash

// Reset the separator configuration properties to their
// default, recommended values
Configuration.ResetSeparators();
```

### DateTime Precision Configuration
clear-hl7-net provides flexible DateTime precision configuration that allows you to control how DateTime values are formatted in HL7 messages while preserving field-specific precision requirements.

#### Key Features
- **Precision preservation**: Fields maintain their HL7 standard precisions when no overrides are set
- **Global override capability**: Optional global setting affects all fields without individual configuration  
- **Per-field overrides**: Type-safe configuration for individual fields
- **Clear hierarchy**: Predictable behavior with well-defined priority order

#### Basic Usage
```csharp
using ClearHl7;

// Set global override (affects all DateTime fields)
Hl7DateTimeFormatConfig.GlobalDateTimeFormatOverride = Consts.DateTimeFormatPrecisionMinute;

// Configure specific fields (type-safe)
Hl7DateTimeFormatConfig.SetPrecision<MshSegment>(x => x.DateTimeOfMessage, Consts.DateFormatPrecisionDay);
Hl7DateTimeFormatConfig.SetPrecision<EvnSegment>(x => x.RecordedDateTime, Consts.DateTimeFormatPrecisionHour);

// NEW: Configure field to use timezone offset format
Hl7DateTimeFormatConfig.SetPrecision<MshSegment>(x => x.DateTimeOfMessage, Consts.DateTimeFormatPrecisionSecondWithTimezoneOffset);

// Clear overrides to revert to default behavior
Hl7DateTimeFormatConfig.ClearGlobalOverride();
Hl7DateTimeFormatConfig.ClearFieldPrecisions();
```

#### Configuration Scenarios
1. **No Global Override**: ALL fields use default precision based on field type
2. **Global Override Set**: ALL fields use global precision  
3. **Individual Override Only**: ONLY overridden fields change from default precision
4. **Global + Individual Overrides**: Global precision for all fields except individually overridden ones

#### Available Precision Levels
- `Consts.DateFormatPrecisionYear` - Year only (yyyy) - e.g., "2024"
- `Consts.DateFormatPrecisionMonth` - Year and month (yyyyMM) - e.g., "202403"  
- `Consts.DateFormatPrecisionDay` - Date only (yyyyMMdd) - e.g., "20240315"
- `Consts.DateTimeFormatPrecisionHour` - Date and hour (yyyyMMddHH) - e.g., "2024031514"
- `Consts.DateTimeFormatPrecisionMinute` - Date, hour, and minute (yyyyMMddHHmm) - e.g., "202403151430"
- `Consts.DateTimeFormatPrecisionSecond` - Full precision (yyyyMMddHHmmss) - e.g., "20240315143045"
- `Consts.DateTimeFormatPrecisionSecondWithTimezoneOffset` - Full precision with timezone offset (yyyyMMddHHmmss±HHMM) - e.g., "20240315143045+0530" (documentation constant; use helper methods below to format with HL7-compliant offsets)

#### Timezone Offset Support
clear-hl7-net provides deterministic timezone offset support for HL7 datetime values. By default, all datetime values with timezone offsets are serialized using UTC (+0000) to ensure consistent, deterministic behavior across different machines and CI environments.

##### Default Behavior (UTC)
```csharp
using ClearHl7;

// Default: Uses UTC offset (+0000)
var dt = new DateTimeOffset(2024, 3, 15, 14, 30, 45, TimeSpan.FromHours(-5));
var result = Hl7DateTimeFormatConfig.FormatDateTimeWithConfiguredOffset(dt);
// Result: "20240315193045+0000" (converted to UTC)
```

##### Using System Local Timezone
```csharp
using ClearHl7;

// Configure to use local system timezone
Hl7DateTimeFormatConfig.TimezoneOffset = DateTimeOffset.Now.Offset;

var dt = new DateTimeOffset(2024, 3, 15, 14, 30, 45, TimeSpan.Zero);
var result = Hl7DateTimeFormatConfig.FormatDateTimeWithConfiguredOffset(dt);
// Result: "20240315093045-0500" (if local offset is -05:00)
```

##### Using Custom Timezone Offset
```csharp
using ClearHl7;

// Configure a specific timezone offset (e.g., IST +05:30)
Hl7DateTimeFormatConfig.TimezoneOffset = new TimeSpan(5, 30, 0);

var dt = new DateTimeOffset(2024, 3, 15, 14, 30, 45, TimeSpan.Zero);
var result = Hl7DateTimeFormatConfig.FormatDateTimeWithConfiguredOffset(dt);
// Result: "20240315200045+0530" (converted to +05:30)
```

##### Preserving Source Offset
```csharp
using ClearHl7;

// Use the source DateTimeOffset's own timezone offset
var dt = new DateTimeOffset(2024, 3, 15, 14, 30, 45, TimeSpan.FromHours(5));
var result = Hl7DateTimeFormatConfig.FormatDateTimeUsingSourceOffset(dt);
// Result: "20240315143045+0500" (preserves original +05:00 offset)
```

##### HL7 Offset Format
The library ensures HL7-compliant timezone offsets in ±HHMM format (without colon), as required by the HL7 standard:
- UTC: `+0000`
- EST: `-0500`
- IST: `+0530`
- ACDT: `+1030`

##### Helper Methods
The `Hl7DateTimeFormatConfig` class provides three helper methods for working with timezone offsets:

1. **`ToHl7OffsetString(TimeSpan offset)`** - Converts a TimeSpan to HL7's ±HHMM format (without colon)
   ```csharp
   var offsetString = Hl7DateTimeFormatConfig.ToHl7OffsetString(TimeSpan.FromHours(5));
   // Returns: "+0500"
   ```

2. **`FormatDateTimeWithConfiguredOffset(DateTimeOffset dt)`** - Formats using the configured `TimezoneOffset` property
   - Converts the DateTimeOffset to the configured timezone
   - Returns HL7 format: `yyyyMMddHHmmss±HHMM`
   - Uses the global `TimezoneOffset` configuration (defaults to UTC)

3. **`FormatDateTimeUsingSourceOffset(DateTimeOffset dt)`** - Formats using the DateTimeOffset's own timezone
   - Preserves the original timezone of the DateTimeOffset
   - Returns HL7 format: `yyyyMMddHHmmss±HHMM`
   - Useful when you want to keep the source timezone information

**Note**: The configured `TimezoneOffset` is global and thread-safe. Set it once at application startup for consistent behavior throughout your application.

For detailed documentation and advanced scenarios, see [DateTime Precision Configuration](DateTime-Precision-Configuration.md).

## Using the ClearHl7.Codes Component
There are code systems published as part of the HL7 specification, which are recommended for use in your messages.  You have flexibility, of course, to use any coded values that you and your message consumer might agree upon.  To easily access the defined codes you may utilize the `ClearHl7.Codes` component, which contains enumerations for each.

### Static Usage (Recommended)
The static `EnumMaps` class provides a convenient way to convert enum values without needing to instantiate a helper object:

```csharp
using ClearHl7.Codes.V282;
using ClearHl7.Codes.V282.Helpers;

// [...]

// Example using the MaritalStatus and YesNoIndicator codes
// Call EnumMaps.EnumToCode() static method to receive the
// actual coded string for a given enum value
pidSegment.MaritalStatus = new CodedWithExceptions
{
    Identifier = EnumMaps.EnumToCode(CodeMaritalStatus.Married)
};
pidSegment.MultipleBirthIndicator = EnumMaps.EnumToCode(CodeYesNoIndicator.No);
```

### Instance Usage (For Dependency Injection)
If you need to use dependency injection or prefer instance-based access, you can use the `EnumHelper` class with the `IEnumHelper` interface:

```csharp
using ClearHl7.Codes.V282;
using ClearHl7.Codes.V282.Helpers;

// [...]

var helper = new EnumHelper();

// Example using the MaritalStatus and YesNoIndicator codes
pidSegment.MaritalStatus = new CodedWithExceptions
{
    Identifier = helper.EnumToCode(CodeMaritalStatus.Married)
};
pidSegment.MultipleBirthIndicator = helper.EnumToCode(CodeYesNoIndicator.No);
```

## Custom Segments

As of version 2.x, clear-hl7-net supports custom HL7 segments through the `SegmentFactory` class. This feature enables you to define and register custom segments (such as Z-segments) that will be automatically recognized during message parsing and serialization.

### Quick Start with Custom Segments

#### 1. Define Your Custom Segment

```csharp
using ClearHl7;
using ClearHl7.V282.Types;

public class ZdsSegment : ISegment
{
    public string Id => "ZDS";
    public int Ordinal { get; set; }

    // Define typed properties for your segment fields
    public string RecordId { get; set; }
    public CodedWithExceptions DataSource { get; set; }
    public CodedWithExceptions ProcessingStatus { get; set; }
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
        var fields = delimitedString?.Split(seps.FieldSeparator);
        
        if (fields == null || fields.Length == 0) return;

        // Parse fields (skip field 0 which is the segment ID)
        if (fields.Length > 1) RecordId = fields[1];
        
        if (fields.Length > 2 && !string.IsNullOrEmpty(fields[2]))
        {
            DataSource = new CodedWithExceptions();
            DataSource.FromDelimitedString(fields[2], seps);
        }

        if (fields.Length > 3 && !string.IsNullOrEmpty(fields[3]))
        {
            ProcessingStatus = new CodedWithExceptions();
            ProcessingStatus.FromDelimitedString(fields[3], seps);
        }

        // Handle repeating contact info
        if (fields.Length > 4 && !string.IsNullOrEmpty(fields[4]))
        {
            var contactElements = fields[4].Split(seps.FieldRepeatSeparator);
            ContactInfo = new ExtendedTelecommunicationNumber[contactElements.Length];
            for (int i = 0; i < contactElements.Length; i++)
            {
                ContactInfo[i] = new ExtendedTelecommunicationNumber();
                ContactInfo[i].FromDelimitedString(contactElements[i], seps);
            }
        }

        // Handle timestamp
        if (fields.Length > 5 && !string.IsNullOrEmpty(fields[5]))
        {
            if (DateTime.TryParseExact(fields[5], "yyyyMMddHHmmss", null, 
                System.Globalization.DateTimeStyles.None, out DateTime timestamp))
            {
                LastUpdated = timestamp;
            }
        }

        // Handle comments with escape sequences
        if (fields.Length > 6 && !string.IsNullOrEmpty(fields[6]))
        {
            Comments = Helpers.StringHelper.Unescape(fields[6]);
        }
    }

    public string ToDelimitedString()
    {
        var seps = new Separators();
        var fields = new string[7];
        
        fields[0] = Id;
        fields[1] = RecordId;
        fields[2] = DataSource?.ToDelimitedString();
        fields[3] = ProcessingStatus?.ToDelimitedString();
        
        if (ContactInfo?.Length > 0)
        {
            fields[4] = string.Join(seps.FieldRepeatSeparator.ToString(), 
                ContactInfo.Select(ci => ci?.ToDelimitedString() ?? string.Empty));
        }
        
        fields[5] = LastUpdated?.ToString("yyyyMMddHHmmss");
        fields[6] = !string.IsNullOrEmpty(Comments) ? Helpers.StringHelper.Escape(Comments) : null;

        return string.Join(seps.FieldSeparator.ToString(), fields);
    }
}
```

#### 2. Register Your Custom Segment

```csharp
using ClearHl7;

// Register for all HL7 versions (global registration)
SegmentFactory.RegisterSegment<ZdsSegment>("ZDS");

// OR register for a specific HL7 version
SegmentFactory.RegisterSegment<Hl7Version, ZdsSegment>("ZDS");
```

#### 3. Use Custom Segments in Message Processing

```csharp
using ClearHl7;
using ClearHl7.Serialization;
using ClearHl7.Extensions;
using ClearHl7.V282;

// Parse messages containing custom segments
string hl7Message = 
    "MSH|^~\\&|SYSTEM|SENDER|RECEIVER|DEST|20240101120000||ADT^A01|MSG001|P|2.8.2||||\r" +
    "PID|1||12345^^^^MR||Doe^John^J||19800101|M|\r" +
    "ZDS|REC001|SRC^Data Source^L|PROC^Processing^L|555-1234^WPN^PH|20240101120000|Custom data segment\r";

var message = MessageSerializer.Deserialize<Message>(hl7Message);

// Access custom segments using new convenience methods
var zdsSegments = message.GetCustomSegments("ZDS");
var firstZds = message.GetCustomSegment("ZDS") as ZdsSegment;

// Access with strong typing
var typedZdsSegments = message.GetSegments<ZdsSegment>("ZDS");
var typedZds = message.GetSegment<ZdsSegment>("ZDS");

// Work with parsed custom segment data
if (typedZds != null)
{
    Console.WriteLine($"Record ID: {typedZds.RecordId}");
    Console.WriteLine($"Data Source: {typedZds.DataSource?.Identifier}");
    Console.WriteLine($"Last Updated: {typedZds.LastUpdated}");
}
```

### Advanced Custom Segment Features

#### Supporting Complex HL7 Data Types

Custom segments can use any of the built-in HL7 data types, including:

- `CodedWithExceptions` - for coded values
- `ExtendedTelecommunicationNumber` - for phone/email contacts  
- `ExtendedPersonName` - for person names
- `ExtendedAddress` - for addresses
- `HierarchicDesignator` - for hierarchical identifiers
- `DateTime` and other primitives

#### Supporting Repetition

Fields can repeat within segments by using arrays and the field repeat separator (`~`):

```csharp
// Multiple contact methods
public ExtendedTelecommunicationNumber[] ContactInfo { get; set; }

// Multiple coded categories
public CodedWithExceptions[] Categories { get; set; }

// Parse repeating fields
var elements = field.Split(seps.FieldRepeatSeparator);
ContactInfo = new ExtendedTelecommunicationNumber[elements.Length];
for (int i = 0; i < elements.Length; i++)
{
    ContactInfo[i] = new ExtendedTelecommunicationNumber();
    ContactInfo[i].FromDelimitedString(elements[i], seps);
}
```

#### Handling Special Characters

Use the `StringHelper.Escape()` and `StringHelper.Unescape()` methods for text fields that may contain HL7 delimiter characters:

```csharp
// When parsing from HL7
Comments = Helpers.StringHelper.Unescape(fields[6]);

// When serializing to HL7  
return Helpers.StringHelper.Escape(Comments);
```

### Accessing Segments in Messages

The library provides several convenient methods for accessing both built-in and custom segments:

```csharp
using ClearHl7.Extensions;

// Get all segments with a specific ID
var allZdsSegments = message.GetSegments("ZDS");
var allZdsCustomSegments = message.GetCustomSegments("ZDS");

// Get the first segment with a specific ID
var firstMsh = message.GetSegment("MSH");
var firstZds = message.GetCustomSegment("ZDS");

// Get segments with strong typing
var typedZdsSegments = message.GetSegments<ZdsSegment>("ZDS");
var typedZds = message.GetSegment<ZdsSegment>("ZDS");

// Get all segments in order
var allSegments = message.GetAllSegments();
```

### Message Structure Patterns

Most message classes expose typed properties for standard segments, and repeating segments are usually exposed as lists:

```csharp
// For built-in segments, access via Segments collection and LINQ
var msh = message.Segments.OfType<MshSegment>().FirstOrDefault();
var pid = message.Segments.OfType<PidSegment>().FirstOrDefault();

// For repeating segments like NK1 (Next of Kin)
var nk1s = message.Segments.OfType<Nk1Segment>().ToList();
foreach(var nk1 in nk1s)
{
    Console.WriteLine(nk1.NkName?.FamilyName?.Surname);
}

// For custom segments, use the new convenience methods
var customSegments = message.GetCustomSegments("ZDS").Cast<ZdsSegment>();
```

### Registration Options

The `SegmentFactory` provides flexible registration options:

```csharp
// Global registration - works with all HL7 versions
SegmentFactory.RegisterSegment<ZdsSegment>("ZDS");

// Version-specific registration
SegmentFactory.RegisterSegment<Hl7Version, ZdsSegment>("ZDS");

// You can also register different implementations for different versions
SegmentFactory.RegisterSegment(Hl7Version.V282, "ZDS");
```

### Thread Safety

The `SegmentFactory` is thread-safe and uses `ConcurrentDictionary` internally. You can safely register custom segments from multiple threads, though it's recommended to register all custom segments during application startup.

### Backward Compatibility

Custom segments are fully backward compatible. All existing functionality is preserved, and the library falls back to built-in segments when no custom registration is found.

## Anything Else?
* `Segment`s, `Type`s, and collections are __not__ automatically initialized for you.  You must manually instantiate each object that you're going to read/write to.  But be a good steward of machine resources, and only instantiate objects that you'll interact with.
* Collection properties are all implemented with the `IEnumerable` interface to provide you with wide flexibility in the type of collection that you pass into the class.  The example above shows usage of simple arrays, but you can use more complex types like `List`, etc.
* `Segment`s can be built and added to a `Message` in any order.  Just set the `Segment.Ordinal` property for each to specify the ordering in the final output.  And remember that the MSH `Segment` is required, and must appear first.
* **DateTime precision is configurable**: You can control how DateTime values are formatted in HL7 messages using global overrides and per-field configuration while preserving field-specific precision requirements. See [DateTime Precision Configuration](DateTime-Precision-Configuration.md) for details.
* The HL7 spec calls out that segments shall be terminated with a single carriage return (a.k.a. \r or (char)13). ClearHl7 supports only this charater.  If you receive messages that use alternate line terminators, you must perform a programmatic replace on those alternate terminators before attempting to deserialize with ClearHL7, so that you may receive the expected result.
* Any string input that may contain one of the utilized delimiter characters should be escaped with `ClearHl7.Helpers.StringHelper.Escape()`.  See the Zxx/ZPD segment in the example above.
* Any `Message`, `Segment`, or `Type` can be serialized to an HL7 pipehat string by calling `Serialize()` or `ToDelimitedString()`.  Utilize the `ClearHl7.Serialization` namespace.
* Any `Message`, `Segment`, or `Type` can be instantiated and populated using an HL7 pipehat string by calling `Deserialize()` or `FromDelimitedString()`.  Utilize the `ClearHl7.Serialization` namespace.

## Contributing
We welcome code and documentation contributions!
### Complex Changes
Please discuss with the repo owners before making the change.  We would like to talk about motivations for the change, and go over your design decisions.
### Simple Changes
Fork davebronson/clear-hl7-net.git and begin development from your own fork.

## License
clear-hl7-net is licensed under the [MIT License](https://github.com/davebronson/clear-hl7-net/blob/master/LICENSE).
