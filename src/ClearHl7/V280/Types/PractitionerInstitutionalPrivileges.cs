using System;
using ClearHl7.Helpers;

namespace ClearHl7.V280.Types
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
        /// <para>Suggested: 0525 Privilege</para>
        /// </summary>
        public CodedWithExceptions Privilege { get; set; }

        /// <summary>
        /// PIP.2 - Privilege Class.
        /// <para>Suggested: 0526 Privilege Class</para>
        /// </summary>
        public CodedWithExceptions PrivilegeClass { get; set; }

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
