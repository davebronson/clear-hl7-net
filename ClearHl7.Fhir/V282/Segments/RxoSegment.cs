using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RXO - Pharmacy Treatment Order.
    /// </summary>
    public class RxoSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RXO";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// RXO.1 - Requested Give Code.
        ///// </summary>
        //public RequestedGiveCode { get; set; }

        ///// <summary>
        ///// RXO.2 - Requested Give Amount - Minimum.
        ///// </summary>
        //public RequestedGiveAmountMinimum { get; set; }

        ///// <summary>
        ///// RXO.3 - Requested Give Amount - Maximum.
        ///// </summary>
        //public RequestedGiveAmountMaximum { get; set; }

        ///// <summary>
        ///// RXO.4 - Requested Give Units.
        ///// </summary>
        //public RequestedGiveUnits { get; set; }

        ///// <summary>
        ///// RXO.5 - Requested Dosage Form.
        ///// </summary>
        //public RequestedDosageForm { get; set; }

        ///// <summary>
        ///// RXO.6 - Provider's Pharmacy/Treatment Instructions.
        ///// </summary>
        //public ProvidersPharmacyTreatmentInstructions { get; set; }

        ///// <summary>
        ///// RXO.7 - Provider's Administration Instructions.
        ///// </summary>
        //public ProvidersAdministrationInstructions { get; set; }

        ///// <summary>
        ///// RXO.8 - Deliver-To Location.
        ///// </summary>
        //public DeliverToLocation { get; set; }

        ///// <summary>
        ///// RXO.9 - Allow Substitutions.
        ///// </summary>
        //public AllowSubstitutions { get; set; }

        ///// <summary>
        ///// RXO.10 - Requested Dispense Code.
        ///// </summary>
        //public RequestedDispenseCode { get; set; }

        ///// <summary>
        ///// RXO.11 - Requested Dispense Amount.
        ///// </summary>
        //public RequestedDispenseAmount { get; set; }

        ///// <summary>
        ///// RXO.12 - Requested Dispense Units.
        ///// </summary>
        //public RequestedDispenseUnits { get; set; }

        ///// <summary>
        ///// RXO.13 - Number Of Refills.
        ///// </summary>
        //public NumberOfRefills { get; set; }

        ///// <summary>
        ///// RXO.14 - Ordering Provider's DEA Number.
        ///// </summary>
        //public OrderingProvidersDeaNumber { get; set; }

        ///// <summary>
        ///// RXO.15 - Pharmacist/Treatment Supplier's Verifier ID.
        ///// </summary>
        //public PharmacistTreatmentSuppliersVerifierId { get; set; }

        ///// <summary>
        ///// RXO.16 - Needs Human Review.
        ///// </summary>
        //public NeedsHumanReview { get; set; }

        ///// <summary>
        ///// RXO.17 - Requested Give Per (Time Unit).
        ///// </summary>
        //public RequestedGivePerTimeUnit { get; set; }

        ///// <summary>
        ///// RXO.18 - Requested Give Strength.
        ///// </summary>
        //public RequestedGiveStrength { get; set; }

        ///// <summary>
        ///// RXO.19 - Requested Give Strength Units.
        ///// </summary>
        //public RequestedGiveStrengthUnits { get; set; }

        ///// <summary>
        ///// RXO.20 - Indication.
        ///// </summary>
        //public Indication { get; set; }

        ///// <summary>
        ///// RXO.21 - Requested Give Rate Amount.
        ///// </summary>
        //public RequestedGiveRateAmount { get; set; }

        ///// <summary>
        ///// RXO.22 - Requested Give Rate Units.
        ///// </summary>
        //public RequestedGiveRateUnits { get; set; }

        ///// <summary>
        ///// RXO.23 - Total Daily Dose.
        ///// </summary>
        //public TotalDailyDose { get; set; }

        ///// <summary>
        ///// RXO.24 - Supplementary Code.
        ///// </summary>
        //public SupplementaryCode { get; set; }

        ///// <summary>
        ///// RXO.25 - Requested Drug Strength Volume.
        ///// </summary>
        //public RequestedDrugStrengthVolume { get; set; }

        ///// <summary>
        ///// RXO.26 - Requested Drug Strength Volume Units.
        ///// </summary>
        //public RequestedDrugStrengthVolumeUnits { get; set; }

        ///// <summary>
        ///// RXO.27 - Pharmacy Order Type.
        ///// </summary>
        //public PharmacyOrderType { get; set; }

        ///// <summary>
        ///// RXO.28 - Dispensing Interval.
        ///// </summary>
        //public DispensingInterval { get; set; }

        ///// <summary>
        ///// RXO.29 - Medication Instance Identifier.
        ///// </summary>
        //public MedicationInstanceIdentifier { get; set; }

        ///// <summary>
        ///// RXO.30 - Segment Instance Identifier.
        ///// </summary>
        //public SegmentInstanceIdentifier { get; set; }

        ///// <summary>
        ///// RXO.31 - Mood Code.
        ///// </summary>
        //public MoodCode { get; set; }

        ///// <summary>
        ///// RXO.32 - Dispensing Pharmacy.
        ///// </summary>
        //public DispensingPharmacy { get; set; }

        ///// <summary>
        ///// RXO.33 - Dispensing Pharmacy Address.
        ///// </summary>
        //public DispensingPharmacyAddress { get; set; }

        ///// <summary>
        ///// RXO.34 - Deliver-to Patient Location.
        ///// </summary>
        //public DeliverToPatientLocation { get; set; }

        ///// <summary>
        ///// RXO.35 - Deliver-to Address.
        ///// </summary>
        //public DeliverToAddress { get; set; }

        ///// <summary>
        ///// RXO.36 - Pharmacy Phone Number.
        ///// </summary>
        //public PharmacyPhoneNumber { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}|{30}|{31}|{32}|{33}|{34}|{35}|{36}"
                                ).TrimEnd('|');
        }
    }
}