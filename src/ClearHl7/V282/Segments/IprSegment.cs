using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment IPR - Invoice Processing Results.
    /// </summary>
    public class IprSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "IPR";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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
        /// <para>Suggested: 0571 Invoice Processing Results Status -&gt; ClearHl7.Codes.V282.CodeInvoiceProcessingResultsStatus</para>
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

            IprIdentifier = segments.Length > 1 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(1), false) : null;
            ProviderCrossReferenceIdentifier = segments.Length > 2 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(2), false) : null;
            PayerCrossReferenceIdentifier = segments.Length > 3 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(3), false) : null;
            IprStatus = segments.Length > 4 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(4), false) : null;
            IprDateTime = segments.ElementAtOrDefault(5)?.ToNullableDateTime();
            AdjudicatedPaidAmount = segments.Length > 6 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(6), false) : null;
            ExpectedPaymentDateTime = segments.ElementAtOrDefault(7)?.ToNullableDateTime();
            IprChecksum = segments.ElementAtOrDefault(8);
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
                                StringHelper.StringFormatSequence(0, 9, Configuration.FieldSeparator),
                                Id,
                                IprIdentifier?.ToDelimitedString(),
                                ProviderCrossReferenceIdentifier?.ToDelimitedString(),
                                PayerCrossReferenceIdentifier?.ToDelimitedString(),
                                IprStatus?.ToDelimitedString(),
                                IprDateTime.HasValue ? IprDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                AdjudicatedPaidAmount?.ToDelimitedString(),
                                ExpectedPaymentDateTime.HasValue ? ExpectedPaymentDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                IprChecksum
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}