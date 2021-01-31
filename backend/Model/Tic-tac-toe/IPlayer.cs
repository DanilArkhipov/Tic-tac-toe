using backend.Model.Enums;

namespace backend.Model
{
    public interface IPlayer
    {
        public Marks Mark { get; set; }
        public void Move(IFieldPart fieldPart);
    }
}