using System.Collections.Generic;

namespace FightClub
{
    class Log
    {
        private List<PlayerEventArgs> batcatalog = new List<PlayerEventArgs>();

        public void BlockHandler(object source, PlayerEventArgs args)
        {
            batcatalog.Add(new PlayerEventArgs(args.Name, args.Hp, args.Change));
        }

        public void WoundHandler(object source, PlayerEventArgs args)
        {
            batcatalog.Add(new PlayerEventArgs(args.Name, args.Hp, args.Change));
        }

        public void DeathHandler(object source, PlayerEventArgs args)
        {
            batcatalog.Add(new PlayerEventArgs(args.Name, args.Hp, args.Change));
        }
        
        public override string ToString()
        {
            string s = "";

            for (int k = 0; k < batcatalog.Count; k++)
            {
                s += batcatalog[k];
            }
            return s;
        }
    }
}
