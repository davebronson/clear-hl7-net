using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// PCR.1 - Implicated Product.
        ///// </summary>
        //public ImplicatedProduct { get; set; }

        ///// <summary>
        ///// PCR.2 - Generic Product.
        ///// </summary>
        //public GenericProduct { get; set; }

        ///// <summary>
        ///// PCR.3 - Product Class.
        ///// </summary>
        //public ProductClass { get; set; }

        ///// <summary>
        ///// PCR.4 - Total Duration Of Therapy.
        ///// </summary>
        //public TotalDurationOfTherapy { get; set; }

        ///// <summary>
        ///// PCR.5 - Product Manufacture Date.
        ///// </summary>
        //public ProductManufactureDate { get; set; }

        ///// <summary>
        ///// PCR.6 - Product Expiration Date.
        ///// </summary>
        //public ProductExpirationDate { get; set; }

        ///// <summary>
        ///// PCR.7 - Product Implantation Date.
        ///// </summary>
        //public ProductImplantationDate { get; set; }

        ///// <summary>
        ///// PCR.8 - Product Explantation Date.
        ///// </summary>
        //public ProductExplantationDate { get; set; }

        ///// <summary>
        ///// PCR.9 - Single Use Device.
        ///// </summary>
        //public SingleUseDevice { get; set; }

        ///// <summary>
        ///// PCR.10 - Indication For Product Use.
        ///// </summary>
        //public IndicationForProductUse { get; set; }

        ///// <summary>
        ///// PCR.11 - Product Problem.
        ///// </summary>
        //public ProductProblem { get; set; }

        ///// <summary>
        ///// PCR.12 - Product Serial/Lot Number.
        ///// </summary>
        //public ProductSerialLotNumber { get; set; }

        ///// <summary>
        ///// PCR.13 - Product Available For Inspection.
        ///// </summary>
        //public ProductAvailableForInspection { get; set; }

        ///// <summary>
        ///// PCR.14 - Product Evaluation Performed.
        ///// </summary>
        //public ProductEvaluationPerformed { get; set; }

        ///// <summary>
        ///// PCR.15 - Product Evaluation Status.
        ///// </summary>
        //public ProductEvaluationStatus { get; set; }

        ///// <summary>
        ///// PCR.16 - Product Evaluation Results.
        ///// </summary>
        //public ProductEvaluationResults { get; set; }

        ///// <summary>
        ///// PCR.17 - Evaluated Product Source.
        ///// </summary>
        //public EvaluatedProductSource { get; set; }

        ///// <summary>
        ///// PCR.18 - Date Product Returned To Manufacturer.
        ///// </summary>
        //public DateProductReturnedToManufacturer { get; set; }

        ///// <summary>
        ///// PCR.19 - Device Operator Qualifications.
        ///// </summary>
        //public DeviceOperatorQualifications { get; set; }

        ///// <summary>
        ///// PCR.20 - Relatedness Assessment.
        ///// </summary>
        //public RelatednessAssessment { get; set; }

        ///// <summary>
        ///// PCR.21 - Action Taken In Response To The Event.
        ///// </summary>
        //public ActionTakenInResponseToTheEvent { get; set; }

        ///// <summary>
        ///// PCR.22 - Event Causality Observations.
        ///// </summary>
        //public EventCausalityObservations { get; set; }

        ///// <summary>
        ///// PCR.23 - Indirect Exposure Mechanism.
        ///// </summary>
        //public IndirectExposureMechanism { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}"
                                ).TrimEnd('|');
        }
    }
}