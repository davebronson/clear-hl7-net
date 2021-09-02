using System;

namespace ClearHl7.Serialization
{
    /// <summary>
    /// Provides serialization methods for HL7 Types.
    /// </summary>
    public static class TypeSerializer
    {
        /// <summary>
        /// Returns a new instance of type T with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="isSubcomponent">A boolean value that indicates whether this instance is a subcomponent of another HL7 component instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <returns>An instance of type T if delimitedString is not null or empty.  Otherwise, null.</returns>
        public static T Deserialize<T>(string delimitedString, bool isSubcomponent, Separators separators) where T : class, IType
        {
            if (string.IsNullOrEmpty(delimitedString))
            {
                return null;
            }
            else
            {
                T item = Activator.CreateInstance<T>();
                item.IsSubcomponent = isSubcomponent;
                item.FromDelimitedString(delimitedString, separators);

                return item;
            }
        }
    }
}
