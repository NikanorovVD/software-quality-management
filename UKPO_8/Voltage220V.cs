namespace UKPO_8
{
    public class Voltage220V: MainsVoltage
    {
        protected string _type;
        protected decimal _power;

        public Voltage220V(uint fazeNumber, string type, decimal power)
            : base(220, fazeNumber)
        {
            _type = type;
            _power = power;
        }

        public override decimal Amperage()
        {
            return _power / _voltage;
        }

        public override decimal Power()
        {
            return _power;
        }

        public override decimal Resistance()
        {
            return _voltage / Amperage();
        }

        public override string Type()
        {
            return _type;
        }
    }
}
