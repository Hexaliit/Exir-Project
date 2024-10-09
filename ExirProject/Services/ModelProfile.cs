using AutoMapper;
using ExirProject.Models;

namespace ExirProject.Services
{
    public class ModelProfile : AutoMapper.Profile
    {
        public ModelProfile() 
        {
            CreateMap<Person, PersonDetail>();
            CreateMap<PersonDetail, Person>();
        }
    }
}
