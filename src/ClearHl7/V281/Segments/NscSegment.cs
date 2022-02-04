using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment NSC - Application Status Change.
    /// </summary>
    public class NscSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NscSegment"/> class.
        /// </summary>
        public NscSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NscSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public NscSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id { get; } = "NSC";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// NSC.1 - Application Change Type.
        /// <para>Suggested: 0409 Application Change Type -&gt; ClearHl7.Codes.V281.CodeApplicationChangeType</para>
        /// </summary>
        public CodedWithExceptions ApplicationChangeType { get; set; }

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
        /// <para>Suggested: 0361 Application</para>
        /// </summary>
        public HierarchicDesignator CurrentApplication { get; set; }

        /// <summary>
        /// NSC.5 - Current Facility.
        /// <para>Suggested: 0362 Facility</para>
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
        /// <para>Suggested: 0361 Application</para>
        /// </summary>
        public HierarchicDesignator NewApplication { get; set; }

        /// <summary>
        /// NSC.9 - New Facility.
        /// <para>Suggested: 0362 Facility</para>
        /// </summary>
        public HierarchicDesignator NewFacility { get; set; }

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

            ApplicationChangeType = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], false, seps) : null;
            CurrentCpu = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            CurrentFileserver = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            CurrentApplication = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[4], false, seps) : null;
            CurrentFacility = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[5], false, seps) : null;
            NewCpu = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            NewFileserver = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            NewApplication = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[8], false, seps) : null;
            NewFacility = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[9], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 10, Configuration.FieldSeparator),
                                Id,
                                ApplicationChangeType?.ToDelimitedString(),
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
