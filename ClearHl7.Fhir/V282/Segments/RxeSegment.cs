using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RXE - Pharmacy Treatment Encoded Order.
    /// </summary>
    public class RxeSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RXE";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// RXE.1 - Quantity/Timing.
        ///// </summary>
        //public QuantityTiming { get; set; }

        ///// <summary>
        ///// RXE.2 - Give Code.
        ///// </summary>
        //public GiveCode { get; set; }

        ///// <summary>
        ///// RXE.3 - Give Amount - Minimum.
        ///// </summary>
        //public GiveAmountMinimum { get; set; }

        ///// <summary>
        ///// RXE.4 - Give Amount - Maximum.
        ///// </summary>
        //public GiveAmountMaximum { get; set; }

        ///// <summary>
        ///// RXE.5 - Give Units.
        ///// </summary>
        //public GiveUnits { get; set; }

        ///// <summary>
        ///// RXE.6 - Give Dosage Form.
        ///// </summary>
        //public GiveDosageForm { get; set; }

        ///// <summary>
        ///// RXE.7 - Provider's Administration Instructions.
        ///// </summary>
        //public ProvidersAdministrationInstructions { get; set; }

        ///// <summary>
        ///// RXE.8 - Deliver-To Location.
        ///// </summary>
        //public DeliverToLocation { get; set; }

        ///// <summary>
        ///// RXE.9 - Substitution Status.
        ///// </summary>
        //public SubstitutionStatus { get; set; }

        ///// <summary>
        ///// RXE.10 - Dispense Amount.
        ///// </summary>
        //public DispenseAmount { get; set; }

        ///// <summary>
        ///// RXE.11 - Dispense Units.
        ///// </summary>
        //public DispenseUnits { get; set; }

        ///// <summary>
        ///// RXE.12 - Number Of Refills.
        ///// </summary>
        //public NumberOfRefills { get; set; }

        ///// <summary>
        ///// RXE.13 - Ordering Provider's DEA Number.
        ///// </summary>
        //public OrderingProvidersDeaNumber { get; set; }

        ///// <summary>
        ///// RXE.14 - Pharmacist/Treatment Supplier's Verifier ID.
        ///// </summary>
        //public PharmacistTreatmentSuppliersVerifierId { get; set; }

        ///// <summary>
        ///// RXE.15 - Prescription Number.
        ///// </summary>
        //public PrescriptionNumber { get; set; }

        ///// <summary>
        ///// RXE.16 - Number of Refills Remaining.
        ///// </summary>
        //public NumberOfRefillsRemaining { get; set; }

        ///// <summary>
        ///// RXE.17 - Number of Refills/Doses Dispensed.
        ///// </summary>
        //public NumberOfRefillsDosesDispensed { get; set; }

        ///// <summary>
        ///// RXE.18 - D/T of Most Recent Refill or Dose Dispensed.
        ///// </summary>
        //public DTOfMostRecentRefillOrDoseDispensed { get; set; }

        ///// <summary>
        ///// RXE.19 - Total Daily Dose.
        ///// </summary>
        //public TotalDailyDose { get; set; }

        ///// <summary>
        ///// RXE.20 - Needs Human Review.
        ///// </summary>
        //public NeedsHumanReview { get; set; }

        ///// <summary>
        ///// RXE.21 - Special Dispensing Instructions.
        ///// </summary>
        //public SpecialDispensingInstructions { get; set; }

        ///// <summary>
        ///// RXE.22 - Give Per (Time Unit).
        ///// </summary>
        //public GivePerTimeUnit { get; set; }

        ///// <summary>
        ///// RXE.23 - Give Rate Amount.
        ///// </summary>
        //public GiveRateAmount { get; set; }

        ///// <summary>
        ///// RXE.24 - Give Rate Units.
        ///// </summary>
        //public GiveRateUnits { get; set; }

        ///// <summary>
        ///// RXE.25 - Give Strength.
        ///// </summary>
        //public GiveStrength { get; set; }

        ///// <summary>
        ///// RXE.26 - Give Strength Units.
        ///// </summary>
        //public GiveStrengthUnits { get; set; }

        ///// <summary>
        ///// RXE.27 - Give Indication.
        ///// </summary>
        //public GiveIndication { get; set; }

        ///// <summary>
        ///// RXE.28 - Dispense Package Size.
        ///// </summary>
        //public DispensePackageSize { get; set; }

        ///// <summary>
        ///// RXE.29 - Dispense Package Size Unit.
        ///// </summary>
        //public DispensePackageSizeUnit { get; set; }

        ///// <summary>
        ///// RXE.30 - Dispense Package Method.
        ///// </summary>
        //public DispensePackageMethod { get; set; }

        ///// <summary>
        ///// RXE.31 - Supplementary Code.
        ///// </summary>
        //public SupplementaryCode { get; set; }

        ///// <summary>
        ///// RXE.32 - Original Order Date/Time.
        ///// </summary>
        //public OriginalOrderDateTime { get; set; }

        ///// <summary>
        ///// RXE.33 - Give Drug Strength Volume.
        ///// </summary>
        //public GiveDrugStrengthVolume { get; set; }

        ///// <summary>
        ///// RXE.34 - Give Drug Strength Volume Units.
        ///// </summary>
        //public GiveDrugStrengthVolumeUnits { get; set; }

        ///// <summary>
        ///// RXE.35 - Controlled Substance Schedule.
        ///// </summary>
        //public ControlledSubstanceSchedule { get; set; }

        ///// <summary>
        ///// RXE.36 - Formulary Status.
        ///// </summary>
        //public FormularyStatus { get; set; }

        ///// <summary>
        ///// RXE.37 - Pharmaceutical Substance Alternative.
        ///// </summary>
        //public PharmaceuticalSubstanceAlternative { get; set; }

        ///// <summary>
        ///// RXE.38 - Pharmacy of Most Recent Fill.
        ///// </summary>
        //public PharmacyOfMostRecentFill { get; set; }

        ///// <summary>
        ///// RXE.39 - Initial Dispense Amount.
        ///// </summary>
        //public InitialDispenseAmount { get; set; }

        ///// <summary>
        ///// RXE.40 - Dispensing Pharmacy.
        ///// </summary>
        //public DispensingPharmacy { get; set; }

        ///// <summary>
        ///// RXE.41 - Dispensing Pharmacy Address.
        ///// </summary>
        //public DispensingPharmacyAddress { get; set; }

        ///// <summary>
        ///// RXE.42 - Deliver-to Patient Location.
        ///// </summary>
        //public DeliverToPatientLocation { get; set; }

        ///// <summary>
        ///// RXE.43 - Deliver-to Address.
        ///// </summary>
        //public DeliverToAddress { get; set; }

        ///// <summary>
        ///// RXE.44 - Pharmacy Order Type.
        ///// </summary>
        //public PharmacyOrderType { get; set; }

        ///// <summary>
        ///// RXE.45 - Pharmacy Phone Number.
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
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}|{30}|{31}|{32}|{33}|{34}|{35}|{36}|{37}|{38}|{39}|{40}|{41}|{42}|{43}|{44}|{45}"
                                ).TrimEnd('|');
        }
    }
}