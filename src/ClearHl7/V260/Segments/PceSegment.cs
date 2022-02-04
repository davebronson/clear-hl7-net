using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PCE - Patient Charge Cost Center Exceptions.
    /// </summary>
    public class PceSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PceSegment"/> class.
        /// </summary>
        public PceSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PceSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public PceSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "PCE";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// PCE.1 - Set ID - PCE.
        /// </summary>
        public uint? SetIdPce { get; set; }

        /// <summary>
        /// PCE.2 - Cost Center Account Number.
        /// <para>Suggested: 0319 Department Cost Center</para>
        /// </summary>
        public string CostCenterAccountNumber { get; set; }

        /// <summary>
        /// PCE.3 - Transaction Code.
        /// <para>Suggested: 0132 Transaction Code</para>
        /// </summary>
        public CodedWithExceptions TransactionCode { get; set; }

        /// <summary>
        /// PCE.4 - Transaction amount - unit.
        /// </summary>
        public CompositePrice TransactionAmountUnit { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdPce = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            CostCenterAccountNumber = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            TransactionCode = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[3], false, seps) : null;
            TransactionAmountUnit = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[4], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator),
                                Id,
                                SetIdPce.HasValue ? SetIdPce.Value.ToString(culture) : null,
                                CostCenterAccountNumber,
                                TransactionCode?.ToDelimitedString(),
                                TransactionAmountUnit?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
