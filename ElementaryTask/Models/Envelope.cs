
namespace EnvelopeTask.Models
{
    class Envelope 
    {
        public double Side1 { get; private set; }
        public double Side2 { get; private set; }

        public Envelope(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }
    }
}
