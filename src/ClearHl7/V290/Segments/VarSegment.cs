using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment VAR - Variance.
    /// </summary>
    public class VarSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "VAR";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// VAR.1 - Variance Instance ID.
        /// </summary>
        public EntityIdentifier VarianceInstanceId { get; set; }

        /// <summary>
        /// VAR.2 - Documented Date/Time.
        /// </summary>
        public DateTime? DocumentedDateTime { get; set; }

        /// <summary>
        /// VAR.3 - Stated Variance Date/Time.
        /// </summary>
        public DateTime? StatedVarianceDateTime { get; set; }

        /// <summary>
        /// VAR.4 - Variance Originator.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> VarianceOriginator { get; set; }

        /// <summary>
        /// VAR.5 - Variance Classification.
        /// </summary>
        public CodedWithExceptions VarianceClassification { get; set; }

        /// <summary>
        /// VAR.6 - Variance Description.
        /// </summary>
        public IEnumerable<string> VarianceDescription { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            VarianceInstanceId = segments.Length > 1 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(1), false) : null;
            DocumentedDateTime = segments.ElementAtOrDefault(2)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond) ;
            StatedVarianceDateTime = segments.ElementAtOrDefault(3)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            VarianceOriginator = segments.Length > 4 ? segments.ElementAtOrDefault(4).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            VarianceClassification = segments.Length > 5 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(5), false) : null;
            VarianceDescription = segments.Length > 6 ? segments.ElementAtOrDefault(6).Split(separator) : null;
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
                                VarianceInstanceId?.ToDelimitedString(),
                                DocumentedDateTime.HasValue ? DocumentedDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                StatedVarianceDateTime.HasValue ? StatedVarianceDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                VarianceOriginator != null ? string.Join(Configuration.FieldRepeatSeparator, VarianceOriginator.Select(x => x.ToDelimitedString())) : null,
                                VarianceClassification?.ToDelimitedString(),
                                VarianceDescription != null ? string.Join(Configuration.FieldRepeatSeparator, VarianceDescription) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}