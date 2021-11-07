using System;
using ClearHl7.Helpers;
using Xunit;

namespace ClearHl7.Tests.HelpersTests
{
    public class MessageHelperTests
    {
        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when V2.3 is specified.
        /// </summary>
        [Fact]
        public void DetectVersion_With23Specified_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|^~\&||||||||||2.3||" }{ Consts.LineTerminator }") == Hl7Version.V230);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when V2.3.0 is specified.
        /// </summary>
        [Fact]
        public void DetectVersion_With230Specified_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|^~\&||||||||||2.3.0||" }{ Consts.LineTerminator }") == Hl7Version.V230);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when V2.3.1 is specified.
        /// </summary>
        [Fact]
        public void DetectVersion_With231Specified_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|^~\&||||||||||2.3.1||" }{ Consts.LineTerminator }") == Hl7Version.V231);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when V2.4 is specified.
        /// </summary>
        [Fact]
        public void DetectVersion_With24Specified_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|^~\&||||||||||2.4||" }{ Consts.LineTerminator }") == Hl7Version.V240);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when V2.4.0 is specified.
        /// </summary>
        [Fact]
        public void DetectVersion_With240Specified_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|^~\&||||||||||2.4.0||" }{ Consts.LineTerminator }") == Hl7Version.V240);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when V2.5 is specified.
        /// </summary>
        [Fact]
        public void DetectVersion_With25Specified_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|^~\&||||||||||2.5||" }{ Consts.LineTerminator }") == Hl7Version.V250);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when V2.5.0 is specified.
        /// </summary>
        [Fact]
        public void DetectVersion_With250Specified_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|^~\&||||||||||2.5.0||" }{ Consts.LineTerminator }") == Hl7Version.V250);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when V2.5.1 is specified.
        /// </summary>
        [Fact]
        public void DetectVersion_With251Specified_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|^~\&||||||||||2.5.1||" }{ Consts.LineTerminator }") == Hl7Version.V251);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when V2.6 is specified.
        /// </summary>
        [Fact]
        public void DetectVersion_With26Specified_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|^~\&||||||||||2.6||" }{ Consts.LineTerminator }") == Hl7Version.V260);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when V2.6.0 is specified.
        /// </summary>
        [Fact]
        public void DetectVersion_With260Specified_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|^~\&||||||||||2.6.0||" }{ Consts.LineTerminator }") == Hl7Version.V260);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when V2.7 is specified.
        /// </summary>
        [Fact]
        public void DetectVersion_With27Specified_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|^~\&||||||||||2.7||" }{ Consts.LineTerminator }") == Hl7Version.V270);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when V2.7.0 is specified.
        /// </summary>
        [Fact]
        public void DetectVersion_With270Specified_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|^~\&||||||||||2.7.0||" }{ Consts.LineTerminator }") == Hl7Version.V270);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when V2.7.1 is specified.
        /// </summary>
        [Fact]
        public void DetectVersion_With271Specified_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|^~\&||||||||||2.7.1||" }{ Consts.LineTerminator }") == Hl7Version.V271);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when V2.8 is specified.
        /// </summary>
        [Fact]
        public void DetectVersion_With28Specified_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|^~\&||||||||||2.8||" }{ Consts.LineTerminator }") == Hl7Version.V280);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when V2.8.0 is specified.
        /// </summary>
        [Fact]
        public void DetectVersion_With280Specified_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|^~\&||||||||||2.8.0||" }{ Consts.LineTerminator }") == Hl7Version.V280);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when V2.8.1 is specified.
        /// </summary>
        [Fact]
        public void DetectVersion_With281Specified_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|^~\&||||||||||2.8.1||" }{ Consts.LineTerminator }") == Hl7Version.V281);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when V2.8.2 is specified.
        /// </summary>
        [Fact]
        public void DetectVersion_With282Specified_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|^~\&||||||||||2.8.2||" }{ Consts.LineTerminator }") == Hl7Version.V282);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when V2.9 is specified.
        /// </summary>
        [Fact]
        public void DetectVersion_With29Specified_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|^~\&||||||||||2.9||" }{ Consts.LineTerminator }") == Hl7Version.V290);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when V2.9.0 is specified.
        /// </summary>
        [Fact]
        public void DetectVersion_With290Specified_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|^~\&||||||||||2.9.0||" }{ Consts.LineTerminator }") == Hl7Version.V290);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when position 12 includes multiple components.
        /// </summary>
        [Fact]
        public void DetectVersion_WithMultipleComponentsInPositionTwelve_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|^~\&||||||||||2.5.1^something else||" }{ Consts.LineTerminator }") == Hl7Version.V251);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when a custom component separator is used.
        /// </summary>
        [Fact]
        public void DetectVersion_WithCustomComponentSeparator_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|$~\&||||||||||2.5.1$something else||" }{ Consts.LineTerminator }") == Hl7Version.V251);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when a custom field separator is used.
        /// </summary>
        [Fact]
        public void DetectVersion_WithCustomFieldSeparator_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH$^~\&$$$$$$$$$$2.5.1$$" }{ Consts.LineTerminator }") == Hl7Version.V251);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when exactly 12 positions are provided.
        /// </summary>
        [Fact]
        public void DetectVersion_WithExactly12Positions_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|^~\&||||||||||2.5.1" }{ Consts.LineTerminator }") == Hl7Version.V251);
        }

        /// <summary>
        /// Validates that DetectVersion() returns the correct HL7 version enum value when less than 12 positions are provided.
        /// </summary>
        [Fact]
        public void DetectVersion_WithLessThan12Positions_ReturnsCorrectHl7Version()
        {
            Assert.True(MessageHelper.DetectVersion($"{ @"MSH|^~\&||||||" }{ Consts.LineTerminator }") == Hl7Version.None);
        }

        /// <summary>
        /// Validates that DetectVersion() throws an ArgumentNullException when a null delimitedString is provided.
        /// </summary>
        [Fact]
        public void DetectVersion_WithNullInput_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                MessageHelper.DetectVersion(null);
            });
        }

        /// <summary>
        /// Validates that DetectVersion() throws an ArgumentException when an under-length delimitedString is provided.
        /// </summary>
        [Fact]
        public void DetectVersion_WithLessThan5CharInput_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                MessageHelper.DetectVersion(@"MSH|");
            });
        }

        /// <summary>
        /// Validates that DetectVersion() throws an ArgumentException when a delimitedString not beginning with an MSH segment is provided.
        /// </summary>
        [Fact]
        public void DetectVersion_WithInvalidFirstSegment_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                MessageHelper.DetectVersion($"{ @"ABC|^~\&||||||||||2.8.0||" }{ Consts.LineTerminator }");
            });
        }

        /// <summary>
        /// Validates that NewInstance() returns the correct message instance when V2.3 is specified.
        /// </summary>
        [Fact]
        public void NewInstance_With23Specified_ReturnsCorrectHl7Version()
        {
            Assert.IsType<V230.Message>(MessageHelper.NewInstance(Hl7Version.V230));
        }

        /// <summary>
        /// Validates that NewInstance() returns the correct message instance when V2.3.1 is specified.
        /// </summary>
        [Fact]
        public void NewInstance_Wit231Specified_ReturnsCorrectHl7Version()
        {
            Assert.IsType<V231.Message>(MessageHelper.NewInstance(Hl7Version.V231));
        }

        /// <summary>
        /// Validates that NewInstance() returns the correct message instance when V2.4 is specified.
        /// </summary>
        [Fact]
        public void NewInstance_With24Specified_ReturnsCorrectHl7Version()
        {
            Assert.IsType<V240.Message>(MessageHelper.NewInstance(Hl7Version.V240));
        }

        /// <summary>
        /// Validates that NewInstance() returns the correct message instance when V2.5 is specified.
        /// </summary>
        [Fact]
        public void NewInstance_With25Specified_ReturnsCorrectHl7Version()
        {
            Assert.IsType<V250.Message>(MessageHelper.NewInstance(Hl7Version.V250));
        }

        /// <summary>
        /// Validates that NewInstance() returns the correct message instance when V2.5.1 is specified.
        /// </summary>
        [Fact]
        public void NewInstance_With251Specified_ReturnsCorrectHl7Version()
        {
            Assert.IsType<V251.Message>(MessageHelper.NewInstance(Hl7Version.V251));
        }

        /// <summary>
        /// Validates that NewInstance() returns the correct message instance when V2.6 is specified.
        /// </summary>
        [Fact]
        public void NewInstance_With26Specified_ReturnsCorrectHl7Version()
        {
            Assert.IsType<V260.Message>(MessageHelper.NewInstance(Hl7Version.V260));
        }

        /// <summary>
        /// Validates that NewInstance() returns the correct message instance when V2.7 is specified.
        /// </summary>
        [Fact]
        public void NewInstance_With27Specified_ReturnsCorrectHl7Version()
        {
            Assert.IsType<V270.Message>(MessageHelper.NewInstance(Hl7Version.V270));
        }

        /// <summary>
        /// Validates that NewInstance() returns the correct message instance when V2.7.1 is specified.
        /// </summary>
        [Fact]
        public void NewInstance_With271Specified_ReturnsCorrectHl7Version()
        {
            Assert.IsType<V271.Message>(MessageHelper.NewInstance(Hl7Version.V271));
        }

        /// <summary>
        /// Validates that NewInstance() returns the correct message instance when V2.8 is specified.
        /// </summary>
        [Fact]
        public void NewInstance_With28Specified_ReturnsCorrectHl7Version()
        {
            Assert.IsType<V280.Message>(MessageHelper.NewInstance(Hl7Version.V280));
        }

        /// <summary>
        /// Validates that NewInstance() returns the correct message instance when V2.8.1 is specified.
        /// </summary>
        [Fact]
        public void NewInstance_With281Specified_ReturnsCorrectHl7Version()
        {
            Assert.IsType<V281.Message>(MessageHelper.NewInstance(Hl7Version.V281));
        }

        /// <summary>
        /// Validates that NewInstance() returns the correct message instance when V2.8.2 is specified.
        /// </summary>
        [Fact]
        public void NewInstance_With282Specified_ReturnsCorrectHl7Version()
        {
            Assert.IsType<V282.Message>(MessageHelper.NewInstance(Hl7Version.V282));
        }

        /// <summary>
        /// Validates that NewInstance() returns the correct message instance when V2.9 is specified.
        /// </summary>
        [Fact]
        public void NewInstance_With29Specified_ReturnsCorrectHl7Version()
        {
            Assert.IsType<V290.Message>(MessageHelper.NewInstance(Hl7Version.V290));
        }
    }
}
