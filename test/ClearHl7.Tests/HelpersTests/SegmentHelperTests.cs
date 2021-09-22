using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.HelpersTests
{
    public class SegmentHelperTests
    {
        /// <summary>
        /// Validates that SetSubcomponentFlags() returns the given object with the subcomponent's IsSubcomponent flag set to true.
        /// </summary>
        [Fact]
        public void SetSubcomponentFlags_WithSubcomponent_ReturnsObjectWithFlagSet()
        {
            PidSegment segment = new()
            {
                PatientAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "123 Main Street",
                            DwellingNumber = "Suite 321"
                        }
                    }
                }
            };

            SegmentHelper helper = new();
            helper.SetSubcomponentFlags(segment);

            Assert.True(segment.PatientAddress.FirstOrDefault().StreetAddress.IsSubcomponent);
        }

        /// <summary>
        /// Validates that SetSubcomponentFlags() returns the given object with the subcomponent's IsSubcomponent flag set to true.
        /// </summary>
        [Fact]
        public void SetSubcomponentFlags_WithoutSubcomponent_ReturnsObjectWithNoFlagSet()
        {
            PidSegment segment = new()
            {
                PatientAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        Addressee = "123 Main Street"
                    }
                }
            };

            SegmentHelper helper = new();
            helper.SetSubcomponentFlags(segment);

            Assert.False(segment.PatientAddress.FirstOrDefault().IsSubcomponent);
        }
    }
}
