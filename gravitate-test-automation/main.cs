/*
 * NOTES
 * 
 * Some GVT pages have very long load times. 
 * Elements show as available and incorrect options are clicked.
 * ImplicitWait does not work in these cases because it sees elements with the same name and continues.
 * Sleep resolves this issue because it gives the page time to order the elements correctly after filtering.
 * On occasion they will refresh their data and it can take minutes and will cause tests to fail.
 * This can be confirmed by performing the tests locally and watching the run
 * 
 * After completing certain actions, pop up windows may display to confirm success or failure.
 * The pop up windows will cause an “Element Is Not Clickable at Point” error
 * Sleep statements are added to the end of the closePopUp functions that cause pop ups to allow them to disapear after they have been closed.
 * 
 * GVT logic caches your filters and searches. 
 * Take this into consideration when building test cases.
 * 
 * Tests are executed in headless mode when ran from ADO. When running locally minimum window size needs to be set to 1708, 1326
 * 
 * Reference for chromeDriver switches: https://peter.sh/experiments/chromium-command-line-switches/
 * 
*/

namespace gravitate_test_automation;

public static class main
{
    public static string? Username;
    public static string? Password;
    public static string? Url;

    public static void import()
    {
        var configuration = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build();

        Username = configuration.GetValue<string>("username");
        Password = configuration.GetValue<string>("password");
        Url = configuration.GetValue<string>("url");
    }
}
