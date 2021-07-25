using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment BLG - Billing.
    /// </summary>
    public class BlgSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "BLG";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// BLG.1 - When to Charge.
        /// <para>Suggested: 0100 Invocation Event -&gt; ClearHl7.Codes.V281.CodeInvocationEvent</para>
        /// </summary>
        public ChargeCodeAndDate WhenToCharge { get; set; }

        /// <summary>
        /// BLG.2 - Charge Type.
        /// <para>Suggested: 0122 Charge Type -&gt; ClearHl7.Codes.V281.CodeChargeType</para>
        /// </summary>
        public string ChargeType { get; set; }

        /// <summary>
        /// BLG.3 - Account ID.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit AccountId { get; set; }

        /// <summary>
        /// BLG.4 - Charge Type Reason.
        /// <para>Suggested: 0475 Charge Type Reason -&gt; ClearHl7.Codes.V281.CodeChargeTypeReason</para>
        /// </summary>
        public CodedWithExceptions ChargeTypeReason { get; set; }

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

            WhenToCharge = segments.Length > 1 ? TypeHelper.Deserialize<ChargeCodeAndDate>(segments.ElementAtOrDefault(1), false) : null;
            ChargeType = segments.ElementAtOrDefault(2);
            AccountId = segments.Length > 3 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments.ElementAtOrDefault(3), false) : null;
            ChargeTypeReason = segments.Length > 4 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(4), false) : null;
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