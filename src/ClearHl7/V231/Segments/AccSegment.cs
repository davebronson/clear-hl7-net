using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ACC - Accident.
    /// </summary>
    public class AccSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ACC";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ACC.1 - Accident Date/Time.
        /// </summary>
        public DateTime? AccidentDateTime { get; set; }

        /// <summary>
        /// ACC.2 - Accident Code.
        /// <para>Suggested: 0050 Accident Code</para>
        /// </summary>
        public CodedElement AccidentCode { get; set; }

        /// <summary>
        /// ACC.3 - Accident Location.
        /// </summary>
        public string AccidentLocation { get; set; }

        /// <summary>
        /// ACC.4 - Auto Accident State.
        /// <para>Suggested: 0347 State/Province</para>
        /// </summary>
        public CodedElement AutoAccidentState { get; set; }

        /// <summary>
        /// ACC.5 - Accident Job Related Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string AccidentJobRelatedIndicator { get; set; }

        /// <summary>
        /// ACC.6 - Accident Death Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string AccidentDeathIndicator { get; set; }

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

            AccidentDateTime = segments.ElementAtOrDefault(1)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            AccidentCode = segments.Length > 2 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(2), false) : null;
            AccidentLocation = segments.ElementAtOrDefault(3);
            AutoAccidentState = segments.Length > 4 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(4), false) : null;
            AccidentJobRelatedIndicator = segments.ElementAtOrDefault(5);
            AccidentDeathIndicator = segments.ElementAtOrDefault(6);
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
                                StringHelper.StringFormatSequence(0, 7, Configuration.FieldSeparator),
                                Id,
                                AccidentDateTime.HasValue ? AccidentDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                AccidentCode?.ToDelimitedString(),
                                AccidentLocation,
                                AutoAccidentState?.ToDelimitedString(),
                                AccidentJobRelatedIndicator,
                                AccidentDeathIndicator
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}