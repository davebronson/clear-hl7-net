# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [2.4.3] - 2026-04-21

### Fixed
- Fix timezone-offset DateTime precision serialization for configured HL7 fields

## [2.4.2] - 2026-04-15

### Added
- **Serializer and Helper Optimizations**: Added reflection caching for GetProperties and Assembly.CreateInstance, plus BenchmarkDotNet project.
  - Optimized serialization hot paths: cache reflection in SegmentHelper and MessageSerializer

## [2.4.1] - 2026-03-15

### Added
- **Parser Options and Configurability**: Added opt-in lenient parsing modes for handling real-world HL7 messages containing unknown segments or malformed data.
  - New `ParserOptions` class for configuring parser behavior (thread-safe)
  - New `ParserConfiguration` static class for global defaults
  - New `ParserWarning` class for structured warning metadata
  - New `ParseResult<T>` class for deserialization results with warnings
  - New enums: `UnknownSegmentHandling`, `MalformedSegmentHandling`, `ParserWarningType`
  - Optional `ParserOptions` parameter on `MessageSerializer.Deserialize<T>()` (backward compatible)
  - New `MessageSerializer.DeserializeWithWarnings<T>()` method
  - Warning collection and event-based notification at both instance and global levels
  - Thread-safe implementation using `ConcurrentBag<T>` and defensive copying with `Array.AsReadOnly()`
- **BestEffort field-level recovery**: `MalformedSegmentHandling.BestEffort` now performs a genuine field-level retry loop when a segment throws during parsing.
  - After each failed parse the partially-populated segment instance is inspected to find the **null boundary** — the first position where the raw segment has a non-empty value but the corresponding property is still `null`, indicating the sequential parser stopped there. This makes recovery **O(1) per bad field** rather than a linear scan.
  - The identified field is permanently blanked and parsing retried from scratch with a fresh instance. If the retry also fails, the new partial instance reveals the next null boundary. This continues until the segment parses completely or no null boundary can be found.
  - Each recovered field produces one `ParserWarning` with `FieldIndex` (1-based position) and `RawFieldValue` (original value before blanking). Five bad fields → five warnings.
  - If the bad field is already empty in the raw segment, or no further progress can be made, the segment is dropped and a single warning is recorded without field details (same as `Skip`).
  - New nullable `FieldIndex` (int?) and `RawFieldValue` (string) properties added to `ParserWarning` — fully non-breaking.

### Notes
- Default behavior remains strict (throw on errors) for full backward compatibility
- No breaking changes - all existing code continues to work unchanged
- Callers using `BestEffort` are responsible for checking `ParserWarning`s — segments may contain partial data with affected fields set to `null`
- No external dependencies added - uses built-in .NET types
