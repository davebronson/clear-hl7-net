namespace ClearHl7
{
    /// <summary>
    /// Provides access to certain library configuration.
    /// </summary>
    public static class Configuration
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this Message instance will automatically handle setting of the IsSubcomponent flag for contained HL7 objects that exist at the subcomponent level.
        /// </summary>
        /// <remarks>
        /// The default value is true.  However, small performance gains can be realized by setting this property to false, and then
        /// manually handling the setting of IsSubcomponent properties as you build up HL7 Message Segments in your own
        /// code.  Doing so prevents this component from having to manually traverse down through the Message object hierarchy
        /// before returning the finished string output.
        /// </remarks>
        public static bool AutoSetSubcomponentFlags { get; set; } = true;

        private static string _fieldSeparator = Consts.DefaultFieldSeparator;
        private static char[] _fieldSeparatorCharArray;

        /// <summary>
        /// Gets or sets the character used to separate fields.
        /// </summary>
        /// <remarks>The default character | is recommended.</remarks>
        public static string FieldSeparator
        {
            get => _fieldSeparator;
            set
            {
                _fieldSeparator = value;
                _fieldSeparatorCharArray = null;  // invalidate lazily — rebuilt on next access
                Helpers.StringHelper.InvalidateFormatSequenceCache();
            }
        }

        /// <summary>
        /// Gets a cached char array of <see cref="FieldSeparator"/>.
        /// Built once on first access after construction or after a separator change.
        /// Avoids the per-call allocation of <c>FieldSeparator.ToCharArray()</c> inside every
        /// <c>ToDelimitedString()</c> invocation.
        /// </summary>
        public static char[] FieldSeparatorCharArray =>
            _fieldSeparatorCharArray ??= _fieldSeparator.ToCharArray();

        private static string _componentSeparator = Consts.DefaultComponentSeparator;
        private static char[] _componentSeparatorCharArray;

        /// <summary>
        /// Gets or sets the character used to separate components.
        /// </summary>
        /// <remarks>The default character ^ is recommended.</remarks>
        public static string ComponentSeparator
        {
            get => _componentSeparator;
            set
            {
                _componentSeparator = value;
                _componentSeparatorCharArray = null;
                Helpers.StringHelper.InvalidateFormatSequenceCache();
            }
        }

        /// <summary>
        /// Gets a cached char array of <see cref="ComponentSeparator"/>.
        /// </summary>
        public static char[] ComponentSeparatorCharArray =>
            _componentSeparatorCharArray ??= _componentSeparator.ToCharArray();

        /// <summary>
        /// Gets or sets the character used to separate repeated fields.
        /// </summary>
        /// <remarks>The default character ~ is recommended.</remarks>
        public static string FieldRepeatSeparator { get; set; } = Consts.DefaultFieldRepeatSeparator;

        /// <summary>
        /// Gets or sets the character used to escape an encoding character.
        /// </summary>
        /// <remarks>The default character \ is recommended.</remarks>
        public static string EscapeCharacter { get; set; } = Consts.DefaultEscapeCharacter;

        private static string _subcomponentSeparator = Consts.DefaultSubcomponentSeparator;
        private static char[] _subcomponentSeparatorCharArray;

        /// <summary>
        /// Gets or sets the character used to separate subcomponents.
        /// </summary>
        /// <remarks>The default character &amp; is recommended.</remarks>
        public static string SubcomponentSeparator
        {
            get => _subcomponentSeparator;
            set
            {
                _subcomponentSeparator = value;
                _subcomponentSeparatorCharArray = null;
                Helpers.StringHelper.InvalidateFormatSequenceCache();
            }
        }

        /// <summary>
        /// Gets a cached char array of <see cref="SubcomponentSeparator"/>.
        /// </summary>
        public static char[] SubcomponentSeparatorCharArray =>
            _subcomponentSeparatorCharArray ??= _subcomponentSeparator.ToCharArray();

        /// <summary>
        /// Resets the separator configuration properties to their default, recommended values.
        /// </summary>
        /// <remarks>Resets ComponentSeparator, FieldRepeatSeparator, EscapeCharacter, and SubcomponentSeparator to their default, recommended values.</remarks>
        public static void ResetSeparators()
        {
            FieldSeparator = Consts.DefaultFieldSeparator;
            ComponentSeparator = Consts.DefaultComponentSeparator;
            FieldRepeatSeparator = Consts.DefaultFieldRepeatSeparator;
            EscapeCharacter = Consts.DefaultEscapeCharacter;
            SubcomponentSeparator = Consts.DefaultSubcomponentSeparator;
        }
    }
}
