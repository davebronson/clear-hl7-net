using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment BLG - Billing.
    /// </summary>
    public class BlgSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlgSegment"/> class.
        /// </summary>
        public BlgSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlgSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public BlgSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "BLG";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// BLG.1 - When to Charge.
        /// <para>Suggested: 0100 Invocation Event -&gt; ClearHl7.Codes.V282.CodeInvocationEvent</para>
        /// </summary>
        public ChargeCodeAndDate WhenToCharge { get; set; }

        /// <summary>
        /// BLG.2 - Charge Type.
        /// <para>Suggested: 0122 Charge Type -&gt; ClearHl7.Codes.V282.CodeChargeType</para>
        /// </summary>
        public string ChargeType { get; set; }

        /// <summary>
        /// BLG.3 - Account ID.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit AccountId { get; set; }

        /// <summary>
        /// BLG.4 - Charge Type Reason.
        /// <para>Suggested: 0475 Charge Type Reason -&gt; ClearHl7.Codes.V282.CodeChargeTypeReason</para>
        /// </summary>
        public CodedWithExceptions ChargeTypeReason { get; set; }

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

            WhenToCharge = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<ChargeCodeAndDate>(segments[1], false, seps) : null;
            ChargeType = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            AccountId = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[3], false, seps) : null;
            ChargeTypeReason = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[4], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator),
                                Id,
                                WhenToCharge?.ToDelimitedString(),
                                ChargeType,
                                AccountId?.ToDelimitedString(),
                                ChargeTypeReason?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
