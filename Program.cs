using System;

namespace fremvisning_codereview
{
    class Program
    {
        static void Main(string[] args)
        {
            var hack = new progressBar();
            var location1 = new Location("NASA", "NASA Headquarters\r\n300 E. Street SW, Suite 5R30\r\nWashington, DC 20546", "NASA: IPv4 Default Gateway    192.168.1.1");
            var location2 = new Location("GOOGLE", "Mountain View, California, United States, 1600 Amphitheatre Parkway Mountain View, CA 94043", "192.168.0.1");
            var location3 = new Location("TWITCH", "350 Bush St FL 2,, San Francisco, United States, CA, 94104 - 2879", "192.168.0.1");
            var ch = new CommandHandler(location1, location2, location3);
            while (true)
            {
                var myCommand = Console.ReadLine();
                var text = ch.HandleCommand(myCommand);
                Console.WriteLine(text);
                
            }
        }
    }
}
