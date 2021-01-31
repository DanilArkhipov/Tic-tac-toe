using backend.Model.Enums;

namespace backend.Model
{
    public interface IGameState
    {
        public GameStatus GameStatus { get; set; }
        public Marks MoveTurn { get; set; }
        public IPlayer Winner { get; set; }
    }
}