using System;

namespace FightClub
{
    class Player
    {
        public string name;
        public BodyPart blocked;
        public int hp;

        public delegate void PlayerHandler(object source, PlayerEventArgs args);

        public event PlayerHandler Block;
        public event PlayerHandler Wound;
        public event PlayerHandler Death;


        public Player(string name, int hp)
        {
            Name = name;
            Hp = hp;
        }
        public Player()
        {
            Name = "Player";
            Hp = 100;
            Blocked = BodyPart.Head;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        internal BodyPart Blocked
        {
            get
            {
                return blocked;
            }

            set
            {
                blocked = value;
            }
        }

        public int Hp
        {
            get
            {
                return hp;
            }

            set
            {
                if (value >= 0)
                {
                    hp = value;

                }
            }
        }

        public void GetHit(BodyPart attackedPart, int damage = 20)
        {
            if (attackedPart != Blocked)
            {
                if (damage < Hp)
                {
                    Hp -= damage;

                    Wound?.Invoke(this, new PlayerEventArgs(Name, Hp, "Received 20 damage"));
                }
                else
                {
                    Hp = 0;
                    Death?.Invoke(this, new PlayerEventArgs(Name, Hp, "Died"));
                }
            }
            else
            {
                Block?.Invoke(this, new PlayerEventArgs(Name, Hp, String.Format("Hit to {0} was blocked", attackedPart)));
            }
        }

        public void SetBlock(BodyPart part)
        {
            Blocked = part;
        }
    }
}
