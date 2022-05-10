using System;
using System.Globalization;
using ClearHl7.Helpers;

namespace ClearHl7.V280.Types
{
    /// <summary>
    /// HL7 Version 2 FN - Family Name.
    /// </summary>
    public class FamilyName : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FamilyName"/> class.
        /// </summary>
        public FamilyName()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FamilyName"/> class.
        /// </summary>
        /// <param name="surname">FN.1 - Surname.</param>
        public FamilyName(string surname)
        {
            Surname = surname;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// FN.1 - Surname.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// FN.2 - Own Surname Prefix.
        /// </summary>
        public string OwnSurnamePrefix { get; set; }

        /// <summary>
        /// FN.3 - Own Surname.
        /// </summary>
        public string OwnSurname { get; set; }

        /// <summary>
        /// FN.4 - Surname Prefix from Partner/Spouse.
        /// </summary>
        public string SurnamePrefixFromPartnerSpouse { get; set; }

        /// <summary>
        /// FN.5 - Surname from Partner/Spouse.
        /// </summary>
        public string SurnameFromPartnerSpouse { get; set; }

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

            Surname = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            OwnSurnamePrefix = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            OwnSurname = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            SurnamePrefixFromPartnerSpouse = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            SurnameFromPartnerSpouse = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 5, separator),
                                Surname,
                                OwnSurnamePrefix,
                                OwnSurname,
                                SurnamePrefixFromPartnerSpouse,
                                SurnameFromPartnerSpouse
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
