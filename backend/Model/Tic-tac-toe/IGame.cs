namespace backend.Model
{
    public interface IGame
    {
        public IField Field { get; set; }
        public IGameState GameState { get; set; }
        public IPlayer FirstPlayer { get; set; }
        public IPlayer SecondPlayer { get; set; }
        public bool CheckWin();
    }
}