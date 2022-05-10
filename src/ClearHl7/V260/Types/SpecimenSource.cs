using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V260.Types
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
        public SpecimenSource(CodedWithExceptions specimenSourceNameOrCode)
        {
            SpecimenSourceNameOrCode = specimenSourceNameOrCode;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// SPS.1 - Specimen Source Name or Code.
        /// </summary>
        public CodedWithExceptions SpecimenSourceNameOrCode { get; set; }

        /// <summary>
        /// SPS.2 - Additives.
        /// <para>Suggested: 0371 Additive/Preservative -&gt; ClearHl7.Codes.V260.CodeAdditivePreservative</para>
        /// </summary>
        public CodedWithExceptions Additives { get; set; }

        /// <summary>
        /// SPS.3 - Specimen Collection Method.
        /// </summary>
        public Text SpecimenCollectionMethod { get; set; }

        /// <summary>
        /// SPS.4 - Body Site.
        /// <para>Suggested: 0163 Body Site -&gt; ClearHl7.Codes.V260.CodeBodySite</para>
        /// </summary>
        public CodedWithExceptions BodySite { get; set; }

        /// <summary>
        /// SPS.5 - Site Modifier.
        /// <para>Suggested: 0495 Body Site Modifier -&gt; ClearHl7.Codes.V260.CodeBodySiteModifier</para>
        /// </summary>
        public CodedWithExceptions SiteModifier { get; set; }

        /// <summary>
        /// SPS.6 - Collection Method Modifier Code.
        /// </summary>
        public CodedWithExceptions CollectionMethodModifierCode { get; set; }

        /// <summary>
        /// SPS.7 - Specimen Role.
        /// <para>Suggested: 0369 Specimen Role -&gt; ClearHl7.Codes.V260.CodeSpecimenRole</para>
        /// </summary>
        public CodedWithExceptions SpecimenRole { get; set; }

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

            SpecimenSourceNameOrCode = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[0], true, seps) : null;
            Additives = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], true, seps) : null;
            SpecimenCollectionMethod = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[2], true, seps) : null;
            BodySite = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[3], true, seps) : null;
            SiteModifier = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[4], true, seps) : null;
            CollectionMethodModifierCode = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[5], true, seps) : null;
            SpecimenRole = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[6], true, seps) : null;
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
