﻿using LW.ApiDotNet6.Domain.Entities;
using LW.ApiDotNet6.Domain.Repositories;
using LW.ApiDotNet6.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace LW.ApiDotNet6.Infra.Data.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _db;

    public ProductRepository(ApplicationDbContext db)
    {
        _db = db;
    }
    public async Task<Product> CreateAsync(Product product)
    {
        await _db.AddAsync(product);
        await _db.SaveChangesAsync();
        return product;
    }

    public async Task DeleteAsync(Product product)
    {
        _db.Remove(product);
        await _db.SaveChangesAsync();
    }

    public async Task EditAsync(Product product)
    {
        _db.Update(product);
        await _db.SaveChangesAsync();
    }

    public async Task<Product> GetByIdAsync(int id)
    {
        return await _db.Products.FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<ICollection<Product>> GetroductsAsync()
    {
        return await _db.Products.ToListAsync();
    }
}
