namespace UKPO_7
{
    public class Resident : Person
    {
        public string Hotel {  get; private set; }
        public uint DaysStay {  get; private set; }

        public Resident(ulong passportNumber, string lastName, string hotel, uint daysStay)
            : base(passportNumber, lastName)
        {
            Hotel = hotel;
            DaysStay = daysStay;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Hotel} {DaysStay}";
        }
    }
}
