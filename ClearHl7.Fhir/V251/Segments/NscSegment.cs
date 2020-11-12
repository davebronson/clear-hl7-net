using System;
using ClearHl7.Fhir.V251.Types;

namespace ClearHl7.Fhir.V251.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment NSC - Application Status Change.
    /// </summary>
    public class NscSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "NSC";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// NSC.1 - Application Change Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0409</remarks>
        public string ApplicationChangeType { get; set; }

        /// <summary>
        /// NSC.2 - Current CPU.
        /// </summary>
        public string CurrentCpu { get; set; }

        /// <summary>
        /// NSC.3 - Current Fileserver.
        /// </summary>
        public string CurrentFileserver { get; set; }

        /// <summary>
        /// NSC.4 - Current Application.
        /// </summary>
        public HierarchicDesignator CurrentApplication { get; set; }

        /// <summary>
        /// NSC.5 - Current Facility.
        /// </summary>
        public HierarchicDesignator CurrentFacility { get; set; }

        /// <summary>
        /// NSC.6 - New CPU.
        /// </summary>
        public string NewCpu { get; set; }

        /// <summary>
        /// NSC.7 - New Fileserver.
        /// </summary>
        public string NewFileserver { get; set; }

        /// <summary>
        /// NSC.8 - New Application.
        /// </summary>
        public HierarchicDesignator NewApplication { get; set; }

        /// <summary>
        /// NSC.9 - New Facility.
        /// </summary>
        public HierarchicDesignator NewFacility { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}",
                                Id,
                                ApplicationChangeType,
                                CurrentCpu,
                                CurrentFileserver,
                                CurrentApplication?.ToDelimitedString(),
                                CurrentFacility?.ToDelimitedString(),
                                NewCpu,
                                NewFileserver,
                                NewApplication?.ToDelimitedString(),
                                NewFacility?.ToDelimitedString()
                                ).TrimEnd('|');
        }
    }
}