using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V231.Types
{
    /// <summary>
    /// HL7 Version 2 SPS - Specimen Source.
    /// </summary>
    public class SpecimenSource : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecimenSource"/> class.
        /// </summary>
        public SpecimenSource()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecimenSource"/> class.
        /// </summary>
        /// <param name="specimenSourceNameOrCode">SPS.1 - Specimen Source Name or Code.</param>
        public SpecimenSource(CodedElement specimenSourceNameOrCode)
        {
            SpecimenSourceNameOrCode = specimenSourceNameOrCode;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// SPS.1 - Specimen Source Name or Code.
        /// <para>Suggested: 0070 Specimen Source Codes -&gt; ClearHl7.Codes.V231.CodeSpecimenSourceCodes</para>
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

            SpecimenSourceNameOrCode = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[0], true, seps) : null;
            Additives = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], true, seps) : null;
            SpecimenCollectionMethod = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[2], true, seps) : null;
            BodySite = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[3], true, seps) : null;
            SiteModifier = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[4], true, seps) : null;
            CollectionMethodModifierCode = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[5], true, seps) : null;
            SpecimenRole = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[6], true, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
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
