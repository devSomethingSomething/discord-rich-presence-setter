using DiscordRPC;
using System;

namespace DiscordRichPresenceSetter
{
    public class Program
    {
        private static DiscordRpcClient discordRpcClient;

        private static void Main()
        {
            Initialize("applicationID");

            Console.WriteLine("Press any key to close the program");

            Console.ReadKey(true);

            Dispose();

            Console.ReadKey(true);
        }

        private static void Initialize(string applicationID)
        {
            discordRpcClient = new DiscordRpcClient(applicationID);

            discordRpcClient.Initialize();

            SetPresence();
        }

        private static void SetPresence()
        {
            discordRpcClient.SetPresence(new RichPresence()
            {
                Details = "Hello World, Discord Edition"
            });
        }

        private static void Dispose()
        {
            discordRpcClient.Dispose();
        }
    }
}
