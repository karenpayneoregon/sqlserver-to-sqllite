using Microsoft.Extensions.Configuration;

namespace ApplicationForm.Classes;
internal class Utilities
{
    /// <summary>
    /// Read sections from appsettings.json
    /// </summary>
    private static IConfigurationRoot ConfigurationRoot() =>
        new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false)
            .AddEnvironmentVariables()
            .Build();

    /// <summary>
    /// Location of the database folder for SqlLite databases
    /// </summary>
    /// <returns></returns>
    public static string DatabaseFolder() =>
        ConfigurationRoot().GetSection("ApplicationSettings")["DatabaseFolder"]!;
}
