﻿using LW.ApiDotNet6.Application.DTOs;
using LW.ApiDotNet6.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LW.ApiDotNet6.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpPost]
    public async Task<ActionResult> PostAsync([FromBody] ProductDTO productDTO)
    {
        var result = await _productService.CreateAsync(productDTO);
        if (result.IsSuccess)
            return Ok(result);

        return BadRequest(result);
    }
}
