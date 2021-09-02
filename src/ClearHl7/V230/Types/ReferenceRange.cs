using System;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

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
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(separator, StringSplitOptions.None);

            NumericRange = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<NumericRange>(segments[0], true, seps) : null;
            AdministrativeSex = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            AgeRange = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<NumericRange>(segments[2], true, seps) : null;
            GestationalAgeRange = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<NumericRange>(segments[3], true, seps) : null;
            Species = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            RaceSubspecies = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            Conditions = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[6], true, seps) : null;
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
