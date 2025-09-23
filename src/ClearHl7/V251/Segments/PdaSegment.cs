using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PDA - Patient Death And Autopsy.
    /// </summary>
    public class PdaSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdaSegment"/> class.
        /// </summary>
        public PdaSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdaSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public PdaSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "PDA";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// PDA.1 - Death Cause Code.
        /// </summary>
        public IEnumerable<CodedElement> DeathCauseCode { get; set; }

        /// <summary>
        /// PDA.2 - Death Location.
        /// </summary>
        public PersonLocation DeathLocation { get; set; }

        /// <summary>
        /// PDA.3 - Death Certified Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V251.CodeYesNoIndicator</para>
        /// </summary>
        public string DeathCertifiedIndicator { get; set; }

        /// <summary>
        /// PDA.4 - Death Certificate Signed Date/Time.
        /// </summary>
        public DateTime? DeathCertificateSignedDateTime { get; set; }

        /// <summary>
        /// PDA.5 - Death Certified By.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons DeathCertifiedBy { get; set; }

        /// <summary>
        /// PDA.6 - Autopsy Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V251.CodeYesNoIndicator</para>
        /// </summary>
        public string AutopsyIndicator { get; set; }

        /// <summary>
        /// PDA.7 - Autopsy Start and End Date/Time.
        /// </summary>
        public DateTimeRange AutopsyStartAndEndDateTime { get; set; }

        /// <summary>
        /// PDA.8 - Autopsy Performed By.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons AutopsyPerformedBy { get; set; }

        /// <summary>
        /// PDA.9 - Coroner Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V251.CodeYesNoIndicator</para>
        /// </summary>
        public string CoronerIndicator { get; set; }

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

            DeathCauseCode = segments.Length > 1 && segments[1].Length > 0 ? segments[1].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            DeathLocation = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<PersonLocation>(segments[2], false, seps) : null;
            DeathCertifiedIndicator = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            DeathCertificateSignedDateTime = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            DeathCertifiedBy = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[5], false, seps) : null;
            AutopsyIndicator = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            AutopsyStartAndEndDateTime = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<DateTimeRange>(segments[7], false, seps) : null;
            AutopsyPerformedBy = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[8], false, seps) : null;
            CoronerIndicator = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 10, Configuration.FieldSeparator),
                                Id,
                                DeathCauseCode != null ? string.Join(Configuration.FieldRepeatSeparator, DeathCauseCode.Select(x => x.ToDelimitedString())) : null,
                                DeathLocation?.ToDelimitedString(),
                                DeathCertifiedIndicator,
                                DeathCertificateSignedDateTime.ToHl7DateTimeString(typeof(PdaSegment), nameof(DeathCertificateSignedDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                DeathCertifiedBy?.ToDelimitedString(),
                                AutopsyIndicator,
                                AutopsyStartAndEndDateTime?.ToDelimitedString(),
                                AutopsyPerformedBy?.ToDelimitedString(),
                                CoronerIndicator
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
