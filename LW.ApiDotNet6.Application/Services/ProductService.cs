
using AutoMapper;
using LW.ApiDotNet6.Application.DTOs;
using LW.ApiDotNet6.Application.DTOs.Validations;
using LW.ApiDotNet6.Application.Services.Interfaces;
using LW.ApiDotNet6.Domain.Entities;
using LW.ApiDotNet6.Domain.Repositories;

namespace LW.ApiDotNet6.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<ResultService<ProductDTO>> CreateAsync(ProductDTO productDTO)
    {
        if (productDTO == null)
            return ResultService.Fail<ProductDTO>("Objeto deve ser informado");

        var result = new ProductDTOValidator().Validate(productDTO);
        if (!result.IsValid)
            return ResultService.RequestError<ProductDTO>("Problemas de validade!", result);

        var product = _mapper.Map<Product>(productDTO);
        var data = await _productRepository.CreateAsync(product);
        return ResultService.Ok<ProductDTO>(_mapper.Map<ProductDTO>(data)); 
    }
}
