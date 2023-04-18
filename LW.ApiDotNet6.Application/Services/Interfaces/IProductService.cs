

using LW.ApiDotNet6.Application.DTOs;

namespace LW.ApiDotNet6.Application.Services.Interfaces;

public interface IProductService
{
    Task<ResultService<ProductDTO>> CreateAsync(ProductDTO productDTO);
}
