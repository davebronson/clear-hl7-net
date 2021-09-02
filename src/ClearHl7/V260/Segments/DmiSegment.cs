using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment DMI - Drg Master File Information.
    /// </summary>
    public class DmiSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "DMI";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// DMI.1 - Diagnostic Related Group.
        /// <para>Suggested: 0055 Diagnosis Related Group</para>
        /// </summary>
        public CodedWithNoExceptions DiagnosticRelatedGroup { get; set; }

        /// <summary>
        /// DMI.2 - Major Diagnostic Category.
        /// <para>Suggested: 0118 Major Diagnostic Category</para>
        /// </summary>
        public CodedWithNoExceptions MajorDiagnosticCategory { get; set; }

        /// <summary>
        /// DMI.3 - Lower and Upper Trim Points.
        /// </summary>
        public NumericRange LowerAndUpperTrimPoints { get; set; }

        /// <summary>
        /// DMI.4 - Average Length of Stay.
        /// </summary>
        public decimal? AverageLengthOfStay { get; set; }

        /// <summary>
        /// DMI.5 - Relative Weight.
        /// </summary>
        public decimal? RelativeWeight { get; set; }

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

            DiagnosticRelatedGroup = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[1], false, seps) : null;
            MajorDiagnosticCategory = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[2], false, seps) : null;
            LowerAndUpperTrimPoints = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<NumericRange>(segments[3], false, seps) : null;
            AverageLengthOfStay = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDecimal() : null;
            RelativeWeight = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDecimal() : null;
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
                                DiagnosticRelatedGroup?.ToDelimitedString(),
                                MajorDiagnosticCategory?.ToDelimitedString(),
                                LowerAndUpperTrimPoints?.ToDelimitedString(),
                                AverageLengthOfStay.HasValue ? AverageLengthOfStay.Value.ToString(Consts.NumericFormat, culture) : null,
                                RelativeWeight.HasValue ? RelativeWeight.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}