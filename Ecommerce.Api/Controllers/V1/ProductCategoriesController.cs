using Ecommerce.DataAccess.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoriesController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly ILogger<ProductCategoriesController> _logger;

        public ProductCategoriesController(IUnitOfWork uow, ILogger<ProductCategoriesController> logger)
        {
            _uow = uow;
            _logger = logger;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var productCategories = await _uow.ProductCategories.GetAllAsync(null,null);

                return Ok(productCategories);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500);
            }
        }
    }
}
