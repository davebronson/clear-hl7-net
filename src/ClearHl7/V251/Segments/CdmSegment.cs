using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
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
        /// <para>Suggested: 0132 Transaction Code</para>
        /// </summary>
        public CodedElement PrimaryKeyValueCdm { get; set; }

        /// <summary>
        /// CDM.2 - Charge Code Alias.
        /// </summary>
        public IEnumerable<CodedElement> ChargeCodeAlias { get; set; }

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
        /// <para>Suggested: 0268 Override -&gt; ClearHl7.Codes.V251.CodeOverride</para>
        /// </summary>
        public string DescriptionOverrideIndicator { get; set; }

        /// <summary>
        /// CDM.6 - Exploding Charges.
        /// </summary>
        public IEnumerable<CodedElement> ExplodingCharges { get; set; }

        /// <summary>
        /// CDM.7 - Procedure Code.
        /// <para>Suggested: 0088 Procedure Code</para>
        /// </summary>
        public IEnumerable<CodedElement> ProcedureCode { get; set; }

        /// <summary>
        /// CDM.8 - Active/Inactive Flag.
        /// <para>Suggested: 0183 Active/Inactive -&gt; ClearHl7.Codes.V251.CodeActiveInactive</para>
        /// </summary>
        public string ActiveInactiveFlag { get; set; }

        /// <summary>
        /// CDM.9 - Inventory Number.
        /// <para>Suggested: 0463 Inventory Number</para>
        /// </summary>
        public IEnumerable<CodedElement> InventoryNumber { get; set; }

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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V251.CodeYesNoIndicator</para>
        /// </summary>
        public string RoomFeeIndicator { get; set; }

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

            PrimaryKeyValueCdm = segments.Length > 1 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(1), false) : null;
            ChargeCodeAlias = segments.Length > 2 ? segments.ElementAtOrDefault(2).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            ChargeDescriptionShort = segments.ElementAtOrDefault(3);
            ChargeDescriptionLong = segments.ElementAtOrDefault(4);
            DescriptionOverrideIndicator = segments.ElementAtOrDefault(5);
            ExplodingCharges = segments.Length > 6 ? segments.ElementAtOrDefault(6).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            ProcedureCode = segments.Length > 7 ? segments.ElementAtOrDefault(7).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            ActiveInactiveFlag = segments.ElementAtOrDefault(8);
            InventoryNumber = segments.Length > 9 ? segments.ElementAtOrDefault(9).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            ResourceLoad = segments.ElementAtOrDefault(10)?.ToNullableDecimal();
            ContractNumber = segments.Length > 11 ? segments.ElementAtOrDefault(1).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false)) : null;
            ContractOrganization = segments.Length > 12 ? segments.ElementAtOrDefault(12).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            RoomFeeIndicator = segments.ElementAtOrDefault(13);
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
                                StringHelper.StringFormatSequence(0, 14, Configuration.FieldSeparator),
                                Id,
                                PrimaryKeyValueCdm?.ToDelimitedString(),
                                ChargeCodeAlias != null ? string.Join(Configuration.FieldRepeatSeparator, ChargeCodeAlias.Select(x => x.ToDelimitedString())) : null,
                                ChargeDescriptionShort,
                                ChargeDescriptionLong,
                                DescriptionOverrideIndicator,
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