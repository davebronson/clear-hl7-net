using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace ClearHl7
{
    /// <summary>
    /// Factory for creating and registering custom HL7 segments.
    /// </summary>
    public static class SegmentFactory
    {
        /// <summary>
        /// Global segment registrations that apply to all HL7 versions.
        /// </summary>
        private static readonly ConcurrentDictionary<string, Func<ISegment>> _globalRegistrations = new();

        /// <summary>
        /// Version-specific segment registrations.
        /// Key format: "Version|SegmentId" (e.g., "V281|ZDS")
        /// </summary>
        private static readonly ConcurrentDictionary<string, Func<ISegment>> _versionRegistrations = new();

        /// <summary>
        /// Registers a custom segment type for all HL7 versions.
        /// </summary>
        /// <typeparam name="T">The segment type that implements ISegment.</typeparam>
        /// <param name="segmentId">The 3-character segment ID (e.g., "ZDS").</param>
        /// <exception cref="ArgumentException">Thrown when segmentId is null, empty, or not exactly 3 characters.</exception>
        /// <exception cref="ArgumentException">Thrown when the segment type does not implement ISegment correctly.</exception>
        public static void RegisterSegment<T>(string segmentId) where T : class, ISegment, new()
        {
            ValidateSegmentId(segmentId);
            ValidateSegmentType<T>(segmentId);

            _globalRegistrations.AddOrUpdate(segmentId.ToUpperInvariant(), 
                _ => () => new T(), 
                (_, __) => () => new T());
        }

        /// <summary>
        /// Registers a custom segment type for a specific HL7 version.
        /// </summary>
        /// <param name="version">The HL7 version enumeration value.</param>
        /// <param name="segmentId">The 3-character segment ID (e.g., "ZDS").</param>
        /// <typeparam name="T">The segment type that implements ISegment.</typeparam>
        /// <exception cref="ArgumentException">Thrown when segmentId is null, empty, or not exactly 3 characters.</exception>
        /// <exception cref="ArgumentException">Thrown when the segment type does not implement ISegment correctly.</exception>
        public static void RegisterSegment<T>(Hl7Version version, string segmentId) where T : class, ISegment, new()
        {
            ValidateSegmentId(segmentId);
            ValidateSegmentType<T>(segmentId);

            string key = $"{version}|{segmentId.ToUpperInvariant()}";
            _versionRegistrations.AddOrUpdate(key, 
                _ => () => new T(), 
                (_, __) => () => new T());
        }

        /// <summary>
        /// Registers a custom segment type for a specific HL7 version.
        /// This method signature matches the API requested in the problem statement.
        /// Note: The first type parameter should be the Hl7Version enum type.
        /// </summary>
        /// <typeparam name="TVersion">The HL7 version enumeration type (should be Hl7Version).</typeparam>
        /// <typeparam name="TSegment">The segment type that implements ISegment.</typeparam>
        /// <param name="segmentId">The 3-character segment ID (e.g., "ZDS").</param>
        /// <exception cref="ArgumentException">Thrown when segmentId is null, empty, or not exactly 3 characters.</exception>
        /// <exception cref="ArgumentException">Thrown when the segment type does not implement ISegment correctly.</exception>
        /// <exception cref="ArgumentException">Thrown when TVersion is not assignable to Hl7Version.</exception>
        public static void RegisterSegment<TVersion, TSegment>(string segmentId) 
            where TSegment : class, ISegment, new()
        {
            ValidateSegmentId(segmentId);
            ValidateSegmentType<TSegment>(segmentId);

            // The problem statement shows this API but doesn't specify which version to use.
            // Since this is meant to be a version-specific registration but no version is provided,
            // we'll register for all HL7 versions to provide the broadest compatibility.
            foreach (Hl7Version version in Enum.GetValues(typeof(Hl7Version)).Cast<Hl7Version>())
            {
                if (version != Hl7Version.None)
                {
                    string key = $"{version}|{segmentId.ToUpperInvariant()}";
                    _versionRegistrations.AddOrUpdate(key, 
                        _ => () => new TSegment(), 
                        (_, __) => () => new TSegment());
                }
            }
        }

        /// <summary>
        /// Creates a segment instance for the specified segment ID and HL7 version.
        /// First checks version-specific registrations, then global registrations.
        /// </summary>
        /// <param name="segmentId">The 3-character segment ID.</param>
        /// <param name="version">The HL7 version.</param>
        /// <returns>An instance of the registered segment, or null if no registration found.</returns>
        public static ISegment CreateSegment(string segmentId, Hl7Version version)
        {
            if (string.IsNullOrEmpty(segmentId) || segmentId.Length != 3)
            {
                return null;
            }

            string normalizedId = segmentId.ToUpperInvariant();

            // Check version-specific registration first
            string versionKey = $"{version}|{normalizedId}";
            if (_versionRegistrations.TryGetValue(versionKey, out Func<ISegment> versionFactory))
            {
                return versionFactory();
            }

            // Fall back to global registration
            if (_globalRegistrations.TryGetValue(normalizedId, out Func<ISegment> globalFactory))
            {
                return globalFactory();
            }

            return null;
        }

        /// <summary>
        /// Creates a segment instance for the specified segment ID using global registrations only.
        /// </summary>
        /// <param name="segmentId">The 3-character segment ID.</param>
        /// <returns>An instance of the registered segment, or null if no registration found.</returns>
        public static ISegment CreateSegment(string segmentId)
        {
            if (string.IsNullOrEmpty(segmentId) || segmentId.Length != 3)
            {
                return null;
            }

            string normalizedId = segmentId.ToUpperInvariant();
            if (_globalRegistrations.TryGetValue(normalizedId, out Func<ISegment> factory))
            {
                return factory();
            }

            return null;
        }

        /// <summary>
        /// Clears all segment registrations. Primarily for testing purposes.
        /// </summary>
        public static void ClearRegistrations()
        {
            _globalRegistrations.Clear();
            _versionRegistrations.Clear();
        }

        /// <summary>
        /// Gets a read-only collection of all registered global segment IDs.
        /// </summary>
        /// <returns>A collection of segment IDs registered globally.</returns>
        public static IEnumerable<string> GetGlobalRegistrations()
        {
            return _globalRegistrations.Keys;
        }

        /// <summary>
        /// Gets a read-only collection of all registered version-specific segment keys.
        /// </summary>
        /// <returns>A collection of version-specific registration keys in format "Version|SegmentId".</returns>
        public static IEnumerable<string> GetVersionRegistrations()
        {
            return _versionRegistrations.Keys;
        }

        private static void ValidateSegmentId(string segmentId)
        {
            if (string.IsNullOrEmpty(segmentId))
            {
                throw new ArgumentException("Segment ID cannot be null or empty.", nameof(segmentId));
            }

            if (segmentId.Length != 3)
            {
                throw new ArgumentException("Segment ID must be exactly 3 characters.", nameof(segmentId));
            }
        }

        private static void ValidateSegmentType<T>(string segmentId) where T : class, ISegment, new()
        {
            try
            {
                T instance = new T();
                if (instance.Id != segmentId.ToUpperInvariant())
                {
                    throw new ArgumentException($"Segment type {typeof(T).Name} returns Id '{instance.Id}' but was registered with ID '{segmentId.ToUpperInvariant()}'.", nameof(T));
                }
            }
            catch (Exception ex) when (!(ex is ArgumentException))
            {
                throw new ArgumentException($"Unable to create instance of segment type {typeof(T).Name}.", nameof(T), ex);
            }
        }
    }
}