using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V231.Types
{
    /// <summary>
    /// HL7 Version 2 SPD - Specialty Description.
    /// </summary>
    public class SpecialtyDescription : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialtyDescription"/> class.
        /// </summary>
        public SpecialtyDescription()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialtyDescription"/> class.
        /// </summary>
        /// <param name="specialtyName">SPD.1 - Specialty Name.</param>
        public SpecialtyDescription(string specialtyName)
        {
            SpecialtyName = specialtyName;
        }

        /// <inheritdoc/>
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
        /// <para>Suggested: 0337 Certification Status -&gt; ClearHl7.Codes.V231.CodeCertificationStatus</para>
        /// </summary>
        public string EligibleOrCertified { get; set; }

        /// <summary>
        /// SPD.4 - Date of Certification.
        /// </summary>
        public DateTime? DateOfCertification { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(separator, StringSplitOptions.None);

            SpecialtyName = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            GoverningBoard = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            EligibleOrCertified = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            DateOfCertification = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, separator),
                                SpecialtyName,
                                GoverningBoard,
                                EligibleOrCertified,
                                DateOfCertification?.ToHl7DateTimeString(typeof(SpecialtyDescription), nameof(DateOfCertification), Consts.DateFormatPrecisionDay, culture)
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
