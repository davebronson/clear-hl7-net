using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment BHS - Batch Header.
    /// </summary>
    public class BhsSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "BHS";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// BHS.1 - Batch Field Separator.
        /// </summary>
        public string BatchFieldSeparator { get; set; }

        /// <summary>
        /// BHS.2 - Batch Encoding Characters.
        /// </summary>
        public string BatchEncodingCharacters { get; set; }

        /// <summary>
        /// BHS.3 - Batch Sending Application.
        /// </summary>
        public HierarchicDesignator BatchSendingApplication { get; set; }

        /// <summary>
        /// BHS.4 - Batch Sending Facility.
        /// </summary>
        public HierarchicDesignator BatchSendingFacility { get; set; }

        /// <summary>
        /// BHS.5 - Batch Receiving Application.
        /// </summary>
        public HierarchicDesignator BatchReceivingApplication { get; set; }

        /// <summary>
        /// BHS.6 - Batch Receiving Facility.
        /// </summary>
        public HierarchicDesignator BatchReceivingFacility { get; set; }

        /// <summary>
        /// BHS.7 - Batch Creation Date/Time.
        /// </summary>
        public DateTime? BatchCreationDateTime { get; set; }

        /// <summary>
        /// BHS.8 - Batch Security.
        /// </summary>
        public string BatchSecurity { get; set; }

        /// <summary>
        /// BHS.9 - Batch Name/ID/Type.
        /// </summary>
        public string BatchNameIdType { get; set; }

        /// <summary>
        /// BHS.10 - Batch Comment.
        /// </summary>
        public string BatchComment { get; set; }

        /// <summary>
        /// BHS.11 - Batch Control ID.
        /// </summary>
        public string BatchControlId { get; set; }

        /// <summary>
        /// BHS.12 - Reference Batch Control ID.
        /// </summary>
        public string ReferenceBatchControlId { get; set; }

        /// <summary>
        /// BHS.13 - Batch Sending Network Address.
        /// </summary>
        public HierarchicDesignator BatchSendingNetworkAddress { get; set; }

        /// <summary>
        /// BHS.14 - Batch Receiving Network Address.
        /// </summary>
        public HierarchicDesignator BatchReceivingNetworkAddress { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            BatchFieldSeparator = segments.ElementAtOrDefault(1);
            BatchEncodingCharacters = segments.ElementAtOrDefault(2);
            BatchSendingApplication = segments.Length > 3 ? TypeHelper.Deserialize<HierarchicDesignator>(segments.ElementAtOrDefault(3), false) : null;
            BatchSendingFacility = segments.Length > 4 ? TypeHelper.Deserialize<HierarchicDesignator>(segments.ElementAtOrDefault(4), false) : null;
            BatchReceivingApplication = segments.Length > 5 ? TypeHelper.Deserialize<HierarchicDesignator>(segments.ElementAtOrDefault(5), false) : null;
            BatchReceivingFacility = segments.Length > 6 ? TypeHelper.Deserialize<HierarchicDesignator>(segments.ElementAtOrDefault(6), false) : null;
            BatchCreationDateTime = segments.ElementAtOrDefault(7)?.ToNullableDateTime();
            BatchSecurity = segments.ElementAtOrDefault(8);
            BatchNameIdType = segments.ElementAtOrDefault(9);
            BatchComment = segments.ElementAtOrDefault(10);
            BatchControlId = segments.ElementAtOrDefault(11);
            ReferenceBatchControlId = segments.ElementAtOrDefault(12);
            BatchSendingNetworkAddress = segments.Length > 13 ? TypeHelper.Deserialize<HierarchicDesignator>(segments.ElementAtOrDefault(13), false) : null;
            BatchReceivingNetworkAddress = segments.Length > 14 ? TypeHelper.Deserialize<HierarchicDesignator>(segments.ElementAtOrDefault(14), false) : null;
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
                                StringHelper.StringFormatSequence(0, 15, Configuration.FieldSeparator),
                                Id,
                                BatchFieldSeparator,
                                BatchEncodingCharacters,
                                BatchSendingApplication?.ToDelimitedString(),
                                BatchSendingFacility?.ToDelimitedString(),
                                BatchReceivingApplication?.ToDelimitedString(),
                                BatchReceivingFacility?.ToDelimitedString(),
                                BatchCreationDateTime.HasValue ? BatchCreationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                BatchSecurity,
                                BatchNameIdType,
                                BatchComment,
                                BatchControlId,
                                ReferenceBatchControlId,
                                BatchSendingNetworkAddress?.ToDelimitedString(),
                                BatchReceivingNetworkAddress?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}