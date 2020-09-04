using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RXG - Pharmacy Treatment Give.
    /// </summary>
    public class RxgSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RXG";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// RXG.1 - Give Sub-ID Counter.
        ///// </summary>
        //public GiveSubIdCounter { get; set; }

        ///// <summary>
        ///// RXG.2 - Dispense Sub-ID Counter.
        ///// </summary>
        //public DispenseSubIdCounter { get; set; }

        ///// <summary>
        ///// RXG.3 - Quantity/Timing.
        ///// </summary>
        //public QuantityTiming { get; set; }

        ///// <summary>
        ///// RXG.4 - Give Code.
        ///// </summary>
        //public GiveCode { get; set; }

        ///// <summary>
        ///// RXG.5 - Give Amount - Minimum.
        ///// </summary>
        //public GiveAmountMinimum { get; set; }

        ///// <summary>
        ///// RXG.6 - Give Amount - Maximum.
        ///// </summary>
        //public GiveAmountMaximum { get; set; }

        ///// <summary>
        ///// RXG.7 - Give Units.
        ///// </summary>
        //public GiveUnits { get; set; }

        ///// <summary>
        ///// RXG.8 - Give Dosage Form.
        ///// </summary>
        //public GiveDosageForm { get; set; }

        ///// <summary>
        ///// RXG.9 - Administration Notes.
        ///// </summary>
        //public AdministrationNotes { get; set; }

        ///// <summary>
        ///// RXG.10 - Substitution Status.
        ///// </summary>
        //public SubstitutionStatus { get; set; }

        ///// <summary>
        ///// RXG.11 - Dispense-to Location.
        ///// </summary>
        //public DispenseToLocation { get; set; }

        ///// <summary>
        ///// RXG.12 - Needs Human Review.
        ///// </summary>
        //public NeedsHumanReview { get; set; }

        ///// <summary>
        ///// RXG.13 - Special Administration Instructions.
        ///// </summary>
        //public SpecialAdministrationInstructions { get; set; }

        ///// <summary>
        ///// RXG.14 - Give Per (Time Unit).
        ///// </summary>
        //public GivePerTimeUnit { get; set; }

        ///// <summary>
        ///// RXG.15 - Give Rate Amount.
        ///// </summary>
        //public GiveRateAmount { get; set; }

        ///// <summary>
        ///// RXG.16 - Give Rate Units.
        ///// </summary>
        //public GiveRateUnits { get; set; }

        ///// <summary>
        ///// RXG.17 - Give Strength.
        ///// </summary>
        //public GiveStrength { get; set; }

        ///// <summary>
        ///// RXG.18 - Give Strength Units.
        ///// </summary>
        //public GiveStrengthUnits { get; set; }

        ///// <summary>
        ///// RXG.19 - Substance Lot Number.
        ///// </summary>
        //public SubstanceLotNumber { get; set; }

        ///// <summary>
        ///// RXG.20 - Substance Expiration Date.
        ///// </summary>
        //public SubstanceExpirationDate { get; set; }

        ///// <summary>
        ///// RXG.21 - Substance Manufacturer Name.
        ///// </summary>
        //public SubstanceManufacturerName { get; set; }

        ///// <summary>
        ///// RXG.22 - Indication.
        ///// </summary>
        //public Indication { get; set; }

        ///// <summary>
        ///// RXG.23 - Give Drug Strength Volume.
        ///// </summary>
        //public GiveDrugStrengthVolume { get; set; }

        ///// <summary>
        ///// RXG.24 - Give Drug Strength Volume Units.
        ///// </summary>
        //public GiveDrugStrengthVolumeUnits { get; set; }

        ///// <summary>
        ///// RXG.25 - Give Barcode Identifier.
        ///// </summary>
        //public GiveBarcodeIdentifier { get; set; }

        ///// <summary>
        ///// RXG.26 - Pharmacy Order Type.
        ///// </summary>
        //public PharmacyOrderType { get; set; }

        ///// <summary>
        ///// RXG.27 - Dispense to Pharmacy.
        ///// </summary>
        //public DispenseToPharmacy { get; set; }

        ///// <summary>
        ///// RXG.28 - Dispense to Pharmacy Address.
        ///// </summary>
        //public DispenseToPharmacyAddress { get; set; }

        ///// <summary>
        ///// RXG.29 - Deliver-to Patient Location.
        ///// </summary>
        //public DeliverToPatientLocation { get; set; }

        ///// <summary>
        ///// RXG.30 - Deliver-to Address.
        ///// </summary>
        //public DeliverToAddress { get; set; }

        ///// <summary>
        ///// RXG.31 - Give Tag Identifier.
        ///// </summary>
        //public GiveTagIdentifier { get; set; }

        ///// <summary>
        ///// RXG.32 - Dispense Amount.
        ///// </summary>
        //public DispenseAmount { get; set; }

        ///// <summary>
        ///// RXG.33 - Dispense Units.
        ///// </summary>
        //public DispenseUnits { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}|{30}|{31}|{32}|{33}"
                                ).TrimEnd('|');
        }
    }
}