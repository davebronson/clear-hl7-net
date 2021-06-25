using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PDA - Patient Death And Autopsy.
    /// </summary>
    public class PdaSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PDA";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// PDA.1 - Death Cause Code.
        /// </summary>
        public IEnumerable<CodedWithExceptions> DeathCauseCode { get; set; }

        /// <summary>
        /// PDA.2 - Death Location.
        /// </summary>
        public PersonLocation DeathLocation { get; set; }

        /// <summary>
        /// PDA.3 - Death Certified Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string CoronerIndicator { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public PdaSegment FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            DeathCauseCode = segments.Length > 1 ? segments.ElementAtOrDefault(1).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            DeathLocation = segments.Length > 2 ? new PersonLocation().FromDelimitedString(segments.ElementAtOrDefault(2)) : null;
            DeathCertifiedIndicator = segments.ElementAtOrDefault(3);
            DeathCertificateSignedDateTime = segments.ElementAtOrDefault(4)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            DeathCertifiedBy = segments.Length > 5 ? new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(segments.ElementAtOrDefault(5)) : null;
            AutopsyIndicator = segments.ElementAtOrDefault(6);
            AutopsyStartAndEndDateTime = segments.Length > 7 ? new DateTimeRange().FromDelimitedString(segments.ElementAtOrDefault(7)) : null;
            AutopsyPerformedBy = segments.Length > 8 ? new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(segments.ElementAtOrDefault(8)) : null;
            CoronerIndicator = segments.ElementAtOrDefault(9);
            
            return this;
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
                                StringHelper.StringFormatSequence(0, 10, Configuration.FieldSeparator),
                                Id,
                                DeathCauseCode != null ? string.Join(Configuration.FieldRepeatSeparator, DeathCauseCode.Select(x => x.ToDelimitedString())) : null,
                                DeathLocation?.ToDelimitedString(),
                                DeathCertifiedIndicator,
                                DeathCertificateSignedDateTime.HasValue ? DeathCertificateSignedDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DeathCertifiedBy?.ToDelimitedString(),
                                AutopsyIndicator,
                                AutopsyStartAndEndDateTime?.ToDelimitedString(),
                                AutopsyPerformedBy?.ToDelimitedString(),
                                CoronerIndicator
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}