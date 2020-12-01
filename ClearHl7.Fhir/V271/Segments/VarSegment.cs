using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V271.Types;

namespace ClearHl7.Fhir.V271.Segments
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
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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