﻿using AutoMapper;
using OnlineShop.Bll.Interfaces;
using OnlineShop.Common;
using OnlineShop.Common.Dtos.Products;
using OnlineShop.Dal.Interfaces;
using OnlineShop.Domain;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Bll.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IRepository<Product> productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProductDto>> GetProductsAsync()
        {
            var records = await _productRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(records);
        }

        public async Task<ProductDto> GetProductByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            var result = _mapper.Map<ProductDto>(product);
            return result;
        }

        public async Task CreateProductAsync(CreateProductDto dto)
        {
            var products = await _productRepository.GetWhereAsync(p => p.ProductSKU == dto.ProductSKU);
            var productWithSameSku = products.FirstOrDefault();
            if (productWithSameSku != null)
            {
                throw new ValidationException(ErrorMessages.ProductAlreadyExists);
            }
            var product = _mapper.Map<Product>(dto);
            await _productRepository.AddAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
            {
                throw new ValidationException(ErrorMessages.NoProductForDelete);
            }
            await _productRepository.DeleteAsync(product);
        }
    }
}

