using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SLT - Sterilization Lot.
    /// </summary>
    public class SltSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SltSegment"/> class.
        /// </summary>
        public SltSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SltSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public SltSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "SLT";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// SLT.1 - Device Number.
        /// </summary>
        public EntityIdentifier DeviceNumber { get; set; }

        /// <summary>
        /// SLT.2 - Device Name.
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// SLT.3 - Lot Number.
        /// </summary>
        public EntityIdentifier LotNumber { get; set; }

        /// <summary>
        /// SLT.4 - Item Identifier.
        /// </summary>
        public EntityIdentifier ItemIdentifier { get; set; }

        /// <summary>
        /// SLT.5 - Bar Code.
        /// </summary>
        public string BarCode { get; set; }

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

            DeviceNumber = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[1], false, seps) : null;
            DeviceName = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            LotNumber = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[3], false, seps) : null;
            ItemIdentifier = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[4], false, seps) : null;
            BarCode = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 6, Configuration.FieldSeparator),
                                Id,
                                DeviceNumber?.ToDelimitedString(),
                                DeviceName,
                                LotNumber?.ToDelimitedString(),
                                ItemIdentifier?.ToDelimitedString(),
                                BarCode
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
