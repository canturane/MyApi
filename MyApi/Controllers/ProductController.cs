using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyApi.Service.Dtos;
using MyApi.Service.ProductService;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService)
        {
            _productService = productService;
           
        }

        [HttpGet]
        public async Task<IEnumerable<ProductResponseDto>> Get()
        {
            var products = await _productService.GetAllAsync();
            return products;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductResponseDto>> Get(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<ProductResponseDto>> Post([FromBody] ProductRequestDto productRequestDto)
        {
            if (productRequestDto == null)
            {
                return BadRequest("Product data is null.");
            }

            var createdProduct = await _productService.InsertAsync(productRequestDto);
            return CreatedAtAction(nameof(Get), new { id = createdProduct.Id }, createdProduct);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ProductResponseDto>> Put(int id, [FromBody] ProductRequestDto productRequestDto)
        {
            if (id != productRequestDto.BrandId)
            {
                return BadRequest("ID mismatch.");
            }

            var updatedProduct = await _productService.UpdateAsync(productRequestDto);
            if (updatedProduct == null)
            {
                return NotFound();
            }
            return Ok(updatedProduct);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deletedProduct = await _productService.DeleteAsync(id);
            if (deletedProduct == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
