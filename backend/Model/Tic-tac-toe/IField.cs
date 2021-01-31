namespace backend.Model
{
    public interface IField
    {
        public IFieldPart this [int i,int j] { get; set; }
    }
}