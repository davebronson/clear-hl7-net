using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment IAR - Allergy Reaction.
    /// </summary>
    public class IarSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "IAR";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public IarSegment FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            AllergyReactionCode = segments.Length > 1 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(1)) : null;
            AllergySeverityCode = segments.Length > 2 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(2)) : null;
            SensitivityToCausativeAgentCode = segments.Length > 3 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(3)) : null;
            Management = segments.ElementAtOrDefault(4);
            
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