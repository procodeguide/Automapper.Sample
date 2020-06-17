using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProCodeGuide.Samples.Automapper.Shared;

namespace ProCodeGuide.Samples.Automapper.DTO
{
    public class EmployeeDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public TelephoneNumberDTO Telephone { get; set; }
    }
}
