using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PRD - Provider Data.
    /// </summary>
    public class PrdSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PRD";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// PRD.1 - Provider Role.
        ///// </summary>
        //public ProviderRole { get; set; }

        ///// <summary>
        ///// PRD.2 - Provider Name.
        ///// </summary>
        //public ProviderName { get; set; }

        ///// <summary>
        ///// PRD.3 - Provider Address.
        ///// </summary>
        //public ProviderAddress { get; set; }

        ///// <summary>
        ///// PRD.4 - Provider Location.
        ///// </summary>
        //public ProviderLocation { get; set; }

        ///// <summary>
        ///// PRD.5 - Provider Communication Information.
        ///// </summary>
        //public ProviderCommunicationInformation { get; set; }

        ///// <summary>
        ///// PRD.6 - Preferred Method of Contact.
        ///// </summary>
        //public PreferredMethodOfContact { get; set; }

        ///// <summary>
        ///// PRD.7 - Provider Identifiers.
        ///// </summary>
        //public ProviderIdentifiers { get; set; }

        ///// <summary>
        ///// PRD.8 - Effective Start Date of Provider Role.
        ///// </summary>
        //public EffectiveStartDateOfProviderRole { get; set; }

        ///// <summary>
        ///// PRD.9 - Effective End Date of Provider Role.
        ///// </summary>
        //public EffectiveEndDateOfProviderRole { get; set; }

        ///// <summary>
        ///// PRD.10 - Provider Organization Name and Identifier.
        ///// </summary>
        //public ProviderOrganizationNameAndIdentifier { get; set; }

        ///// <summary>
        ///// PRD.11 - Provider Organization Address.
        ///// </summary>
        //public ProviderOrganizationAddress { get; set; }

        ///// <summary>
        ///// PRD.12 - Provider Organization Location Information.
        ///// </summary>
        //public ProviderOrganizationLocationInformation { get; set; }

        ///// <summary>
        ///// PRD.13 - Provider Organization Communication Information.
        ///// </summary>
        //public ProviderOrganizationCommunicationInformation { get; set; }

        ///// <summary>
        ///// PRD.14 - Provider Organization Method of Contact.
        ///// </summary>
        //public ProviderOrganizationMethodOfContact { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}"
                                ).TrimEnd('|');
        }
    }
}