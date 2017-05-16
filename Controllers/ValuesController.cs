using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspCoreEperiment.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
         ApplicationContext dbContext = new ApplicationContext() ;          
        // GET api/values
        [HttpGet]
        public IEnumerable<HardwareItemsModel> Get()
        {   
            return dbContext.HardwareItem;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            string[] strAr = new string[] {"kek", "lel", "gogogog","<b>ty p</b>"} ; 
            return strAr[id];
        }
        
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            using(ApplicationContext context = new ApplicationContext()){
                HardwareItemsModel HWIModel = new HardwareItemsModel();
                HWIModel.Name = "Orange Pi Lite";
                HWIModel.Count = 2;
                HWIModel.Type = 1;
                context.HardwareItem.Add(HWIModel);
                context.SaveChanges();                
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
