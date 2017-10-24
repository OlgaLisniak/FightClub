using System;

namespace FightClub
{
    class PlayerEventArgs:EventArgs
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public string Change { get; set; }

        public PlayerEventArgs(string name, int hp, string change)
        {
            Name = name;
            Hp = hp;
            Change = change;
        }

        public override string ToString()
        {
            return "Player " + Name + "   HP: " + Hp + "   Action: " + Change + "\n";
        }
    }
}
