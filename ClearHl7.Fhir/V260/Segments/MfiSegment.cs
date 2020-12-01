using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V260.Types;

namespace ClearHl7.Fhir.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment MFI - Master File Identification.
    /// </summary>
    public class MfiSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "MFI";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// MFI.1 - Master File Identifier.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0175</remarks>
        public CodedWithExceptions MasterFileIdentifier { get; set; }

        /// <summary>
        /// MFI.2 - Master File Application Identifier.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0361</remarks>
        public IEnumerable<HierarchicDesignator> MasterFileApplicationIdentifier { get; set; }

        /// <summary>
        /// MFI.3 - File-Level Event Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0178</remarks>
        public string FileLevelEventCode { get; set; }

        /// <summary>
        /// MFI.4 - Entered Date/Time.
        /// </summary>
        public DateTime? EnteredDateTime { get; set; }

        /// <summary>
        /// MFI.5 - Effective Date/Time.
        /// </summary>
        public DateTime? EffectiveDateTime { get; set; }

        /// <summary>
        /// MFI.6 - Response Level Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0179</remarks>
        public string ResponseLevelCode { get; set; }
        
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
                                MasterFileIdentifier?.ToDelimitedString(),
                                MasterFileApplicationIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, MasterFileApplicationIdentifier.Select(x => x.ToDelimitedString())) : null,
                                FileLevelEventCode,
                                EnteredDateTime.HasValue ? EnteredDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EffectiveDateTime.HasValue ? EffectiveDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ResponseLevelCode
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}