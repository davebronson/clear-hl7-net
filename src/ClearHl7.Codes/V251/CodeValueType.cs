namespace ClearHl7.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0125 - Value Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0125</remarks>
    public enum CodeValueType
    {
        /// <summary>
        /// AD - Address.
        /// </summary>
        Address,
        
        /// <summary>
        /// CE - Coded Entry.
        /// </summary>
        CodedEntry,
        
        /// <summary>
        /// CF - Coded Element With Formatted Values.
        /// </summary>
        CodedElementWithFormattedValues,
        
        /// <summary>
        /// CK - Composite ID With Check Digit.
        /// </summary>
        CompositeIdWithCheckDigit,
        
        /// <summary>
        /// CN - Composite ID And Name.
        /// </summary>
        CompositeIdAndName,
        
        /// <summary>
        /// CP - Composite Price.
        /// </summary>
        CompositePrice,
        
        /// <summary>
        /// CX - Extended Composite ID With Check Digit.
        /// </summary>
        ExtendedCompositeIdWithCheckDigit,
        
        /// <summary>
        /// DT - Date.
        /// </summary>
        Date,
        
        /// <summary>
        /// ED - Encapsulated Data.
        /// </summary>
        EncapsulatedData,
        
        /// <summary>
        /// FT - Formatted Text.
        /// </summary>
        FormattedText,
        
        /// <summary>
        /// ID - Coded Value For HL7 Defined Tables.
        /// </summary>
        CodedValueForHl7DefinedTables,
        
        /// <summary>
        /// MO - Money.
        /// </summary>
        Money,
        
        /// <summary>
        /// NDL - Name With Date And Location.
        /// </summary>
        NameWithDateAndLocation,
        
        /// <summary>
        /// NM - Numeric.
        /// </summary>
        Numeric,
        
        /// <summary>
        /// PN - Person Name.
        /// </summary>
        PersonName,
        
        /// <summary>
        /// RP - Reference Pointer.
        /// </summary>
        ReferencePointer,
        
        /// <summary>
        /// SN - Structured Numeric.
        /// </summary>
        StructuredNumeric,
        
        /// <summary>
        /// ST - String Data.
        /// </summary>
        StringData,
        
        /// <summary>
        /// TM - Time.
        /// </summary>
        Time,
        
        /// <summary>
        /// TN - Telephone Number.
        /// </summary>
        TelephoneNumber,
        
        /// <summary>
        /// TS - Time Stamp (Date And Time).
        /// </summary>
        TimeStampDateAndTime,
        
        /// <summary>
        /// TX - Text Data.
        /// </summary>
        TextData,
        
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