﻿using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PYE - Payee Information.
    /// </summary>
    public class PyeSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PYE";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// PYE.1 - Set ID - PYE.
        /// </summary>
        public uint? SetIdPye { get; set; }

        /// <summary>
        /// PYE.2 - Payee Type.
        /// <para>Suggested: 0557 Payee Type -&gt; ClearHl7.Codes.V260.CodePayeeType</para>
        /// </summary>
        public string PayeeType { get; set; }

        /// <summary>
        /// PYE.3 - Payee Relationship to Invoice (Patient).
        /// <para>Suggested: 0558 Payee Relationship To Invoice -&gt; ClearHl7.Codes.V260.CodePayeeRelationshipToInvoice</para>
        /// </summary>
        public string PayeeRelationshipToInvoicePatient { get; set; }

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
        /// <para>Suggested: 0570 Payment Method Code -&gt; ClearHl7.Codes.V260.CodePaymentMethodCode</para>
        /// </summary>
        public string PaymentMethod { get; set; }

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

            SetIdPye = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            PayeeType = segments.ElementAtOrDefault(2);
            PayeeRelationshipToInvoicePatient = segments.ElementAtOrDefault(3);
            PayeeIdentificationList = segments.Length > 4 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments.ElementAtOrDefault(4), false) : null;
            PayeePersonName = segments.Length > 5 ? TypeHelper.Deserialize<ExtendedPersonName>(segments.ElementAtOrDefault(5), false) : null;
            PayeeAddress = segments.Length > 6 ? TypeHelper.Deserialize<ExtendedAddress>(segments.ElementAtOrDefault(6), false) : null;
            PaymentMethod = segments.ElementAtOrDefault(7);
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
                                StringHelper.StringFormatSequence(0, 8, Configuration.FieldSeparator),
                                Id,
                                SetIdPye.HasValue ? SetIdPye.Value.ToString(culture) : null,
                                PayeeType,
                                PayeeRelationshipToInvoicePatient,
                                PayeeIdentificationList?.ToDelimitedString(),
                                PayeePersonName?.ToDelimitedString(),
                                PayeeAddress?.ToDelimitedString(),
                                PaymentMethod
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}