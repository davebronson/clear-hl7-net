using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PAC - Shipment Package.
    /// </summary>
    public class PacSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacSegment"/> class.
        /// </summary>
        public PacSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PacSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public PacSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "PAC";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// PAC.1 - Set Id - PAC.
        /// </summary>
        public uint? SetIdPac { get; set; }

        /// <summary>
        /// PAC.2 - Package ID.
        /// </summary>
        public EntityIdentifier PackageId { get; set; }

        /// <summary>
        /// PAC.3 - Parent Package ID.
        /// </summary>
        public EntityIdentifier ParentPackageId { get; set; }

        /// <summary>
        /// PAC.4 - Position in Parent Package.
        /// </summary>
        public NumericArray PositionInParentPackage { get; set; }

        /// <summary>
        /// PAC.5 - Package Type.
        /// <para>Suggested: 0908 Package Type</para>
        /// </summary>
        public CodedWithExceptions PackageType { get; set; }

        /// <summary>
        /// PAC.6 - Package Condition.
        /// <para>Suggested: 0544 Container Condition -&gt; ClearHl7.Codes.V280.CodeContainerCondition</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> PackageCondition { get; set; }

        /// <summary>
        /// PAC.7 - Package Handling Code.
        /// <para>Suggested: 0376 Special Handling Code -&gt; ClearHl7.Codes.V280.CodeSpecialHandlingCode</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> PackageHandlingCode { get; set; }

        /// <summary>
        /// PAC.8 - Package Risk Code.
        /// <para>Suggested: 0489 Risk Codes -&gt; ClearHl7.Codes.V280.CodeRiskCodes</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> PackageRiskCode { get; set; }

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

            SetIdPac = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            PackageId = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[2], false, seps) : null;
            ParentPackageId = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[3], false, seps) : null;
            PositionInParentPackage = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<NumericArray>(segments[4], false, seps) : null;
            PackageType = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[5], false, seps) : null;
            PackageCondition = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            PackageHandlingCode = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            PackageRiskCode = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 9, Configuration.FieldSeparator),
                                Id,
                                SetIdPac.HasValue ? SetIdPac.Value.ToString(culture) : null,
                                PackageId?.ToDelimitedString(),
                                ParentPackageId?.ToDelimitedString(),
                                PositionInParentPackage?.ToDelimitedString(),
                                PackageType?.ToDelimitedString(),
                                PackageCondition != null ? string.Join(Configuration.FieldRepeatSeparator, PackageCondition.Select(x => x.ToDelimitedString())) : null,
                                PackageHandlingCode != null ? string.Join(Configuration.FieldRepeatSeparator, PackageHandlingCode.Select(x => x.ToDelimitedString())) : null,
                                PackageRiskCode != null ? string.Join(Configuration.FieldRepeatSeparator, PackageRiskCode.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
