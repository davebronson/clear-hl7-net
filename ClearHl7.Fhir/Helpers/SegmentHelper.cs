using System;
using System.Linq;
using System.Collections;
using System.Reflection;

namespace ClearHl7.Fhir.Helpers
{
    /// <summary>
    /// Provides helper methods for interacting with HL7 Segments.
    /// </summary>
    public class SegmentHelper : ISegmentHelper
    {
        /// <summary>
        /// Sets the IsSubcomponent property for any HL7 objects that are nested at the subcomponent level.
        /// </summary>
        /// <param name="segment">The Segment to traverse.</param>
        /// <remarks>
        /// HL7 objects at the subcomponent level require a field delimiter that differs from that at the field and component
        /// levels.  This method detects objects in a given Segment's hierarchy that exist at this subcomponent
        /// level, and sets their IsSubcomponent property to true so that they utilize the correct delimiter
        /// when ToDelimitedString() is called.
        /// </remarks>
        public void SetSubcomponentFlags(ISegment segment)
        {
            SetSubcomponentFlagsRecursive(segment, 0);
        }

        /// <summary>
        /// Recursively traverses down through a Segment and sets the IsSubcomponent property for any HL7 objects that are nested at the subcomponent level.
        /// </summary>
        /// <param name="obj">The object instance to traverse.</param>
        /// <param name="nestingLevel">The current nesting level.  Initial calls to this method should pass 0 (zero).</param>
        private void SetSubcomponentFlagsRecursive(object obj, int nestingLevel)
        {
            if (obj == null)
            {
                return;
            }

            Type objectType = obj.GetType();
            PropertyInfo[] objectProperties = objectType.GetProperties();

            if (nestingLevel > 1)
            {
                obj.GetType().GetProperty("IsSubcomponent", BindingFlags.Public | BindingFlags.Instance)?.SetValue(obj, true, null);

                // At the deepest level, so no need to continue searching for deeper levels within the current object.
                return;
            }

            foreach (PropertyInfo property in objectProperties)
            {
                object propertyValue = property.GetValue(obj, null);

                if (propertyValue is IList list)
                {
                    foreach (IType item in list.OfType<IType>())
                    {
                        SetSubcomponentFlagsRecursive(item, nestingLevel + 1);
                    }
                }
                else
                {
                    if (property.PropertyType.Assembly == objectType.Assembly)
                    {
                        SetSubcomponentFlagsRecursive(propertyValue, nestingLevel + 1);
                    }
                }
            }
        }
    }
}
