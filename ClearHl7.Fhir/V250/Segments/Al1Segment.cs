using System;
using System.Collections.Generic;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V250.Types;

namespace ClearHl7.Fhir.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment AL1 - Patient Allergy Information.
    /// </summary>
    public class Al1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "AL1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// AL1.1 - Set ID - AL1.
        /// </summary>
        public uint? SetIdAl1 { get; set; }

        /// <summary>
        /// AL1.2 - Allergen Type Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0127</remarks>
        public CodedElement AllergenTypeCode { get; set; }

        /// <summary>
        /// AL1.3 - Allergen Code/Mnemonic/Description.
        /// </summary>
        public CodedElement AllergenCodeMnemonicDescription { get; set; }

        /// <summary>
        /// AL1.4 - Allergy Severity Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0128</remarks>
        public CodedElement AllergySeverityCode { get; set; }

        /// <summary>
        /// AL1.5 - Allergy Reaction Code.
        /// </summary>
        public IEnumerable<string> AllergyReactionCode { get; set; }

        /// <summary>
        /// AL1.6 - Identification Date.
        /// </summary>
        public DateTime? IdentificationDate { get; set; }

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
                                SetIdAl1.HasValue ? SetIdAl1.Value.ToString(culture) : null,
                                AllergenTypeCode?.ToDelimitedString(),
                                AllergenCodeMnemonicDescription?.ToDelimitedString(),
                                AllergySeverityCode?.ToDelimitedString(),
                                AllergyReactionCode != null ? string.Join(Configuration.FieldRepeatSeparator, AllergyReactionCode) : null,
                                IdentificationDate.HasValue ? IdentificationDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}