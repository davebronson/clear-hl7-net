using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RQ1 - Requisition Detail-1.
    /// </summary>
    public class Rq1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RQ1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// RQ1.1 - Anticipated Price.
        /// </summary>
        public string AnticipatedPrice { get; set; }

        /// <summary>
        /// RQ1.2 - Manufacturer Identifier.
        /// </summary>
        public CodedElement ManufacturerIdentifier { get; set; }

        /// <summary>
        /// RQ1.3 - Manufacturer's Catalog.
        /// </summary>
        public string ManufacturersCatalog { get; set; }

        /// <summary>
        /// RQ1.4 - Vendor ID.
        /// </summary>
        public CodedElement VendorId { get; set; }

        /// <summary>
        /// RQ1.5 - Vendor Catalog.
        /// </summary>
        public string VendorCatalog { get; set; }

        /// <summary>
        /// RQ1.6 - Taxable.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string Taxable { get; set; }

        /// <summary>
        /// RQ1.7 - Substitute Allowed.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string SubstituteAllowed { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            AnticipatedPrice = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            ManufacturerIdentifier = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[2], false, seps) : null;
            ManufacturersCatalog = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            VendorId = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[4], false, seps) : null;
            VendorCatalog = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            Taxable = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            SubstituteAllowed = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 8, Configuration.FieldSeparator),
                                Id,
                                AnticipatedPrice,
                                ManufacturerIdentifier?.ToDelimitedString(),
                                ManufacturersCatalog,
                                VendorId?.ToDelimitedString(),
                                VendorCatalog,
                                Taxable,
                                SubstituteAllowed
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}