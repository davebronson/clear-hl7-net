using System;
using System.Collections.Generic;
using ClearHl7.Helpers;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0249</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0244</remarks>
        public CodedWithExceptions SingleUseDevice { get; set; }

        /// <summary>
        /// PCR.10 - Indication For Product Use.
        /// </summary>
        public CodedWithExceptions IndicationForProductUse { get; set; }

        /// <summary>
        /// PCR.11 - Product Problem.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0245</remarks>
        public CodedWithExceptions ProductProblem { get; set; }

        /// <summary>
        /// PCR.12 - Product Serial/Lot Number.
        /// </summary>
        public IEnumerable<string> ProductSerialLotNumber { get; set; }

        /// <summary>
        /// PCR.13 - Product Available For Inspection.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0246</remarks>
        public CodedWithExceptions ProductAvailableForInspection { get; set; }

        /// <summary>
        /// PCR.14 - Product Evaluation Performed.
        /// </summary>
        public CodedWithExceptions ProductEvaluationPerformed { get; set; }

        /// <summary>
        /// PCR.15 - Product Evaluation Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0247</remarks>
        public CodedWithExceptions ProductEvaluationStatus { get; set; }

        /// <summary>
        /// PCR.16 - Product Evaluation Results.
        /// </summary>
        public CodedWithExceptions ProductEvaluationResults { get; set; }

        /// <summary>
        /// PCR.17 - Evaluated Product Source.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0248</remarks>
        public string EvaluatedProductSource { get; set; }

        /// <summary>
        /// PCR.18 - Date Product Returned To Manufacturer.
        /// </summary>
        public DateTime? DateProductReturnedToManufacturer { get; set; }

        /// <summary>
        /// PCR.19 - Device Operator Qualifications.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0242</remarks>
        public string DeviceOperatorQualifications { get; set; }

        /// <summary>
        /// PCR.20 - Relatedness Assessment.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0250</remarks>
        public string RelatednessAssessment { get; set; }

        /// <summary>
        /// PCR.21 - Action Taken In Response To The Event.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0251</remarks>
        public IEnumerable<string> ActionTakenInResponseToTheEvent { get; set; }

        /// <summary>
        /// PCR.22 - Event Causality Observations.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0252</remarks>
        public IEnumerable<string> EventCausalityObservations { get; set; }

        /// <summary>
        /// PCR.23 - Indirect Exposure Mechanism.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0253</remarks>
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
                                SingleUseDevice?.ToDelimitedString(),
                                IndicationForProductUse?.ToDelimitedString(),
                                ProductProblem?.ToDelimitedString(),
                                ProductSerialLotNumber != null ? string.Join(Configuration.FieldRepeatSeparator, ProductSerialLotNumber) : null,
                                ProductAvailableForInspection?.ToDelimitedString(),
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