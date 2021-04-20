using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace fremvisning_codereview
{
    class CommandHandler 
    {
        public Location[] SelectLocations;
        public progressBar hackProgressBar;

        public CommandHandler(params Location[] locations)
        {
            SelectLocations = locations;
        }

        public string HandleCommand(string command)
        {
            if (command == "start")
            {
                return "H4CKbot.exe loaded. \nType: targets";
            }
            if (command == "targets")
            {
                return "\n" + SelectLocations[0].Name + "\n" + SelectLocations[1].Name + "\n" + SelectLocations[2].Name + "\nChoose your company:";
            }
            if (command.Contains("NASA"))
            {
                return Nasa(command);
            }
            if (command.Contains("GOOGLE"))
            {
                return Google(command);
            }
            if (command.Contains("TWITCH"))
            {
                return Twitch(command);
            }
            return null;
        }

        private string Nasa(string command)
        {
            if (command == "NASA")
            {
                return "Type in commands.NASA to see your options";
            }
            if (command == "commands.NASA")
            {
                return "Hack, Locate, Trace" + "\nType: Trace.NASA";
            }
            if (command == "Trace.NASA")
            {
                return SelectLocations[0].IpAdress + "\nType: Locate.NASA";
            }
            if (command == "Locate.NASA")
            {
                return SelectLocations[0].Adress + "\nType: Hack.NASA";
            }
            if (command == "Hack.NASA")
            {
                SelectLocations[0].Hack();
            }

            return "";
        }

        private string Google(string command)
        {
            if (command == "GOOGLE")
            {
                return "Type in commands.GOOGLE to see your options";
            }
            if (command == "commands.GOOGLE")
            {
                return "Hack, Locate, Trace" + "\nType: Trace.GOOGLE";
            }
            if (command == "Trace.GOOGLE")
            {
                return SelectLocations[1].IpAdress + "\nType: Locate.GOOGLE";
            }
            if (command == "Locate.GOOGLE")
            {
                return SelectLocations[1].Adress + "\nType: Hack.GOOGLE";
            }
            if (command == "Hack.GOOGLE")
            {
                SelectLocations[1].Hack();
            }

            return "";
        }

        private string Twitch(string command)
        {
            if (command == "TWITCH")
            {
                return "Type in commands.TWITCH to see your options";
            }
            if (command == "commands.TWITCH")
            {
                return "Hack, Locate, Trace" + "\nType: Trace.TWITCH";
            }
            if (command == "Trace.TWITCH")
            {
                return SelectLocations[2].IpAdress + "\nType: Locate.TWITCH";
            }
            if (command == "Locate.TWITCH")
            {
                return SelectLocations[2].Adress + "\nType: Hack.TWITCH";
            }
            if (command == "Hack.TWITCH")
            {
                SelectLocations[2].Hack();
            }

            return "";
        }
    }
}
