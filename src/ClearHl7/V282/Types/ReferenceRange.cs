using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V282.Types
{
    /// <summary>
    /// HL7 Version 2 RFR - Reference Range.
    /// </summary>
    public class ReferenceRange : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceRange"/> class.
        /// </summary>
        public ReferenceRange()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceRange"/> class.
        /// </summary>
        /// <param name="numericRange">RFR.1 - Numeric Range.</param>
        public ReferenceRange(NumericRange numericRange)
        {
            NumericRange = numericRange;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// RFR.1 - Numeric Range.
        /// </summary>
        public NumericRange NumericRange { get; set; }

        /// <summary>
        /// RFR.2 - Administrative Sex.
        /// <para>Suggested: 0001 Administrative Sex -&gt; ClearHl7.Codes.V282.CodeAdministrativeSex</para>
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

            NumericRange = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<NumericRange>(segments[0], true, seps) : null;
            AdministrativeSex = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], true, seps) : null;
            AgeRange = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<NumericRange>(segments[2], true, seps) : null;
            GestationalAgeRange = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<NumericRange>(segments[3], true, seps) : null;
            Species = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            RaceSubspecies = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            Conditions = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[6], true, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
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
