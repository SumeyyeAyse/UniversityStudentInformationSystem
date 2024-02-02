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
    public class CourseController : Controller
    {
        private readonly AppDbContext db;
        public CourseController(AppDbContext context)
        {
            db = context;
        }
        /// <summary>
        /// Course Listesini getiren metottur
        /// </summary>
        /// <returns></returns>
        [HttpGet("List")]
        public IActionResult List()
        {
            return Json(db.Courses.Where(x => x.IsActive == true).ToList());
        }
        /// <summary>
        /// Nesneyi getiren metottur
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            return Json(db.Courses.Find(id));
        }
        /// <summary>
        ///  Nesneyi ekleyen metottur 
        /// </summary>
        /// <param name="nesne"></param>
        /// <returns></returns>
        [HttpPost("Post")]
        public IActionResult Post(Course nesne)
        {
            nesne.IsActive = true;
            db.Courses.Add(nesne);
            db.SaveChanges();
            return Json("");
        }
        /// <summary>
        /// Nesneyi güncelleyen metottur 
        /// </summary>
        /// <param name="nesne"></param>
        /// <returns></returns>
        [HttpPut("Put")]
        public IActionResult Put(Course nesne)
        {
            nesne.IsActive = true;
            db.Courses.Update(nesne);
            db.SaveChanges();
            return Json("");

        }
        /// <summary>
        /// Nesneyi silen metottur. 
        /// </summary>
        /// <param name="nesne"></param>
        /// <returns></returns>
        [HttpDelete("Delete")]
        public IActionResult Delete(Course nesne)
        {
            nesne.IsActive = false;
            db.Courses.Update(nesne);
            db.SaveChanges();
            return Json("");
        }
    }
}
