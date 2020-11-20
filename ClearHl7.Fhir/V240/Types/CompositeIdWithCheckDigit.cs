using System;

namespace ClearHl7.Fhir.V240.Types
{
    /// <summary>
    /// HL7 Version 2 CK - Composite Id With Check Digit.
    /// </summary>
    public class CompositeIdWithCheckDigit : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// CK.1 - ID Number.
        /// </summary>
        public decimal? IdNumber { get; set; }

        /// <summary>
        /// CK.2 - Check Digit.
        /// </summary>
        public string CheckDigit { get; set; }

        /// <summary>
        /// CK.3 - Code Identifying The Check Digit Scheme Employed.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0061</remarks>
        public string CodeIdentifyingTheCheckDigitSchemeEmployed { get; set; }

        /// <summary>
        /// CK.4 - Assigning Authority.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0363</remarks>
        public HierarchicDesignator AssigningAuthority { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}&{2}&{3}" : "{0}^{1}^{2}^{3}",
                                IdNumber.HasValue ? IdNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                CheckDigit,
                                CodeIdentifyingTheCheckDigitSchemeEmployed,
                                AssigningAuthority?.ToDelimitedString()
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
