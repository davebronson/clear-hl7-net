using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
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
        /// <para>Suggested: 0409 Application Change Type -&gt; ClearHl7.Codes.V251.CodeApplicationChangeType</para>
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
        public HierarchicDesignator CurrentApplication { get; set; }

        /// <summary>
        /// NSC.5 - Current Facility.
        /// </summary>
        public HierarchicDesignator CurrentFacility { get; set; }

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
        public HierarchicDesignator NewApplication { get; set; }

        /// <summary>
        /// NSC.9 - New Facility.
        /// </summary>
        public HierarchicDesignator NewFacility { get; set; }

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

            ApplicationChangeType = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            CurrentCpu = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            CurrentFileserver = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            CurrentApplication = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[4], false) : null;
            CurrentFacility = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[5], false) : null;
            NewCpu = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            NewFileserver = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            NewApplication = segments.Length > 8 && segments[8].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[8], false) : null;
            NewFacility = segments.Length > 9 && segments[9].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[9], false) : null;
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
                                CurrentApplication?.ToDelimitedString(),
                                CurrentFacility?.ToDelimitedString(),
                                NewCpu,
                                NewFileserver,
                                NewApplication?.ToDelimitedString(),
                                NewFacility?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}