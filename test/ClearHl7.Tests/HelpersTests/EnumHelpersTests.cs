using ClearHl7.Codes.V282;
using ClearHl7.Codes.V282.Helpers;
using Xunit;

namespace ClearHl7.Tests.HelpersTests
{
    public class EnumHelpersTests
    {
        #region Static Method Tests

        /// <summary>
        /// Validates that EnumHelpers.EnumToCode() static method returns the correct HL7 code.
        /// </summary>
        [Fact]
        public void EnumToCode_Static_WithCodeAcceptApplicationAcknowledgmentConditionsAlways_ReturnsAL()
        {
            // Arrange
            var input = CodeAcceptApplicationAcknowledgmentConditions.Always;

            // Act
            string result = EnumHelpers.EnumToCode(input);

            // Assert
            Assert.Equal("AL", result);
        }

        /// <summary>
        /// Validates that EnumHelpers.EnumToCode() static method returns the correct HL7 code.
        /// </summary>
        [Fact]
        public void EnumToCode_Static_WithCodeAcceptApplicationAcknowledgmentConditionsErrorRejectConditionsOnly_ReturnsER()
        {
            // Arrange
            var input = CodeAcceptApplicationAcknowledgmentConditions.ErrorRejectConditionsOnly;

            // Act
            string result = EnumHelpers.EnumToCode(input);

            // Assert
            Assert.Equal("ER", result);
        }

        /// <summary>
        /// Validates that EnumHelpers.EnumToCode() static method returns the correct HL7 code.
        /// </summary>
        [Fact]
        public void EnumToCode_Static_WithCodeAcceptApplicationAcknowledgmentConditionsNever_ReturnsNE()
        {
            // Arrange
            var input = CodeAcceptApplicationAcknowledgmentConditions.Never;

            // Act
            string result = EnumHelpers.EnumToCode(input);

            // Assert
            Assert.Equal("NE", result);
        }

        /// <summary>
        /// Validates that EnumHelpers.EnumToCode() static method returns the correct HL7 code.
        /// </summary>
        [Fact]
        public void EnumToCode_Static_WithCodeAcceptApplicationAcknowledgmentConditionsSuccessfulCompletionOnly_ReturnsSU()
        {
            // Arrange
            var input = CodeAcceptApplicationAcknowledgmentConditions.SuccessfulCompletionOnly;

            // Act
            string result = EnumHelpers.EnumToCode(input);

            // Assert
            Assert.Equal("SU", result);
        }

        /// <summary>
        /// Validates that EnumHelpers.EnumToCode() static method works with different enum types.
        /// </summary>
        [Fact]
        public void EnumToCode_Static_WithCodeAcknowledgmentCode_ReturnsCorrectValue()
        {
            // Arrange
            var input = CodeAcknowledgmentCode.OriginalModeAcceptEnhancedModeAcknowledgmentAccept;

            // Act
            string result = EnumHelpers.EnumToCode(input);

            // Assert
            Assert.Equal("AA", result);
        }

        /// <summary>
        /// Validates that EnumHelpers.EnumToCode() static method works with different enum types.
        /// </summary>
        [Fact]
        public void EnumToCode_Static_WithCodeActiveInactive_ReturnsCorrectValue()
        {
            // Arrange
            var input = CodeActiveInactive.ActiveStaff;

            // Act
            string result = EnumHelpers.EnumToCode(input);

            // Assert
            Assert.Equal("A", result);
        }

        /// <summary>
        /// Validates that EnumHelpers.EnumToCode() static method works with CodeAccessRestrictionReasonCode.
        /// </summary>
        [Fact]
        public void EnumToCode_Static_WithCodeAccessRestrictionReasonCode_ReturnsCorrectValue()
        {
            // Arrange
            var input = CodeAccessRestrictionReasonCode.DiagnosisRelated;

            // Act
            string result = EnumHelpers.EnumToCode(input);

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
            Assert.Equal("AL", EnumHelpers.EnumToCode(CodeAcceptApplicationAcknowledgmentConditions.Always));
            Assert.Equal("AA", EnumHelpers.EnumToCode(CodeAcknowledgmentCode.OriginalModeAcceptEnhancedModeAcknowledgmentAccept));
            Assert.Equal("A", EnumHelpers.EnumToCode(CodeActiveInactive.ActiveStaff));
            Assert.Equal("DIA", EnumHelpers.EnumToCode(CodeAccessRestrictionReasonCode.DiagnosisRelated));
        }

        /// <summary>
        /// Validates EnumHelpers.EnumToCode with CodeAccessRestrictionValue enum.
        /// </summary>
        [Fact]
        public void EnumToCode_Static_WithCodeAccessRestrictionValue_ReturnsCorrectValue()
        {
            // Act & Assert
            Assert.Equal("ALL", EnumHelpers.EnumToCode(CodeAccessRestrictionValue.All));
            Assert.Equal("DEM", EnumHelpers.EnumToCode(CodeAccessRestrictionValue.AllDemographicData));
            Assert.Equal("DRG", EnumHelpers.EnumToCode(CodeAccessRestrictionValue.Drug));
            Assert.Equal("HIV", EnumHelpers.EnumToCode(CodeAccessRestrictionValue.HivStatusAndResults));
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
            string staticResult = EnumHelpers.EnumToCode(input);
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
                EnumHelpers.EnumToCode(CodeAcceptApplicationAcknowledgmentConditions.ErrorRejectConditionsOnly)
            );

            Assert.Equal(
                helper.EnumToCode(CodeAcknowledgmentCode.OriginalModeErrorEnhancedModeAcknowledgmentError),
                EnumHelpers.EnumToCode(CodeAcknowledgmentCode.OriginalModeErrorEnhancedModeAcknowledgmentError)
            );

            Assert.Equal(
                helper.EnumToCode(CodeActiveInactive.InactiveStaff),
                EnumHelpers.EnumToCode(CodeActiveInactive.InactiveStaff)
            );
        }

        #endregion
    }
}
