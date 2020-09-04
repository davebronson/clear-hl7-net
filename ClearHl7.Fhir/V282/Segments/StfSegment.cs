using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment STF - Staff Identification.
    /// </summary>
    public class StfSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "STF";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// STF.1 - Primary Key Value - STF.
        ///// </summary>
        //public PrimaryKeyValueStf { get; set; }

        ///// <summary>
        ///// STF.2 - Staff Identifier List.
        ///// </summary>
        //public StaffIdentifierList { get; set; }

        ///// <summary>
        ///// STF.3 - Staff Name.
        ///// </summary>
        //public StaffName { get; set; }

        ///// <summary>
        ///// STF.4 - Staff Type.
        ///// </summary>
        //public StaffType { get; set; }

        ///// <summary>
        ///// STF.5 - Administrative Sex.
        ///// </summary>
        //public AdministrativeSex { get; set; }

        ///// <summary>
        ///// STF.6 - Date/Time of Birth.
        ///// </summary>
        //public DateTimeOfBirth { get; set; }

        ///// <summary>
        ///// STF.7 - Active/Inactive Flag.
        ///// </summary>
        //public ActiveInactiveFlag { get; set; }

        ///// <summary>
        ///// STF.8 - Department.
        ///// </summary>
        //public Department { get; set; }

        ///// <summary>
        ///// STF.9 - Hospital Service - STF.
        ///// </summary>
        //public HospitalServiceStf { get; set; }

        ///// <summary>
        ///// STF.10 - Phone.
        ///// </summary>
        //public Phone { get; set; }

        ///// <summary>
        ///// STF.11 - Office/Home Address/Birthplace.
        ///// </summary>
        //public OfficeHomeAddressBirthplace { get; set; }

        ///// <summary>
        ///// STF.12 - Institution Activation Date.
        ///// </summary>
        //public InstitutionActivationDate { get; set; }

        ///// <summary>
        ///// STF.13 - Institution Inactivation Date.
        ///// </summary>
        //public InstitutionInactivationDate { get; set; }

        ///// <summary>
        ///// STF.14 - Backup Person ID.
        ///// </summary>
        //public BackupPersonId { get; set; }

        ///// <summary>
        ///// STF.15 - E-Mail Address.
        ///// </summary>
        //public EMailAddress { get; set; }

        ///// <summary>
        ///// STF.16 - Preferred Method of Contact.
        ///// </summary>
        //public PreferredMethodOfContact { get; set; }

        ///// <summary>
        ///// STF.17 - Marital Status.
        ///// </summary>
        //public MaritalStatus { get; set; }

        ///// <summary>
        ///// STF.18 - Job Title.
        ///// </summary>
        //public JobTitle { get; set; }

        ///// <summary>
        ///// STF.19 - Job Code/Class.
        ///// </summary>
        //public JobCodeClass { get; set; }

        ///// <summary>
        ///// STF.20 - Employment Status Code.
        ///// </summary>
        //public EmploymentStatusCode { get; set; }

        ///// <summary>
        ///// STF.21 - Additional Insured on Auto.
        ///// </summary>
        //public AdditionalInsuredOnAuto { get; set; }

        ///// <summary>
        ///// STF.22 - Driver's License Number - Staff.
        ///// </summary>
        //public DriversLicenseNumberStaff { get; set; }

        ///// <summary>
        ///// STF.23 - Copy Auto Ins.
        ///// </summary>
        //public CopyAutoIns { get; set; }

        ///// <summary>
        ///// STF.24 - Auto Ins Expires.
        ///// </summary>
        //public AutoInsExpires { get; set; }

        ///// <summary>
        ///// STF.25 - Date Last DMV Review.
        ///// </summary>
        //public DateLastDmvReview { get; set; }

        ///// <summary>
        ///// STF.26 - Date Next DMV Review.
        ///// </summary>
        //public DateNextDmvReview { get; set; }

        ///// <summary>
        ///// STF.27 - Race.
        ///// </summary>
        //public Race { get; set; }

        ///// <summary>
        ///// STF.28 - Ethnic Group.
        ///// </summary>
        //public EthnicGroup { get; set; }

        ///// <summary>
        ///// STF.29 - Re-activation Approval Indicator.
        ///// </summary>
        //public ReActivationApprovalIndicator { get; set; }

        ///// <summary>
        ///// STF.30 - Citizenship.
        ///// </summary>
        //public Citizenship { get; set; }

        ///// <summary>
        ///// STF.31 - Date/Time of Death.
        ///// </summary>
        //public DateTimeOfDeath { get; set; }

        ///// <summary>
        ///// STF.32 - Death Indicator.
        ///// </summary>
        //public DeathIndicator { get; set; }

        ///// <summary>
        ///// STF.33 - Institution Relationship Type Code.
        ///// </summary>
        //public InstitutionRelationshipTypeCode { get; set; }

        ///// <summary>
        ///// STF.34 - Institution Relationship Period.
        ///// </summary>
        //public InstitutionRelationshipPeriod { get; set; }

        ///// <summary>
        ///// STF.35 - Expected Return Date.
        ///// </summary>
        //public ExpectedReturnDate { get; set; }

        ///// <summary>
        ///// STF.36 - Cost Center Code.
        ///// </summary>
        //public CostCenterCode { get; set; }

        ///// <summary>
        ///// STF.37 - Generic Classification Indicator.
        ///// </summary>
        //public GenericClassificationIndicator { get; set; }

        ///// <summary>
        ///// STF.38 - Inactive Reason Code.
        ///// </summary>
        //public InactiveReasonCode { get; set; }

        ///// <summary>
        ///// STF.39 - Generic resource type or category.
        ///// </summary>
        //public GenericResourceTypeOrCategory { get; set; }

        ///// <summary>
        ///// STF.40 - Religion.
        ///// </summary>
        //public Religion { get; set; }

        ///// <summary>
        ///// STF.41 - Signature.
        ///// </summary>
        //public Signature { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}|{30}|{31}|{32}|{33}|{34}|{35}|{36}|{37}|{38}|{39}|{40}|{41}"
                                ).TrimEnd('|');
        }
    }
}