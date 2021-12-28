using System;
using System.Globalization;
using ClearHl7.Helpers;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment NSC - Application Status Change.
    /// </summary>
    public class NscSegment : ISegment
    {
        /// <inheritdoc/>
        public string Id { get; } = "NSC";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// NSC.1 - Application Change Type.
        /// <para>Suggested: 0333 Driver's License Issuing Authority</para>
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

            ApplicationChangeType = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            CurrentCpu = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            CurrentFileserver = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            CurrentApplication = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            CurrentFacility = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            NewCpu = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            NewFileserver = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            NewApplication = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            NewFacility = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
        }

        /// <inheritdoc/>
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
