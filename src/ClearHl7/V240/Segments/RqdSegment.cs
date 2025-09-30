using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RQD - Requisition Detail.
    /// </summary>
    public class RqdSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RqdSegment"/> class.
        /// </summary>
        public RqdSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RqdSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public RqdSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "RQD";

        /// <inheritdoc/>
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

            RequisitionLineNumber = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            ItemCodeInternal = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[2], false, seps) : null;
            ItemCodeExternal = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[3], false, seps) : null;
            HospitalItemCode = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[4], false, seps) : null;
            RequisitionQuantity = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDecimal() : null;
            RequisitionUnitOfMeasure = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[6], false, seps) : null;
            CostCenterAccountNumber = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            ItemNaturalAccountCode = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            DeliverToId = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[9], false, seps) : null;
            DateNeeded = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDateTime() : null; ;
        }

        /// <inheritdoc/>
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
                                DateNeeded?.ToHl7DateTimeString(typeof(RqdSegment), nameof(DateNeeded), Consts.DateFormatPrecisionDay, culture)
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
