using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PR1 - Procedures.
    /// </summary>
    public class Pr1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PR1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// PR1.1 - Set ID - PR1.
        ///// </summary>
        //public SetIdPr1 { get; set; }

        ///// <summary>
        ///// PR1.2 - Procedure Coding Method.
        ///// </summary>
        //public ProcedureCodingMethod { get; set; }

        ///// <summary>
        ///// PR1.3 - Procedure Code.
        ///// </summary>
        //public ProcedureCode { get; set; }

        ///// <summary>
        ///// PR1.4 - Procedure Description.
        ///// </summary>
        //public ProcedureDescription { get; set; }

        ///// <summary>
        ///// PR1.5 - Procedure Date/Time.
        ///// </summary>
        //public ProcedureDateTime { get; set; }

        ///// <summary>
        ///// PR1.6 - Procedure Functional Type.
        ///// </summary>
        //public ProcedureFunctionalType { get; set; }

        ///// <summary>
        ///// PR1.7 - Procedure Minutes.
        ///// </summary>
        //public ProcedureMinutes { get; set; }

        ///// <summary>
        ///// PR1.8 - Anesthesiologist.
        ///// </summary>
        //public Anesthesiologist { get; set; }

        ///// <summary>
        ///// PR1.9 - Anesthesia Code.
        ///// </summary>
        //public AnesthesiaCode { get; set; }

        ///// <summary>
        ///// PR1.10 - Anesthesia Minutes.
        ///// </summary>
        //public AnesthesiaMinutes { get; set; }

        ///// <summary>
        ///// PR1.11 - Surgeon.
        ///// </summary>
        //public Surgeon { get; set; }

        ///// <summary>
        ///// PR1.12 - Procedure Practitioner.
        ///// </summary>
        //public ProcedurePractitioner { get; set; }

        ///// <summary>
        ///// PR1.13 - Consent Code.
        ///// </summary>
        //public ConsentCode { get; set; }

        ///// <summary>
        ///// PR1.14 - Procedure Priority.
        ///// </summary>
        //public ProcedurePriority { get; set; }

        ///// <summary>
        ///// PR1.15 - Associated Diagnosis Code.
        ///// </summary>
        //public AssociatedDiagnosisCode { get; set; }

        ///// <summary>
        ///// PR1.16 - Procedure Code Modifier.
        ///// </summary>
        //public ProcedureCodeModifier { get; set; }

        ///// <summary>
        ///// PR1.17 - Procedure DRG Type.
        ///// </summary>
        //public ProcedureDrgType { get; set; }

        ///// <summary>
        ///// PR1.18 - Tissue Type Code.
        ///// </summary>
        //public TissueTypeCode { get; set; }

        ///// <summary>
        ///// PR1.19 - Procedure Identifier.
        ///// </summary>
        //public ProcedureIdentifier { get; set; }

        ///// <summary>
        ///// PR1.20 - Procedure Action Code.
        ///// </summary>
        //public ProcedureActionCode { get; set; }

        ///// <summary>
        ///// PR1.21 - DRG Procedure Determination Status.
        ///// </summary>
        //public DrgProcedureDeterminationStatus { get; set; }

        ///// <summary>
        ///// PR1.22 - DRG Procedure Relevance.
        ///// </summary>
        //public DrgProcedureRelevance { get; set; }

        ///// <summary>
        ///// PR1.23 - Treating Organizational Unit.
        ///// </summary>
        //public TreatingOrganizationalUnit { get; set; }

        ///// <summary>
        ///// PR1.24 - Respiratory Within Surgery.
        ///// </summary>
        //public RespiratoryWithinSurgery { get; set; }

        ///// <summary>
        ///// PR1.25 - Parent Procedure ID.
        ///// </summary>
        //public ParentProcedureId { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}"
                                ).TrimEnd('|');
        }
    }
}