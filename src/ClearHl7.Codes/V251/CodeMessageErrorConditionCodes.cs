namespace ClearHl7.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0357 - Message Error Condition Codes.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0357</remarks>
    public enum CodeMessageErrorConditionCodes
    {
        /// <summary>
        /// 0 - Message accepted.
        /// </summary>
        MessageAccepted,

        /// <summary>
        /// 100 - Segment sequence error.
        /// </summary>
        SegmentSequenceError,

        /// <summary>
        /// 101 - Required field missing.
        /// </summary>
        RequiredFieldMissing,

        /// <summary>
        /// 102 - Data type error.
        /// </summary>
        DataTypeError,

        /// <summary>
        /// 103 - Table value not found.
        /// </summary>
        TableValueNotFound,

        /// <summary>
        /// 200 - Unsupported message type.
        /// </summary>
        UnsupportedMessageType,

        /// <summary>
        /// 201 - Unsupported event code.
        /// </summary>
        UnsupportedEventCode,

        /// <summary>
        /// 202 - Unsupported processing id.
        /// </summary>
        UnsupportedProcessingId,

        /// <summary>
        /// 203 - Unsupported version id.
        /// </summary>
        UnsupportedVersionId,

        /// <summary>
        /// 204 - Unknown key identifier.
        /// </summary>
        UnknownKeyIdentifier,

        /// <summary>
        /// 205 - Duplicate key identifier.
        /// </summary>
        DuplicateKeyIdentifier,

        /// <summary>
        /// 206 - Application record locked.
        /// </summary>
        ApplicationRecordLocked,

        /// <summary>
        /// 207 - Application error.
        /// </summary>
        ApplicationError
    }
}
