using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V281.Types
{
    /// <summary>
    /// HL7 Version 2 AUI - Authorization Information.
    /// </summary>
    public class AuthorizationInformation : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationInformation"/> class.
        /// </summary>
        public AuthorizationInformation()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationInformation"/> class.
        /// </summary>
        /// <param name="authorizationNumber">AUI.1 - Authorization Number.</param>
        public AuthorizationInformation(string authorizationNumber)
        {
            AuthorizationNumber = authorizationNumber;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// AUI.1 - Authorization Number.
        /// </summary>
        public string AuthorizationNumber { get; set; }

        /// <summary>
        /// AUI.2 - Date.
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// AUI.3 - Source.
        /// </summary>
        public string Source { get; set; }

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

            AuthorizationNumber = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            Date = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDateTime() : null;
            Source = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, separator),
                                AuthorizationNumber,
                                Date?.ToHl7DateTimeString(typeof(AuthorizationInformation), nameof(Date), Consts.DateFormatPrecisionDay, culture),
                                Source
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
