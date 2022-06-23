using System.Net;
using System.Threading;
using System.Threading.Tasks;

static class AlQuranDownlaod
{
    private static string _File = Directory.GetCurrentDirectory();

    private static void Run(int num)
    {
        using (var client = new WebClient())
        {
            client.DownloadFile($"https://ia803406.us.archive.org/27/items/AlQuranWithEnglishSaheehIntlTranslation--RecitationByMishariIbnRashidAl-AfasyWithIbrahimWalk/{num:D3}.mp3",$"{_File}/{num:D3}.mp3");

        }
    }
    public static async void Download(int num)
    {
        Console.WriteLine($"{num} Sura Yuklanmoqda...");
        await Task.Run(() => Run(num));
        Console.WriteLine($"{num} Sura Yuklandi");
    }
}