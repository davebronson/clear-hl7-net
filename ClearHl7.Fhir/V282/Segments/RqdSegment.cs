using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RQD - Requisition Detail.
    /// </summary>
    public class RqdSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RQD";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// RQD.1 - Requisition Line Number.
        ///// </summary>
        //public RequisitionLineNumber { get; set; }

        ///// <summary>
        ///// RQD.2 - Item Code - Internal.
        ///// </summary>
        //public ItemCodeInternal { get; set; }

        ///// <summary>
        ///// RQD.3 - Item Code - External.
        ///// </summary>
        //public ItemCodeExternal { get; set; }

        ///// <summary>
        ///// RQD.4 - Hospital Item Code.
        ///// </summary>
        //public HospitalItemCode { get; set; }

        ///// <summary>
        ///// RQD.5 - Requisition Quantity.
        ///// </summary>
        //public RequisitionQuantity { get; set; }

        ///// <summary>
        ///// RQD.6 - Requisition Unit of Measure.
        ///// </summary>
        //public RequisitionUnitOfMeasure { get; set; }

        ///// <summary>
        ///// RQD.7 - Cost Center Account Number.
        ///// </summary>
        //public CostCenterAccountNumber { get; set; }

        ///// <summary>
        ///// RQD.8 - Item Natural Account Code.
        ///// </summary>
        //public ItemNaturalAccountCode { get; set; }

        ///// <summary>
        ///// RQD.9 - Deliver To ID.
        ///// </summary>
        //public DeliverToId { get; set; }

        ///// <summary>
        ///// RQD.10 - Date Needed.
        ///// </summary>
        //public DateNeeded { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}"
                                ).TrimEnd('|');
        }
    }
}