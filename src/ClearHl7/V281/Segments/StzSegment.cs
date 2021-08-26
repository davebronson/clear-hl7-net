using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment STZ - Sterilization Parameter.
    /// </summary>
    public class StzSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "STZ";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// STZ.1 - Sterilization Type.
        /// <para>Suggested: 0806 Sterilization Type -&gt; ClearHl7.Codes.V281.CodeSterilizationType</para>
        /// </summary>
        public CodedWithExceptions SterilizationType { get; set; }

        /// <summary>
        /// STZ.2 - Sterilization Cycle.
        /// <para>Suggested: 0702 Cycle Type -&gt; ClearHl7.Codes.V281.CodeCycleType</para>
        /// </summary>
        public CodedWithExceptions SterilizationCycle { get; set; }

        /// <summary>
        /// STZ.3 - Maintenance Cycle.
        /// <para>Suggested: 0809 Maintenance Cycle</para>
        /// </summary>
        public CodedWithExceptions MaintenanceCycle { get; set; }

        /// <summary>
        /// STZ.4 - Maintenance Type.
        /// <para>Suggested: 0811 Maintenance Type</para>
        /// </summary>
        public CodedWithExceptions MaintenanceType { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        internal void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SterilizationType = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[1], false) : null;
            SterilizationCycle = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[2], false) : null;
            MaintenanceCycle = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[3], false) : null;
            MaintenanceType = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[4], false) : null;
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
                                SterilizationType?.ToDelimitedString(),
                                SterilizationCycle?.ToDelimitedString(),
                                MaintenanceCycle?.ToDelimitedString(),
                                MaintenanceType?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}