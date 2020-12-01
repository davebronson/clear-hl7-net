using System;
using ClearHl7.Fhir.Helpers;

namespace ClearHl7.Fhir.V280.Types
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
        /// <remarks>https://www.hl7.org/fhir/v2/0525</remarks>
        public CodedWithExceptions Privilege { get; set; }

        /// <summary>
        /// PIP.2 - Privilege Class.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0526</remarks>
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
