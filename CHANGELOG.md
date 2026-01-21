# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

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
  - Thread-safe implementation using `ConcurrentBag<T>` and defensive copying

### Dependencies
- Added `System.Collections.Immutable` 8.0.0 for immutable warning list snapshots

### Notes
- Default behavior remains strict (throw on errors) for full backward compatibility
- No breaking changes - all existing code continues to work unchanged
- 42 new comprehensive tests added (1037 total tests passing)
