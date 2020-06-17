using AutoMapper;
using ProCodeGuide.Samples.Automapper.DTO;
using ProCodeGuide.Samples.Automapper.Model;
using ProCodeGuide.Samples.Automapper.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProCodeGuide.Samples.Automapper.AutomapperProfiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeDTO, EmployeeModel>()
                .ForMember(empmodel => empmodel.FullName, empdto => empdto.MapFrom(empdto => empdto.Name))
                .ForMember(empmodel => empmodel.Salary, empdto => empdto.MapFrom(empdto => empdto.Age > 55 ? empdto.Salary * 10 : empdto.Salary))
                .ReverseMap();
            CreateMap<TelephoneNumberDTO, TelephoneNumberModel>()
                .ReverseMap();

            CreateMap<EmployeeDTO, EmployeeModel>()
                .ForMember(empmodel => empmodel.Telephone, empdto => empdto.NullSubstitute("Not Available"));
        }
    }
}
