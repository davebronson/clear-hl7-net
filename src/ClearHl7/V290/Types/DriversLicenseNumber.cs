using System;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V290.Types
{
    /// <summary>
    /// HL7 Version 2 DLN - Drivers License Number.
    /// </summary>
    public class DriversLicenseNumber : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// DLN.1 - License Number.
        /// </summary>
        public string LicenseNumber { get; set; }

        /// <summary>
        /// DLN.2 - Issuing State, Province, Country.
        /// <para>Suggested: 0333 Issuing State, Province, Country</para>
        /// </summary>
        public CodedWithExceptions IssuingStateProvinceCountry { get; set; }

        /// <summary>
        /// DLN.3 - Expiration Date.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public DriversLicenseNumber FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            LicenseNumber = segments.ElementAtOrDefault(0);
            IssuingStateProvinceCountry = segments.Length > 1 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(1)) : null;
            ExpirationDate = segments.ElementAtOrDefault(2).ToNullableDateTime();

            return this;
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, separator),
                                LicenseNumber,
                                IssuingStateProvinceCountry?.ToDelimitedString(),
                                ExpirationDate.HasValue ? ExpirationDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
