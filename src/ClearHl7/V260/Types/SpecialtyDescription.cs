using System;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V260.Types
{
    /// <summary>
    /// HL7 Version 2 SPD - Specialty Description.
    /// </summary>
    public class SpecialtyDescription : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// SPD.1 - Specialty Name.
        /// </summary>
        public string SpecialtyName { get; set; }

        /// <summary>
        /// SPD.2 - Governing Board.
        /// </summary>
        public string GoverningBoard { get; set; }

        /// <summary>
        /// SPD.3 - Eligible or Certified.
        /// <para>Suggested: 0337 Certification Status -&gt; ClearHl7.Codes.V260.CodeCertificationStatus</para>
        /// </summary>
        public string EligibleOrCertified { get; set; }

        /// <summary>
        /// SPD.4 - Date of Certification.
        /// </summary>
        public DateTime? DateOfCertification { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            SpecialtyName = segments.ElementAtOrDefault(0);
            GoverningBoard = segments.ElementAtOrDefault(1);
            EligibleOrCertified = segments.ElementAtOrDefault(2);
            DateOfCertification = segments.ElementAtOrDefault(3)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
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
                                StringHelper.StringFormatSequence(0, 4, separator),
                                SpecialtyName,
                                GoverningBoard,
                                EligibleOrCertified,
                                DateOfCertification.HasValue ? DateOfCertification.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
