using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class District
    {
        public int Id { get; set; }
        public List<string> Name { get; set; } = new List<string>() { "Retkinia", "Łódź Kaliska", "Śródmieście", "Widzew", "Janów" };
        public int Distance { get; set; }

    }
}
