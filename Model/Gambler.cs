namespace Model
{
    public abstract class Gambler
    {
        public readonly string Name;

        protected Gambler(string name)
        {
            Name = name;
        }

        public int Score { get; protected set; }

        public abstract void FetchNewNumber(object sender, NumbertronEventArgs args);
    }
}
