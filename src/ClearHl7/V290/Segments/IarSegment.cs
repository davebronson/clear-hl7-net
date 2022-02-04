using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment IAR - Allergy Reaction.
    /// </summary>
    public class IarSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IarSegment"/> class.
        /// </summary>
        public IarSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IarSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public IarSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "IAR";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// IAR.1 - Allergy Reaction Code.
        /// </summary>
        public CodedWithExceptions AllergyReactionCode { get; set; }

        /// <summary>
        /// IAR.2 - Allergy Severity Code.
        /// <para>Suggested: 0128 Allergy Severity -&gt; ClearHl7.Codes.V290.CodeAllergySeverity</para>
        /// </summary>
        public CodedWithExceptions AllergySeverityCode { get; set; }

        /// <summary>
        /// IAR.3 - Sensitivity to Causative Agent Code.
        /// <para>Suggested: 0436 Sensitivity To Causative Agent Code -&gt; ClearHl7.Codes.V290.CodeSensitivityToCausativeAgentCode</para>
        /// </summary>
        public CodedWithExceptions SensitivityToCausativeAgentCode { get; set; }

        /// <summary>
        /// IAR.4 - Management.
        /// </summary>
        public string Management { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            AllergyReactionCode = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], false, seps) : null;
            AllergySeverityCode = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            SensitivityToCausativeAgentCode = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[3], false, seps) : null;
            Management = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator),
                                Id,
                                AllergyReactionCode?.ToDelimitedString(),
                                AllergySeverityCode?.ToDelimitedString(),
                                SensitivityToCausativeAgentCode?.ToDelimitedString(),
                                Management
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
