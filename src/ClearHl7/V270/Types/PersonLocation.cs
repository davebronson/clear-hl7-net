using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V270.Types
{
    /// <summary>
    /// HL7 Version 2 PL - Person Location.
    /// </summary>
    public class PersonLocation : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonLocation"/> class.
        /// </summary>
        public PersonLocation()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonLocation"/> class.
        /// </summary>
        /// <param name="pointOfCare">PL.1 - Point of Care.</param>
        public PersonLocation(HierarchicDesignator pointOfCare)
        {
            PointOfCare = pointOfCare;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// PL.1 - Point of Care.
        /// <para>Suggested: 0302 Point Of Care</para>
        /// </summary>
        public HierarchicDesignator PointOfCare { get; set; }

        /// <summary>
        /// PL.2 - Room.
        /// <para>Suggested: 0303 Room</para>
        /// </summary>
        public HierarchicDesignator Room { get; set; }

        /// <summary>
        /// PL.3 - Bed.
        /// <para>Suggested: 0304 Bed</para>
        /// </summary>
        public HierarchicDesignator Bed { get; set; }

        /// <summary>
        /// PL.4 - Facility.
        /// </summary>
        public HierarchicDesignator Facility { get; set; }

        /// <summary>
        /// PL.5 - Location Status.
        /// <para>Suggested: 0306 Location Status</para>
        /// </summary>
        public string LocationStatus { get; set; }

        /// <summary>
        /// PL.6 - Person Location Type.
        /// <para>Suggested: 0305 Person Location Type -&gt; ClearHl7.Codes.V270.CodePersonLocationType</para>
        /// </summary>
        public string PersonLocationType { get; set; }

        /// <summary>
        /// PL.7 - Building.
        /// <para>Suggested: 0307 Building</para>
        /// </summary>
        public HierarchicDesignator Building { get; set; }

        /// <summary>
        /// PL.8 - Floor.
        /// <para>Suggested: 0308 Floor</para>
        /// </summary>
        public HierarchicDesignator Floor { get; set; }

        /// <summary>
        /// PL.9 - Location Description.
        /// </summary>
        public string LocationDescription { get; set; }

        /// <summary>
        /// PL.10 - Comprehensive Location Identifier.
        /// </summary>
        public EntityIdentifier ComprehensiveLocationIdentifier { get; set; }

        /// <summary>
        /// PL.11 - Assigning Authority for Location.
        /// <para>Suggested: 0363 Assigning Authority -&gt; ClearHl7.Codes.V270.CodeAssigningAuthority</para>
        /// </summary>
        public HierarchicDesignator AssigningAuthorityForLocation { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(separator, StringSplitOptions.None);

            PointOfCare = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[0], true, seps) : null;
            Room = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[1], true, seps) : null;
            Bed = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[2], true, seps) : null;
            Facility = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[3], true, seps) : null;
            LocationStatus = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            PersonLocationType = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            Building = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[6], true, seps) : null;
            Floor = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[7], true, seps) : null;
            LocationDescription = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            ComprehensiveLocationIdentifier = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[9], true, seps) : null;
            AssigningAuthorityForLocation = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[10], true, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 11, separator),
                                PointOfCare?.ToDelimitedString(),
                                Room?.ToDelimitedString(),
                                Bed?.ToDelimitedString(),
                                Facility?.ToDelimitedString(),
                                LocationStatus,
                                PersonLocationType,
                                Building?.ToDelimitedString(),
                                Floor?.ToDelimitedString(),
                                LocationDescription,
                                ComprehensiveLocationIdentifier?.ToDelimitedString(),
                                AssigningAuthorityForLocation?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
