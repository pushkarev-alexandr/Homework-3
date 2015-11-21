namespace Model
{
    public class SilentBob : Gambler
    {
        public SilentBob()
            : base("SilentBob")
        {
        }

        public override void FetchNewNumber(object sender, NumbertronEventArgs args)
        {
            if (!args.GeneratedNumber.IsEven())
                Score++;
        }
    }
}
