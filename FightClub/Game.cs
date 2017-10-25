

namespace FightClub
{
    class Game
    {
        public FormFightClub formFight;

        public Game (FormFightClub form)
        {
            formFight = form;
        }

        public void AddEvent (Player player, Computer computer, Log log)
        {
            player.Block += log.BlockHandler;
            player.Wound += log.WoundHandler;
            player.Death += log.DeathHandler;

            computer.Block += log.BlockHandler;
            computer.Wound += log.WoundHandler;
            computer.Death += log.DeathHandler;
        }


        public void RemoveEvent (Player player, Computer computer, Log log)
        {
            player.Block -= log.BlockHandler;
            player.Wound -= log.WoundHandler;
            player.Death -= log.DeathHandler;

            computer.Block -= log.BlockHandler;
            computer.Wound -= log.WoundHandler;
            computer.Death -= log.DeathHandler;
        }
    }
}