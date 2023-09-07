namespace AsyncandAwait
{
    class Program
    {
        static async Task Main()
        {
            string result = await FetchDataFromAPI();
            Console.WriteLine(result);

            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();

        }

        static async Task<string> FetchDataFromAPI()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("https://api.coingecko.com/api/v3/simple/price?ids=bitcoin,litecoin,ethereum,ripple,cardano&vs_currencies=zar");
                return result;
            }
        }
    }

}