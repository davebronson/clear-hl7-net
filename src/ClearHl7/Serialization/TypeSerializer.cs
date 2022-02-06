using System;

namespace ClearHl7.Serialization
{
    /// <summary>
    /// Provides serialization methods for HL7 Types.
    /// </summary>
    public static class TypeSerializer
    {
        /// <summary>
        /// Parses the text representing a single Type value into an instance of a specified type.
        /// </summary>
        /// <typeparam name="T">The target type of the string value.</typeparam>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="isSubcomponent">A boolean value that indicates whether this instance is a subcomponent of another HL7 component instance.</param>
        /// <returns>An instance of type T.</returns>
        /// <exception cref="ArgumentNullException">delimitedString is null.</exception>
        public static T Deserialize<T>(string delimitedString, bool isSubcomponent) where T : class, IType
        {
            if (string.IsNullOrEmpty(delimitedString))
            {
                throw new ArgumentNullException(nameof(delimitedString), $"{ nameof(delimitedString) } is null.");
            }

            return Deserialize<T>(delimitedString, isSubcomponent, null);
        }

        /// <summary>
        /// Parses the text representing a single Type value into an instance of a specified type.
        /// </summary>
        /// <typeparam name="T">The target type of the string value.</typeparam>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="isSubcomponent">A boolean value that indicates whether this instance is a subcomponent of another HL7 component instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <returns>An instance of type T.</returns>
        /// <exception cref="ArgumentNullException">delimitedString is null.</exception>
        public static T Deserialize<T>(string delimitedString, bool isSubcomponent, Separators separators) where T : class, IType
        {
            if (string.IsNullOrEmpty(delimitedString))
            {
                throw new ArgumentNullException(nameof(delimitedString), $"{ nameof(delimitedString) } is null.");
            }

            T item = Activator.CreateInstance<T>();
            item.IsSubcomponent = isSubcomponent;
            item.FromDelimitedString(delimitedString, separators);

            return item;
        }

        /// <summary>
        /// Converts the value of a specified Type into a string.
        /// </summary>
        /// <param name="type">The Type to convert.</param>
        /// <returns>A string.</returns>
        /// <exception cref="ArgumentNullException">value is null.</exception>
        public static string Serialize(IType type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type), $"{ nameof(type) } is null.");
            }

            return type.ToDelimitedString();
        }
    }
}
