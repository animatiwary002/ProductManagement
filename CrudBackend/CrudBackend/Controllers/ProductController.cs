using CrudBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductDataDbContext _productDataDbContext;
        public ProductController(ProductDataDbContext productDataDbContext)
        {
            _productDataDbContext = productDataDbContext;
        }
        [HttpGet]
        [Route("GetProducts")]
        public async Task<IEnumerable<ProductData>> GetProducts()
        {
            return await _productDataDbContext.Products.ToListAsync();
        }
        [HttpPost]
        [Route("AddProduct")]
        public async Task<ProductData> AddProduct(ProductData objProduct)
        {
            _productDataDbContext.Products.Add(objProduct);
            await _productDataDbContext.SaveChangesAsync();
            return objProduct;
        }
        [HttpPatch]
        [Route("UpdateProduct/{id}")]
        public async Task<ProductData> UpdateProduct(ProductData objProduct)
        {
            _productDataDbContext.Entry(objProduct).State = EntityState.Modified;
            await _productDataDbContext.SaveChangesAsync();
            return objProduct;
        }
        [HttpDelete]
        [Route("DeleteProduct/{id}")]
        public bool DeleteProduct(int id)
        {
            bool a = false;
            var product = _productDataDbContext.Products.Find(id);
            if (product != null)
            {
                a = true;
                _productDataDbContext.Entry(product).State = EntityState.Deleted;
                _productDataDbContext.SaveChanges();
            }
            else
            {
                a = false;
            }
            return a;
        }

        }
    }
