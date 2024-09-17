using System.Collections.Generic;
using System.Linq;


namespace UKPO_7
{
    public static class ResidentQuery
    {
        public static int DaysStayOfPersonInHotel(this IEnumerable<Resident> residents, string person_last_name, string hotel_name)
        {
            return (int)residents
                .Where(p => p.LastName == person_last_name)
                .Where(p => p.Hotel == hotel_name)
                .Sum(p => p.DaysStay);
        }
    }
}
