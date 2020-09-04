using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// PYE.1 - Set ID - PYE.
        ///// </summary>
        //public SetIdPye { get; set; }

        ///// <summary>
        ///// PYE.2 - Payee Type.
        ///// </summary>
        //public PayeeType { get; set; }

        ///// <summary>
        ///// PYE.3 - Payee Relationship to Invoice (Patient).
        ///// </summary>
        //public PayeeRelationshipToInvoicePatient { get; set; }

        ///// <summary>
        ///// PYE.4 - Payee Identification List.
        ///// </summary>
        //public PayeeIdentificationList { get; set; }

        ///// <summary>
        ///// PYE.5 - Payee Person Name.
        ///// </summary>
        //public PayeePersonName { get; set; }

        ///// <summary>
        ///// PYE.6 - Payee Address.
        ///// </summary>
        //public PayeeAddress { get; set; }

        ///// <summary>
        ///// PYE.7 - Payment Method.
        ///// </summary>
        //public PaymentMethod { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}"
                                ).TrimEnd('|');
        }
    }
}