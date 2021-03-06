﻿using ClearHl7.Helpers;

namespace ClearHl7.V290.Types
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
        /// <para>Suggested: 0001 Administrative Sex -&gt; ClearHl7.Codes.V290.CodeAdministrativeSex</para>
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
