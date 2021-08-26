using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
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
        /// <para>Suggested: 0319 Department Cost Center</para>
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit CostCenterAccountNumber { get; set; }

        /// <summary>
        /// RQD.8 - Item Natural Account Code.
        /// <para>Suggested: 0320 Item Natural Account Code</para>
        /// </summary>
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
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        internal void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            RequisitionLineNumber = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            ItemCodeInternal = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[2], false) : null;
            ItemCodeExternal = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[3], false) : null;
            HospitalItemCode = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[4], false) : null;
            RequisitionQuantity = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDecimal() : null;
            RequisitionUnitOfMeasure = segments.Length > 6 && segments[6].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[6], false) : null;
            CostCenterAccountNumber = segments.Length > 7 && segments[7].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[7], false) : null;
            ItemNaturalAccountCode = segments.Length > 8 && segments[8].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[8], false) : null;
            DeliverToId = segments.Length > 9 && segments[9].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[9], false) : null;
            DateNeeded = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDateTime() : null; ;
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
                                CostCenterAccountNumber?.ToDelimitedString(),
                                ItemNaturalAccountCode?.ToDelimitedString(),
                                DeliverToId?.ToDelimitedString(),
                                DateNeeded.HasValue ? DateNeeded.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}