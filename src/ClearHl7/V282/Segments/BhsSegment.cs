using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
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
        internal void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            BatchFieldSeparator = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            BatchEncodingCharacters = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            BatchSendingApplication = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[3], false) : null;
            BatchSendingFacility = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[4], false) : null;
            BatchReceivingApplication = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[5], false) : null;
            BatchReceivingFacility = segments.Length > 6 && segments[6].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[6], false) : null;
            BatchCreationDateTime = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            BatchSecurity = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            BatchNameIdType = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            BatchComment = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            BatchControlId = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            ReferenceBatchControlId = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            BatchSendingNetworkAddress = segments.Length > 13 && segments[13].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[13], false) : null;
            BatchReceivingNetworkAddress = segments.Length > 14 && segments[14].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[14], false) : null;
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