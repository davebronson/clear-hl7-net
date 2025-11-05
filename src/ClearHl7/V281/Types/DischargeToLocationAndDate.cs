using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V281.Types
{
    /// <summary>
    /// HL7 Version 2 DLD - Discharge To Location And Date.
    /// </summary>
    public class DischargeToLocationAndDate : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DischargeToLocationAndDate"/> class.
        /// </summary>
        public DischargeToLocationAndDate()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DischargeToLocationAndDate"/> class.
        /// </summary>
        /// <param name="dischargeToLocation">DLD.1 - Discharge to Location.</param>
        public DischargeToLocationAndDate(CodedWithExceptions dischargeToLocation)
        {
            DischargeToLocation = dischargeToLocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DischargeToLocationAndDate"/> class.
        /// </summary>
        /// <param name="dischargeToLocation">DLD.1 - Discharge to Location.</param>
        /// <param name="effectiveDate">DLD.2 - Effective Date.</param>
        public DischargeToLocationAndDate(CodedWithExceptions dischargeToLocation, DateTime effectiveDate)
        {
            DischargeToLocation = dischargeToLocation;
            EffectiveDate = effectiveDate;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// DLD.1 - Discharge to Location.
        /// <para>Suggested: 0113 Discharge To Location</para>
        /// </summary>
        public CodedWithExceptions DischargeToLocation { get; set; }

        /// <summary>
        /// DLD.2 - Effective Date.
        /// </summary>
        public DateTime? EffectiveDate { get; set; }

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

            DischargeToLocation = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[0], true, seps) : null;
            EffectiveDate = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDateTime() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                DischargeToLocation?.ToDelimitedString(),
                                EffectiveDate?.ToHl7DateTimeString(typeof(DischargeToLocationAndDate), nameof(EffectiveDate), Consts.DateTimeFormatPrecisionSecond, culture)
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
