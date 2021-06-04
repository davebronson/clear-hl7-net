﻿using System.Linq;
using ClearHl7.Helpers;

namespace ClearHl7.V260.Types
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

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public SpecimentSource FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            SpecimenSourceNameOrCode = segments.Length > 0 ? new CodedWithExceptions { IsSubcomponent = true }.FromDelimitedString(segments.ElementAtOrDefault(0)) : null;
            Additives = segments.Length > 1 ? new CodedWithExceptions { IsSubcomponent = true }.FromDelimitedString(segments.ElementAtOrDefault(1)) : null;
            SpecimenCollectionMethod = segments.Length > 2 ? new Text { IsSubcomponent = true }.FromDelimitedString(segments.ElementAtOrDefault(2)) : null;
            BodySite = segments.Length > 3 ? new CodedWithExceptions { IsSubcomponent = true }.FromDelimitedString(segments.ElementAtOrDefault(3)) : null;
            SiteModifier = segments.Length > 4 ? new CodedWithExceptions { IsSubcomponent = true }.FromDelimitedString(segments.ElementAtOrDefault(4)) : null;
            CollectionMethodModifierCode = segments.Length > 5 ? new CodedWithExceptions { IsSubcomponent = true }.FromDelimitedString(segments.ElementAtOrDefault(5)) : null;
            SpecimenRole = segments.Length > 6 ? new CodedWithExceptions { IsSubcomponent = true }.FromDelimitedString(segments.ElementAtOrDefault(6)) : null;

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
