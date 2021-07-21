using System.Linq;
using ClearHl7.Helpers;

namespace ClearHl7.V271.Types
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
        /// <para>Suggested: 0001 Administrative Sex -&gt; ClearHl7.Codes.V271.CodeAdministrativeSex</para>
        /// </summary>
        public CodedWithExceptions AdministrativeSex { get; set; }

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

            if (segments.Length > 0)
            {
                NumericRange = new NumericRange { IsSubcomponent = true };
                NumericRange.FromDelimitedString(segments.ElementAtOrDefault(0));
            }
            else
            {
                NumericRange = null;
            }

            if (segments.Length > 1)
            {
                AdministrativeSex = new CodedWithExceptions { IsSubcomponent = true };
                AdministrativeSex.FromDelimitedString(segments.ElementAtOrDefault(1));
            }
            else
            {
                AdministrativeSex = null;
            }

            if (segments.Length > 2)
            {
                AgeRange = new NumericRange { IsSubcomponent = true };
                AgeRange.FromDelimitedString(segments.ElementAtOrDefault(2));
            }
            else
            {
                AgeRange = null;
            }

            if (segments.Length > 3)
            {
                GestationalAgeRange = new NumericRange { IsSubcomponent = true };
                GestationalAgeRange.FromDelimitedString(segments.ElementAtOrDefault(3));
            }
            else
            {
                GestationalAgeRange = null;
            }

            Species = segments.ElementAtOrDefault(4);
            RaceSubspecies = segments.ElementAtOrDefault(5);

            if (segments.Length > 6)
            {
                Conditions = new Text { IsSubcomponent = true };
                Conditions.FromDelimitedString(segments.ElementAtOrDefault(6));
            }
            else
            {
                Conditions = null;
            }
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
                                AdministrativeSex?.ToDelimitedString(),
                                AgeRange?.ToDelimitedString(),
                                GestationalAgeRange?.ToDelimitedString(),
                                Species,
                                RaceSubspecies,
                                Conditions?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
