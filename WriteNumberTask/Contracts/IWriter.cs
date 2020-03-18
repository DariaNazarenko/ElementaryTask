using WriteNumberTask.Models;

namespace WriteNumberTask.Contracts
{
    interface IWriter
    {
        string Write(Numeric number);
    }
}
