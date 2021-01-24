using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
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
        public CodedWithExceptions Modality { get; set; }

        /// <summary>
        /// IPC.6 - Protocol Code.
        /// </summary>
        public IEnumerable<CodedWithExceptions> ProtocolCode { get; set; }

        /// <summary>
        /// IPC.7 - Scheduled Station Name.
        /// </summary>
        public EntityIdentifier ScheduledStationName { get; set; }

        /// <summary>
        /// IPC.8 - Scheduled Procedure Step Location.
        /// </summary>
        public IEnumerable<CodedWithExceptions> ScheduledProcedureStepLocation { get; set; }

        /// <summary>
        /// IPC.9 - Scheduled Station AE Title.
        /// </summary>
        public string ScheduledStationAeTitle { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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