using AutoMapper;
using Common.DTO;
using IBEXDATA.Models;

namespace Application
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            // Mapping from ProjectCreateDTO to Project
            CreateMap<ProjectCreateDTO, Project>();

            // Mapping from Project to ProjectDTO
            CreateMap<Project, ProjectDTO>();

            // Mapping from Bank to BankDTO
            CreateMap<Bank, BankDTO>();

            CreateMap<Bank, BankNamesDTO>();
        }
    }
}
