﻿using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V290.Types;

namespace ClearHl7.Fhir.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CDM - Charge Description Master.
    /// </summary>
    public class CdmSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "CDM";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// CDM.1 - Primary Key Value - CDM.
        /// </summary>
        public CodedWithExceptions PrimaryKeyValueCdm { get; set; }

        /// <summary>
        /// CDM.2 - Charge Code Alias.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0132</remarks>
        public IEnumerable<CodedWithExceptions> ChargeCodeAlias { get; set; }

        /// <summary>
        /// CDM.3 - Charge Description Short.
        /// </summary>
        public string ChargeDescriptionShort { get; set; }

        /// <summary>
        /// CDM.4 - Charge Description Long.
        /// </summary>
        public string ChargeDescriptionLong { get; set; }

        /// <summary>
        /// CDM.5 - Description Override Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0268</remarks>
        public CodedWithExceptions DescriptionOverrideIndicator { get; set; }

        /// <summary>
        /// CDM.6 - Exploding Charges.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0132</remarks>
        public IEnumerable<CodedWithExceptions> ExplodingCharges { get; set; }

        /// <summary>
        /// CDM.7 - Procedure Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0088</remarks>
        public IEnumerable<CodedWithNoExceptions> ProcedureCode { get; set; }

        /// <summary>
        /// CDM.8 - Active/Inactive Flag.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0183</remarks>
        public string ActiveInactiveFlag { get; set; }

        /// <summary>
        /// CDM.9 - Inventory Number.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0463</remarks>
        public IEnumerable<CodedWithExceptions> InventoryNumber { get; set; }

        /// <summary>
        /// CDM.10 - Resource Load.
        /// </summary>
        public decimal? ResourceLoad { get; set; }

        /// <summary>
        /// CDM.11 - Contract Number.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> ContractNumber { get; set; }

        /// <summary>
        /// CDM.12 - Contract Organization.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> ContractOrganization { get; set; }

        /// <summary>
        /// CDM.13 - Room Fee Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string RoomFeeIndicator { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 14, Configuration.FieldSeparator),
                                Id,
                                PrimaryKeyValueCdm?.ToDelimitedString(),
                                ChargeCodeAlias != null ? string.Join(Configuration.FieldRepeatSeparator, ChargeCodeAlias.Select(x => x.ToDelimitedString())) : null,
                                ChargeDescriptionShort,
                                ChargeDescriptionLong,
                                DescriptionOverrideIndicator?.ToDelimitedString(),
                                ExplodingCharges != null ? string.Join(Configuration.FieldRepeatSeparator, ExplodingCharges.Select(x => x.ToDelimitedString())) : null,
                                ProcedureCode != null ? string.Join(Configuration.FieldRepeatSeparator, ProcedureCode.Select(x => x.ToDelimitedString())) : null,
                                ActiveInactiveFlag,
                                InventoryNumber != null ? string.Join(Configuration.FieldRepeatSeparator, InventoryNumber.Select(x => x.ToDelimitedString())) : null,
                                ResourceLoad.HasValue ? ResourceLoad.Value.ToString(Consts.NumericFormat, culture) : null,
                                ContractNumber != null ? string.Join(Configuration.FieldRepeatSeparator, ContractNumber.Select(x => x.ToDelimitedString())) : null,
                                ContractOrganization != null ? string.Join(Configuration.FieldRepeatSeparator, ContractOrganization.Select(x => x.ToDelimitedString())) : null,
                                RoomFeeIndicator
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}