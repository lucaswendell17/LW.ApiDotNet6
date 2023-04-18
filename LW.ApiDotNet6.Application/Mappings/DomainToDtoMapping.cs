

using AutoMapper;
using LW.ApiDotNet6.Application.DTOs;
using LW.ApiDotNet6.Domain.Entities;

namespace LW.ApiDotNet6.Application.Mappings;

public class DomainToDtoMapping : Profile
{
	public DomainToDtoMapping()
	{
		CreateMap<Person, PersonDTO>();
		CreateMap<Product, ProductDTO>();
	}
}
