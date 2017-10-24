using System;

namespace FightClub
{
    class Computer: Player
    {
        public void BlockPart()
        {
            BodyPart blockPart = BodyPart.Legs;

            Random rng = new Random();

            switch(rng.Next(0, 3))
            {
                case 0:
                    blockPart = BodyPart.Body;
                    break;
                case 1:
                    blockPart = BodyPart.Head;
                    break;
                case 2:
                    blockPart = BodyPart.Legs;
                    break;
            }

            SetBlock(blockPart);
        }

        public Computer(string name, int hp) : base(name, hp) { }

        public BodyPart AtackPlayer()
        {
            BodyPart attackPart = BodyPart.Body;

            Random rng = new Random();

            switch (rng.Next(0, 3))
            {
                case 0:
                    attackPart = BodyPart.Head;
                    break;
                case 1:
                    attackPart = BodyPart.Legs;
                    break;
                case 2:
                    attackPart = BodyPart.Body;
                    break;
            }

            return attackPart;
        }
    }
}