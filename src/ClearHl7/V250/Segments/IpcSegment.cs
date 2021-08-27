using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment IPC - Imaging Procedure Control Segment.
    /// </summary>
    public class IpcSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "IPC";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// IPC.1 - Accession Identifier.
        /// </summary>
        public EntityIdentifier AccessionIdentifier { get; set; }

        /// <summary>
        /// IPC.2 - Requested Procedure ID.
        /// </summary>
        public EntityIdentifier RequestedProcedureId { get; set; }

        /// <summary>
        /// IPC.3 - Study Instance UID.
        /// </summary>
        public EntityIdentifier StudyInstanceUid { get; set; }

        /// <summary>
        /// IPC.4 - Scheduled Procedure Step ID.
        /// </summary>
        public EntityIdentifier ScheduledProcedureStepId { get; set; }

        /// <summary>
        /// IPC.5 - Modality.
        /// </summary>
        public CodedElement Modality { get; set; }

        /// <summary>
        /// IPC.6 - Protocol Code.
        /// </summary>
        public IEnumerable<CodedElement> ProtocolCode { get; set; }

        /// <summary>
        /// IPC.7 - Scheduled Station Name.
        /// </summary>
        public EntityIdentifier ScheduledStationName { get; set; }

        /// <summary>
        /// IPC.8 - Scheduled Procedure Step Location.
        /// </summary>
        public IEnumerable<CodedElement> ScheduledProcedureStepLocation { get; set; }

        /// <summary>
        /// IPC.9 - Scheduled Station AE Title.
        /// </summary>
        public string ScheduledStationAeTitle { get; set; }

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
        public void FromDelimitedString(string delimitedString, Separators separators)
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

            AccessionIdentifier = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[1], false, seps) : null;
            RequestedProcedureId = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[2], false, seps) : null;
            StudyInstanceUid = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[3], false, seps) : null;
            ScheduledProcedureStepId = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[4], false, seps) : null;
            Modality = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[5], false, seps) : null;
            ProtocolCode = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedElement>(x, false, seps)) : null;
            ScheduledStationName = segments.Length > 7 && segments[7].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[7], false, seps) : null;
            ScheduledProcedureStepLocation = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedElement>(x, false, seps)) : null;
            ScheduledStationAeTitle = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
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
                                AccessionIdentifier?.ToDelimitedString(),
                                RequestedProcedureId?.ToDelimitedString(),
                                StudyInstanceUid?.ToDelimitedString(),
                                ScheduledProcedureStepId?.ToDelimitedString(),
                                Modality?.ToDelimitedString(),
                                ProtocolCode != null ? string.Join(Configuration.FieldRepeatSeparator, ProtocolCode.Select(x => x.ToDelimitedString())) : null,
                                ScheduledStationName?.ToDelimitedString(),
                                ScheduledProcedureStepLocation != null ? string.Join(Configuration.FieldRepeatSeparator, ScheduledProcedureStepLocation.Select(x => x.ToDelimitedString())) : null,
                                ScheduledStationAeTitle
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}