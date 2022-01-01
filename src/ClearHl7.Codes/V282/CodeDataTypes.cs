namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0440 - Data Types.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0440</remarks>
    public enum CodeDataTypes
    {
        /// <summary>
        /// AD - Address.
        /// </summary>
        Address,

        /// <summary>
        /// AUI - Authorization information.
        /// </summary>
        AuthorizationInformation,

        /// <summary>
        /// CCD - Charge code and date.
        /// </summary>
        ChargeCodeAndDate,

        /// <summary>
        /// CCP - Channel calibration parameters.
        /// </summary>
        ChannelCalibrationParameters,

        /// <summary>
        /// CD - Channel definition.
        /// </summary>
        ChannelDefinition,

        /// <summary>
        /// CE - Coded element.
        /// </summary>
        CodedElement,

        /// <summary>
        /// CF - Coded element with formatted values.
        /// </summary>
        CodedElementWithFormattedValues,

        /// <summary>
        /// CK - Composite ID with check digit.
        /// </summary>
        CompositeIdWithCheckDigit,

        /// <summary>
        /// CM - Composite.
        /// </summary>
        Composite,

        /// <summary>
        /// CN - Composite ID number and name.
        /// </summary>
        CompositeIdNumberAndName,

        /// <summary>
        /// CNE - Coded with no exceptions.
        /// </summary>
        CodedWithNoExceptions,

        /// <summary>
        /// CNN - Composite ID number and name simplified.
        /// </summary>
        CompositeIdNumberAndNameSimplified,

        /// <summary>
        /// CP - Composite price.
        /// </summary>
        CompositePrice,

        /// <summary>
        /// CQ - Composite quantity with units.
        /// </summary>
        CompositeQuantityWithUnits,

        /// <summary>
        /// CSU - Channel sensitivity and units.
        /// </summary>
        ChannelSensitivityAndUnits,

        /// <summary>
        /// CWE - Coded with exceptions.
        /// </summary>
        CodedWithExceptions,

        /// <summary>
        /// CX - Extended composite ID with check digit.
        /// </summary>
        ExtendedCompositeIdWithCheckDigit,

        /// <summary>
        /// DDI - Daily deductible information.
        /// </summary>
        DailyDeductibleInformation,

        /// <summary>
        /// DIN - Date and institution name.
        /// </summary>
        DateAndInstitutionName,

        /// <summary>
        /// DLD - Discharge to location and date.
        /// </summary>
        DischargeToLocationAndDate,

        /// <summary>
        /// DLN - Driver's license number.
        /// </summary>
        DriversLicenseNumber,

        /// <summary>
        /// DLT - Delta.
        /// </summary>
        Delta,

        /// <summary>
        /// DR - Date/time range.
        /// </summary>
        DateTimeRange,

        /// <summary>
        /// DT - Date.
        /// </summary>
        Date,

        /// <summary>
        /// DTM - Date/time.
        /// </summary>
        DateTime,

        /// <summary>
        /// DTN - Day type and number.
        /// </summary>
        DayTypeAndNumber,

        /// <summary>
        /// ED - Encapsulated data.
        /// </summary>
        EncapsulatedData,

        /// <summary>
        /// EI - Entity identifier.
        /// </summary>
        EntityIdentifier,

        /// <summary>
        /// EIP - Entity identifier pair.
        /// </summary>
        EntityIdentifierPair,

        /// <summary>
        /// ELD - Error location and description.
        /// </summary>
        ErrorLocationAndDescription,

        /// <summary>
        /// ERL - Error location.
        /// </summary>
        ErrorLocation,

        /// <summary>
        /// FC - Financial class.
        /// </summary>
        FinancialClass,

        /// <summary>
        /// FN - Family name.
        /// </summary>
        FamilyName,

        /// <summary>
        /// FT - Formatted text.
        /// </summary>
        FormattedText,

        /// <summary>
        /// GTS - General timing specification.
        /// </summary>
        GeneralTimingSpecification,

        /// <summary>
        /// HD - Hierarchic designator.
        /// </summary>
        HierarchicDesignator,

        /// <summary>
        /// ICD - Insurance certification definition.
        /// </summary>
        InsuranceCertificationDefinition,

        /// <summary>
        /// ID - Coded values for HL7 tables.
        /// </summary>
        CodedValuesForHl7Tables,

        /// <summary>
        /// IS - Coded value for user-defined tables.
        /// </summary>
        CodedValueForUserDefinedTables,

        /// <summary>
        /// JCC - Job code/class.
        /// </summary>
        JobCodeClass,

        /// <summary>
        /// LA1 - Location with address variation 1.
        /// </summary>
        LocationWithAddressVariation1,

        /// <summary>
        /// LA2 - Location with address variation 2.
        /// </summary>
        LocationWithAddressVariation2,

        /// <summary>
        /// MA - Multiplexed array.
        /// </summary>
        MultiplexedArray,

        /// <summary>
        /// MO - Money.
        /// </summary>
        Money,

        /// <summary>
        /// MOC - Money and charge code.
        /// </summary>
        MoneyAndChargeCode,

        /// <summary>
        /// MOP - Money or percentage.
        /// </summary>
        MoneyOrPercentage,

        /// <summary>
        /// MSG - Message type.
        /// </summary>
        MessageType,

        /// <summary>
        /// NA - Numeric array.
        /// </summary>
        NumericArray,

        /// <summary>
        /// NDL - Name with date and location.
        /// </summary>
        NameWithDateAndLocation,

        /// <summary>
        /// NM - Numeric.
        /// </summary>
        Numeric,

        /// <summary>
        /// NR - Numeric range.
        /// </summary>
        NumericRange,

        /// <summary>
        /// OCD - Occurrence code and date.
        /// </summary>
        OccurrenceCodeAndDate,

        /// <summary>
        /// OSD - Order sequence definition.
        /// </summary>
        OrderSequenceDefinition,

        /// <summary>
        /// OSP - Occurrence span code and date.
        /// </summary>
        OccurrenceSpanCodeAndDate,

        /// <summary>
        /// PIP - Practitioner institutional privileges.
        /// </summary>
        PractitionerInstitutionalPrivileges,

        /// <summary>
        /// PL - Person location.
        /// </summary>
        PersonLocation,

        /// <summary>
        /// PLN - Practitioner license or other ID number.
        /// </summary>
        PractitionerLicenseOrOtherIdNumber,

        /// <summary>
        /// PN - Person name.
        /// </summary>
        PersonName,

        /// <summary>
        /// PPN - Performing person time stamp.
        /// </summary>
        PerformingPersonTimeStamp,

        /// <summary>
        /// PRL - Parent result link.
        /// </summary>
        ParentResultLink,

        /// <summary>
        /// PT - Processing type.
        /// </summary>
        ProcessingType,

        /// <summary>
        /// PTA - Policy type and amount.
        /// </summary>
        PolicyTypeAndAmount,

        /// <summary>
        /// QIP - Query input parameter list.
        /// </summary>
        QueryInputParameterList,

        /// <summary>
        /// QSC - Query selection criteria.
        /// </summary>
        QuerySelectionCriteria,

        /// <summary>
        /// RCD - Row column definition.
        /// </summary>
        RowColumnDefinition,

        /// <summary>
        /// RFR - Reference range.
        /// </summary>
        ReferenceRange,

        /// <summary>
        /// RI - Repeat interval.
        /// </summary>
        RepeatInterval,

        /// <summary>
        /// RMC - Room coverage.
        /// </summary>
        RoomCoverage,

        /// <summary>
        /// RP - Reference pointer.
        /// </summary>
        ReferencePointer,

        /// <summary>
        /// RPT - Repeat pattern.
        /// </summary>
        RepeatPattern,

        /// <summary>
        /// SAD - Street Address.
        /// </summary>
        StreetAddress,

        /// <summary>
        /// SCV - Scheduling class value pair.
        /// </summary>
        SchedulingClassValuePair,

        /// <summary>
        /// SI - Sequence ID.
        /// </summary>
        SequenceId,

        /// <summary>
        /// SN - Structured numeric.
        /// </summary>
        StructuredNumeric,

        /// <summary>
        /// SNM - String of telephone number digits.
        /// </summary>
        StringOfTelephoneNumberDigits,

        /// <summary>
        /// SPD - Specialty description.
        /// </summary>
        SpecialtyDescription,

        /// <summary>
        /// SPS - Specimen source.
        /// </summary>
        SpecimenSource,

        /// <summary>
        /// SRT - Sort order.
        /// </summary>
        SortOrder,

        /// <summary>
        /// ST - String data.
        /// </summary>
        StringData,

        /// <summary>
        /// TM - Time.
        /// </summary>
        Time,

        /// <summary>
        /// TN - Telephone number.
        /// </summary>
        TelephoneNumber,

        /// <summary>
        /// TQ - Timing/quantity.
        /// </summary>
        TimingQuantity,

        /// <summary>
        /// TS - Time stamp.
        /// </summary>
        TimeStamp,

        /// <summary>
        /// TX - Text data.
        /// </summary>
        TextData,

        /// <summary>
        /// UVC - UB value code and amount.
        /// </summary>
        UbValueCodeAndAmount,

        /// <summary>
        /// VH - Visiting hours.
        /// </summary>
        VisitingHours,

        /// <summary>
        /// VID - Version identifier.
        /// </summary>
        VersionIdentifier,

        /// <summary>
        /// VR - Value range.
        /// </summary>
        ValueRange,

        /// <summary>
        /// WVI - Channel Identifier.
        /// </summary>
        ChannelIdentifier,

        /// <summary>
        /// WVS - Waveform source.
        /// </summary>
        WaveformSource,

        /// <summary>
        /// XAD - Extended address.
        /// </summary>
        ExtendedAddress,

        /// <summary>
        /// XCN - Extended composite ID number and name for persons.
        /// </summary>
        ExtendedCompositeIdNumberAndNameForPersons,

        /// <summary>
        /// XON - Extended composite name and ID number for organizations.
        /// </summary>
        ExtendedCompositeNameAndIdNumberForOrganizations,

        /// <summary>
        /// XPN - Extended person name.
        /// </summary>
        ExtendedPersonName,

        /// <summary>
        /// XTN - Extended telecommunications number.
        /// </summary>
        ExtendedTelecommunicationsNumber
    }
}
