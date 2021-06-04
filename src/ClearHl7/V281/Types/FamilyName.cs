using System.Linq;
using ClearHl7.Helpers;

namespace ClearHl7.V281.Types
{
    /// <summary>
    /// HL7 Version 2 FN - Family Name.
    /// </summary>
    public class FamilyName : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
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

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public FamilyName FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            Surname = segments.ElementAtOrDefault(0);
            OwnSurnamePrefix = segments.ElementAtOrDefault(1);
            OwnSurname = segments.ElementAtOrDefault(2);
            SurnamePrefixFromPartnerSpouse = segments.ElementAtOrDefault(3);
            SurnameFromPartnerSpouse = segments.ElementAtOrDefault(4);

            return this;
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
                                Surname,
                                OwnSurnamePrefix,
                                OwnSurname,
                                SurnamePrefixFromPartnerSpouse,
                                SurnameFromPartnerSpouse
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
