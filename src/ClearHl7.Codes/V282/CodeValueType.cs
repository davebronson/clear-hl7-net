namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0125 - Value Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0125</remarks>
    public enum CodeValueType
    {
        /// <summary>
        /// AUI - Authorization Information.
        /// </summary>
        AuthorizationInformation,

        /// <summary>
        /// CCD - Charge Code And Date.
        /// </summary>
        ChargeCodeAndDate,

        /// <summary>
        /// CCP - Channel Calibration Parameters.
        /// </summary>
        ChannelCalibrationParameters,

        /// <summary>
        /// CD - Channel Definition.
        /// </summary>
        ChannelDefinition,

        /// <summary>
        /// CF - Coded Element With Formatted Values.
        /// </summary>
        CodedElementWithFormattedValues,

        /// <summary>
        /// CNE - Coded With No Exceptions.
        /// </summary>
        CodedWithNoExceptions,

        /// <summary>
        /// CNN - Composite ID Number And Name Simplified.
        /// </summary>
        CompositeIdNumberAndNameSimplified,

        /// <summary>
        /// CP - Composite Price.
        /// </summary>
        CompositePrice,

        /// <summary>
        /// CSU - Channel Sensitivity And Units.
        /// </summary>
        ChannelSensitivityAndUnits,

        /// <summary>
        /// CWE - Coded With Exceptions.
        /// </summary>
        CodedWithExceptions,

        /// <summary>
        /// CX - Extended Composite ID With Check Digit.
        /// </summary>
        ExtendedCompositeIdWithCheckDigit,

        /// <summary>
        /// DDI - Daily Deductible Information.
        /// </summary>
        DailyDeductibleInformation,

        /// <summary>
        /// DIN - Date And Institution Name.
        /// </summary>
        DateAndInstitutionName,

        /// <summary>
        /// DLD - Discharge To Location And Date.
        /// </summary>
        DischargeToLocationAndDate,

        /// <summary>
        /// DLN - Driver's License Number.
        /// </summary>
        DriversLicenseNumber,

        /// <summary>
        /// DLT - Delta.
        /// </summary>
        Delta,

        /// <summary>
        /// DR - Date/Time Range.
        /// </summary>
        DateTimeRange,

        /// <summary>
        /// DT - Date.
        /// </summary>
        Date,

        /// <summary>
        /// DTM - Date/Time.
        /// </summary>
        DateTime,

        /// <summary>
        /// DTN - Day Type And Number.
        /// </summary>
        DayTypeAndNumber,

        /// <summary>
        /// ED - Encapsulated Data.
        /// </summary>
        EncapsulatedData,

        /// <summary>
        /// EI - Entity Identifier.
        /// </summary>
        EntityIdentifier,

        /// <summary>
        /// EIP - Entity Identifier Pair.
        /// </summary>
        EntityIdentifierPair,

        /// <summary>
        /// ERL - Error Location.
        /// </summary>
        ErrorLocation,

        /// <summary>
        /// FC - Financial Class.
        /// </summary>
        FinancialClass,

        /// <summary>
        /// FT - Formatted Text.
        /// </summary>
        FormattedText,

        /// <summary>
        /// GTS - General Timing Specification.
        /// </summary>
        GeneralTimingSpecification,

        /// <summary>
        /// HD - Hierarchic Designator.
        /// </summary>
        HierarchicDesignator,

        /// <summary>
        /// ICD - Insurance Certification Definition.
        /// </summary>
        InsuranceCertificationDefinition,

        /// <summary>
        /// IS - Coded Value For User-Defined Tables.
        /// </summary>
        CodedValueForUserDefinedTables,

        /// <summary>
        /// JCC - Job Code/Class.
        /// </summary>
        JobCodeClass,

        /// <summary>
        /// LA1 - Location With Address Variation 1.
        /// </summary>
        LocationWithAddressVariation1,

        /// <summary>
        /// LA2 - Location With Address Variation 2.
        /// </summary>
        LocationWithAddressVariation2,

        /// <summary>
        /// MA - Multiplexed Array.
        /// </summary>
        MultiplexedArray,

        /// <summary>
        /// MO - Money.
        /// </summary>
        Money,

        /// <summary>
        /// MOC - Money And Charge Code.
        /// </summary>
        MoneyAndChargeCode,

        /// <summary>
        /// MOP - Money Or Percentage.
        /// </summary>
        MoneyOrPercentage,

        /// <summary>
        /// MSG - Message Type.
        /// </summary>
        MessageType,

        /// <summary>
        /// NA - Numeric Array.
        /// </summary>
        NumericArray,

        /// <summary>
        /// NDL - Name With Date And Location.
        /// </summary>
        NameWithDateAndLocation,

        /// <summary>
        /// NM - Numeric.
        /// </summary>
        Numeric,

        /// <summary>
        /// NR - Numeric Range.
        /// </summary>
        NumericRange,

        /// <summary>
        /// OCD - Occurrence Code And Date.
        /// </summary>
        OccurrenceCodeAndDate,

        /// <summary>
        /// OSP - Occurrence Span Code And Date.
        /// </summary>
        OccurrenceSpanCodeAndDate,

        /// <summary>
        /// PIP - Practitioner Institutional Privileges.
        /// </summary>
        PractitionerInstitutionalPrivileges,

        /// <summary>
        /// PL - Person Location.
        /// </summary>
        PersonLocation,

        /// <summary>
        /// PLN - Practitioner License Or OtherID Number.
        /// </summary>
        PractitionerLicenseOrOtherIdNumber,

        /// <summary>
        /// PPN - Performing Person Time Stamp.
        /// </summary>
        PerformingPersonTimeStamp,

        /// <summary>
        /// PRL - Parent Result Link.
        /// </summary>
        ParentResultLink,

        /// <summary>
        /// PT - Processing Type.
        /// </summary>
        ProcessingType,

        /// <summary>
        /// PTA - Policy Type And Amount.
        /// </summary>
        PolicyTypeAndAmount,

        /// <summary>
        /// QIP - Query Input Parameter List.
        /// </summary>
        QueryInputParameterList,

        /// <summary>
        /// QSC - Query Selection Criteria.
        /// </summary>
        QuerySelectionCriteria,

        /// <summary>
        /// RCD - Row Column Definition.
        /// </summary>
        RowColumnDefinition,

        /// <summary>
        /// RFR - Reference Range.
        /// </summary>
        ReferenceRange,

        /// <summary>
        /// RI - Repeat Interval.
        /// </summary>
        RepeatInterval,

        /// <summary>
        /// RMC - Room Coverage.
        /// </summary>
        RoomCoverage,

        /// <summary>
        /// RP - Reference Pointer.
        /// </summary>
        ReferencePointer,

        /// <summary>
        /// RPT - Repeat Pattern.
        /// </summary>
        RepeatPattern,

        /// <summary>
        /// SCV - Scheduling Class Value Pair.
        /// </summary>
        SchedulingClassValuePair,

        /// <summary>
        /// SN - Structured Numeric.
        /// </summary>
        StructuredNumeric,

        /// <summary>
        /// SNM - String Of Telephone Number Digits.
        /// </summary>
        StringOfTelephoneNumberDigits,

        /// <summary>
        /// SPD - Specialty Description.
        /// </summary>
        SpecialtyDescription,

        /// <summary>
        /// SRT - Sort Order.
        /// </summary>
        SortOrder,

        /// <summary>
        /// ST - String Data.
        /// </summary>
        StringData,

        /// <summary>
        /// TM - Time.
        /// </summary>
        Time,

        /// <summary>
        /// TX - Text Data.
        /// </summary>
        TextData,

        /// <summary>
        /// UVC - UB Value Code And Amount.
        /// </summary>
        UbValueCodeAndAmount,

        /// <summary>
        /// VH - Visiting Hours.
        /// </summary>
        VisitingHours,

        /// <summary>
        /// VID - Version Identifier.
        /// </summary>
        VersionIdentifier,

        /// <summary>
        /// VR - Value Range.
        /// </summary>
        ValueRange,

        /// <summary>
        /// WVI - Channel Identifier.
        /// </summary>
        ChannelIdentifier,

        /// <summary>
        /// WVS - Waveform Source.
        /// </summary>
        WaveformSource,

        /// <summary>
        /// XAD - Extended Address.
        /// </summary>
        ExtendedAddress,

        /// <summary>
        /// XCN - Extended Composite ID Number And Name For Persons.
        /// </summary>
        ExtendedCompositeIdNumberAndNameForPersons,

        /// <summary>
        /// OXN - Extended Composite Name And ID Number For Organizations.
        /// </summary>
        ExtendedCompositeNameAndIdNumberForOrganizations,

        /// <summary>
        /// XPN - Extended Person Name.
        /// </summary>
        ExtendedPersonName,

        /// <summary>
        /// XTN - Extended Telecommunications Number.
        /// </summary>
        ExtendedTelecommunicationsNumber
    }
}
