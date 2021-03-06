using System;
using System.Collections.Generic;
using ClearHl7.Helpers;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PCR - Possible Causal Relationship.
    /// </summary>
    public class PcrSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PCR";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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
        public string SingleUseDevice { get; set; }

        /// <summary>
        /// PCR.10 - Indication For Product Use.
        /// </summary>
        public CodedWithExceptions IndicationForProductUse { get; set; }

        /// <summary>
        /// PCR.11 - Product Problem.
        /// <para>Suggested: 0245 Product Problem</para>
        /// </summary>
        public string ProductProblem { get; set; }

        /// <summary>
        /// PCR.12 - Product Serial/Lot Number.
        /// </summary>
        public IEnumerable<string> ProductSerialLotNumber { get; set; }

        /// <summary>
        /// PCR.13 - Product Available For Inspection.
        /// <para>Suggested: 0246 Product Available For Inspection</para>
        /// </summary>
        public string ProductAvailableForInspection { get; set; }

        /// <summary>
        /// PCR.14 - Product Evaluation Performed.
        /// </summary>
        public CodedWithExceptions ProductEvaluationPerformed { get; set; }

        /// <summary>
        /// PCR.15 - Product Evaluation Status.
        /// <para>Suggested: 0247 Status Of Evaluation -&gt; ClearHl7.Codes.V260.CodeStatusOfEvaluation</para>
        /// </summary>
        public CodedWithExceptions ProductEvaluationStatus { get; set; }

        /// <summary>
        /// PCR.16 - Product Evaluation Results.
        /// </summary>
        public CodedWithExceptions ProductEvaluationResults { get; set; }

        /// <summary>
        /// PCR.17 - Evaluated Product Source.
        /// <para>Suggested: 0248 Product Source -&gt; ClearHl7.Codes.V260.CodeProductSource</para>
        /// </summary>
        public string EvaluatedProductSource { get; set; }

        /// <summary>
        /// PCR.18 - Date Product Returned To Manufacturer.
        /// </summary>
        public DateTime? DateProductReturnedToManufacturer { get; set; }

        /// <summary>
        /// PCR.19 - Device Operator Qualifications.
        /// <para>Suggested: 0242 Primary Observer's Qualification -&gt; ClearHl7.Codes.V260.CodePrimaryObserversQualification</para>
        /// </summary>
        public string DeviceOperatorQualifications { get; set; }

        /// <summary>
        /// PCR.20 - Relatedness Assessment.
        /// <para>Suggested: 0250 Relatedness Assessment -&gt; ClearHl7.Codes.V260.CodeRelatednessAssessment</para>
        /// </summary>
        public string RelatednessAssessment { get; set; }

        /// <summary>
        /// PCR.21 - Action Taken In Response To The Event.
        /// <para>Suggested: 0251 Action Taken In Response To The Event -&gt; ClearHl7.Codes.V260.CodeActionTakenInResponseToTheEvent</para>
        /// </summary>
        public IEnumerable<string> ActionTakenInResponseToTheEvent { get; set; }

        /// <summary>
        /// PCR.22 - Event Causality Observations.
        /// <para>Suggested: 0252 Causality Observations -&gt; ClearHl7.Codes.V260.CodeCausalityObservations</para>
        /// </summary>
        public IEnumerable<string> EventCausalityObservations { get; set; }

        /// <summary>
        /// PCR.23 - Indirect Exposure Mechanism.
        /// <para>Suggested: 0253 Indirect Exposure Mechanism -&gt; ClearHl7.Codes.V260.CodeIndirectExposureMechanism</para>
        /// </summary>
        public IEnumerable<string> IndirectExposureMechanism { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 24, Configuration.FieldSeparator),
                                Id,
                                ImplicatedProduct?.ToDelimitedString(),
                                GenericProduct,
                                ProductClass?.ToDelimitedString(),
                                TotalDurationOfTherapy?.ToDelimitedString(),
                                ProductManufactureDate.HasValue ? ProductManufactureDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ProductExpirationDate.HasValue ? ProductExpirationDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ProductImplantationDate.HasValue ? ProductImplantationDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ProductExplantationDate.HasValue ? ProductExplantationDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                SingleUseDevice,
                                IndicationForProductUse?.ToDelimitedString(),
                                ProductProblem,
                                ProductSerialLotNumber != null ? string.Join(Configuration.FieldRepeatSeparator, ProductSerialLotNumber) : null,
                                ProductAvailableForInspection,
                                ProductEvaluationPerformed?.ToDelimitedString(),
                                ProductEvaluationStatus?.ToDelimitedString(),
                                ProductEvaluationResults?.ToDelimitedString(),
                                EvaluatedProductSource,
                                DateProductReturnedToManufacturer.HasValue ? DateProductReturnedToManufacturer.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DeviceOperatorQualifications,
                                RelatednessAssessment,
                                ActionTakenInResponseToTheEvent != null ? string.Join(Configuration.FieldRepeatSeparator, ActionTakenInResponseToTheEvent) : null,
                                EventCausalityObservations != null ? string.Join(Configuration.FieldRepeatSeparator, EventCausalityObservations) : null,
                                IndirectExposureMechanism != null ? string.Join(Configuration.FieldRepeatSeparator, IndirectExposureMechanism) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}