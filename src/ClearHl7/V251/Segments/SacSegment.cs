using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SAC - Specimen Container Detail.
    /// </summary>
    public class SacSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SacSegment"/> class.
        /// </summary>
        public SacSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SacSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public SacSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "SAC";

        /// <inheritdoc/>
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
        public SpecimenSource SpecimenSource { get; set; }

        /// <summary>
        /// SAC.7 - Registration Date/Time.
        /// </summary>
        public DateTime? RegistrationDateTime { get; set; }

        /// <summary>
        /// SAC.8 - Container Status.
        /// <para>Suggested: 0370 Container Status -&gt; ClearHl7.Codes.V251.CodeContainerStatus</para>
        /// </summary>
        public CodedElement ContainerStatus { get; set; }

        /// <summary>
        /// SAC.9 - Carrier Type.
        /// <para>Suggested: 0378 Carrier Type</para>
        /// </summary>
        public CodedElement CarrierType { get; set; }

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
        /// <para>Suggested: 0379 Tray Type</para>
        /// </summary>
        public CodedElement TrayTypeSac { get; set; }

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
        public IEnumerable<CodedElement> Location { get; set; }

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
        public CodedElement ContainerHeightDiameterDeltaUnits { get; set; }

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
        public CodedElement VolumeUnits { get; set; }

        /// <summary>
        /// SAC.25 - Separator Type.
        /// <para>Suggested: 0380 Separator Type</para>
        /// </summary>
        public CodedElement SeparatorType { get; set; }

        /// <summary>
        /// SAC.26 - Cap Type.
        /// <para>Suggested: 0381 Cap Type</para>
        /// </summary>
        public CodedElement CapType { get; set; }

        /// <summary>
        /// SAC.27 - Additive.
        /// <para>Suggested: 0371 Additive/Preservative -&gt; ClearHl7.Codes.V251.CodeAdditivePreservative</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> Additive { get; set; }

        /// <summary>
        /// SAC.28 - Specimen Component.
        /// </summary>
        public CodedElement SpecimenComponent { get; set; }

        /// <summary>
        /// SAC.29 - Dilution Factor.
        /// </summary>
        public StructuredNumeric DilutionFactor { get; set; }

        /// <summary>
        /// SAC.30 - Treatment.
        /// <para>Suggested: 0373 Treatment -&gt; ClearHl7.Codes.V251.CodeTreatment</para>
        /// </summary>
        public CodedElement Treatment { get; set; }

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
        public CodedElement HemolysisIndexUnits { get; set; }

        /// <summary>
        /// SAC.34 - Lipemia Index.
        /// </summary>
        public decimal? LipemiaIndex { get; set; }

        /// <summary>
        /// SAC.35 - Lipemia Index Units.
        /// </summary>
        public CodedElement LipemiaIndexUnits { get; set; }

        /// <summary>
        /// SAC.36 - Icterus Index.
        /// </summary>
        public decimal? IcterusIndex { get; set; }

        /// <summary>
        /// SAC.37 - Icterus Index Units.
        /// </summary>
        public CodedElement IcterusIndexUnits { get; set; }

        /// <summary>
        /// SAC.38 - Fibrin Index.
        /// </summary>
        public decimal? FibrinIndex { get; set; }

        /// <summary>
        /// SAC.39 - Fibrin Index Units.
        /// </summary>
        public CodedElement FibrinIndexUnits { get; set; }

        /// <summary>
        /// SAC.40 - System Induced Contaminants.
        /// <para>Suggested: 0374 System Induced Contaminants -&gt; ClearHl7.Codes.V251.CodeSystemInducedContaminants</para>
        /// </summary>
        public IEnumerable<CodedElement> SystemInducedContaminants { get; set; }

        /// <summary>
        /// SAC.41 - Drug Interference.
        /// <para>Suggested: 0382 Drug Interference</para>
        /// </summary>
        public IEnumerable<CodedElement> DrugInterference { get; set; }

        /// <summary>
        /// SAC.42 - Artificial Blood.
        /// <para>Suggested: 0375 Artificial Blood -&gt; ClearHl7.Codes.V251.CodeArtificialBlood</para>
        /// </summary>
        public CodedElement ArtificialBlood { get; set; }

        /// <summary>
        /// SAC.43 - Special Handling Code.
        /// <para>Suggested: 0376 Special Handling Code -&gt; ClearHl7.Codes.V251.CodeSpecialHandlingCode</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> SpecialHandlingCode { get; set; }

        /// <summary>
        /// SAC.44 - Other Environmental Factors.
        /// <para>Suggested: 0377 Other Environmental Factors -&gt; ClearHl7.Codes.V251.CodeOtherEnvironmentalFactors</para>
        /// </summary>
        public IEnumerable<CodedElement> OtherEnvironmentalFactors { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ExternalAccessionIdentifier = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[1], false, seps) : null;
            AccessionIdentifier = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[2], false, seps) : null;
            ContainerIdentifier = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[3], false, seps) : null;
            PrimaryParentContainerIdentifier = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[4], false, seps) : null;
            EquipmentContainerIdentifier = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[5], false, seps) : null;
            SpecimenSource = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<SpecimenSource>(segments[6], false, seps) : null;
            RegistrationDateTime = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            ContainerStatus = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[8], false, seps) : null;
            CarrierType = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[9], false, seps) : null;
            CarrierIdentifier = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[10], false, seps) : null;
            PositionInCarrier = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<NumericArray>(segments[11], false, seps) : null;
            TrayTypeSac = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[12], false, seps) : null;
            TrayIdentifier = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[13], false, seps) : null;
            PositionInTray = segments.Length > 14 && segments[14].Length > 0 ? TypeSerializer.Deserialize<NumericArray>(segments[14], false, seps) : null;
            Location = segments.Length > 15 && segments[15].Length > 0 ? segments[15].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            ContainerHeight = segments.Length > 16 && segments[16].Length > 0 ? segments[16].ToNullableDecimal() : null;
            ContainerDiameter = segments.Length > 17 && segments[17].Length > 0 ? segments[17].ToNullableDecimal() : null;
            BarrierDelta = segments.Length > 18 && segments[18].Length > 0 ? segments[18].ToNullableDecimal() : null;
            BottomDelta = segments.Length > 19 && segments[19].Length > 0 ? segments[19].ToNullableDecimal() : null;
            ContainerHeightDiameterDeltaUnits = segments.Length > 20 && segments[20].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[20], false, seps) : null;
            ContainerVolume = segments.Length > 21 && segments[21].Length > 0 ? segments[21].ToNullableDecimal() : null;
            AvailableSpecimenVolume = segments.Length > 22 && segments[22].Length > 0 ? segments[22].ToNullableDecimal() : null;
            InitialSpecimenVolume = segments.Length > 23 && segments[23].Length > 0 ? segments[23].ToNullableDecimal() : null;
            VolumeUnits = segments.Length > 24 && segments[24].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[24], false, seps) : null;
            SeparatorType = segments.Length > 25 && segments[25].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[25], false, seps) : null;
            CapType = segments.Length > 26 && segments[26].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[26], false, seps) : null;
            Additive = segments.Length > 27 && segments[27].Length > 0 ? segments[27].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            SpecimenComponent = segments.Length > 28 && segments[28].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[28], false, seps) : null;
            DilutionFactor = segments.Length > 29 && segments[29].Length > 0 ? TypeSerializer.Deserialize<StructuredNumeric>(segments[29], false, seps) : null;
            Treatment = segments.Length > 30 && segments[30].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[30], false, seps) : null;
            Temperature = segments.Length > 31 && segments[31].Length > 0 ? TypeSerializer.Deserialize<StructuredNumeric>(segments[31], false, seps) : null;
            HemolysisIndex = segments.Length > 32 && segments[32].Length > 0 ? segments[32].ToNullableDecimal() : null;
            HemolysisIndexUnits = segments.Length > 33 && segments[33].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[33], false, seps) : null;
            LipemiaIndex = segments.Length > 34 && segments[34].Length > 0 ? segments[34].ToNullableDecimal() : null;
            LipemiaIndexUnits = segments.Length > 35 && segments[35].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[35], false, seps) : null;
            IcterusIndex = segments.Length > 36 && segments[36].Length > 0 ? segments[36].ToNullableDecimal() : null;
            IcterusIndexUnits = segments.Length > 37 && segments[37].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[37], false, seps) : null;
            FibrinIndex = segments.Length > 38 && segments[38].Length > 0 ? segments[38].ToNullableDecimal() : null;
            FibrinIndexUnits = segments.Length > 39 && segments[39].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[39], false, seps) : null;
            SystemInducedContaminants = segments.Length > 40 && segments[40].Length > 0 ? segments[40].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            DrugInterference = segments.Length > 41 && segments[41].Length > 0 ? segments[41].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            ArtificialBlood = segments.Length > 42 && segments[42].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[42], false, seps) : null;
            SpecialHandlingCode = segments.Length > 43 && segments[43].Length > 0 ? segments[43].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            OtherEnvironmentalFactors = segments.Length > 44 && segments[44].Length > 0 ? segments[44].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 45, Configuration.FieldSeparator),
                                Id,
                                ExternalAccessionIdentifier?.ToDelimitedString(),
                                AccessionIdentifier?.ToDelimitedString(),
                                ContainerIdentifier?.ToDelimitedString(),
                                PrimaryParentContainerIdentifier?.ToDelimitedString(),
                                EquipmentContainerIdentifier?.ToDelimitedString(),
                                SpecimenSource?.ToDelimitedString(),
                                RegistrationDateTime.ToHl7DateTimeString(typeof(SacSegment), nameof(RegistrationDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                ContainerStatus?.ToDelimitedString(),
                                CarrierType?.ToDelimitedString(),
                                CarrierIdentifier?.ToDelimitedString(),
                                PositionInCarrier?.ToDelimitedString(),
                                TrayTypeSac?.ToDelimitedString(),
                                TrayIdentifier?.ToDelimitedString(),
                                PositionInTray?.ToDelimitedString(),
                                Location != null ? string.Join(Configuration.FieldRepeatSeparator, Location.Select(x => x.ToDelimitedString())) : null,
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
                                Additive != null ? string.Join(Configuration.FieldRepeatSeparator, Additive.Select(x => x.ToDelimitedString())) : null,
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
                                SystemInducedContaminants != null ? string.Join(Configuration.FieldRepeatSeparator, SystemInducedContaminants.Select(x => x.ToDelimitedString())) : null,
                                DrugInterference != null ? string.Join(Configuration.FieldRepeatSeparator, DrugInterference.Select(x => x.ToDelimitedString())) : null,
                                ArtificialBlood?.ToDelimitedString(),
                                SpecialHandlingCode != null ? string.Join(Configuration.FieldRepeatSeparator, SpecialHandlingCode.Select(x => x.ToDelimitedString())) : null,
                                OtherEnvironmentalFactors != null ? string.Join(Configuration.FieldRepeatSeparator, OtherEnvironmentalFactors.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
