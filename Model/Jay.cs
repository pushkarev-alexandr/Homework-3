namespace Model
{
    public class Jay : Gambler
    {
        public Jay()
            : base("Jay")
        {
        }

        public override void FetchNewNumber(object sender, NumbertronEventArgs args)
        {
            if (args.GeneratedNumber.IsEven())
                Score++;
        }
    }
}
