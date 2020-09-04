using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PID - Patient Identification.
    /// </summary>
    public class PidSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PID";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// PID.1 - Set ID - PID.
        ///// </summary>
        //public SetIdPid { get; set; }

        ///// <summary>
        ///// PID.2 - Patient ID.
        ///// </summary>
        //public PatientId { get; set; }

        ///// <summary>
        ///// PID.3 - Patient Identifier List.
        ///// </summary>
        //public PatientIdentifierList { get; set; }

        ///// <summary>
        ///// PID.4 - Alternate Patient ID - PID.
        ///// </summary>
        //public AlternatePatientIdPid { get; set; }

        ///// <summary>
        ///// PID.5 - Patient Name.
        ///// </summary>
        //public PatientName { get; set; }

        ///// <summary>
        ///// PID.6 - Mother's Maiden Name.
        ///// </summary>
        //public MothersMaidenName { get; set; }

        ///// <summary>
        ///// PID.7 - Date/Time of Birth.
        ///// </summary>
        //public DateTimeOfBirth { get; set; }

        ///// <summary>
        ///// PID.8 - Administrative Sex.
        ///// </summary>
        //public AdministrativeSex { get; set; }

        ///// <summary>
        ///// PID.9 - Patient Alias.
        ///// </summary>
        //public PatientAlias { get; set; }

        ///// <summary>
        ///// PID.10 - Race.
        ///// </summary>
        //public Race { get; set; }

        ///// <summary>
        ///// PID.11 - Patient Address.
        ///// </summary>
        //public PatientAddress { get; set; }

        ///// <summary>
        ///// PID.12 - County Code.
        ///// </summary>
        //public CountyCode { get; set; }

        ///// <summary>
        ///// PID.13 - Phone Number - Home.
        ///// </summary>
        //public PhoneNumberHome { get; set; }

        ///// <summary>
        ///// PID.14 - Phone Number - Business.
        ///// </summary>
        //public PhoneNumberBusiness { get; set; }

        ///// <summary>
        ///// PID.15 - Primary Language.
        ///// </summary>
        //public PrimaryLanguage { get; set; }

        ///// <summary>
        ///// PID.16 - Marital Status.
        ///// </summary>
        //public MaritalStatus { get; set; }

        ///// <summary>
        ///// PID.17 - Religion.
        ///// </summary>
        //public Religion { get; set; }

        ///// <summary>
        ///// PID.18 - Patient Account Number.
        ///// </summary>
        //public PatientAccountNumber { get; set; }

        ///// <summary>
        ///// PID.19 - SSN Number - Patient.
        ///// </summary>
        //public SsnNumberPatient { get; set; }

        ///// <summary>
        ///// PID.20 - Driver's License Number - Patient.
        ///// </summary>
        //public DriversLicenseNumberPatient { get; set; }

        ///// <summary>
        ///// PID.21 - Mother's Identifier.
        ///// </summary>
        //public MothersIdentifier { get; set; }

        ///// <summary>
        ///// PID.22 - Ethnic Group.
        ///// </summary>
        //public EthnicGroup { get; set; }

        ///// <summary>
        ///// PID.23 - Birth Place.
        ///// </summary>
        //public BirthPlace { get; set; }

        ///// <summary>
        ///// PID.24 - Multiple Birth Indicator.
        ///// </summary>
        //public MultipleBirthIndicator { get; set; }

        ///// <summary>
        ///// PID.25 - Birth Order.
        ///// </summary>
        //public BirthOrder { get; set; }

        ///// <summary>
        ///// PID.26 - Citizenship.
        ///// </summary>
        //public Citizenship { get; set; }

        ///// <summary>
        ///// PID.27 - Veterans Military Status.
        ///// </summary>
        //public VeteransMilitaryStatus { get; set; }

        ///// <summary>
        ///// PID.28 - Nationality.
        ///// </summary>
        //public Nationality { get; set; }

        ///// <summary>
        ///// PID.29 - Patient Death Date and Time.
        ///// </summary>
        //public PatientDeathDateAndTime { get; set; }

        ///// <summary>
        ///// PID.30 - Patient Death Indicator.
        ///// </summary>
        //public PatientDeathIndicator { get; set; }

        ///// <summary>
        ///// PID.31 - Identity Unknown Indicator.
        ///// </summary>
        //public IdentityUnknownIndicator { get; set; }

        ///// <summary>
        ///// PID.32 - Identity Reliability Code.
        ///// </summary>
        //public IdentityReliabilityCode { get; set; }

        ///// <summary>
        ///// PID.33 - Last Update Date/Time.
        ///// </summary>
        //public LastUpdateDateTime { get; set; }

        ///// <summary>
        ///// PID.34 - Last Update Facility.
        ///// </summary>
        //public LastUpdateFacility { get; set; }

        ///// <summary>
        ///// PID.35 - Taxonomic Classification Code.
        ///// </summary>
        //public TaxonomicClassificationCode { get; set; }

        ///// <summary>
        ///// PID.36 - Breed Code.
        ///// </summary>
        //public BreedCode { get; set; }

        ///// <summary>
        ///// PID.37 - Strain.
        ///// </summary>
        //public Strain { get; set; }

        ///// <summary>
        ///// PID.38 - Production Class Code.
        ///// </summary>
        //public ProductionClassCode { get; set; }

        ///// <summary>
        ///// PID.39 - Tribal Citizenship.
        ///// </summary>
        //public TribalCitizenship { get; set; }

        ///// <summary>
        ///// PID.40 - Patient Telecommunication Information.
        ///// </summary>
        //public PatientTelecommunicationInformation { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}|{30}|{31}|{32}|{33}|{34}|{35}|{36}|{37}|{38}|{39}|{40}"
                                ).TrimEnd('|');
        }
    }
}