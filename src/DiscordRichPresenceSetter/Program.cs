using DiscordRPC;
using DiscordRPC.Logging;
using System;

namespace DiscordRichPresenceSetter
{
    public class Program
    {
        private static DiscordRpcClient discordRpcClient;

        private static void Main()
        {
            Initialize("applicationID");

            Console.ReadKey(true);

            Dispose();
        }

        private static void Initialize(string applicationID)
        {
            discordRpcClient = new DiscordRpcClient(applicationID);

            discordRpcClient.Initialize();

            SetPresence();
        }

        private static void SetPresence()
        {
            discordRpcClient.SetPresence(new RichPresence());
        }

        private static void Dispose()
        {
            discordRpcClient.Dispose();
        }
    }
}
