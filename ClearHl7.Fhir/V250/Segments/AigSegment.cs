using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V250.Types;

namespace ClearHl7.Fhir.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment AIG - Appointment Information - General Resource.
    /// </summary>
    public class AigSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "AIG";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// AIG.1 - Set ID - AIG.
        /// </summary>
        public uint? SetIdAig { get; set; }

        /// <summary>
        /// AIG.2 - Segment Action Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0206</remarks>
        public string SegmentActionCode { get; set; }

        /// <summary>
        /// AIG.3 - Resource ID.
        /// </summary>
        public CodedElement ResourceId { get; set; }

        /// <summary>
        /// AIG.4 - Resource Type.
        /// </summary>
        public CodedElement ResourceType { get; set; }

        /// <summary>
        /// AIG.5 - Resource Group.
        /// </summary>
        public IEnumerable<CodedElement> ResourceGroup { get; set; }

        /// <summary>
        /// AIG.6 - Resource Quantity.
        /// </summary>
        public decimal? ResourceQuantity { get; set; }

        /// <summary>
        /// AIG.7 - Resource Quantity Units.
        /// </summary>
        public CodedElement ResourceQuantityUnits { get; set; }

        /// <summary>
        /// AIG.8 - Start Date/Time.
        /// </summary>
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// AIG.9 - Start Date/Time Offset.
        /// </summary>
        public decimal? StartDateTimeOffset { get; set; }

        /// <summary>
        /// AIG.10 - Start Date/Time Offset Units.
        /// </summary>
        public CodedElement StartDateTimeOffsetUnits { get; set; }

        /// <summary>
        /// AIG.11 - Duration.
        /// </summary>
        public decimal? Duration { get; set; }

        /// <summary>
        /// AIG.12 - Duration Units.
        /// </summary>
        public CodedElement DurationUnits { get; set; }

        /// <summary>
        /// AIG.13 - Allow Substitution Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0279</remarks>
        public string AllowSubstitutionCode { get; set; }

        /// <summary>
        /// AIG.14 - Filler Status Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0278</remarks>
        public CodedElement FillerStatusCode { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 15, Configuration.FieldSeparator),
                                Id,
                                SetIdAig.HasValue ? SetIdAig.Value.ToString(culture) : null,
                                SegmentActionCode,
                                ResourceId?.ToDelimitedString(),
                                ResourceType?.ToDelimitedString(),
                                ResourceGroup != null ? string.Join(Configuration.FieldRepeatSeparator, ResourceGroup.Select(x => x.ToDelimitedString())) : null,
                                ResourceQuantity.HasValue ? ResourceQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                ResourceQuantityUnits?.ToDelimitedString(),
                                StartDateTime.HasValue ? StartDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                StartDateTimeOffset.HasValue ? StartDateTimeOffset.Value.ToString(Consts.NumericFormat, culture) : null,
                                StartDateTimeOffsetUnits?.ToDelimitedString(),
                                Duration.HasValue ? Duration.Value.ToString(Consts.NumericFormat, culture) : null,
                                DurationUnits?.ToDelimitedString(),
                                AllowSubstitutionCode,
                                FillerStatusCode?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}