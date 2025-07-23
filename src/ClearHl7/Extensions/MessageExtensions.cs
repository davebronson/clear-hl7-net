using System;
using System.Collections.Generic;
using System.Linq;

namespace ClearHl7.Extensions
{
    /// <summary>
    /// Extension methods for IMessage to provide convenient access to segments.
    /// </summary>
    public static class MessageExtensions
    {
        /// <summary>
        /// Gets all segments with the specified segment ID from the message.
        /// This method supports accessing both built-in and custom segments.
        /// </summary>
        /// <param name="message">The message to search in.</param>
        /// <param name="segmentId">The 3-character segment ID (e.g., "MSH", "PID", "ZDS").</param>
        /// <returns>An enumerable collection of segments with the specified ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when message is null.</exception>
        /// <exception cref="ArgumentException">Thrown when segmentId is null, empty, or not exactly 3 characters.</exception>
        public static IEnumerable<ISegment> GetSegments(this IMessage message, string segmentId)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message));
            
            if (string.IsNullOrEmpty(segmentId))
                throw new ArgumentException("Segment ID cannot be null or empty.", nameof(segmentId));
            
            if (segmentId.Length != 3)
                throw new ArgumentException("Segment ID must be exactly 3 characters.", nameof(segmentId));

            if (message.Segments == null)
                return Enumerable.Empty<ISegment>();

            string normalizedSegmentId = segmentId.ToUpperInvariant();
            return message.Segments.Where(s => s != null && string.Equals(s.Id, normalizedSegmentId, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Gets all custom segments with the specified segment ID from the message.
        /// This method is specifically for accessing custom segments registered with SegmentFactory.
        /// </summary>
        /// <param name="message">The message to search in.</param>
        /// <param name="segmentId">The 3-character segment ID (e.g., "ZDS", "ZPD").</param>
        /// <returns>An enumerable collection of custom segments with the specified ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when message is null.</exception>
        /// <exception cref="ArgumentException">Thrown when segmentId is null, empty, or not exactly 3 characters.</exception>
        public static IEnumerable<ISegment> GetCustomSegments(this IMessage message, string segmentId)
        {
            return message.GetSegments(segmentId);
        }

        /// <summary>
        /// Gets the first segment with the specified segment ID from the message.
        /// Returns null if no segment is found.
        /// </summary>
        /// <param name="message">The message to search in.</param>
        /// <param name="segmentId">The 3-character segment ID (e.g., "MSH", "PID", "ZDS").</param>
        /// <returns>The first segment with the specified ID, or null if not found.</returns>
        /// <exception cref="ArgumentNullException">Thrown when message is null.</exception>
        /// <exception cref="ArgumentException">Thrown when segmentId is null, empty, or not exactly 3 characters.</exception>
        public static ISegment GetSegment(this IMessage message, string segmentId)
        {
            return message.GetSegments(segmentId).FirstOrDefault();
        }

        /// <summary>
        /// Gets the first custom segment with the specified segment ID from the message.
        /// Returns null if no custom segment is found.
        /// </summary>
        /// <param name="message">The message to search in.</param>
        /// <param name="segmentId">The 3-character segment ID (e.g., "ZDS", "ZPD").</param>
        /// <returns>The first custom segment with the specified ID, or null if not found.</returns>
        /// <exception cref="ArgumentNullException">Thrown when message is null.</exception>
        /// <exception cref="ArgumentException">Thrown when segmentId is null, empty, or not exactly 3 characters.</exception>
        public static ISegment GetCustomSegment(this IMessage message, string segmentId)
        {
            return message.GetCustomSegments(segmentId).FirstOrDefault();
        }

        /// <summary>
        /// Gets all segments with the specified segment ID from the message, cast to the specified type.
        /// This is useful for accessing custom segments with their specific type.
        /// </summary>
        /// <typeparam name="T">The segment type that implements ISegment.</typeparam>
        /// <param name="message">The message to search in.</param>
        /// <param name="segmentId">The 3-character segment ID (e.g., "ZDS", "ZPD").</param>
        /// <returns>An enumerable collection of segments with the specified ID, cast to type T.</returns>
        /// <exception cref="ArgumentNullException">Thrown when message is null.</exception>
        /// <exception cref="ArgumentException">Thrown when segmentId is null, empty, or not exactly 3 characters.</exception>
        public static IEnumerable<T> GetSegments<T>(this IMessage message, string segmentId) where T : class, ISegment
        {
            return message.GetSegments(segmentId).OfType<T>();
        }

        /// <summary>
        /// Gets the first segment with the specified segment ID from the message, cast to the specified type.
        /// Returns null if no segment is found or if the segment cannot be cast to the specified type.
        /// </summary>
        /// <typeparam name="T">The segment type that implements ISegment.</typeparam>
        /// <param name="message">The message to search in.</param>
        /// <param name="segmentId">The 3-character segment ID (e.g., "ZDS", "ZPD").</param>
        /// <returns>The first segment with the specified ID cast to type T, or null if not found.</returns>
        /// <exception cref="ArgumentNullException">Thrown when message is null.</exception>
        /// <exception cref="ArgumentException">Thrown when segmentId is null, empty, or not exactly 3 characters.</exception>
        public static T GetSegment<T>(this IMessage message, string segmentId) where T : class, ISegment
        {
            return message.GetSegments<T>(segmentId).FirstOrDefault();
        }

        /// <summary>
        /// Gets all segments from the message, ordered by their Ordinal property.
        /// This provides access to the complete segment list in the order they appear in the message.
        /// </summary>
        /// <param name="message">The message to get segments from.</param>
        /// <returns>An enumerable collection of all segments, ordered by Ordinal.</returns>
        /// <exception cref="ArgumentNullException">Thrown when message is null.</exception>
        public static IEnumerable<ISegment> GetAllSegments(this IMessage message)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message));

            if (message.Segments == null)
                return Enumerable.Empty<ISegment>();

            return message.Segments.Where(s => s != null).OrderBy(s => s.Ordinal);
        }
    }
}