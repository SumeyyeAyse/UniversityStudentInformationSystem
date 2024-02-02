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
    public class StudentAddressController : Controller
    {
        private readonly AppDbContext db;
        public StudentAddressController(AppDbContext context)
        {
            db = context;
        }
        /// <summary>
        /// StudentAddresses Listesini getiren metottur
        /// </summary>
        /// <returns></returns>
        [HttpGet("List")]
        public IActionResult List()
        {
            return Json(db.StudentAddresses.Where(x => x.IsActive == true).ToList());
        }
        [HttpGet("StudentTableList")]
        public IActionResult StudentTableList()
        {
            return Json(db.V_StudentTable.Where(x => x.IsActive).ToList());
        }
        /// <summary>
        /// Nesneyi getiren metottur
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            return Json(db.StudentAddresses.Find(id));
        }
        /// <summary>
        ///  Nesneyi ekleyen metottur 
        /// </summary>
        /// <param name="nesne"></param>
        /// <returns></returns>
        [HttpPost("Post")]
        public IActionResult Post(StudentAddress nesne)
        {
            nesne.IsActive = true;
            db.StudentAddresses.Add(nesne);
            db.SaveChanges();
            return Json("");
        }
        /// <summary>
        /// Nesneyi güncelleyen metottur 
        /// </summary>
        /// <param name="nesne"></param>
        /// <returns></returns>
        [HttpPut("Put")]
        public IActionResult Put(StudentAddress nesne)
        {
            nesne.IsActive = true;
            db.StudentAddresses.Update(nesne);
            db.SaveChanges();
            return Json("");

        }
        /// <summary>
        /// Nesneyi silen metottur. 
        /// </summary>
        /// <param name="nesne"></param>
        /// <returns></returns>
        [HttpDelete("Delete")]
        public IActionResult Delete(StudentAddress nesne)
        {
            nesne.IsActive = false;
            db.StudentAddresses.Update(nesne);
            db.SaveChanges();
            return Json("");
        }
    }
}
