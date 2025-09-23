using System;
using System.Collections.Generic;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PCR - Possible Causal Relationship.
    /// </summary>
    public class PcrSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PcrSegment"/> class.
        /// </summary>
        public PcrSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PcrSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public PcrSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "PCR";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// PCR.1 - Implicated Product.
        /// </summary>
        public CodedWithExceptions ImplicatedProduct { get; set; }

        /// <summary>
        /// PCR.2 - Generic Product.
        /// <para>Suggested: 0249 Generic Product</para>
        /// </summary>
        public string GenericProduct { get; set; }

        /// <summary>
        /// PCR.3 - Product Class.
        /// </summary>
        public CodedWithExceptions ProductClass { get; set; }

        /// <summary>
        /// PCR.4 - Total Duration Of Therapy.
        /// </summary>
        public CompositeQuantityWithUnits TotalDurationOfTherapy { get; set; }

        /// <summary>
        /// PCR.5 - Product Manufacture Date.
        /// </summary>
        public DateTime? ProductManufactureDate { get; set; }

        /// <summary>
        /// PCR.6 - Product Expiration Date.
        /// </summary>
        public DateTime? ProductExpirationDate { get; set; }

        /// <summary>
        /// PCR.7 - Product Implantation Date.
        /// </summary>
        public DateTime? ProductImplantationDate { get; set; }

        /// <summary>
        /// PCR.8 - Product Explantation Date.
        /// </summary>
        public DateTime? ProductExplantationDate { get; set; }

        /// <summary>
        /// PCR.9 - Single Use Device.
        /// <para>Suggested: 0244 Single Use Device</para>
        /// </summary>
        public CodedWithExceptions SingleUseDevice { get; set; }

        /// <summary>
        /// PCR.10 - Indication For Product Use.
        /// </summary>
        public CodedWithExceptions IndicationForProductUse { get; set; }

        /// <summary>
        /// PCR.11 - Product Problem.
        /// <para>Suggested: 0245 Product Problem</para>
        /// </summary>
        public CodedWithExceptions ProductProblem { get; set; }

        /// <summary>
        /// PCR.12 - Product Serial/Lot Number.
        /// </summary>
        public IEnumerable<string> ProductSerialLotNumber { get; set; }

        /// <summary>
        /// PCR.13 - Product Available For Inspection.
        /// <para>Suggested: 0246 Product Available For Inspection</para>
        /// </summary>
        public CodedWithExceptions ProductAvailableForInspection { get; set; }

        /// <summary>
        /// PCR.14 - Product Evaluation Performed.
        /// </summary>
        public CodedWithExceptions ProductEvaluationPerformed { get; set; }

        /// <summary>
        /// PCR.15 - Product Evaluation Status.
        /// <para>Suggested: 0247 Status Of Evaluation -&gt; ClearHl7.Codes.V280.CodeStatusOfEvaluation</para>
        /// </summary>
        public CodedWithExceptions ProductEvaluationStatus { get; set; }

        /// <summary>
        /// PCR.16 - Product Evaluation Results.
        /// </summary>
        public CodedWithExceptions ProductEvaluationResults { get; set; }

        /// <summary>
        /// PCR.17 - Evaluated Product Source.
        /// <para>Suggested: 0248 Product Source -&gt; ClearHl7.Codes.V280.CodeProductSource</para>
        /// </summary>
        public string EvaluatedProductSource { get; set; }

        /// <summary>
        /// PCR.18 - Date Product Returned To Manufacturer.
        /// </summary>
        public DateTime? DateProductReturnedToManufacturer { get; set; }

        /// <summary>
        /// PCR.19 - Device Operator Qualifications.
        /// <para>Suggested: 0242 Primary Observer's Qualification -&gt; ClearHl7.Codes.V280.CodePrimaryObserversQualification</para>
        /// </summary>
        public string DeviceOperatorQualifications { get; set; }

        /// <summary>
        /// PCR.20 - Relatedness Assessment.
        /// <para>Suggested: 0250 Relatedness Assessment -&gt; ClearHl7.Codes.V280.CodeRelatednessAssessment</para>
        /// </summary>
        public string RelatednessAssessment { get; set; }

        /// <summary>
        /// PCR.21 - Action Taken In Response To The Event.
        /// <para>Suggested: 0251 Action Taken In Response To The Event -&gt; ClearHl7.Codes.V280.CodeActionTakenInResponseToTheEvent</para>
        /// </summary>
        public IEnumerable<string> ActionTakenInResponseToTheEvent { get; set; }

        /// <summary>
        /// PCR.22 - Event Causality Observations.
        /// <para>Suggested: 0252 Causality Observations -&gt; ClearHl7.Codes.V280.CodeCausalityObservations</para>
        /// </summary>
        public IEnumerable<string> EventCausalityObservations { get; set; }

        /// <summary>
        /// PCR.23 - Indirect Exposure Mechanism.
        /// <para>Suggested: 0253 Indirect Exposure Mechanism -&gt; ClearHl7.Codes.V280.CodeIndirectExposureMechanism</para>
        /// </summary>
        public IEnumerable<string> IndirectExposureMechanism { get; set; }

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

            ImplicatedProduct = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], false, seps) : null;
            GenericProduct = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            ProductClass = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[3], false, seps) : null;
            TotalDurationOfTherapy = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[4], false, seps) : null;
            ProductManufactureDate = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDateTime() : null;
            ProductExpirationDate = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
            ProductImplantationDate = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            ProductExplantationDate = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDateTime() : null;
            SingleUseDevice = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[9], false, seps) : null;
            IndicationForProductUse = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[10], false, seps) : null;
            ProductProblem = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[11], false, seps) : null;
            ProductSerialLotNumber = segments.Length > 12 && segments[12].Length > 0 ? segments[12].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            ProductAvailableForInspection = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[13], false, seps) : null;
            ProductEvaluationPerformed = segments.Length > 14 && segments[14].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[14], false, seps) : null;
            ProductEvaluationStatus = segments.Length > 15 && segments[15].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[15], false, seps) : null;
            ProductEvaluationResults = segments.Length > 16 && segments[16].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[16], false, seps) : null;
            EvaluatedProductSource = segments.Length > 17 && segments[17].Length > 0 ? segments[17] : null;
            DateProductReturnedToManufacturer = segments.Length > 18 && segments[18].Length > 0 ? segments[18].ToNullableDateTime() : null;
            DeviceOperatorQualifications = segments.Length > 19 && segments[19].Length > 0 ? segments[19] : null;
            RelatednessAssessment = segments.Length > 20 && segments[20].Length > 0 ? segments[20] : null;
            ActionTakenInResponseToTheEvent = segments.Length > 21 && segments[21].Length > 0 ? segments[21].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            EventCausalityObservations = segments.Length > 22 && segments[22].Length > 0 ? segments[22].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            IndirectExposureMechanism = segments.Length > 23 && segments[23].Length > 0 ? segments[23].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 24, Configuration.FieldSeparator),
                                Id,
                                ImplicatedProduct?.ToDelimitedString(),
                                GenericProduct,
                                ProductClass?.ToDelimitedString(),
                                TotalDurationOfTherapy?.ToDelimitedString(),
                                ProductManufactureDate.ToHl7DateTimeString(typeof(PcrSegment), nameof(ProductManufactureDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                ProductExpirationDate.ToHl7DateTimeString(typeof(PcrSegment), nameof(ProductExpirationDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                ProductImplantationDate.ToHl7DateTimeString(typeof(PcrSegment), nameof(ProductImplantationDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                ProductExplantationDate.ToHl7DateTimeString(typeof(PcrSegment), nameof(ProductExplantationDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                SingleUseDevice?.ToDelimitedString(),
                                IndicationForProductUse?.ToDelimitedString(),
                                ProductProblem?.ToDelimitedString(),
                                ProductSerialLotNumber != null ? string.Join(Configuration.FieldRepeatSeparator, ProductSerialLotNumber) : null,
                                ProductAvailableForInspection?.ToDelimitedString(),
                                ProductEvaluationPerformed?.ToDelimitedString(),
                                ProductEvaluationStatus?.ToDelimitedString(),
                                ProductEvaluationResults?.ToDelimitedString(),
                                EvaluatedProductSource,
                                DateProductReturnedToManufacturer.ToHl7DateTimeString(typeof(PcrSegment), nameof(DateProductReturnedToManufacturer), Consts.DateTimeFormatPrecisionSecond, culture),
                                DeviceOperatorQualifications,
                                RelatednessAssessment,
                                ActionTakenInResponseToTheEvent != null ? string.Join(Configuration.FieldRepeatSeparator, ActionTakenInResponseToTheEvent) : null,
                                EventCausalityObservations != null ? string.Join(Configuration.FieldRepeatSeparator, EventCausalityObservations) : null,
                                IndirectExposureMechanism != null ? string.Join(Configuration.FieldRepeatSeparator, IndirectExposureMechanism) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
