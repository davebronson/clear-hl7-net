using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 CSU - Channel Sensitivity And Units.
    /// </summary>
    public class ChannelSensitivityAndUnits
    {
        /// <summary>
        /// CSU.1 - Channel Sensitivity.
        /// </summary>
        public decimal ChannelSensitivity { get; set; }

        /// <summary>
        /// CSU.2 - Unit of Measure Identifier.
        /// </summary>
        public string UnitOfMeasureIdentifier { get; set; }

        /// <summary>
        /// CSU.3 - Unit of Measure Description.
        /// </summary>
        public string UnitOfMeasureDescription { get; set; }

        /// <summary>
        /// CSU.4 - Unit of Measure Coding System.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0396</remarks>
        public string UnitOfMeasureCodingSystem { get; set; }

        /// <summary>
        /// CSU.5 - Alternate Unit of Measure Identifier.
        /// </summary>
        public string AlternateUnitOfMeasureIdentifier { get; set; }

        /// <summary>
        /// CSU.6 - Alternate Unit of Measure Description.
        /// </summary>
        public string AlternateUnitOfMeasureDescription { get; set; }

        /// <summary>
        /// CSU.7 - Alternate Unit of Measure Coding System.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0396</remarks>
        public string AlternateUnitOfMeasureCodingSystem { get; set; }

        /// <summary>
        /// CSU.8 - Unit of Measure Coding System Version ID.
        /// </summary>
        public string UnitOfMeasureCodingSystemVersionId { get; set; }

        /// <summary>
        /// CSU.9 - Alternate Unit of Measure Coding System Version ID.
        /// </summary>
        public string AlternateUnitOfMeasureCodingSystemVersionId { get; set; }

        /// <summary>
        /// CSU.10 - Original Text.
        /// </summary>
        public string OriginalText { get; set; }

        /// <summary>
        /// CSU.11 - Second Alternate Unit of Measure Identifier.
        /// </summary>
        public string SecondAlternateUnitOfMeasureIdentifier { get; set; }

        /// <summary>
        /// CSU.12 - Second Alternate Unit of Measure Text.
        /// </summary>
        public string SecondAlternateUnitOfMeasureText { get; set; }

        /// <summary>
        /// CSU.13 - Name of Second Alternate Unit of Measure Coding System.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0396</remarks>
        public string NameOfSecondAlternateUnitOfMeasureCodingSystem { get; set; }

        /// <summary>
        /// CSU.14 - Second Alternate Unit of Measure Coding System Version ID.
        /// </summary>
        public string SecondAlternateUnitOfMeasureCodingSystemVersionId { get; set; }

        /// <summary>
        /// CSU.15 - Unit of Measure Coding System OID.
        /// </summary>
        public string UnitOfMeasureCodingSystemOid { get; set; }

        /// <summary>
        /// CSU.16 - Unit of Measure Value Set OID.
        /// </summary>
        public string UnitOfMeasureValueSetOid { get; set; }

        /// <summary>
        /// CSU.17 - Unit of MeasureValue Set Version ID.
        /// </summary>
        public DateTime UnitOfMeasureValueSetVersionId { get; set; }

        /// <summary>
        /// CSU.18 - Alternate Unit of Measure Coding System OID.
        /// </summary>
        public string AlternateUnitOfMeasureCodingSystemOid { get; set; }

        /// <summary>
        /// CSU.19 - Alternate Unit of Measure Value Set OID.
        /// </summary>
        public string AlternateUnitOfMeasureValueSetOid { get; set; }

        /// <summary>
        /// CSU.20 - Alternate Unit of Measure Value Set Version ID.
        /// </summary>
        public DateTime AlternateUnitOfMeasureValueSetVersionId { get; set; }

        /// <summary>
        /// CSU.21 - Alternate Unit of Measure Coding System OID.
        /// </summary>
        public string AlternateUnitOfMeasureCodingSystemOidAdditional { get; set; }

        /// <summary>
        /// CSU.22 - Alternate Unit of Measure Value Set OID.
        /// </summary>
        public string AlternateUnitOfMeasureValueSetOidAdditional { get; set; }

        /// <summary>
        /// CSU.23 - Alternate Unit of Measure Value Set Version ID.
        /// </summary>
        public string AlternateUnitOfMeasureValueSetVersionIdAdditional { get; set; }
    }
}
