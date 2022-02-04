using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CDM - Charge Description Master.
    /// </summary>
    public class CdmSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CdmSegment"/> class.
        /// </summary>
        public CdmSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CdmSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public CdmSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id { get; } = "CDM";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// CDM.1 - Primary Key Value - CDM.
        /// </summary>
        public CodedWithExceptions PrimaryKeyValueCdm { get; set; }

        /// <summary>
        /// CDM.2 - Charge Code Alias.
        /// <para>Suggested: 0132 Transaction Code</para>
        /// </summary>
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
        /// <para>Suggested: 0268 Override -&gt; ClearHl7.Codes.V290.CodeOverride</para>
        /// </summary>
        public CodedWithExceptions DescriptionOverrideIndicator { get; set; }

        /// <summary>
        /// CDM.6 - Exploding Charges.
        /// <para>Suggested: 0132 Transaction Code</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ExplodingCharges { get; set; }

        /// <summary>
        /// CDM.7 - Procedure Code.
        /// <para>Suggested: 0088 Procedure Code</para>
        /// </summary>
        public IEnumerable<CodedWithNoExceptions> ProcedureCode { get; set; }

        /// <summary>
        /// CDM.8 - Active/Inactive Flag.
        /// <para>Suggested: 0183 Active/Inactive -&gt; ClearHl7.Codes.V290.CodeActiveInactive</para>
        /// </summary>
        public string ActiveInactiveFlag { get; set; }

        /// <summary>
        /// CDM.9 - Inventory Number.
        /// <para>Suggested: 0463 Inventory Number</para>
        /// </summary>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string RoomFeeIndicator { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            PrimaryKeyValueCdm = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], false, seps) : null;
            ChargeCodeAlias = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            ChargeDescriptionShort = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            ChargeDescriptionLong = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            DescriptionOverrideIndicator = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[5], false, seps) : null;
            ExplodingCharges = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            ProcedureCode = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithNoExceptions>(x, false, seps)) : null;
            ActiveInactiveFlag = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            InventoryNumber = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            ResourceLoad = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDecimal() : null;
            ContractNumber = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false, seps)) : null;
            ContractOrganization = segments.Length > 12 && segments[12].Length > 0 ? segments[12].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false, seps)) : null;
            RoomFeeIndicator = segments.Length > 13 && segments[13].Length > 0 ? segments[13] : null;
        }

        /// <inheritdoc/>
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
