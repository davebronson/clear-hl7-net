using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ACC - Accident.
    /// </summary>
    public class AccSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccSegment"/> class.
        /// </summary>
        public AccSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public AccSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "ACC";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// ACC.1 - Accident Date/Time.
        /// </summary>
        public DateTime? AccidentDateTime { get; set; }

        /// <summary>
        /// ACC.2 - Accident Code.
        /// <para>Suggested: 0050 Accident Code</para>
        /// </summary>
        public CodedElement AccidentCode { get; set; }

        /// <summary>
        /// ACC.3 - Accident Location.
        /// </summary>
        public string AccidentLocation { get; set; }

        /// <summary>
        /// ACC.4 - Auto Accident State.
        /// <para>Suggested: 0347 State/Province</para>
        /// </summary>
        public CodedElement AutoAccidentState { get; set; }

        /// <summary>
        /// ACC.5 - Accident Job Related Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V251.CodeYesNoIndicator</para>
        /// </summary>
        public string AccidentJobRelatedIndicator { get; set; }

        /// <summary>
        /// ACC.6 - Accident Death Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V251.CodeYesNoIndicator</para>
        /// </summary>
        public string AccidentDeathIndicator { get; set; }

        /// <summary>
        /// ACC.7 - Entered By.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons EnteredBy { get; set; }

        /// <summary>
        /// ACC.8 - Accident Description.
        /// </summary>
        public string AccidentDescription { get; set; }

        /// <summary>
        /// ACC.9 - Brought In By.
        /// </summary>
        public string BroughtInBy { get; set; }

        /// <summary>
        /// ACC.10 - Police Notified Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V251.CodeYesNoIndicator</para>
        /// </summary>
        public string PoliceNotifiedIndicator { get; set; }

        /// <summary>
        /// ACC.11 - Accident Address.
        /// </summary>
        public ExtendedAddress AccidentAddress { get; set; }

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

            AccidentDateTime = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDateTime() : null;
            AccidentCode = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[2], false, seps) : null;
            AccidentLocation = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            AutoAccidentState = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[4], false, seps) : null;
            AccidentJobRelatedIndicator = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            AccidentDeathIndicator = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            EnteredBy = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[7], false, seps) : null;
            AccidentDescription = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            BroughtInBy = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            PoliceNotifiedIndicator = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            AccidentAddress = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<ExtendedAddress>(segments[11], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 12, Configuration.FieldSeparator),
                                Id,
                                AccidentDateTime?.ToHl7DateTimeString(typeof(AccSegment), nameof(AccidentDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                AccidentCode?.ToDelimitedString(),
                                AccidentLocation,
                                AutoAccidentState?.ToDelimitedString(),
                                AccidentJobRelatedIndicator,
                                AccidentDeathIndicator,
                                EnteredBy?.ToDelimitedString(),
                                AccidentDescription,
                                BroughtInBy,
                                PoliceNotifiedIndicator,
                                AccidentAddress?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
