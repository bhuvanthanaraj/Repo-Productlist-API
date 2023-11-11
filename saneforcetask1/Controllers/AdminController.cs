using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using saneforcetask1.DataDbContext;
using saneforcetask1.Models;


namespace saneforcetask1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly ProductDbContext dbContext;

        public AdminController(ProductDbContext dbContext)
        {
            this.dbContext = dbContext;
        }



        [HttpGet]
        
        public async Task<IActionResult> GetProduct()
        {
            var product = await dbContext.Products.ToListAsync();
            return Ok(product);
        }




        //Add transaction
        //ADDTrans model just use for tem model just use post method

        [HttpPost]
        public async Task<IActionResult> AddTrans(AddTrans addTrans)
        {
            var trans = new Trans()
            {
                TransId = Guid.NewGuid(),
                ProductCode = addTrans.ProductCode,
                ProductName = addTrans.ProductName,
                Quality = addTrans.Quality,
                Rate = addTrans.Rate,
                TaxPercentage = addTrans.TaxPercentage,
                TaxAmount = addTrans.TaxAmount,
                GrossTotal = addTrans.GrossTotal,
            };

            await dbContext.Transs.AddAsync(trans);
            await dbContext.SaveChangesAsync();
            return Ok(trans);

        }



        //This is for get product by id
        //use for select product from dropdown list fatch other details code,rate 

        [HttpGet]
        [Route("{Id:int}")]

        public async Task<IActionResult> GetProductid(int Id)
        {
            var product = await dbContext.Products.FindAsync(Id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);

        }



        
        [HttpGet("trans")]
        public async Task<IActionResult> GetTrans()
        {
            var trans = await dbContext.Transs.ToListAsync();
            return Ok(trans);
        }








    }
}
