using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
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
        public SpecimentSource SpecimenSource { get; set; }

        /// <summary>
        /// SAC.7 - Registration Date/Time.
        /// </summary>
        public DateTime? RegistrationDateTime { get; set; }

        /// <summary>
        /// SAC.8 - Container Status.
        /// <para>Suggested: 0370 Container Status -&gt; ClearHl7.Codes.V260.CodeContainerStatus</para>
        /// </summary>
        public CodedWithExceptions ContainerStatus { get; set; }

        /// <summary>
        /// SAC.9 - Carrier Type.
        /// <para>Suggested: 0378 Carrier Type</para>
        /// </summary>
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
        /// <para>Suggested: 0379 Tray Type</para>
        /// </summary>
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
        /// <para>Suggested: 0380 Separator Type</para>
        /// </summary>
        public CodedWithExceptions SeparatorType { get; set; }

        /// <summary>
        /// SAC.26 - Cap Type.
        /// <para>Suggested: 0381 Cap Type</para>
        /// </summary>
        public CodedWithExceptions CapType { get; set; }

        /// <summary>
        /// SAC.27 - Additive.
        /// <para>Suggested: 0371 Additive/Preservative -&gt; ClearHl7.Codes.V260.CodeAdditivePreservative</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> Additive { get; set; }

        /// <summary>
        /// SAC.28 - Specimen Component.
        /// <para>Suggested: 0372 Specimen Component -&gt; ClearHl7.Codes.V260.CodeSpecimenComponent</para>
        /// </summary>
        public CodedWithExceptions SpecimenComponent { get; set; }

        /// <summary>
        /// SAC.29 - Dilution Factor.
        /// </summary>
        public StructuredNumeric DilutionFactor { get; set; }

        /// <summary>
        /// SAC.30 - Treatment.
        /// <para>Suggested: 0373 Treatment -&gt; ClearHl7.Codes.V260.CodeTreatment</para>
        /// </summary>
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
        /// <para>Suggested: 0374 System Induced Contaminants -&gt; ClearHl7.Codes.V260.CodeSystemInducedContaminants</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> SystemInducedContaminants { get; set; }

        /// <summary>
        /// SAC.41 - Drug Interference.
        /// <para>Suggested: 0382 Drug Interference</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> DrugInterference { get; set; }

        /// <summary>
        /// SAC.42 - Artificial Blood.
        /// <para>Suggested: 0375 Artificial Blood -&gt; ClearHl7.Codes.V260.CodeArtificialBlood</para>
        /// </summary>
        public CodedWithExceptions ArtificialBlood { get; set; }

        /// <summary>
        /// SAC.43 - Special Handling Code.
        /// <para>Suggested: 0376 Special Handling Code -&gt; ClearHl7.Codes.V260.CodeSpecialHandlingCode</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> SpecialHandlingCode { get; set; }

        /// <summary>
        /// SAC.44 - Other Environmental Factors.
        /// <para>Suggested: 0377 Other Environmental Factors -&gt; ClearHl7.Codes.V260.CodeOtherEnvironmentalFactors</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> OtherEnvironmentalFactors { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ExternalAccessionIdentifier = segments.Length > 1 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(1), false) : null;
            AccessionIdentifier = segments.Length > 2 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(2), false) : null;
            ContainerIdentifier = segments.Length > 3 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(3), false) : null;
            PrimaryParentContainerIdentifier = segments.Length > 4 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(4), false) : null;
            EquipmentContainerIdentifier = segments.Length > 5 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(5), false) : null;
            SpecimenSource = segments.Length > 6 ? TypeHelper.Deserialize<SpecimentSource>(segments.ElementAtOrDefault(6), false) : null;
            RegistrationDateTime = segments.ElementAtOrDefault(7)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ContainerStatus = segments.Length > 8 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(8), false) : null;
            CarrierType = segments.Length > 9 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(9), false) : null;
            CarrierIdentifier = segments.Length > 10 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(10), false) : null;
            PositionInCarrier = segments.Length > 11 ? TypeHelper.Deserialize<NumericArray>(segments.ElementAtOrDefault(11), false) : null;
            TrayTypeSac = segments.Length > 12 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(12), false) : null;
            TrayIdentifier = segments.Length > 13 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(13), false) : null;
            PositionInTray = segments.Length > 14 ? TypeHelper.Deserialize<NumericArray>(segments.ElementAtOrDefault(14), false) : null;
            Location = segments.Length > 15 ? segments.ElementAtOrDefault(15).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            ContainerHeight = segments.ElementAtOrDefault(16)?.ToNullableDecimal();
            ContainerDiameter = segments.ElementAtOrDefault(17)?.ToNullableDecimal();
            BarrierDelta = segments.ElementAtOrDefault(18)?.ToNullableDecimal();
            BottomDelta = segments.ElementAtOrDefault(19)?.ToNullableDecimal();
            ContainerHeightDiameterDeltaUnits = segments.Length > 20 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(20), false) : null;
            ContainerVolume = segments.ElementAtOrDefault(21)?.ToNullableDecimal();
            AvailableSpecimenVolume = segments.ElementAtOrDefault(22)?.ToNullableDecimal();
            InitialSpecimenVolume = segments.ElementAtOrDefault(23)?.ToNullableDecimal();
            VolumeUnits = segments.Length > 24 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(24), false) : null;
            SeparatorType = segments.Length > 25 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(25), false) : null;
            CapType = segments.Length > 26 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(26), false) : null;
            Additive = segments.Length > 27 ? segments.ElementAtOrDefault(27).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            SpecimenComponent = segments.Length > 28 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(28), false) : null;
            DilutionFactor = segments.Length > 29 ? TypeHelper.Deserialize<StructuredNumeric>(segments.ElementAtOrDefault(29), false) : null;
            Treatment = segments.Length > 30 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(30), false) : null;
            Temperature = segments.Length > 31 ? TypeHelper.Deserialize<StructuredNumeric>(segments.ElementAtOrDefault(31), false) : null;
            HemolysisIndex = segments.ElementAtOrDefault(32)?.ToNullableDecimal();
            HemolysisIndexUnits = segments.Length > 33 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(33), false) : null;
            LipemiaIndex = segments.ElementAtOrDefault(34)?.ToNullableDecimal();
            LipemiaIndexUnits = segments.Length > 35 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(35), false) : null;
            IcterusIndex = segments.ElementAtOrDefault(36)?.ToNullableDecimal();
            IcterusIndexUnits = segments.Length > 37 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(37), false) : null;
            FibrinIndex = segments.ElementAtOrDefault(38)?.ToNullableDecimal();
            FibrinIndexUnits = segments.Length > 39 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(39), false) : null;
            SystemInducedContaminants = segments.Length > 40 ? segments.ElementAtOrDefault(40).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            DrugInterference = segments.Length > 41 ? segments.ElementAtOrDefault(41).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            ArtificialBlood = segments.Length > 42 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(42), false) : null;
            SpecialHandlingCode = segments.Length > 43 ? segments.ElementAtOrDefault(43).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            OtherEnvironmentalFactors = segments.Length > 44 ? segments.ElementAtOrDefault(44).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
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
                                RegistrationDateTime.HasValue ? RegistrationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
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