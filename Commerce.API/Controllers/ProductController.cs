using Commerce.Application.Interface;
using Commerce.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Commerce.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductRepo _productRepo;

    public ProductController(IProductRepo productRepo)
    {
        _productRepo = productRepo;
    }

    [HttpGet]
    public IEnumerable<Product> GetAll()
    {
        return _productRepo.GetAllAsync();
    }

}




