namespace fremvisning_codereview
{
    public class Location
    {
        public string Name;
        public string Adress;
        public string IpAdress;
        public progressBar HackProgress = new progressBar();

        public Location(string name, string adress, string ipAdress)
        {
            Name = name;
            Adress = adress;
            IpAdress = ipAdress;
        }

        public void Hack()
        {
            HackProgress.ProgressBar();
        }
    }
}