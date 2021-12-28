using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SID - Substance Identifier.
    /// </summary>
    public class SidSegment : ISegment
    {
        /// <inheritdoc/>
        public string Id { get; } = "SID";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// SID.1 - Application/Method Identifier.
        /// </summary>
        public CodedWithExceptions ApplicationMethodIdentifier { get; set; }

        /// <summary>
        /// SID.2 - Substance Lot Number.
        /// </summary>
        public string SubstanceLotNumber { get; set; }

        /// <summary>
        /// SID.3 - Substance Container Identifier.
        /// </summary>
        public string SubstanceContainerIdentifier { get; set; }

        /// <summary>
        /// SID.4 - Substance Manufacturer Identifier.
        /// <para>Suggested: 0385 Manufacturer Identifier</para>
        /// </summary>
        public CodedWithExceptions SubstanceManufacturerIdentifier { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
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

            ApplicationMethodIdentifier = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], false, seps) : null;
            SubstanceLotNumber = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            SubstanceContainerIdentifier = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            SubstanceManufacturerIdentifier = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[4], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator),
                                Id,
                                ApplicationMethodIdentifier?.ToDelimitedString(),
                                SubstanceLotNumber,
                                SubstanceContainerIdentifier,
                                SubstanceManufacturerIdentifier?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
