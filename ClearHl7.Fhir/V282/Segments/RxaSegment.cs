using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RXA - Pharmacy Treatment Administration.
    /// </summary>
    public class RxaSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RXA";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// RXA.1 - Give Sub-ID Counter.
        ///// </summary>
        //public GiveSubIdCounter { get; set; }

        ///// <summary>
        ///// RXA.2 - Administration Sub-ID Counter.
        ///// </summary>
        //public AdministrationSubIdCounter { get; set; }

        ///// <summary>
        ///// RXA.3 - Date/Time Start of Administration.
        ///// </summary>
        //public DateTimeStartOfAdministration { get; set; }

        ///// <summary>
        ///// RXA.4 - Date/Time End of Administration.
        ///// </summary>
        //public DateTimeEndOfAdministration { get; set; }

        ///// <summary>
        ///// RXA.5 - Administered Code.
        ///// </summary>
        //public AdministeredCode { get; set; }

        ///// <summary>
        ///// RXA.6 - Administered Amount.
        ///// </summary>
        //public AdministeredAmount { get; set; }

        ///// <summary>
        ///// RXA.7 - Administered Units.
        ///// </summary>
        //public AdministeredUnits { get; set; }

        ///// <summary>
        ///// RXA.8 - Administered Dosage Form.
        ///// </summary>
        //public AdministeredDosageForm { get; set; }

        ///// <summary>
        ///// RXA.9 - Administration Notes.
        ///// </summary>
        //public AdministrationNotes { get; set; }

        ///// <summary>
        ///// RXA.10 - Administering Provider.
        ///// </summary>
        //public AdministeringProvider { get; set; }

        ///// <summary>
        ///// RXA.11 - Administered-at Location.
        ///// </summary>
        //public AdministeredAtLocation { get; set; }

        ///// <summary>
        ///// RXA.12 - Administered Per (Time Unit).
        ///// </summary>
        //public AdministeredPerTimeUnit { get; set; }

        ///// <summary>
        ///// RXA.13 - Administered Strength.
        ///// </summary>
        //public AdministeredStrength { get; set; }

        ///// <summary>
        ///// RXA.14 - Administered Strength Units.
        ///// </summary>
        //public AdministeredStrengthUnits { get; set; }

        ///// <summary>
        ///// RXA.15 - Substance Lot Number.
        ///// </summary>
        //public SubstanceLotNumber { get; set; }

        ///// <summary>
        ///// RXA.16 - Substance Expiration Date.
        ///// </summary>
        //public SubstanceExpirationDate { get; set; }

        ///// <summary>
        ///// RXA.17 - Substance Manufacturer Name.
        ///// </summary>
        //public SubstanceManufacturerName { get; set; }

        ///// <summary>
        ///// RXA.18 - Substance/Treatment Refusal Reason.
        ///// </summary>
        //public SubstanceTreatmentRefusalReason { get; set; }

        ///// <summary>
        ///// RXA.19 - Indication.
        ///// </summary>
        //public Indication { get; set; }

        ///// <summary>
        ///// RXA.20 - Completion Status.
        ///// </summary>
        //public CompletionStatus { get; set; }

        ///// <summary>
        ///// RXA.21 - Action Code - RXA.
        ///// </summary>
        //public ActionCodeRxa { get; set; }

        ///// <summary>
        ///// RXA.22 - System Entry Date/Time.
        ///// </summary>
        //public SystemEntryDateTime { get; set; }

        ///// <summary>
        ///// RXA.23 - Administered Drug Strength Volume.
        ///// </summary>
        //public AdministeredDrugStrengthVolume { get; set; }

        ///// <summary>
        ///// RXA.24 - Administered Drug Strength Volume Units.
        ///// </summary>
        //public AdministeredDrugStrengthVolumeUnits { get; set; }

        ///// <summary>
        ///// RXA.25 - Administered Barcode Identifier.
        ///// </summary>
        //public AdministeredBarcodeIdentifier { get; set; }

        ///// <summary>
        ///// RXA.26 - Pharmacy Order Type.
        ///// </summary>
        //public PharmacyOrderType { get; set; }

        ///// <summary>
        ///// RXA.27 - Administer-at.
        ///// </summary>
        //public AdministerAt { get; set; }

        ///// <summary>
        ///// RXA.28 - Administered-at Address.
        ///// </summary>
        //public AdministeredAtAddress { get; set; }

        ///// <summary>
        ///// RXA.29 - Administered Tag Identifier.
        ///// </summary>
        //public AdministeredTagIdentifier { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}"
                                ).TrimEnd('|');
        }
    }
}