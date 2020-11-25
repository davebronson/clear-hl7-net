﻿using System;

namespace ClearHl7.Fhir.V280.Types
{
    /// <summary>
    /// HL7 Version 2 MO - Money.
    /// </summary>
    public class Money : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// MO.1 - Quantity.
        /// </summary>
        public decimal? Quantity { get; set; }

        /// <summary>
        /// MO.2 - Denomination.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0913</remarks>
        public string Denomination { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}" : "{0}^{1}",
                                Quantity.HasValue ? Quantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                Denomination
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}