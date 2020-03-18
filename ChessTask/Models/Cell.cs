
namespace ChessTask.Models
{
    abstract class Cell
    {
        public char Value { get; private set; }

        public Cell(char value)
        {
            Value = value;
        }
    }
}
