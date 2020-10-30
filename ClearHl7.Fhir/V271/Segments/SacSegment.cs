using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V271.Types;

namespace ClearHl7.Fhir.V271.Segments
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

        /// <summary>
        /// SAC.1 - External Accession Identifier.
        /// </summary>
        public EntityIdentifier ExternalAccessionIdentifier { get; set; }

        /// <summary>
        /// SAC.2 - Accession Identifier.
        /// </summary>
        public EntityIdentifier AccessionIdentifier { get; set; }

        /// <summary>
        /// SAC.3 - Container Identifier.
        /// </summary>
        public EntityIdentifier ContainerIdentifier { get; set; }

        /// <summary>
        /// SAC.4 - Primary (Parent) Container Identifier.
        /// </summary>
        public EntityIdentifier PrimaryParentContainerIdentifier { get; set; }

        /// <summary>
        /// SAC.5 - Equipment Container Identifier.
        /// </summary>
        public EntityIdentifier EquipmentContainerIdentifier { get; set; }

        /// <summary>
        /// SAC.6 - Specimen Source.
        /// </summary>
        public string SpecimenSource { get; set; }

        /// <summary>
        /// SAC.7 - Registration Date/Time.
        /// </summary>
        public DateTime? RegistrationDateTime { get; set; }

        /// <summary>
        /// SAC.8 - Container Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0370</remarks>
        public CodedWithExceptions ContainerStatus { get; set; }

        /// <summary>
        /// SAC.9 - Carrier Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0378</remarks>
        public CodedWithExceptions CarrierType { get; set; }

        /// <summary>
        /// SAC.10 - Carrier Identifier.
        /// </summary>
        public EntityIdentifier CarrierIdentifier { get; set; }

        /// <summary>
        /// SAC.11 - Position in Carrier.
        /// </summary>
        public NumericArray PositionInCarrier { get; set; }

        /// <summary>
        /// SAC.12 - Tray Type - SAC.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0379</remarks>
        public CodedWithExceptions TrayTypeSac { get; set; }

        /// <summary>
        /// SAC.13 - Tray Identifier.
        /// </summary>
        public EntityIdentifier TrayIdentifier { get; set; }

        /// <summary>
        /// SAC.14 - Position in Tray.
        /// </summary>
        public NumericArray PositionInTray { get; set; }

        /// <summary>
        /// SAC.15 - Location.
        /// </summary>
        public IEnumerable<CodedWithExceptions> Location { get; set; }

        /// <summary>
        /// SAC.16 - Container Height.
        /// </summary>
        public decimal? ContainerHeight { get; set; }

        /// <summary>
        /// SAC.17 - Container Diameter.
        /// </summary>
        public decimal? ContainerDiameter { get; set; }

        /// <summary>
        /// SAC.18 - Barrier Delta.
        /// </summary>
        public decimal? BarrierDelta { get; set; }

        /// <summary>
        /// SAC.19 - Bottom Delta.
        /// </summary>
        public decimal? BottomDelta { get; set; }

        /// <summary>
        /// SAC.20 - Container Height/Diameter/Delta Units.
        /// </summary>
        public CodedWithExceptions ContainerHeightDiameterDeltaUnits { get; set; }

        /// <summary>
        /// SAC.21 - Container Volume.
        /// </summary>
        public decimal? ContainerVolume { get; set; }

        /// <summary>
        /// SAC.22 - Available Specimen Volume.
        /// </summary>
        public decimal? AvailableSpecimenVolume { get; set; }

        /// <summary>
        /// SAC.23 - Initial Specimen Volume.
        /// </summary>
        public decimal? InitialSpecimenVolume { get; set; }

        /// <summary>
        /// SAC.24 - Volume Units.
        /// </summary>
        public CodedWithExceptions VolumeUnits { get; set; }

        /// <summary>
        /// SAC.25 - Separator Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0380</remarks>
        public CodedWithExceptions SeparatorType { get; set; }

        /// <summary>
        /// SAC.26 - Cap Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0381</remarks>
        public CodedWithExceptions CapType { get; set; }

        /// <summary>
        /// SAC.27 - Additive.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0371</remarks>
        public IEnumerable<CodedWithExceptions> Additive { get; set; }

        /// <summary>
        /// SAC.28 - Specimen Component.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0372</remarks>
        public CodedWithExceptions SpecimenComponent { get; set; }

        /// <summary>
        /// SAC.29 - Dilution Factor.
        /// </summary>
        public StructuredNumeric DilutionFactor { get; set; }

        /// <summary>
        /// SAC.30 - Treatment.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0373</remarks>
        public CodedWithExceptions Treatment { get; set; }

        /// <summary>
        /// SAC.31 - Temperature.
        /// </summary>
        public StructuredNumeric Temperature { get; set; }

        /// <summary>
        /// SAC.32 - Hemolysis Index.
        /// </summary>
        public decimal? HemolysisIndex { get; set; }

        /// <summary>
        /// SAC.33 - Hemolysis Index Units.
        /// </summary>
        public CodedWithExceptions HemolysisIndexUnits { get; set; }

        /// <summary>
        /// SAC.34 - Lipemia Index.
        /// </summary>
        public decimal? LipemiaIndex { get; set; }

        /// <summary>
        /// SAC.35 - Lipemia Index Units.
        /// </summary>
        public CodedWithExceptions LipemiaIndexUnits { get; set; }

        /// <summary>
        /// SAC.36 - Icterus Index.
        /// </summary>
        public decimal? IcterusIndex { get; set; }

        /// <summary>
        /// SAC.37 - Icterus Index Units.
        /// </summary>
        public CodedWithExceptions IcterusIndexUnits { get; set; }

        /// <summary>
        /// SAC.38 - Fibrin Index.
        /// </summary>
        public decimal? FibrinIndex { get; set; }

        /// <summary>
        /// SAC.39 - Fibrin Index Units.
        /// </summary>
        public CodedWithExceptions FibrinIndexUnits { get; set; }

        /// <summary>
        /// SAC.40 - System Induced Contaminants.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0374</remarks>
        public IEnumerable<CodedWithExceptions> SystemInducedContaminants { get; set; }

        /// <summary>
        /// SAC.41 - Drug Interference.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0382</remarks>
        public IEnumerable<CodedWithExceptions> DrugInterference { get; set; }

        /// <summary>
        /// SAC.42 - Artificial Blood.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0375</remarks>
        public CodedWithExceptions ArtificialBlood { get; set; }

        /// <summary>
        /// SAC.43 - Special Handling Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0376</remarks>
        public IEnumerable<CodedWithExceptions> SpecialHandlingCode { get; set; }

        /// <summary>
        /// SAC.44 - Other Environmental Factors.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0377</remarks>
        public IEnumerable<CodedWithExceptions> OtherEnvironmentalFactors { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}|{30}|{31}|{32}|{33}|{34}|{35}|{36}|{37}|{38}|{39}|{40}|{41}|{42}|{43}|{44}",
                                Id,
                                ExternalAccessionIdentifier?.ToDelimitedString(),
                                AccessionIdentifier?.ToDelimitedString(),
                                ContainerIdentifier?.ToDelimitedString(),
                                PrimaryParentContainerIdentifier?.ToDelimitedString(),
                                EquipmentContainerIdentifier?.ToDelimitedString(),
                                SpecimenSource,
                                RegistrationDateTime.HasValue ? RegistrationDateTime.Value.ToString(Consts.NumericFormat, culture) : null,
                                ContainerStatus?.ToDelimitedString(),
                                CarrierType?.ToDelimitedString(),
                                CarrierIdentifier?.ToDelimitedString(),
                                PositionInCarrier?.ToDelimitedString(),
                                TrayTypeSac?.ToDelimitedString(),
                                TrayIdentifier?.ToDelimitedString(),
                                PositionInTray?.ToDelimitedString(),
                                Location != null ? string.Join("~", Location.Select(x => x.ToDelimitedString())) : null,
                                ContainerHeight.HasValue ? ContainerHeight.Value.ToString(Consts.NumericFormat, culture) : null,
                                ContainerDiameter.HasValue ? ContainerDiameter.Value.ToString(Consts.NumericFormat, culture) : null,
                                BarrierDelta.HasValue ? BarrierDelta.Value.ToString(Consts.NumericFormat, culture) : null,
                                BottomDelta.HasValue ? BottomDelta.Value.ToString(Consts.NumericFormat, culture) : null,
                                ContainerHeightDiameterDeltaUnits?.ToDelimitedString(),
                                ContainerVolume.HasValue ? ContainerVolume.Value.ToString(Consts.NumericFormat, culture) : null,
                                AvailableSpecimenVolume.HasValue ? AvailableSpecimenVolume.Value.ToString(Consts.NumericFormat, culture) : null,
                                InitialSpecimenVolume.HasValue ? InitialSpecimenVolume.Value.ToString(Consts.NumericFormat, culture) : null,
                                VolumeUnits?.ToDelimitedString(),
                                SeparatorType?.ToDelimitedString(),
                                CapType?.ToDelimitedString(),
                                Additive != null ? string.Join("~", Additive.Select(x => x.ToDelimitedString())) : null,
                                SpecimenComponent?.ToDelimitedString(),
                                DilutionFactor?.ToDelimitedString(),
                                Treatment?.ToDelimitedString(),
                                Temperature?.ToDelimitedString(),
                                HemolysisIndex.HasValue ? HemolysisIndex.Value.ToString(Consts.NumericFormat, culture) : null,
                                HemolysisIndexUnits?.ToDelimitedString(),
                                LipemiaIndex.HasValue ? LipemiaIndex.Value.ToString(Consts.NumericFormat, culture) : null,
                                LipemiaIndexUnits?.ToDelimitedString(),
                                IcterusIndex.HasValue ? IcterusIndex.Value.ToString(Consts.NumericFormat, culture) : null,
                                IcterusIndexUnits?.ToDelimitedString(),
                                FibrinIndex.HasValue ? FibrinIndex.Value.ToString(Consts.NumericFormat, culture) : null,
                                FibrinIndexUnits?.ToDelimitedString(),
                                SystemInducedContaminants != null ? string.Join("~", SystemInducedContaminants.Select(x => x.ToDelimitedString())) : null,
                                DrugInterference != null ? string.Join("~", DrugInterference.Select(x => x.ToDelimitedString())) : null,
                                ArtificialBlood?.ToDelimitedString(),
                                SpecialHandlingCode != null ? string.Join("~", SpecialHandlingCode.Select(x => x.ToDelimitedString())) : null,
                                OtherEnvironmentalFactors != null ? string.Join("~", OtherEnvironmentalFactors.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd('|');
        }
    }
}