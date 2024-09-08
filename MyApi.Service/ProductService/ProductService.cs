using AutoMapper;
using MyApi.Data.Entities;
using MyApi.Data.Repositories.Productrepos;
using MyApi.Service.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyApi.Service.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductResponseDto>> GetAllAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductResponseDto>>(products);
        }

        public async Task<ProductResponseDto> GetByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            return _mapper.Map<ProductResponseDto>(product);
        }

        public async Task<ProductResponseDto> InsertAsync(ProductRequestDto productRequestDto)
        {
            var product = _mapper.Map<Product>(productRequestDto);
            var createdProduct = await _productRepository.InsertAsync(product);
            return _mapper.Map<ProductResponseDto>(createdProduct);
        }

        public async Task<ProductResponseDto> UpdateAsync(ProductRequestDto productRequestDto)
        {
            var product = _mapper.Map<Product>(productRequestDto);
            var updatedProduct = await _productRepository.UpdateAsync(product);
            return _mapper.Map<ProductResponseDto>(updatedProduct);
        }

        public async Task<ProductResponseDto> DeleteAsync(int id)
        {
            var deletedProduct = await _productRepository.DeleteAsync(id);
            return _mapper.Map<ProductResponseDto>(deletedProduct);
        }
    }
}
