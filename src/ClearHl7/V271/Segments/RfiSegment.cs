using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RFI - Request For Information.
    /// </summary>
    public class RfiSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RFI";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// RFI.1 - Request Date.
        /// </summary>
        public DateTime? RequestDate { get; set; }

        /// <summary>
        /// RFI.2 - Response Due Date.
        /// </summary>
        public DateTime? ResponseDueDate { get; set; }

        /// <summary>
        /// RFI.3 - Patient Consent.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V271.CodeYesNoIndicator</para>
        /// </summary>
        public string PatientConsent { get; set; }

        /// <summary>
        /// RFI.4 - Date Additional Information Was Submitted.
        /// </summary>
        public DateTime? DateAdditionalInformationWasSubmitted { get; set; }

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

            RequestDate = segments.ElementAtOrDefault(1)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ResponseDueDate = segments.ElementAtOrDefault(2)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            PatientConsent = segments.ElementAtOrDefault(3);
            DateAdditionalInformationWasSubmitted = segments.ElementAtOrDefault(4)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
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
                                StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator),
                                Id,
                                RequestDate.HasValue ? RequestDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ResponseDueDate.HasValue ? ResponseDueDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PatientConsent,
                                DateAdditionalInformationWasSubmitted.HasValue ? DateAdditionalInformationWasSubmitted.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}