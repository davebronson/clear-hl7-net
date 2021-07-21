using System.Linq;
using ClearHl7.Helpers;

namespace ClearHl7.V251.Types
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
        public CodedWithExceptions SpecimenSourceNameOrCode { get; set; }

        /// <summary>
        /// SPS.2 - Additives.
        /// <para>Suggested: 0371 Additive/Preservative -&gt; ClearHl7.Codes.V251.CodeAdditivePreservative</para>
        /// </summary>
        public CodedWithExceptions Additives { get; set; }

        /// <summary>
        /// SPS.3 - Specimen Collection Method.
        /// </summary>
        public Text SpecimenCollectionMethod { get; set; }

        /// <summary>
        /// SPS.4 - Body Site.
        /// <para>Suggested: 0163 Body Site -&gt; ClearHl7.Codes.V251.CodeBodySite</para>
        /// </summary>
        public CodedWithExceptions BodySite { get; set; }

        /// <summary>
        /// SPS.5 - Site Modifier.
        /// <para>Suggested: 0495 Body Site Modifier -&gt; ClearHl7.Codes.V251.CodeBodySiteModifier</para>
        /// </summary>
        public CodedWithExceptions SiteModifier { get; set; }

        /// <summary>
        /// SPS.6 - Collection Method Modifier Code.
        /// </summary>
        public CodedWithExceptions CollectionMethodModifierCode { get; set; }

        /// <summary>
        /// SPS.7 - Specimen Role.
        /// <para>Suggested: 0369 Specimen Role -&gt; ClearHl7.Codes.V251.CodeSpecimenRole</para>
        /// </summary>
        public CodedWithExceptions SpecimenRole { get; set; }

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
                SpecimenSourceNameOrCode = new CodedWithExceptions { IsSubcomponent = true };
                SpecimenSourceNameOrCode.FromDelimitedString(segments.ElementAtOrDefault(0));
            }
            else
            {
                SpecimenSourceNameOrCode = null;
            }

            if (segments.Length > 1)
            {
                Additives = new CodedWithExceptions { IsSubcomponent = true };
                Additives.FromDelimitedString(segments.ElementAtOrDefault(1));
            }
            else
            {
                Additives = null;
            }

            if (segments.Length > 2)
            {
                SpecimenCollectionMethod = new Text { IsSubcomponent = true };
                SpecimenCollectionMethod.FromDelimitedString(segments.ElementAtOrDefault(2));
            }
            else
            {
                SpecimenCollectionMethod = null;
            }

            if (segments.Length > 3)
            {
                BodySite = new CodedWithExceptions { IsSubcomponent = true };
                BodySite.FromDelimitedString(segments.ElementAtOrDefault(3));
            }
            else
            {
                BodySite = null;
            }

            if (segments.Length > 4)
            {
                SiteModifier = new CodedWithExceptions { IsSubcomponent = true };
                SiteModifier.FromDelimitedString(segments.ElementAtOrDefault(4));
            }
            else
            {
                SiteModifier = null;
            }

            if (segments.Length > 5)
            {
                CollectionMethodModifierCode = new CodedWithExceptions { IsSubcomponent = true };
                CollectionMethodModifierCode.FromDelimitedString(segments.ElementAtOrDefault(5));
            }
            else
            {
                CollectionMethodModifierCode = null;
            }

            if (segments.Length > 6)
            {
                SpecimenRole = new CodedWithExceptions { IsSubcomponent = true };
                SpecimenRole.FromDelimitedString(segments.ElementAtOrDefault(6));
            }
            else
            {
                SpecimenRole = null;
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
