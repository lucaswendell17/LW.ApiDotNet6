using AutoMapper;
using LW.ApiDotNet6.Application.DTOs;
using LW.ApiDotNet6.Domain.Entities;

namespace LW.ApiDotNet6.Application.Mappings;

public class DtoToDomainMapping : Profile
{
	public DtoToDomainMapping()
	{
		CreateMap<PersonDTO, Person>();
	}
}
