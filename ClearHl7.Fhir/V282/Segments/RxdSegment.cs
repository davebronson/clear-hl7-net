using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RXD - Pharmacy Treatment Dispense.
    /// </summary>
    public class RxdSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RXD";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// RXD.1 - Dispense Sub-ID Counter.
        ///// </summary>
        //public DispenseSubIdCounter { get; set; }

        ///// <summary>
        ///// RXD.2 - Dispense/Give Code.
        ///// </summary>
        //public DispenseGiveCode { get; set; }

        ///// <summary>
        ///// RXD.3 - Date/Time Dispensed.
        ///// </summary>
        //public DateTimeDispensed { get; set; }

        ///// <summary>
        ///// RXD.4 - Actual Dispense Amount.
        ///// </summary>
        //public ActualDispenseAmount { get; set; }

        ///// <summary>
        ///// RXD.5 - Actual Dispense Units.
        ///// </summary>
        //public ActualDispenseUnits { get; set; }

        ///// <summary>
        ///// RXD.6 - Actual Dosage Form.
        ///// </summary>
        //public ActualDosageForm { get; set; }

        ///// <summary>
        ///// RXD.7 - Prescription Number.
        ///// </summary>
        //public PrescriptionNumber { get; set; }

        ///// <summary>
        ///// RXD.8 - Number of Refills Remaining.
        ///// </summary>
        //public NumberOfRefillsRemaining { get; set; }

        ///// <summary>
        ///// RXD.9 - Dispense Notes.
        ///// </summary>
        //public DispenseNotes { get; set; }

        ///// <summary>
        ///// RXD.10 - Dispensing Provider.
        ///// </summary>
        //public DispensingProvider { get; set; }

        ///// <summary>
        ///// RXD.11 - Substitution Status.
        ///// </summary>
        //public SubstitutionStatus { get; set; }

        ///// <summary>
        ///// RXD.12 - Total Daily Dose.
        ///// </summary>
        //public TotalDailyDose { get; set; }

        ///// <summary>
        ///// RXD.13 - Dispense-to Location.
        ///// </summary>
        //public DispenseToLocation { get; set; }

        ///// <summary>
        ///// RXD.14 - Needs Human Review.
        ///// </summary>
        //public NeedsHumanReview { get; set; }

        ///// <summary>
        ///// RXD.15 - Special Dispensing Instructions.
        ///// </summary>
        //public SpecialDispensingInstructions { get; set; }

        ///// <summary>
        ///// RXD.16 - Actual Strength.
        ///// </summary>
        //public ActualStrength { get; set; }

        ///// <summary>
        ///// RXD.17 - Actual Strength Unit.
        ///// </summary>
        //public ActualStrengthUnit { get; set; }

        ///// <summary>
        ///// RXD.18 - Substance Lot Number.
        ///// </summary>
        //public SubstanceLotNumber { get; set; }

        ///// <summary>
        ///// RXD.19 - Substance Expiration Date.
        ///// </summary>
        //public SubstanceExpirationDate { get; set; }

        ///// <summary>
        ///// RXD.20 - Substance Manufacturer Name.
        ///// </summary>
        //public SubstanceManufacturerName { get; set; }

        ///// <summary>
        ///// RXD.21 - Indication.
        ///// </summary>
        //public Indication { get; set; }

        ///// <summary>
        ///// RXD.22 - Dispense Package Size.
        ///// </summary>
        //public DispensePackageSize { get; set; }

        ///// <summary>
        ///// RXD.23 - Dispense Package Size Unit.
        ///// </summary>
        //public DispensePackageSizeUnit { get; set; }

        ///// <summary>
        ///// RXD.24 - Dispense Package Method.
        ///// </summary>
        //public DispensePackageMethod { get; set; }

        ///// <summary>
        ///// RXD.25 - Supplementary Code.
        ///// </summary>
        //public SupplementaryCode { get; set; }

        ///// <summary>
        ///// RXD.26 - Initiating Location.
        ///// </summary>
        //public InitiatingLocation { get; set; }

        ///// <summary>
        ///// RXD.27 - Packaging/Assembly Location.
        ///// </summary>
        //public PackagingAssemblyLocation { get; set; }

        ///// <summary>
        ///// RXD.28 - Actual Drug Strength Volume.
        ///// </summary>
        //public ActualDrugStrengthVolume { get; set; }

        ///// <summary>
        ///// RXD.29 - Actual Drug Strength Volume Units.
        ///// </summary>
        //public ActualDrugStrengthVolumeUnits { get; set; }

        ///// <summary>
        ///// RXD.30 - Dispense to Pharmacy.
        ///// </summary>
        //public DispenseToPharmacy { get; set; }

        ///// <summary>
        ///// RXD.31 - Dispense to Pharmacy Address.
        ///// </summary>
        //public DispenseToPharmacyAddress { get; set; }

        ///// <summary>
        ///// RXD.32 - Pharmacy Order Type.
        ///// </summary>
        //public PharmacyOrderType { get; set; }

        ///// <summary>
        ///// RXD.33 - Dispense Type.
        ///// </summary>
        //public DispenseType { get; set; }

        ///// <summary>
        ///// RXD.34 - Pharmacy Phone Number.
        ///// </summary>
        //public PharmacyPhoneNumber { get; set; }

        ///// <summary>
        ///// RXD.35 - Dispense Tag Identifier.
        ///// </summary>
        //public DispenseTagIdentifier { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}|{30}|{31}|{32}|{33}|{34}|{35}"
                                ).TrimEnd('|');
        }
    }
}