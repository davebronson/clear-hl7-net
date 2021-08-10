using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;

namespace ClearHl7.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment NSC - Application Status Change.
    /// </summary>
    public class NscSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "NSC";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// NSC.1 - Application Change Type.
        /// </summary>
        public string ApplicationChangeType { get; set; }

        /// <summary>
        /// NSC.2 - Current CPU.
        /// </summary>
        public string CurrentCpu { get; set; }

        /// <summary>
        /// NSC.3 - Current Fileserver.
        /// </summary>
        public string CurrentFileserver { get; set; }

        /// <summary>
        /// NSC.4 - Current Application.
        /// </summary>
        public string CurrentApplication { get; set; }

        /// <summary>
        /// NSC.5 - Current Facility.
        /// </summary>
        public string CurrentFacility { get; set; }

        /// <summary>
        /// NSC.6 - New CPU.
        /// </summary>
        public string NewCpu { get; set; }

        /// <summary>
        /// NSC.7 - New Fileserver.
        /// </summary>
        public string NewFileserver { get; set; }

        /// <summary>
        /// NSC.8 - New Application.
        /// </summary>
        public string NewApplication { get; set; }

        /// <summary>
        /// NSC.9 - New Facility.
        /// </summary>
        public string NewFacility { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ApplicationChangeType = segments.ElementAtOrDefault(1);
            CurrentCpu = segments.ElementAtOrDefault(2);
            CurrentFileserver = segments.ElementAtOrDefault(3);
            CurrentApplication = segments.ElementAtOrDefault(4);
            CurrentFacility = segments.ElementAtOrDefault(5);
            NewCpu = segments.ElementAtOrDefault(6);
            NewFileserver = segments.ElementAtOrDefault(7);
            NewApplication = segments.ElementAtOrDefault(8);
            NewFacility = segments.ElementAtOrDefault(9);
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
                                ApplicationChangeType,
                                CurrentCpu,
                                CurrentFileserver,
                                CurrentApplication,
                                CurrentFacility,
                                NewCpu,
                                NewFileserver,
                                NewApplication,
                                NewFacility
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}