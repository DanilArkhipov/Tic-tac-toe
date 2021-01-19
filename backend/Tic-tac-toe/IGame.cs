namespace Tic_tac_toe
{
    public class IGame
    {
        public IPlayer FirstPlayer { get; set; }
        public IPlayer SecondPlayer { get; set; }
        public Marks MoveTurn { get; set; }
        public IField Field { get; set; }
    }
}