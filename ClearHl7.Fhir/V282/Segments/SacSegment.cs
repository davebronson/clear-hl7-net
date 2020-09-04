using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SAC - Specimen Container Detail.
    /// </summary>
    public class SacSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "SAC";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// SAC.1 - External Accession Identifier.
        ///// </summary>
        //public ExternalAccessionIdentifier { get; set; }

        ///// <summary>
        ///// SAC.2 - Accession Identifier.
        ///// </summary>
        //public AccessionIdentifier { get; set; }

        ///// <summary>
        ///// SAC.3 - Container Identifier.
        ///// </summary>
        //public ContainerIdentifier { get; set; }

        ///// <summary>
        ///// SAC.4 - Primary (Parent) Container Identifier.
        ///// </summary>
        //public PrimaryParentContainerIdentifier { get; set; }

        ///// <summary>
        ///// SAC.5 - Equipment Container Identifier.
        ///// </summary>
        //public EquipmentContainerIdentifier { get; set; }

        ///// <summary>
        ///// SAC.6 - Specimen Source.
        ///// </summary>
        //public SpecimenSource { get; set; }

        ///// <summary>
        ///// SAC.7 - Registration Date/Time.
        ///// </summary>
        //public RegistrationDateTime { get; set; }

        ///// <summary>
        ///// SAC.8 - Container Status.
        ///// </summary>
        //public ContainerStatus { get; set; }

        ///// <summary>
        ///// SAC.9 - Carrier Type.
        ///// </summary>
        //public CarrierType { get; set; }

        ///// <summary>
        ///// SAC.10 - Carrier Identifier.
        ///// </summary>
        //public CarrierIdentifier { get; set; }

        ///// <summary>
        ///// SAC.11 - Position in Carrier.
        ///// </summary>
        //public PositionInCarrier { get; set; }

        ///// <summary>
        ///// SAC.12 - Tray Type - SAC.
        ///// </summary>
        //public TrayTypeSac { get; set; }

        ///// <summary>
        ///// SAC.13 - Tray Identifier.
        ///// </summary>
        //public TrayIdentifier { get; set; }

        ///// <summary>
        ///// SAC.14 - Position in Tray.
        ///// </summary>
        //public PositionInTray { get; set; }

        ///// <summary>
        ///// SAC.15 - Location.
        ///// </summary>
        //public Location { get; set; }

        ///// <summary>
        ///// SAC.16 - Container Height.
        ///// </summary>
        //public ContainerHeight { get; set; }

        ///// <summary>
        ///// SAC.17 - Container Diameter.
        ///// </summary>
        //public ContainerDiameter { get; set; }

        ///// <summary>
        ///// SAC.18 - Barrier Delta.
        ///// </summary>
        //public BarrierDelta { get; set; }

        ///// <summary>
        ///// SAC.19 - Bottom Delta.
        ///// </summary>
        //public BottomDelta { get; set; }

        ///// <summary>
        ///// SAC.20 - Container Height/Diameter/Delta Units.
        ///// </summary>
        //public ContainerHeightDiameterDeltaUnits { get; set; }

        ///// <summary>
        ///// SAC.21 - Container Volume.
        ///// </summary>
        //public ContainerVolume { get; set; }

        ///// <summary>
        ///// SAC.22 - Available Specimen Volume.
        ///// </summary>
        //public AvailableSpecimenVolume { get; set; }

        ///// <summary>
        ///// SAC.23 - Initial Specimen Volume.
        ///// </summary>
        //public InitialSpecimenVolume { get; set; }

        ///// <summary>
        ///// SAC.24 - Volume Units.
        ///// </summary>
        //public VolumeUnits { get; set; }

        ///// <summary>
        ///// SAC.25 - Separator Type.
        ///// </summary>
        //public SeparatorType { get; set; }

        ///// <summary>
        ///// SAC.26 - Cap Type.
        ///// </summary>
        //public CapType { get; set; }

        ///// <summary>
        ///// SAC.27 - Additive.
        ///// </summary>
        //public Additive { get; set; }

        ///// <summary>
        ///// SAC.28 - Specimen Component.
        ///// </summary>
        //public SpecimenComponent { get; set; }

        ///// <summary>
        ///// SAC.29 - Dilution Factor.
        ///// </summary>
        //public DilutionFactor { get; set; }

        ///// <summary>
        ///// SAC.30 - Treatment.
        ///// </summary>
        //public Treatment { get; set; }

        ///// <summary>
        ///// SAC.31 - Temperature.
        ///// </summary>
        //public Temperature { get; set; }

        ///// <summary>
        ///// SAC.32 - Hemolysis Index.
        ///// </summary>
        //public HemolysisIndex { get; set; }

        ///// <summary>
        ///// SAC.33 - Hemolysis Index Units.
        ///// </summary>
        //public HemolysisIndexUnits { get; set; }

        ///// <summary>
        ///// SAC.34 - Lipemia Index.
        ///// </summary>
        //public LipemiaIndex { get; set; }

        ///// <summary>
        ///// SAC.35 - Lipemia Index Units.
        ///// </summary>
        //public LipemiaIndexUnits { get; set; }

        ///// <summary>
        ///// SAC.36 - Icterus Index.
        ///// </summary>
        //public IcterusIndex { get; set; }

        ///// <summary>
        ///// SAC.37 - Icterus Index Units.
        ///// </summary>
        //public IcterusIndexUnits { get; set; }

        ///// <summary>
        ///// SAC.38 - Fibrin Index.
        ///// </summary>
        //public FibrinIndex { get; set; }

        ///// <summary>
        ///// SAC.39 - Fibrin Index Units.
        ///// </summary>
        //public FibrinIndexUnits { get; set; }

        ///// <summary>
        ///// SAC.40 - System Induced Contaminants.
        ///// </summary>
        //public SystemInducedContaminants { get; set; }

        ///// <summary>
        ///// SAC.41 - Drug Interference.
        ///// </summary>
        //public DrugInterference { get; set; }

        ///// <summary>
        ///// SAC.42 - Artificial Blood.
        ///// </summary>
        //public ArtificialBlood { get; set; }

        ///// <summary>
        ///// SAC.43 - Special Handling Code.
        ///// </summary>
        //public SpecialHandlingCode { get; set; }

        ///// <summary>
        ///// SAC.44 - Other Environmental Factors.
        ///// </summary>
        //public OtherEnvironmentalFactors { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}|{30}|{31}|{32}|{33}|{34}|{35}|{36}|{37}|{38}|{39}|{40}|{41}|{42}|{43}|{44}"
                                ).TrimEnd('|');
        }
    }
}