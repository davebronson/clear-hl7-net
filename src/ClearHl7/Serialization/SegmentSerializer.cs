using System;

namespace ClearHl7.Serialization
{
    /// <summary>
    /// Provides serialization methods for HL7 Segments.
    /// </summary>
    public static class SegmentSerializer
    {
        /// <summary>
        /// Returns a new instance of type T with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <returns>An instance of type T.</returns>
        /// <exception cref="ArgumentNullException">delimitedString is null.</exception>
        public static T Deserialize<T>(string delimitedString, Separators separators) where T : class, ISegment
        {
            if (string.IsNullOrEmpty(delimitedString))
            {
                throw new ArgumentNullException(nameof(delimitedString), $"{ delimitedString } is null.");
            }

            T item = Activator.CreateInstance<T>();
            item.FromDelimitedString(delimitedString, separators);

            return item;
        }
    }
}
