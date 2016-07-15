using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bus_table_management
{
    class Program
    {
        static void Main(string[] args)
        {
         //   DateTime depTime1 = DateTime.Parse("07:00 AM");
            bus Company1 = new bus()
            {
                number = "A1",
                name = "Airavatha",
                toPlace = "Chennai",
                depTime = DateTime.Parse("07:00 AM"),
                travelTime = TimeSpan.Parse("05:30")
            };
        //    DateTime depTime2 = DateTime.Parse("06:00 AM");
            bus Company2 = new bus()
            {
                number = "B2",
                name = "Ram Travels",
                toPlace = "Chennai",
                depTime = DateTime.Parse("06:00 AM"),
                travelTime = TimeSpan.Parse("05:00")
            };

            List<bus> comp1List = new List<bus>();
            comp1List.Add(Company1);
            comp1List.Add(Company2);

            // Sorting based on depTime (Depature time)
            var OrderedList = comp1List.OrderBy(p => p.depTime);

            // Optimizing for shortest time of travel
            var shortTimeList = comp1List.OrderBy(p => p.travelTime);

            Console.WriteLine("Option\tPlace\tCompany Name\tTravel Time\tDepature Time\tBus Number\n");
            for (int i = 0; i < comp1List.Count; i++)
            {
                Console.WriteLine((i + 1) + "\t" + comp1List[i].toPlace + "\t" + comp1List[i].name + "\t" +
                                    comp1List[i].travelTime + "\t" + comp1List[i].depTime.ToShortTimeString()
                                    + "\t\t" + comp1List[i].number);
            }
            Console.ReadLine();
        }
    }
    class bus
    {
        public string number { get; set; }
        public string name { get; set; }
        public string toPlace { get; set; }
        public DateTime depTime { get; set; }
        public TimeSpan travelTime { get; set; }
    }
}
