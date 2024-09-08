using MyApi.Service.Dtos;

namespace MyApi.Service.ProductService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductResponseDto>> GetAllAsync();
        Task<ProductResponseDto> GetByIdAsync(int id);
        Task<ProductResponseDto> InsertAsync(ProductRequestDto productRequestDto);
        Task<ProductResponseDto> UpdateAsync(ProductRequestDto productRequestDto);
        Task<ProductResponseDto> DeleteAsync(int id);
    }
}
