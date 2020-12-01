using System;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V280.Types;

namespace ClearHl7.Fhir.V280.Segments
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

        /// <summary>
        /// RQD.1 - Requisition Line Number.
        /// </summary>
        public uint? RequisitionLineNumber { get; set; }

        /// <summary>
        /// RQD.2 - Item Code - Internal.
        /// </summary>
        public CodedWithExceptions ItemCodeInternal { get; set; }

        /// <summary>
        /// RQD.3 - Item Code - External.
        /// </summary>
        public CodedWithExceptions ItemCodeExternal { get; set; }

        /// <summary>
        /// RQD.4 - Hospital Item Code.
        /// </summary>
        public CodedWithExceptions HospitalItemCode { get; set; }

        /// <summary>
        /// RQD.5 - Requisition Quantity.
        /// </summary>
        public decimal? RequisitionQuantity { get; set; }

        /// <summary>
        /// RQD.6 - Requisition Unit of Measure.
        /// </summary>
        public CodedWithExceptions RequisitionUnitOfMeasure { get; set; }

        /// <summary>
        /// RQD.7 - Cost Center Account Number.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0319</remarks>
        public ExtendedCompositeIdWithCheckDigit CostCenterAccountNumber { get; set; }

        /// <summary>
        /// RQD.8 - Item Natural Account Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0320</remarks>
        public CodedWithExceptions ItemNaturalAccountCode { get; set; }

        /// <summary>
        /// RQD.9 - Deliver To ID.
        /// </summary>
        public CodedWithExceptions DeliverToId { get; set; }

        /// <summary>
        /// RQD.10 - Date Needed.
        /// </summary>
        public DateTime? DateNeeded { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 11, Configuration.FieldSeparator),
                                Id,
                                RequisitionLineNumber.HasValue ? RequisitionLineNumber.Value.ToString(culture) : null,
                                ItemCodeInternal?.ToDelimitedString(),
                                ItemCodeExternal?.ToDelimitedString(),
                                HospitalItemCode?.ToDelimitedString(),
                                RequisitionQuantity.HasValue ? RequisitionQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                RequisitionUnitOfMeasure?.ToDelimitedString(),
                                CostCenterAccountNumber?.ToDelimitedString(),
                                ItemNaturalAccountCode?.ToDelimitedString(),
                                DeliverToId?.ToDelimitedString(),
                                DateNeeded.HasValue ? DateNeeded.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}