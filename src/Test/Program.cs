using System.Diagnostics;

namespace Test;

internal class Program
{
    static async Task<bool> SetRandom()
    {
        try
        {
            var client = AnonymousHttpClientFactory.Instance.Create("http://localhost:54473/Random/Index");
            client.DefaultRequestHeaders.TransferEncodingChunked = false;

            var response = await client.PostAsync(string.Empty, null);

            if (response.IsSuccessStatusCode)
            {
                return bool.Parse(await response.Content.ReadAsStringAsync());
            }

            return false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }
    }

    static async Task Main(string[] args)
    {
        Stopwatch sw = new();
        sw.Start();
        for (int i = 0; i < 100; i++) await SetRandom();
        sw.Stop();
        Console.WriteLine($"Elapsed={sw.Elapsed}");
    }
}