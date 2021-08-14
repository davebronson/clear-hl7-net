using System;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V231.Types
{
    /// <summary>
    /// HL7 Version 2 PIP - Practitioner Institutional Privileges.
    /// </summary>
    public class PractitionerInstitutionalPrivileges : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// PIP.1 - Privilege.
        /// </summary>
        public CodedElement Privilege { get; set; }

        /// <summary>
        /// PIP.2 - Privilege Class.
        /// </summary>
        public CodedElement PrivilegeClass { get; set; }

        /// <summary>
        /// PIP.3 - Expiration Date.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// PIP.4 - Activation Date.
        /// </summary>
        public DateTime? ActivationDate { get; set; }

        /// <summary>
        /// PIP.5 - Facility.
        /// </summary>
        public EntityIdentifier Facility { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            Privilege = segments.Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(0), true) : null;
            PrivilegeClass = segments.Length > 1 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(1), true) : null;
            ExpirationDate = segments.ElementAtOrDefault(2)?.ToNullableDateTime();
            ActivationDate = segments.ElementAtOrDefault(3)?.ToNullableDateTime();
            Facility = segments.Length > 4 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(4), true) : null;
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 5, separator),
                                Privilege?.ToDelimitedString(),
                                PrivilegeClass?.ToDelimitedString(),
                                ExpirationDate.HasValue ? ExpirationDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                ActivationDate.HasValue ? ActivationDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                Facility?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
