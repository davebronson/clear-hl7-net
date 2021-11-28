using System;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V250.Types
{
    /// <summary>
    /// HL7 Version 2 PLN - Practitioner License Or Other Id Number.
    /// </summary>
    public class PractitionerLicenseOrOtherIdNumber : IType
    {
        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// PLN.1 - ID Number.
        /// </summary>
        public string IdNumber { get; set; }

        /// <summary>
        /// PLN.2 - Type of ID Number.
        /// <para>Suggested: 0338 Practitioner ID Number Type -&gt; ClearHl7.Codes.V250.CodePractitionerIdNumberType</para>
        /// </summary>
        public string TypeOfIdNumber { get; set; }

        /// <summary>
        /// PLN.3 - State/other Qualifying Information.
        /// </summary>
        public string StateOtherQualifyingInformation { get; set; }

        /// <summary>
        /// PLN.4 - Expiration Date.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

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

            IdNumber = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            TypeOfIdNumber = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            StateOtherQualifyingInformation = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            ExpirationDate = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, separator),
                                IdNumber,
                                TypeOfIdNumber,
                                StateOtherQualifyingInformation,
                                ExpirationDate.HasValue ? ExpirationDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
