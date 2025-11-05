using ClearHl7.Codes.V282;
using ClearHl7.Codes.V282.Helpers;
using Xunit;

namespace ClearHl7.Tests.HelpersTests
{
    public class EnumHelperTests
    {
        #region Instance Method Tests

        /// <summary>
        /// Validates that EnumHelper can be instantiated and used as an instance object.
        /// </summary>
        [Fact]
        public void EnumHelper_CanBeInstantiated()
        {
            // Arrange & Act
            var helper = new EnumHelper();

            // Assert
            Assert.NotNull(helper);
        }

        /// <summary>
        /// Validates that EnumToCode() instance method returns the correct HL7 code.
        /// </summary>
        [Fact]
        public void EnumToCode_WithCodeAcceptApplicationAcknowledgmentConditionsAlways_ReturnsAL()
        {
            // Arrange
            var helper = new EnumHelper();
            var input = CodeAcceptApplicationAcknowledgmentConditions.Always;

            // Act
            string result = helper.EnumToCode(input);

            // Assert
            Assert.Equal("AL", result);
        }

        /// <summary>
        /// Validates that EnumToCode() instance method returns the correct HL7 code.
        /// </summary>
        [Fact]
        public void EnumToCode_WithCodeAcceptApplicationAcknowledgmentConditionsErrorRejectConditionsOnly_ReturnsER()
        {
            // Arrange
            var helper = new EnumHelper();
            var input = CodeAcceptApplicationAcknowledgmentConditions.ErrorRejectConditionsOnly;

            // Act
            string result = helper.EnumToCode(input);

            // Assert
            Assert.Equal("ER", result);
        }

        /// <summary>
        /// Validates that EnumToCode() instance method returns the correct HL7 code.
        /// </summary>
        [Fact]
        public void EnumToCode_WithCodeAcceptApplicationAcknowledgmentConditionsNever_ReturnsNE()
        {
            // Arrange
            var helper = new EnumHelper();
            var input = CodeAcceptApplicationAcknowledgmentConditions.Never;

            // Act
            string result = helper.EnumToCode(input);

            // Assert
            Assert.Equal("NE", result);
        }

        /// <summary>
        /// Validates that EnumToCode() instance method returns the correct HL7 code.
        /// </summary>
        [Fact]
        public void EnumToCode_WithCodeAcceptApplicationAcknowledgmentConditionsSuccessfulCompletionOnly_ReturnsSU()
        {
            // Arrange
            var helper = new EnumHelper();
            var input = CodeAcceptApplicationAcknowledgmentConditions.SuccessfulCompletionOnly;

            // Act
            string result = helper.EnumToCode(input);

            // Assert
            Assert.Equal("SU", result);
        }

        /// <summary>
        /// Validates that EnumToCode() instance method works with different enum types.
        /// </summary>
        [Fact]
        public void EnumToCode_WithCodeAcknowledgmentCode_ReturnsCorrectValue()
        {
            // Arrange
            var helper = new EnumHelper();
            var input = CodeAcknowledgmentCode.OriginalModeAcceptEnhancedModeAcknowledgmentAccept;

            // Act
            string result = helper.EnumToCode(input);

            // Assert
            Assert.Equal("AA", result);
        }

        /// <summary>
        /// Validates that EnumToCode() instance method works with different enum types.
        /// </summary>
        [Fact]
        public void EnumToCode_WithCodeActiveInactive_ReturnsCorrectValue()
        {
            // Arrange
            var helper = new EnumHelper();
            var input = CodeActiveInactive.ActiveStaff;

            // Act
            string result = helper.EnumToCode(input);

            // Assert
            Assert.Equal("A", result);
        }

        /// <summary>
        /// Validates that EnumToCode() instance method works with CodeAccessRestrictionReasonCode.
        /// </summary>
        [Fact]
        public void EnumToCode_WithCodeAccessRestrictionReasonCode_ReturnsCorrectValue()
        {
            // Arrange
            var helper = new EnumHelper();
            var input = CodeAccessRestrictionReasonCode.DiagnosisRelated;

            // Act
            string result = helper.EnumToCode(input);

            // Assert
            Assert.Equal("DIA", result);
        }

        /// <summary>
        /// Validates that multiple EnumHelper instances can be created and used independently.
        /// </summary>
        [Fact]
        public void EnumHelper_MultipleInstances_WorkIndependently()
        {
            // Arrange
            var helper1 = new EnumHelper();
            var helper2 = new EnumHelper();

            // Act
            string result1 = helper1.EnumToCode(CodeAcceptApplicationAcknowledgmentConditions.Always);
            string result2 = helper2.EnumToCode(CodeAcceptApplicationAcknowledgmentConditions.Never);

            // Assert
            Assert.Equal("AL", result1);
            Assert.Equal("NE", result2);
        }

        /// <summary>
        /// Validates that EnumHelper can be used through the IEnumHelper interface.
        /// </summary>
        [Fact]
        public void EnumHelper_CanBeUsedThroughInterface()
        {
            // Arrange
            IEnumHelper helper = new EnumHelper();
            var input = CodeAcceptApplicationAcknowledgmentConditions.ErrorRejectConditionsOnly;

            // Act
            string result = helper.EnumToCode(input);

            // Assert
            Assert.Equal("ER", result);
        }

        /// <summary>
        /// Validates that EnumHelper can be instantiated using var keyword.
        /// </summary>
        [Fact]
        public void EnumHelper_WithVarKeyword_Works()
        {
            // Arrange
            var helper = new EnumHelper();
            var input = CodeAcceptApplicationAcknowledgmentConditions.SuccessfulCompletionOnly;

            // Act
            var result = helper.EnumToCode(input);

            // Assert
            Assert.Equal("SU", result);
        }

        #endregion

        #region Multiple Enum Type Tests

        /// <summary>
        /// Validates that a single EnumHelper instance can handle multiple different enum types.
        /// </summary>
        [Fact]
        public void EnumHelper_SingleInstance_HandlesMultipleEnumTypes()
        {
            // Arrange
            var helper = new EnumHelper();

            // Act & Assert
            Assert.Equal("AL", helper.EnumToCode(CodeAcceptApplicationAcknowledgmentConditions.Always));
            Assert.Equal("AA", helper.EnumToCode(CodeAcknowledgmentCode.OriginalModeAcceptEnhancedModeAcknowledgmentAccept));
            Assert.Equal("A", helper.EnumToCode(CodeActiveInactive.ActiveStaff));
            Assert.Equal("DIA", helper.EnumToCode(CodeAccessRestrictionReasonCode.DiagnosisRelated));
        }

        /// <summary>
        /// Validates EnumToCode with CodeAccessRestrictionValue enum.
        /// </summary>
        [Fact]
        public void EnumToCode_WithCodeAccessRestrictionValue_ReturnsCorrectValue()
        {
            // Arrange
            var helper = new EnumHelper();

            // Act & Assert
            Assert.Equal("ALL", helper.EnumToCode(CodeAccessRestrictionValue.All));
            Assert.Equal("DEM", helper.EnumToCode(CodeAccessRestrictionValue.AllDemographicData));
            Assert.Equal("DRG", helper.EnumToCode(CodeAccessRestrictionValue.Drug));
            Assert.Equal("HIV", helper.EnumToCode(CodeAccessRestrictionValue.HivStatusAndResults));
        }

        #endregion
    }
}
