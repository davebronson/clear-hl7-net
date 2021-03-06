﻿using System;
using ClearHl7.Helpers;

namespace ClearHl7.V290.Types
{
    /// <summary>
    /// HL7 Version 2 CSU - Channel Sensitivity And Units.
    /// </summary>
    public class ChannelSensitivityAndUnits : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// CSU.1 - Channel Sensitivity.
        /// </summary>
        public decimal? ChannelSensitivity { get; set; }

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
        /// <para>Suggested: 0396 Coding System</para>
        /// </summary>
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
        /// <para>Suggested: 0396 Coding System</para>
        /// </summary>
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
        /// <para>Suggested: 0396 Coding System</para>
        /// </summary>
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
        public DateTime? UnitOfMeasureValueSetVersionId { get; set; }

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
        public DateTime? AlternateUnitOfMeasureValueSetVersionId { get; set; }

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

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 23, separator),
                                ChannelSensitivity.HasValue ? ChannelSensitivity.Value.ToString(Consts.NumericFormat, culture) : null,
                                UnitOfMeasureIdentifier,
                                UnitOfMeasureDescription,
                                UnitOfMeasureCodingSystem,
                                AlternateUnitOfMeasureIdentifier,
                                AlternateUnitOfMeasureDescription,
                                AlternateUnitOfMeasureCodingSystem,
                                UnitOfMeasureCodingSystemVersionId,
                                AlternateUnitOfMeasureCodingSystemVersionId,
                                OriginalText,
                                SecondAlternateUnitOfMeasureIdentifier,
                                SecondAlternateUnitOfMeasureText,
                                NameOfSecondAlternateUnitOfMeasureCodingSystem,
                                SecondAlternateUnitOfMeasureCodingSystemVersionId,
                                UnitOfMeasureCodingSystemOid,
                                UnitOfMeasureValueSetOid,
                                UnitOfMeasureValueSetVersionId.HasValue ? UnitOfMeasureValueSetVersionId.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                AlternateUnitOfMeasureCodingSystemOid,
                                AlternateUnitOfMeasureValueSetOid,
                                AlternateUnitOfMeasureValueSetVersionId.HasValue ? AlternateUnitOfMeasureValueSetVersionId.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                AlternateUnitOfMeasureCodingSystemOidAdditional,
                                AlternateUnitOfMeasureValueSetOidAdditional,
                                AlternateUnitOfMeasureValueSetVersionIdAdditional
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
