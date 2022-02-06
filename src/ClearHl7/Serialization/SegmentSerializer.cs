using System;

namespace ClearHl7.Serialization
{
    /// <summary>
    /// Provides serialization methods for HL7 Segments.
    /// </summary>
    public static class SegmentSerializer
    {
        /// <summary>
        /// Parses the text representing a single Segment value into an instance of a specified type.
        /// </summary>
        /// <typeparam name="T">The target type of the string value.</typeparam>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>An instance of type T.</returns>
        /// <exception cref="ArgumentNullException">delimitedString is null.</exception>
        public static T Deserialize<T>(string delimitedString) where T : class, ISegment
        {
            if (string.IsNullOrEmpty(delimitedString))
            {
                throw new ArgumentNullException(nameof(delimitedString), $"{ nameof(delimitedString) } is null.");
            }

            return Deserialize<T>(delimitedString, null);
        }

        /// <summary>
        /// Parses the text representing a single Type value into an instance of a specified type.
        /// </summary>
        /// <typeparam name="T">The target type of the string value.</typeparam>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <returns>An instance of type T.</returns>
        /// <exception cref="ArgumentNullException">delimitedString is null.</exception>
        public static T Deserialize<T>(string delimitedString, Separators separators) where T : class, ISegment
        {
            if (string.IsNullOrEmpty(delimitedString))
            {
                throw new ArgumentNullException(nameof(delimitedString), $"{ nameof(delimitedString) } is null.");
            }

            T item = Activator.CreateInstance<T>();
            item.FromDelimitedString(delimitedString, separators);

            return item;
        }

        /// <summary>
        /// Converts the value of a specified Segment into a string.
        /// </summary>
        /// <param name="segment">The Segment to convert.</param>
        /// <returns>A string.</returns>
        /// <exception cref="ArgumentNullException">value is null.</exception>
        public static string Serialize(ISegment segment)
        {
            if (segment == null)
            {
                throw new ArgumentNullException(nameof(segment), $"{ nameof(segment) } is null.");
            }

            return segment.ToDelimitedString();
        }
    }
}
