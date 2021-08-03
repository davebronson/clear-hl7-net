using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PAC - Shipment Package.
    /// </summary>
    public class PacSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PAC";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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
        /// <para>Suggested: 0544 Container Condition -&gt; ClearHl7.Codes.V270.CodeContainerCondition</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> PackageCondition { get; set; }

        /// <summary>
        /// PAC.7 - Package Handling Code.
        /// <para>Suggested: 0376 Special Handling Code -&gt; ClearHl7.Codes.V270.CodeSpecialHandlingCode</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> PackageHandlingCode { get; set; }

        /// <summary>
        /// PAC.8 - Package Risk Code.
        /// <para>Suggested: 0489 Risk Codes -&gt; ClearHl7.Codes.V270.CodeRiskCodes</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> PackageRiskCode { get; set; }

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

            SetIdPac = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            PackageId = segments.Length > 2 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(2), false) : null;
            ParentPackageId = segments.Length > 3 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(3), false) : null;
            PositionInParentPackage = segments.Length > 4 ? TypeHelper.Deserialize<NumericArray>(segments.ElementAtOrDefault(4), false) : null;
            PackageType = segments.Length > 5 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(5), false) : null;
            PackageCondition = segments.Length > 6 ? segments.ElementAtOrDefault(6).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            PackageHandlingCode = segments.Length > 7 ? segments.ElementAtOrDefault(7).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            PackageRiskCode = segments.Length > 8 ? segments.ElementAtOrDefault(8).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
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