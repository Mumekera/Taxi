using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Car
    {

        public int Id { get; set; }
        public List<string> Name { get; set; } = new List<string>() { "Ford mondeo", "Dacia Logan", "Toyota Avensis", "Mercedes E220", "Hyundai Lantra" };
        public bool Status { get; set; }
        public List<District> DistrictName { get; set; } = new List<District>();

    }
}