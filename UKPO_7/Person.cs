namespace UKPO_7
{
    public class Person
    {
        private ulong PassportNumber { get; set; }
        public string LastName { get; private set; }

        public Person(ulong passportNumber, string lastName)
        {
            PassportNumber = passportNumber;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{PassportNumber} {LastName}";
        }
    }
}
