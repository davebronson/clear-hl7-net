using System.Linq;
using ClearHl7.Helpers;

namespace ClearHl7.V230.Types
{
    /// <summary>
    /// HL7 Version 2 RFR - Reference Range.
    /// </summary>
    public class ReferenceRange : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// RFR.1 - Numeric Range.
        /// </summary>
        public NumericRange NumericRange { get; set; }

        /// <summary>
        /// RFR.2 - Administrative Sex.
        /// </summary>
        public string AdministrativeSex { get; set; }

        /// <summary>
        /// RFR.3 - Age Range.
        /// </summary>
        public NumericRange AgeRange { get; set; }

        /// <summary>
        /// RFR.4 - Gestational Age Range.
        /// </summary>
        public NumericRange GestationalAgeRange { get; set; }

        /// <summary>
        /// RFR.5 - Species.
        /// </summary>
        public string Species { get; set; }

        /// <summary>
        /// RFR.6 - Race/subspecies.
        /// </summary>
        public string RaceSubspecies { get; set; }

        /// <summary>
        /// RFR.7 - Conditions.
        /// </summary>
        public Text Conditions { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            NumericRange = segments.Length > 0 ? TypeHelper.Deserialize<NumericRange>(segments.ElementAtOrDefault(0), true) : null;
            AdministrativeSex = segments.ElementAtOrDefault(1);
            AgeRange = segments.Length > 2 ? TypeHelper.Deserialize<NumericRange>(segments.ElementAtOrDefault(2), true) : null;
            GestationalAgeRange = segments.Length > 3 ? TypeHelper.Deserialize<NumericRange>(segments.ElementAtOrDefault(3), true) : null;
            Species = segments.ElementAtOrDefault(4);
            RaceSubspecies = segments.ElementAtOrDefault(5);
            Conditions = segments.Length > 6 ? TypeHelper.Deserialize<Text>(segments.ElementAtOrDefault(6), true) : null;
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
                                StringHelper.StringFormatSequence(0, 7, separator),
                                NumericRange?.ToDelimitedString(),
                                AdministrativeSex,
                                AgeRange?.ToDelimitedString(),
                                GestationalAgeRange?.ToDelimitedString(),
                                Species,
                                RaceSubspecies,
                                Conditions?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
