using ProCodeGuide.Samples.Automapper.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProCodeGuide.Samples.Automapper.Model
{
    public class EmployeeModel
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public TelephoneNumberModel Telephone { get; set; }
    }
}
