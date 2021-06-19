using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
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
        /// <para>Suggested: 0604 Modality</para>
        /// </summary>
        public CodedWithExceptions Modality { get; set; }

        /// <summary>
        /// IPC.6 - Protocol Code.
        /// <para>Suggested: 0605 Protocol Code</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ProtocolCode { get; set; }

        /// <summary>
        /// IPC.7 - Scheduled Station Name.
        /// </summary>
        public EntityIdentifier ScheduledStationName { get; set; }

        /// <summary>
        /// IPC.8 - Scheduled Procedure Step Location.
        /// <para>Suggested: 0606 Scheduled Procedure Step Location</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ScheduledProcedureStepLocation { get; set; }

        /// <summary>
        /// IPC.9 - Scheduled Station AE Title.
        /// </summary>
        public string ScheduledStationAeTitle { get; set; }

        /// <summary>
        /// IPC.10 - Action Code.
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public IpcSegment FromDelimitedString(string delimitedString)
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

            AccessionIdentifier = segments.Length > 1 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(1)) : null;
            RequestedProcedureId = segments.Length > 2 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(2)) : null;
            StudyInstanceUid = segments.Length > 3 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(3)) : null;
            ScheduledProcedureStepId = segments.Length > 4 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(4)) : null;
            Modality = segments.Length > 5 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(5)) : null;
            ProtocolCode = segments.Length > 6 ? segments.ElementAtOrDefault(6).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            ScheduledStationName = segments.Length > 7 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(7)) : null;
            ScheduledProcedureStepLocation = segments.Length > 8 ? segments.ElementAtOrDefault(8).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            ScheduledStationAeTitle = segments.ElementAtOrDefault(9);
            ActionCode = segments.ElementAtOrDefault(10);
            
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
                                StringHelper.StringFormatSequence(0, 11, Configuration.FieldSeparator),
                                Id,
                                AccessionIdentifier?.ToDelimitedString(),
                                RequestedProcedureId?.ToDelimitedString(),
                                StudyInstanceUid?.ToDelimitedString(),
                                ScheduledProcedureStepId?.ToDelimitedString(),
                                Modality?.ToDelimitedString(),
                                ProtocolCode != null ? string.Join(Configuration.FieldRepeatSeparator, ProtocolCode.Select(x => x.ToDelimitedString())) : null,
                                ScheduledStationName?.ToDelimitedString(),
                                ScheduledProcedureStepLocation != null ? string.Join(Configuration.FieldRepeatSeparator, ScheduledProcedureStepLocation.Select(x => x.ToDelimitedString())) : null,
                                ScheduledStationAeTitle,
                                ActionCode
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}