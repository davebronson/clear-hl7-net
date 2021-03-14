using ClearHl7.Helpers;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RXR - Pharmacy Treatment Route.
    /// </summary>
    public class RxrSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RXR";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// RXR.1 - Route.
        /// <para>Suggested: 0162 Route Of Administration -&gt; ClearHl7.Codes.V231.CodeRouteOfAdministration</para>
        /// </summary>
        public CodedElement Route { get; set; }

        /// <summary>
        /// RXR.2 - Administration Site.
        /// <para>Suggested: 0163 Body Site -&gt; ClearHl7.Codes.V231.CodeBodySite</para>
        /// </summary>
        public CodedElement AdministrationSite { get; set; }

        /// <summary>
        /// RXR.3 - Administration Device.
        /// <para>Suggested: 0164 Administration Device -&gt; ClearHl7.Codes.V231.CodeAdministrationDevice</para>
        /// </summary>
        public CodedElement AdministrationDevice { get; set; }

        /// <summary>
        /// RXR.4 - Administration Method.
        /// <para>Suggested: 0165 Administration Method -&gt; ClearHl7.Codes.V231.CodeAdministrationMethod</para>
        /// </summary>
        public CodedElement AdministrationMethod { get; set; }

        /// <summary>
        /// RXR.5 - Routing Instruction.
        /// </summary>
        public CodedElement RoutingInstruction { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 6, Configuration.FieldSeparator),
                                Id,
                                Route?.ToDelimitedString(),
                                AdministrationSite?.ToDelimitedString(),
                                AdministrationDevice?.ToDelimitedString(),
                                AdministrationMethod?.ToDelimitedString(),
                                RoutingInstruction?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}