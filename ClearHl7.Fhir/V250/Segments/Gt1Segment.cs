using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V250.Types;

namespace ClearHl7.Fhir.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment GT1 - Guarantor.
    /// </summary>
    public class Gt1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "GT1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// GT1.1 - Set ID - GT1.
        /// </summary>
        public uint? SetIdGt1 { get; set; }

        /// <summary>
        /// GT1.2 - Guarantor Number.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> GuarantorNumber { get; set; }

        /// <summary>
        /// GT1.3 - Guarantor Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> GuarantorName { get; set; }

        /// <summary>
        /// GT1.4 - Guarantor Spouse Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> GuarantorSpouseName { get; set; }

        /// <summary>
        /// GT1.5 - Guarantor Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> GuarantorAddress { get; set; }

        /// <summary>
        /// GT1.6 - Guarantor Ph Num - Home.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> GuarantorPhNumHome { get; set; }

        /// <summary>
        /// GT1.7 - Guarantor Ph Num - Business.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> GuarantorPhNumBusiness { get; set; }

        /// <summary>
        /// GT1.8 - Guarantor Date/Time Of Birth.
        /// </summary>
        public DateTime? GuarantorDateTimeOfBirth { get; set; }

        /// <summary>
        /// GT1.9 - Guarantor Administrative Sex.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0001</remarks>
        public string GuarantorAdministrativeSex { get; set; }

        /// <summary>
        /// GT1.10 - Guarantor Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0068</remarks>
        public string GuarantorType { get; set; }

        /// <summary>
        /// GT1.11 - Guarantor Relationship.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0063</remarks>
        public CodedElement GuarantorRelationship { get; set; }

        /// <summary>
        /// GT1.12 - Guarantor SSN.
        /// </summary>
        public string GuarantorSsn { get; set; }

        /// <summary>
        /// GT1.13 - Guarantor Date - Begin.
        /// </summary>
        public DateTime? GuarantorDateBegin { get; set; }

        /// <summary>
        /// GT1.14 - Guarantor Date - End.
        /// </summary>
        public DateTime? GuarantorDateEnd { get; set; }

        /// <summary>
        /// GT1.15 - Guarantor Priority.
        /// </summary>
        public decimal? GuarantorPriority { get; set; }

        /// <summary>
        /// GT1.16 - Guarantor Employer Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> GuarantorEmployerName { get; set; }

        /// <summary>
        /// GT1.17 - Guarantor Employer Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> GuarantorEmployerAddress { get; set; }

        /// <summary>
        /// GT1.18 - Guarantor Employer Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> GuarantorEmployerPhoneNumber { get; set; }

        /// <summary>
        /// GT1.19 - Guarantor Employee ID Number.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> GuarantorEmployeeIdNumber { get; set; }

        /// <summary>
        /// GT1.20 - Guarantor Employment Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0066</remarks>
        public string GuarantorEmploymentStatus { get; set; }

        /// <summary>
        /// GT1.21 - Guarantor Organization Name.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> GuarantorOrganizationName { get; set; }

        /// <summary>
        /// GT1.22 - Guarantor Billing Hold Flag.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string GuarantorBillingHoldFlag { get; set; }

        /// <summary>
        /// GT1.23 - Guarantor Credit Rating Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0341</remarks>
        public CodedElement GuarantorCreditRatingCode { get; set; }

        /// <summary>
        /// GT1.24 - Guarantor Death Date And Time.
        /// </summary>
        public DateTime? GuarantorDeathDateAndTime { get; set; }

        /// <summary>
        /// GT1.25 - Guarantor Death Flag.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string GuarantorDeathFlag { get; set; }

        /// <summary>
        /// GT1.26 - Guarantor Charge Adjustment Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0218</remarks>
        public CodedElement GuarantorChargeAdjustmentCode { get; set; }

        /// <summary>
        /// GT1.27 - Guarantor Household Annual Income.
        /// </summary>
        public CompositePrice GuarantorHouseholdAnnualIncome { get; set; }

        /// <summary>
        /// GT1.28 - Guarantor Household Size.
        /// </summary>
        public decimal? GuarantorHouseholdSize { get; set; }

        /// <summary>
        /// GT1.29 - Guarantor Employer ID Number.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> GuarantorEmployerIdNumber { get; set; }

        /// <summary>
        /// GT1.30 - Guarantor Marital Status Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0002</remarks>
        public CodedElement GuarantorMaritalStatusCode { get; set; }

        /// <summary>
        /// GT1.31 - Guarantor Hire Effective Date.
        /// </summary>
        public DateTime? GuarantorHireEffectiveDate { get; set; }

        /// <summary>
        /// GT1.32 - Employment Stop Date.
        /// </summary>
        public DateTime? EmploymentStopDate { get; set; }

        /// <summary>
        /// GT1.33 - Living Dependency.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0223</remarks>
        public string LivingDependency { get; set; }

        /// <summary>
        /// GT1.34 - Ambulatory Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0009</remarks>
        public IEnumerable<string> AmbulatoryStatus { get; set; }

        /// <summary>
        /// GT1.35 - Citizenship.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0171</remarks>
        public IEnumerable<CodedElement> Citizenship { get; set; }

        /// <summary>
        /// GT1.36 - Primary Language.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0296</remarks>
        public CodedElement PrimaryLanguage { get; set; }

        /// <summary>
        /// GT1.37 - Living Arrangement.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0220</remarks>
        public string LivingArrangement { get; set; }

        /// <summary>
        /// GT1.38 - Publicity Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0215</remarks>
        public CodedElement PublicityCode { get; set; }

        /// <summary>
        /// GT1.39 - Protection Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string ProtectionIndicator { get; set; }

        /// <summary>
        /// GT1.40 - Student Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0231</remarks>
        public string StudentIndicator { get; set; }

        /// <summary>
        /// GT1.41 - Religion.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0006</remarks>
        public CodedElement Religion { get; set; }

        /// <summary>
        /// GT1.42 - Mother's Maiden Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> MothersMaidenName { get; set; }

        /// <summary>
        /// GT1.43 - Nationality.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0212</remarks>
        public CodedElement Nationality { get; set; }

        /// <summary>
        /// GT1.44 - Ethnic Group.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0189</remarks>
        public IEnumerable<CodedElement> EthnicGroup { get; set; }

        /// <summary>
        /// GT1.45 - Contact Person's Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> ContactPersonsName { get; set; }

        /// <summary>
        /// GT1.46 - Contact Person's Telephone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> ContactPersonsTelephoneNumber { get; set; }

        /// <summary>
        /// GT1.47 - Contact Reason.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0222</remarks>
        public CodedElement ContactReason { get; set; }

        /// <summary>
        /// GT1.48 - Contact Relationship.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0063</remarks>
        public string ContactRelationship { get; set; }

        /// <summary>
        /// GT1.49 - Job Title.
        /// </summary>
        public string JobTitle { get; set; }

        /// <summary>
        /// GT1.50 - Job Code/Class.
        /// </summary>
        public JobCodeClass JobCodeClass { get; set; }

        /// <summary>
        /// GT1.51 - Guarantor Employer's Organization Name.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> GuarantorEmployersOrganizationName { get; set; }

        /// <summary>
        /// GT1.52 - Handicap.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0295</remarks>
        public string Handicap { get; set; }

        /// <summary>
        /// GT1.53 - Job Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0311</remarks>
        public string JobStatus { get; set; }

        /// <summary>
        /// GT1.54 - Guarantor Financial Class.
        /// </summary>
        public FinancialClass GuarantorFinancialClass { get; set; }

        /// <summary>
        /// GT1.55 - Guarantor Race.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0005</remarks>
        public IEnumerable<CodedElement> GuarantorRace { get; set; }

        /// <summary>
        /// GT1.56 - Guarantor Birth Place.
        /// </summary>
        public string GuarantorBirthPlace { get; set; }

        /// <summary>
        /// GT1.57 - VIP Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0099</remarks>
        public string VipIndicator { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 58, Configuration.FieldSeparator),
                                Id,
                                SetIdGt1.HasValue ? SetIdGt1.Value.ToString(culture) : null,
                                GuarantorNumber != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorNumber.Select(x => x.ToDelimitedString())) : null,
                                GuarantorName != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorName.Select(x => x.ToDelimitedString())) : null,
                                GuarantorSpouseName != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorSpouseName.Select(x => x.ToDelimitedString())) : null,
                                GuarantorAddress != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorAddress.Select(x => x.ToDelimitedString())) : null,
                                GuarantorPhNumHome != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorPhNumHome.Select(x => x.ToDelimitedString())) : null,
                                GuarantorPhNumBusiness != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorPhNumBusiness.Select(x => x.ToDelimitedString())) : null,
                                GuarantorDateTimeOfBirth.HasValue ? GuarantorDateTimeOfBirth.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                GuarantorAdministrativeSex,
                                GuarantorType,
                                GuarantorRelationship?.ToDelimitedString(),
                                GuarantorSsn,
                                GuarantorDateBegin.HasValue ? GuarantorDateBegin.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                GuarantorDateEnd.HasValue ? GuarantorDateEnd.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                GuarantorPriority.HasValue ? GuarantorPriority.Value.ToString(Consts.NumericFormat, culture) : null,
                                GuarantorEmployerName != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorEmployerName.Select(x => x.ToDelimitedString())) : null,
                                GuarantorEmployerAddress != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorEmployerAddress.Select(x => x.ToDelimitedString())) : null,
                                GuarantorEmployerPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorEmployerPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                GuarantorEmployeeIdNumber != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorEmployeeIdNumber.Select(x => x.ToDelimitedString())) : null,
                                GuarantorEmploymentStatus,
                                GuarantorOrganizationName != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorOrganizationName.Select(x => x.ToDelimitedString())) : null,
                                GuarantorBillingHoldFlag,
                                GuarantorCreditRatingCode?.ToDelimitedString(),
                                GuarantorDeathDateAndTime.HasValue ? GuarantorDeathDateAndTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                GuarantorDeathFlag,
                                GuarantorChargeAdjustmentCode?.ToDelimitedString(),
                                GuarantorHouseholdAnnualIncome?.ToDelimitedString(),
                                GuarantorHouseholdSize.HasValue ? GuarantorHouseholdSize.Value.ToString(Consts.NumericFormat, culture) : null,
                                GuarantorEmployerIdNumber != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorEmployerIdNumber.Select(x => x.ToDelimitedString())) : null,
                                GuarantorMaritalStatusCode?.ToDelimitedString(),
                                GuarantorHireEffectiveDate.HasValue ? GuarantorHireEffectiveDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                EmploymentStopDate.HasValue ? EmploymentStopDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                LivingDependency,
                                AmbulatoryStatus != null ? string.Join(Configuration.FieldRepeatSeparator, AmbulatoryStatus) : null,
                                Citizenship != null ? string.Join(Configuration.FieldRepeatSeparator, Citizenship.Select(x => x.ToDelimitedString())) : null,
                                PrimaryLanguage?.ToDelimitedString(),
                                LivingArrangement,
                                PublicityCode?.ToDelimitedString(),
                                ProtectionIndicator,
                                StudentIndicator,
                                Religion?.ToDelimitedString(),
                                MothersMaidenName != null ? string.Join(Configuration.FieldRepeatSeparator, MothersMaidenName.Select(x => x.ToDelimitedString())) : null,
                                Nationality?.ToDelimitedString(),
                                EthnicGroup != null ? string.Join(Configuration.FieldRepeatSeparator, EthnicGroup.Select(x => x.ToDelimitedString())) : null,
                                ContactPersonsName != null ? string.Join(Configuration.FieldRepeatSeparator, ContactPersonsName.Select(x => x.ToDelimitedString())) : null,
                                ContactPersonsTelephoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, ContactPersonsTelephoneNumber.Select(x => x.ToDelimitedString())) : null,
                                ContactReason?.ToDelimitedString(),
                                ContactRelationship,
                                JobTitle,
                                JobCodeClass?.ToDelimitedString(),
                                GuarantorEmployersOrganizationName != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorEmployersOrganizationName.Select(x => x.ToDelimitedString())) : null,
                                Handicap,
                                JobStatus,
                                GuarantorFinancialClass?.ToDelimitedString(),
                                GuarantorRace != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorRace.Select(x => x.ToDelimitedString())) : null,
                                GuarantorBirthPlace,
                                VipIndicator
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}