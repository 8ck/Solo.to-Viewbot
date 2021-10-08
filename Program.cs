using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace soloviewbot
{
    class Program
    {
        public static int Views = 0;
        public static int RatelimitCount = 0;
        public static int RateLimit = 429;
        public static string UA = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:93.0) Gecko/20100101 Firefox/93.0";
        public static async Task SendRequest1(string username)
        {
            string url = "https://solo.to/" + username;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", UA);
                await Task.Run(async () =>
                {
                    while (1 < 2)
                    {
                        var response = await client.GetAsync(url);
                        if (((int)response.StatusCode) == 429)
                        {
                            RatelimitCount++;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("[WAITING 1 Minute] Ratelimit Count: {0} | STATUS CODE: {1}", RatelimitCount, ((int)response.StatusCode));
                            await Task.Delay(60000);
                        }
                        else
                        {
                            Views++;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Sent view: {0} | STATUS CODE: {1}", Views, ((int)response.StatusCode));
                        }
                    }
                });
            }
        }
        public static async Task SendRequest2(string username)
        {
            string url = "https://solo.to/" + username;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", UA);
                await Task.Run(async () =>
                {
                    while (1 < 2)
                    {
                        var response = await client.GetAsync(url);
                        if (((int)response.StatusCode) == 429)
                        {
                            RatelimitCount++;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("[WAITING 1 Minute] Ratelimit Count: {0} | STATUS CODE: {1}", RatelimitCount, ((int)response.StatusCode));
                            await Task.Delay(60000);
                        }
                        else
                        {
                            Views++;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Sent view: {0} | STATUS CODE: {1}", Views, ((int)response.StatusCode));
                        }
                    }
                });
            }
        }
        public static async Task SendRequest3(string username)
        {
            string url = "https://solo.to/" + username;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", UA);
                await Task.Run(async () =>
                {
                    while (1 < 2)
                    {
                        var response = await client.GetAsync(url);
                        if (((int)response.StatusCode) == 429)
                        {
                            RatelimitCount++;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("[WAITING 1 Minute] Ratelimit Count: {0} | STATUS CODE: {1}", RatelimitCount, ((int)response.StatusCode));
                            await Task.Delay(60000);
                        }
                        else
                        {
                            Views++;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Sent view: {0} | STATUS CODE: {1}", Views, ((int)response.StatusCode));
                        }
                    }
                });
            }
        }
        public static async Task SendRequest4(string username)
        {
            string url = "https://solo.to/" + username;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", UA);
                await Task.Run(async () =>
                {
                    while (1 < 2)
                    {
                        var response = await client.GetAsync(url);
                        if (((int)response.StatusCode) == 429)
                        {
                            RatelimitCount++;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("[WAITING 1 Minute] Ratelimit Count: {0} | STATUS CODE: {1}", RatelimitCount, ((int)response.StatusCode));
                            await Task.Delay(60000);
                        }
                        else
                        {
                            Views++;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Sent view: {0} | STATUS CODE: {1}", Views, ((int)response.StatusCode));
                        }
                    }
                });
            }
        }
        public static async Task SendRequest5(string username)
        {
            string url = "https://solo.to/" + username;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", UA);
                await Task.Run(async () =>
                {
                    while (1 < 2)
                    {
                        var response = await client.GetAsync(url);
                        if (((int)response.StatusCode) == 429)
                        {
                            RatelimitCount++;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("[WAITING 1 Minute] Ratelimit Count: {0} | STATUS CODE: {1}", RatelimitCount, ((int)response.StatusCode));
                            await Task.Delay(60000);
                        }
                        else
                        {
                            Views++;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Sent view: {0} | STATUS CODE: {1}", Views, ((int)response.StatusCode));
                        }
                    }
                });
            }
        }
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Enter your solo.to username.");
            string username = Console.ReadLine();
            var tasks = new Task[] {
                SendRequest1(username),
                SendRequest2(username),
                SendRequest3(username),
                SendRequest4(username),
                SendRequest5(username),
                SendRequest1(username),
                SendRequest2(username),
                SendRequest3(username),
                SendRequest4(username),
                SendRequest5(username),
                SendRequest1(username),
                SendRequest2(username),
                SendRequest3(username),
                SendRequest4(username),
                SendRequest5(username),
                SendRequest1(username),
                SendRequest2(username),
                SendRequest3(username),
                SendRequest4(username),
                SendRequest5(username),
                SendRequest1(username),
                SendRequest2(username),
                SendRequest3(username),
                SendRequest4(username),
                SendRequest5(username),
                SendRequest1(username),
                SendRequest2(username),
                SendRequest3(username),
                SendRequest4(username),
                SendRequest5(username),
                SendRequest1(username),
                SendRequest2(username),
                SendRequest3(username),
                SendRequest4(username),
                SendRequest5(username),
            };
            while (1 < 2)
            {
                await Task.WhenAll(tasks);
            }
        }
    }
}
