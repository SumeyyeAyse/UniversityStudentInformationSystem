using API.Models.Context;
using API.Models.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorAddressController : Controller
    {
        private readonly AppDbContext db;
        public InstructorAddressController(AppDbContext context)
        {
            db = context;
        }
        /// <summary>
        /// InstructorAddresses Listesini getiren metottur
        /// </summary>
        /// <returns></returns>
        [HttpGet("List")]
        public IActionResult List()
        {
            return Json(db.InstructorAddresses.Where(x => x.IsActive == true).ToList());
        }
        /// <summary>
        /// Nesneyi getiren metottur
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            return Json(db.InstructorAddresses.Find(id));
        }
        /// <summary>
        ///  Nesneyi ekleyen metottur 
        /// </summary>
        /// <param name="nesne"></param>
        /// <returns></returns>
        [HttpPost("Post")]
        public IActionResult Post(InstructorAddress nesne)
        {
            nesne.IsActive = true;
            db.InstructorAddresses.Add(nesne);
            db.SaveChanges();
            return Json("");
        }
        /// <summary>
        /// Nesneyi güncelleyen metottur 
        /// </summary>
        /// <param name="nesne"></param>
        /// <returns></returns>
        [HttpPut("Put")]
        public IActionResult Put(InstructorAddress nesne)
        {
            nesne.IsActive = true;
            db.InstructorAddresses.Update(nesne);
            db.SaveChanges();
            return Json("");

        }
        /// <summary>
        /// Nesneyi silen metottur. 
        /// </summary>
        /// <param name="nesne"></param>
        /// <returns></returns>
        [HttpDelete("Delete")]
        public IActionResult Delete(InstructorAddress nesne)
        {
            nesne.IsActive = false;
            db.InstructorAddresses.Update(nesne);
            db.SaveChanges();
            return Json("");
        }
    }
}

