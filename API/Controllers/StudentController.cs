using API.Models.Context;
using API.Models.Entities.Concrete;
using API.Models.Entities.Enums;
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
    public class StudentController : Controller
    {
        private readonly AppDbContext db;
        public StudentController(AppDbContext context)
        {
            db = context;
        }
        /// <summary>
        /// Student Listesini getiren metottur
        /// </summary>
        /// <returns></returns>
        [HttpGet("List")]
        public IActionResult List()
        {
            return Json(db.Students.Where(x => x.IsActive == true).ToList());
        }
        [HttpGet("StudentTable")]
        public IActionResult StudentTable()
        {
            return Json(db.V_StudentTable.Where(x => x.IsActive == true).ToList());
        }
        /// <summary>
        /// Nesneyi getiren metottur
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            return Json(db.Students.Find(id));
        }
        /// <summary>
        ///  Nesneyi ekleyen metottur 
        /// </summary>
        /// <param name="nesne"></param>
        /// <returns></returns>
        [HttpPost("Post")]
        public IActionResult Post(Student nesne)
        {
            nesne.IsActive = true;
            db.Students.Add(nesne);
            db.SaveChanges();
            return Json("");
        }
        /// <summary>
        /// Nesneyi güncelleyen metottur 
        /// </summary>
        /// <param name="nesne"></param>
        /// <returns></returns>
        [HttpPut("Put")]
        public IActionResult Put(Student nesne)
        {
            nesne.IsActive = true;
            db.Students.Update(nesne);
            db.SaveChanges();
            return Json("");

        }
        /// <summary>
        /// Nesneyi silen metottur. 
        /// </summary>
        /// <param name="nesne"></param>
        /// <returns></returns>
        [HttpDelete("Delete")]
        public IActionResult Delete(Student nesne)
        {
            nesne.IsActive = false;
            db.Students.Update(nesne);
            db.SaveChanges();
            return Json("");
        }
    }
}
