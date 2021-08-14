using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
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
        public CodedElement ItemCodeInternal { get; set; }

        /// <summary>
        /// RQD.3 - Item Code - External.
        /// </summary>
        public CodedElement ItemCodeExternal { get; set; }

        /// <summary>
        /// RQD.4 - Hospital Item Code.
        /// </summary>
        public CodedElement HospitalItemCode { get; set; }

        /// <summary>
        /// RQD.5 - Requisition Quantity.
        /// </summary>
        public decimal? RequisitionQuantity { get; set; }

        /// <summary>
        /// RQD.6 - Requisition Unit of Measure.
        /// </summary>
        public CodedElement RequisitionUnitOfMeasure { get; set; }

        /// <summary>
        /// RQD.7 - Cost Center Account Number.
        /// <para>Suggested: 0319 Department Cost Center</para>
        /// </summary>
        public string CostCenterAccountNumber { get; set; }

        /// <summary>
        /// RQD.8 - Item Natural Account Code.
        /// <para>Suggested: 0320 Item Natural Account Code</para>
        /// </summary>
        public string ItemNaturalAccountCode { get; set; }

        /// <summary>
        /// RQD.9 - Deliver To ID.
        /// </summary>
        public CodedElement DeliverToId { get; set; }

        /// <summary>
        /// RQD.10 - Date Needed.
        /// </summary>
        public DateTime? DateNeeded { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            RequisitionLineNumber = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            ItemCodeInternal = segments.Length > 2 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(2), false) : null;
            ItemCodeExternal = segments.Length > 3 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(3), false) : null;
            HospitalItemCode = segments.Length > 4 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(4), false) : null;
            RequisitionQuantity = segments.ElementAtOrDefault(5)?.ToNullableDecimal();
            RequisitionUnitOfMeasure = segments.Length > 6 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(6), false) : null;
            CostCenterAccountNumber = segments.ElementAtOrDefault(7);
            ItemNaturalAccountCode = segments.ElementAtOrDefault(8);
            DeliverToId = segments.Length > 9 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(9), false) : null;
            DateNeeded = segments.ElementAtOrDefault(10)?.ToNullableDateTime(); ;
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
                                StringHelper.StringFormatSequence(0, 11, Configuration.FieldSeparator),
                                Id,
                                RequisitionLineNumber.HasValue ? RequisitionLineNumber.Value.ToString(culture) : null,
                                ItemCodeInternal?.ToDelimitedString(),
                                ItemCodeExternal?.ToDelimitedString(),
                                HospitalItemCode?.ToDelimitedString(),
                                RequisitionQuantity.HasValue ? RequisitionQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                RequisitionUnitOfMeasure?.ToDelimitedString(),
                                CostCenterAccountNumber,
                                ItemNaturalAccountCode,
                                DeliverToId?.ToDelimitedString(),
                                DateNeeded.HasValue ? DateNeeded.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}