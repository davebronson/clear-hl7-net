using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V230.Types
{
    /// <summary>
    /// HL7 Version 2 PCF - Pre-Certification Required.
    /// </summary>
    public class PreCertificationRequired : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreCertificationRequired"/> class.
        /// </summary>
        public PreCertificationRequired()
        {

        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// PCF.1 - Pre-certification Patient Type.
        /// </summary>
        public string PreCertificationPatientType { get; set; }

        /// <summary>
        /// PCF.2 - Pre-Certification Required.
        /// </summary>
        public string PreCertificationIsRequired { get; set; }

        /// <summary>
        /// PCF.3 - Pre-certification Window.
        /// </summary>
        public DateTime? PreCertificationWindow { get; set; }

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

            PreCertificationPatientType = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            PreCertificationIsRequired = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            PreCertificationWindow = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDateTime() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, separator),
                                PreCertificationPatientType,
                                PreCertificationIsRequired,
                                PreCertificationWindow?.ToHl7DateTimeString(typeof(PreCertificationRequired), nameof(PreCertificationWindow), Consts.DateTimeFormatPrecisionSecond, culture)
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
