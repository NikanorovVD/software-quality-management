namespace UKPO_8
{
    public class Voltage360V: MainsVoltage
    {
        protected string _type;
        protected decimal _resistanse;
        //protected int _amperage;

        public Voltage360V(uint fazeNumber, string type, decimal resistanse)
            : base(360, fazeNumber)
        {
            _type = type;
            _resistanse = resistanse;

        }

        public override decimal Amperage()
        {
            return _voltage / _resistanse;
        }

        public override decimal Power()
        {
            return Amperage() * _voltage;
        }

        public override decimal Resistance()
        {
            return _resistanse;
        }

        public override string Type()
        {
            return _type;
        }
    }
}
