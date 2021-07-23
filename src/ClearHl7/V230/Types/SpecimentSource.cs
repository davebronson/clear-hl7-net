using System.Linq;
using ClearHl7.Helpers;

namespace ClearHl7.V230.Types
{
    /// <summary>
    /// HL7 Version 2 SPS - Speciment Source.
    /// </summary>
    public class SpecimentSource : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// SPS.1 - Specimen Source Name or Code.
        /// </summary>
        public CodedElement SpecimenSourceNameOrCode { get; set; }

        /// <summary>
        /// SPS.2 - Additives.
        /// </summary>
        public CodedWithExceptions Additives { get; set; }

        /// <summary>
        /// SPS.3 - Specimen Collection Method.
        /// </summary>
        public Text SpecimenCollectionMethod { get; set; }

        /// <summary>
        /// SPS.4 - Body Site.
        /// </summary>
        public CodedElement BodySite { get; set; }

        /// <summary>
        /// SPS.5 - Site Modifier.
        /// </summary>
        public CodedElement SiteModifier { get; set; }

        /// <summary>
        /// SPS.6 - Collection Method Modifier Code.
        /// </summary>
        public CodedElement CollectionMethodModifierCode { get; set; }

        /// <summary>
        /// SPS.7 - Specimen Role.
        /// </summary>
        public CodedElement SpecimenRole { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            SpecimenSourceNameOrCode = segments.Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(0), true) : null;
            Additives = segments.Length > 1 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(1), true) : null;
            SpecimenCollectionMethod = segments.Length > 2 ? TypeHelper.Deserialize<Text>(segments.ElementAtOrDefault(2), true) : null;
            BodySite = segments.Length > 3 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(3), true) : null;
            SiteModifier = segments.Length > 4 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(4), true) : null;
            CollectionMethodModifierCode = segments.Length > 5 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(5), true) : null;
            SpecimenRole = segments.Length > 6 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(6), true) : null;
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
                                SpecimenSourceNameOrCode?.ToDelimitedString(),
                                Additives?.ToDelimitedString(),
                                SpecimenCollectionMethod?.ToDelimitedString(),
                                BodySite?.ToDelimitedString(),
                                SiteModifier?.ToDelimitedString(),
                                CollectionMethodModifierCode?.ToDelimitedString(),
                                SpecimenRole?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
