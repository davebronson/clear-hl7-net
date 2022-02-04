using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PYE - Payee Information.
    /// </summary>
    public class PyeSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PyeSegment"/> class.
        /// </summary>
        public PyeSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PyeSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public PyeSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "PYE";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// PYE.1 - Set ID - PYE.
        /// </summary>
        public uint? SetIdPye { get; set; }

        /// <summary>
        /// PYE.2 - Payee Type.
        /// <para>Suggested: 0557 Payee Type -&gt; ClearHl7.Codes.V280.CodePayeeType</para>
        /// </summary>
        public CodedWithExceptions PayeeType { get; set; }

        /// <summary>
        /// PYE.3 - Payee Relationship to Invoice (Patient).
        /// <para>Suggested: 0558 Payee Relationship To Invoice -&gt; ClearHl7.Codes.V280.CodePayeeRelationshipToInvoice</para>
        /// </summary>
        public CodedWithExceptions PayeeRelationshipToInvoicePatient { get; set; }

        /// <summary>
        /// PYE.4 - Payee Identification List.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations PayeeIdentificationList { get; set; }

        /// <summary>
        /// PYE.5 - Payee Person Name.
        /// </summary>
        public ExtendedPersonName PayeePersonName { get; set; }

        /// <summary>
        /// PYE.6 - Payee Address.
        /// </summary>
        public ExtendedAddress PayeeAddress { get; set; }

        /// <summary>
        /// PYE.7 - Payment Method.
        /// <para>Suggested: 0570 Payment Method Code -&gt; ClearHl7.Codes.V280.CodePaymentMethodCode</para>
        /// </summary>
        public CodedWithExceptions PaymentMethod { get; set; }

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

            SetIdPye = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            PayeeType = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            PayeeRelationshipToInvoicePatient = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[3], false, seps) : null;
            PayeeIdentificationList = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[4], false, seps) : null;
            PayeePersonName = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<ExtendedPersonName>(segments[5], false, seps) : null;
            PayeeAddress = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<ExtendedAddress>(segments[6], false, seps) : null;
            PaymentMethod = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[7], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 8, Configuration.FieldSeparator),
                                Id,
                                SetIdPye.HasValue ? SetIdPye.Value.ToString(culture) : null,
                                PayeeType?.ToDelimitedString(),
                                PayeeRelationshipToInvoicePatient?.ToDelimitedString(),
                                PayeeIdentificationList?.ToDelimitedString(),
                                PayeePersonName?.ToDelimitedString(),
                                PayeeAddress?.ToDelimitedString(),
                                PaymentMethod?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
