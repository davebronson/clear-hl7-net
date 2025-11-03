using Xunit;

namespace ClearHl7.Tests.ConfigurationTests
{
    /// <summary>
    /// Defines a test collection to ensure tests that modify the shared static Hl7DateTimeFormatConfig
    /// run serially rather than in parallel, preventing race conditions.
    /// Using DisableParallelization = true allows other tests to continue running in parallel
    /// while only this collection runs sequentially.
    /// </summary>
    [CollectionDefinition("Hl7DateTimeFormatConfig", DisableParallelization = true)]
    public class Hl7DateTimeFormatConfigCollection
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}
