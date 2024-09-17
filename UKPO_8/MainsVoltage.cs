namespace UKPO_8
{
    public abstract class MainsVoltage
    {
        protected decimal _voltage;
        protected uint _fazeNumber;

        protected MainsVoltage(decimal voltage, uint fazeNumber)
        {
            _voltage = voltage;
            _fazeNumber = fazeNumber;
        }

        public abstract string Type();
        public abstract decimal Resistance();
        public abstract decimal Amperage();
        public abstract decimal Power();

        public override string ToString()
        {
            return $"Тип: {Type()};\tR = {Resistance()};\tI = {Amperage()};\tW = {Power()}\t";
        }
    }
}
