namespace IMDbApiLib;

public class Test
{
    public async Task TestAsync()
    {
        var apiLib = new ApiLib("your_api_key_here");
        await apiLib.TitleAsync("tt1234567", Models.Language.EN, "FullActor");
    }
}