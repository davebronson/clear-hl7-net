using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment IPR - Invoice Processing Results.
    /// </summary>
    public class IprSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IprSegment"/> class.
        /// </summary>
        public IprSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IprSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public IprSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "IPR";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// IPR.1 - IPR Identifier.
        /// </summary>
        public EntityIdentifier IprIdentifier { get; set; }

        /// <summary>
        /// IPR.2 - Provider Cross Reference Identifier.
        /// </summary>
        public EntityIdentifier ProviderCrossReferenceIdentifier { get; set; }

        /// <summary>
        /// IPR.3 - Payer Cross Reference Identifier.
        /// </summary>
        public EntityIdentifier PayerCrossReferenceIdentifier { get; set; }

        /// <summary>
        /// IPR.4 - IPR Status.
        /// <para>Suggested: 0571 Invoice Processing Results Status -&gt; ClearHl7.Codes.V290.CodeInvoiceProcessingResultsStatus</para>
        /// </summary>
        public CodedWithExceptions IprStatus { get; set; }

        /// <summary>
        /// IPR.5 - IPR Date/Time.
        /// </summary>
        public DateTime? IprDateTime { get; set; }

        /// <summary>
        /// IPR.6 - Adjudicated/Paid Amount.
        /// </summary>
        public CompositePrice AdjudicatedPaidAmount { get; set; }

        /// <summary>
        /// IPR.7 - Expected Payment Date/Time.
        /// </summary>
        public DateTime? ExpectedPaymentDateTime { get; set; }

        /// <summary>
        /// IPR.8 - IPR Checksum.
        /// </summary>
        public string IprChecksum { get; set; }

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

            IprIdentifier = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[1], false, seps) : null;
            ProviderCrossReferenceIdentifier = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[2], false, seps) : null;
            PayerCrossReferenceIdentifier = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[3], false, seps) : null;
            IprStatus = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[4], false, seps) : null;
            IprDateTime = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDateTime() : null;
            AdjudicatedPaidAmount = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[6], false, seps) : null;
            ExpectedPaymentDateTime = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            IprChecksum = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 9, Configuration.FieldSeparator),
                                Id,
                                IprIdentifier?.ToDelimitedString(),
                                ProviderCrossReferenceIdentifier?.ToDelimitedString(),
                                PayerCrossReferenceIdentifier?.ToDelimitedString(),
                                IprStatus?.ToDelimitedString(),
                                IprDateTime?.ToHl7DateTimeString(typeof(IprSegment), nameof(IprDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                AdjudicatedPaidAmount?.ToDelimitedString(),
                                ExpectedPaymentDateTime?.ToHl7DateTimeString(typeof(IprSegment), nameof(ExpectedPaymentDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                IprChecksum
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
