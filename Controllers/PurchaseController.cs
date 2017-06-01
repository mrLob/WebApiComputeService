using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspCoreEperiment.Controllers
{
    [Route("api/[controller]")]
    public class PurchaseController : Controller
    {
        ApplicationContext dbContext = new ApplicationContext() ;          
        // GET api/values
        [HttpGet]
        public IEnumerable<PurchaseItem> Get()
        {   
            return dbContext.PurchaseItems;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public PurchaseItem Get(int id)
        {             
            return dbContext.PurchaseItems.Find(id);
        }
        
        // POST api/purchase
        [HttpPost]
        public void Post([FromBody] PurchaseItem value)
        {
            if(value != null){
                PurchaseItem newItem = new PurchaseItem();
                newItem.Name = value.Name;
                newItem.Count = value.Count;
                newItem.Price = value.Price;
                dbContext.PurchaseItems.Add(newItem);
                dbContext.SaveChanges();
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
