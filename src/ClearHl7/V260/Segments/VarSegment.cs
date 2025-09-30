using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment VAR - Variance.
    /// </summary>
    public class VarSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VarSegment"/> class.
        /// </summary>
        public VarSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VarSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public VarSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "VAR";

        /// <inheritdoc/>
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
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            VarianceInstanceId = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[1], false, seps) : null;
            DocumentedDateTime = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDateTime() : null;
            StatedVarianceDateTime = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
            VarianceOriginator = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            VarianceClassification = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[5], false, seps) : null;
            VarianceDescription = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 7, Configuration.FieldSeparator),
                                Id,
                                VarianceInstanceId?.ToDelimitedString(),
                                DocumentedDateTime?.ToHl7DateTimeString(typeof(VarSegment), nameof(DocumentedDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                StatedVarianceDateTime?.ToHl7DateTimeString(typeof(VarSegment), nameof(StatedVarianceDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                VarianceOriginator != null ? string.Join(Configuration.FieldRepeatSeparator, VarianceOriginator.Select(x => x.ToDelimitedString())) : null,
                                VarianceClassification?.ToDelimitedString(),
                                VarianceDescription != null ? string.Join(Configuration.FieldRepeatSeparator, VarianceDescription) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
