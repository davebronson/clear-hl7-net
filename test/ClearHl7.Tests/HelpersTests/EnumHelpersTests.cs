using ClearHl7.Codes.V282;
using ClearHl7.Codes.V282.Helpers;
using Xunit;

namespace ClearHl7.Tests.HelpersTests
{
    public class EnumHelpersTests
    {
        #region Static Method Tests

        /// <summary>
        /// Validates that EnumMaps.EnumToCode() static method returns the correct HL7 code.
        /// </summary>
        [Fact]
        public void EnumToCode_Static_WithCodeAcceptApplicationAcknowledgmentConditionsAlways_ReturnsAL()
        {
            // Arrange
            var input = CodeAcceptApplicationAcknowledgmentConditions.Always;

            // Act
            string result = EnumMaps.EnumToCode(input);

            // Assert
            Assert.Equal("AL", result);
        }

        /// <summary>
        /// Validates that EnumMaps.EnumToCode() static method returns the correct HL7 code.
        /// </summary>
        [Fact]
        public void EnumToCode_Static_WithCodeAcceptApplicationAcknowledgmentConditionsErrorRejectConditionsOnly_ReturnsER()
        {
            // Arrange
            var input = CodeAcceptApplicationAcknowledgmentConditions.ErrorRejectConditionsOnly;

            // Act
            string result = EnumMaps.EnumToCode(input);

            // Assert
            Assert.Equal("ER", result);
        }

        /// <summary>
        /// Validates that EnumMaps.EnumToCode() static method returns the correct HL7 code.
        /// </summary>
        [Fact]
        public void EnumToCode_Static_WithCodeAcceptApplicationAcknowledgmentConditionsNever_ReturnsNE()
        {
            // Arrange
            var input = CodeAcceptApplicationAcknowledgmentConditions.Never;

            // Act
            string result = EnumMaps.EnumToCode(input);

            // Assert
            Assert.Equal("NE", result);
        }

        /// <summary>
        /// Validates that EnumMaps.EnumToCode() static method returns the correct HL7 code.
        /// </summary>
        [Fact]
        public void EnumToCode_Static_WithCodeAcceptApplicationAcknowledgmentConditionsSuccessfulCompletionOnly_ReturnsSU()
        {
            // Arrange
            var input = CodeAcceptApplicationAcknowledgmentConditions.SuccessfulCompletionOnly;

            // Act
            string result = EnumMaps.EnumToCode(input);

            // Assert
            Assert.Equal("SU", result);
        }

        /// <summary>
        /// Validates that EnumMaps.EnumToCode() static method works with different enum types.
        /// </summary>
        [Fact]
        public void EnumToCode_Static_WithCodeAcknowledgmentCode_ReturnsCorrectValue()
        {
            // Arrange
            var input = CodeAcknowledgmentCode.OriginalModeAcceptEnhancedModeAcknowledgmentAccept;

            // Act
            string result = EnumMaps.EnumToCode(input);

            // Assert
            Assert.Equal("AA", result);
        }

        /// <summary>
        /// Validates that EnumMaps.EnumToCode() static method works with different enum types.
        /// </summary>
        [Fact]
        public void EnumToCode_Static_WithCodeActiveInactive_ReturnsCorrectValue()
        {
            // Arrange
            var input = CodeActiveInactive.ActiveStaff;

            // Act
            string result = EnumMaps.EnumToCode(input);

            // Assert
            Assert.Equal("A", result);
        }

        /// <summary>
        /// Validates that EnumMaps.EnumToCode() static method works with CodeAccessRestrictionReasonCode.
        /// </summary>
        [Fact]
        public void EnumToCode_Static_WithCodeAccessRestrictionReasonCode_ReturnsCorrectValue()
        {
            // Arrange
            var input = CodeAccessRestrictionReasonCode.DiagnosisRelated;

            // Act
            string result = EnumMaps.EnumToCode(input);

            // Assert
            Assert.Equal("DIA", result);
        }

        /// <summary>
        /// Validates that EnumHelpers static methods handle multiple different enum types.
        /// </summary>
        [Fact]
        public void EnumHelpers_Static_HandlesMultipleEnumTypes()
        {
            // Act & Assert
            Assert.Equal("AL", EnumMaps.EnumToCode(CodeAcceptApplicationAcknowledgmentConditions.Always));
            Assert.Equal("AA", EnumMaps.EnumToCode(CodeAcknowledgmentCode.OriginalModeAcceptEnhancedModeAcknowledgmentAccept));
            Assert.Equal("A", EnumMaps.EnumToCode(CodeActiveInactive.ActiveStaff));
            Assert.Equal("DIA", EnumMaps.EnumToCode(CodeAccessRestrictionReasonCode.DiagnosisRelated));
        }

        /// <summary>
        /// Validates EnumMaps.EnumToCode with CodeAccessRestrictionValue enum.
        /// </summary>
        [Fact]
        public void EnumToCode_Static_WithCodeAccessRestrictionValue_ReturnsCorrectValue()
        {
            // Act & Assert
            Assert.Equal("ALL", EnumMaps.EnumToCode(CodeAccessRestrictionValue.All));
            Assert.Equal("DEM", EnumMaps.EnumToCode(CodeAccessRestrictionValue.AllDemographicData));
            Assert.Equal("DRG", EnumMaps.EnumToCode(CodeAccessRestrictionValue.Drug));
            Assert.Equal("HIV", EnumMaps.EnumToCode(CodeAccessRestrictionValue.HivStatusAndResults));
        }

        #endregion

        #region Comparison Tests: Static vs Instance

        /// <summary>
        /// Validates that static EnumHelpers and instance EnumHelper return the same results.
        /// </summary>
        [Fact]
        public void EnumHelpers_StaticAndInstance_ReturnSameResults()
        {
            // Arrange
            var helper = new EnumHelper();
            var input = CodeAcceptApplicationAcknowledgmentConditions.Always;

            // Act
            string staticResult = EnumMaps.EnumToCode(input);
            string instanceResult = helper.EnumToCode(input);

            // Assert
            Assert.Equal(staticResult, instanceResult);
        }

        /// <summary>
        /// Validates that static and instance methods produce identical results for multiple enum types.
        /// </summary>
        [Fact]
        public void EnumHelpers_StaticAndInstance_ProduceIdenticalResults()
        {
            // Arrange
            var helper = new EnumHelper();

            // Act & Assert - Test multiple enum types
            Assert.Equal(
                helper.EnumToCode(CodeAcceptApplicationAcknowledgmentConditions.ErrorRejectConditionsOnly),
                EnumMaps.EnumToCode(CodeAcceptApplicationAcknowledgmentConditions.ErrorRejectConditionsOnly)
            );

            Assert.Equal(
                helper.EnumToCode(CodeAcknowledgmentCode.OriginalModeErrorEnhancedModeAcknowledgmentError),
                EnumMaps.EnumToCode(CodeAcknowledgmentCode.OriginalModeErrorEnhancedModeAcknowledgmentError)
            );

            Assert.Equal(
                helper.EnumToCode(CodeActiveInactive.InactiveStaff),
                EnumMaps.EnumToCode(CodeActiveInactive.InactiveStaff)
            );
        }

        #endregion
    }
}
