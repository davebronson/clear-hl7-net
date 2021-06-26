using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SLT - Sterilization Lot.
    /// </summary>
    public class SltSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "SLT";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public SltSegment FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            DeviceNumber = segments.Length > 1 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(1)) : null;
            DeviceName = segments.ElementAtOrDefault(2);
            LotNumber = segments.Length > 3 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(3)) : null;
            ItemIdentifier = segments.Length > 4 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(4)) : null;
            BarCode = segments.ElementAtOrDefault(5);
            
            return this;
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