using System;

namespace Model
{
    public class NumbertronEventArgs : EventArgs
    {
        public readonly int GeneratedNumber;

        public NumbertronEventArgs(int generatedNumber)
        {
            GeneratedNumber = generatedNumber;
        }
    }

    public delegate void GenerateNumberHandler(object sender, NumbertronEventArgs e);

    public class Numbertron
    {
        private Random _random;

        public Numbertron()
        {
            _random = new Random();
        }

        public event GenerateNumberHandler NewNumber;

        public void Generate()
        {
            var handler = NewNumber;
            if (handler != null)
                handler(this, new NumbertronEventArgs(_random.Next()));
        }
    }
}