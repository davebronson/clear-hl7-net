using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V281.Types
{
    /// <summary>
    /// HL7 Version 2 PIP - Practitioner Institutional Privileges.
    /// </summary>
    public class PractitionerInstitutionalPrivileges : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PractitionerInstitutionalPrivileges"/> class.
        /// </summary>
        public PractitionerInstitutionalPrivileges()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PractitionerInstitutionalPrivileges"/> class.
        /// </summary>
        /// <param name="privilege">PIP.1 - Privilege.</param>
        public PractitionerInstitutionalPrivileges(CodedWithExceptions privilege)
        {
            Privilege = privilege;
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(separator, StringSplitOptions.None);

            Privilege = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[0], true, seps) : null;
            PrivilegeClass = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], true, seps) : null;
            ExpirationDate = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDateTime() : null;
            ActivationDate = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
            Facility = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[4], true, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 5, separator),
                                Privilege?.ToDelimitedString(),
                                PrivilegeClass?.ToDelimitedString(),
                                ExpirationDate?.ToHl7DateTimeString(typeof(PractitionerInstitutionalPrivileges), nameof(ExpirationDate), Consts.DateFormatPrecisionDay, culture),
                                ActivationDate?.ToHl7DateTimeString(typeof(PractitionerInstitutionalPrivileges), nameof(ActivationDate), Consts.DateFormatPrecisionDay, culture),
                                Facility?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
