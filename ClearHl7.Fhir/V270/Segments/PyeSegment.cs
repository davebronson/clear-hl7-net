using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V270.Types;

namespace ClearHl7.Fhir.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PYE - Payee Information.
    /// </summary>
    public class PyeSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PYE";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// PYE.1 - Set ID - PYE.
        /// </summary>
        public uint? SetIdPye { get; set; }

        /// <summary>
        /// PYE.2 - Payee Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0557</remarks>
        public CodedWithExceptions PayeeType { get; set; }

        /// <summary>
        /// PYE.3 - Payee Relationship to Invoice (Patient).
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0558</remarks>
        public CodedWithExceptions PayeeRelationshipToInvoicePatient { get; set; }

        /// <summary>
        /// PYE.4 - Payee Identification List.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations PayeeIdentificationList { get; set; }

        /// <summary>
        /// PYE.5 - Payee Person Name.
        /// </summary>
        public ExtendedPersonName PayeePersonName { get; set; }

        /// <summary>
        /// PYE.6 - Payee Address.
        /// </summary>
        public ExtendedAddress PayeeAddress { get; set; }

        /// <summary>
        /// PYE.7 - Payment Method.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0570</remarks>
        public CodedWithExceptions PaymentMethod { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 8, Configuration.FieldSeparator),
                                Id,
                                SetIdPye.HasValue ? SetIdPye.Value.ToString(culture) : null,
                                PayeeType?.ToDelimitedString(),
                                PayeeRelationshipToInvoicePatient?.ToDelimitedString(),
                                PayeeIdentificationList?.ToDelimitedString(),
                                PayeePersonName?.ToDelimitedString(),
                                PayeeAddress?.ToDelimitedString(),
                                PaymentMethod?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}