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
    public class InstructorController : Controller
    {
        private readonly AppDbContext db;
        public InstructorController(AppDbContext context)
        {
            db = context;
        }
        [HttpGet("InstructorTable")]
        public IActionResult InstructorTable()
        {
            return Json(db.V_InstructorTable.Where(x => x.IsActive == true).ToList());
        }
        /// <summary>
        /// Instructor Listesini getiren metottur
        /// </summary>
        /// <returns></returns>
        [HttpGet("List")]
        public IActionResult List()
        {
            return Json(db.Instructors.Where(x => x.IsActive == true).ToList());
        }
        /// <summary>
        /// Nesneyi getiren metottur
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            return Json(db.Instructors.Find(id));
        }
        /// <summary>
        ///  Nesneyi ekleyen metottur 
        /// </summary>
        /// <param name="nesne"></param>
        /// <returns></returns>
        [HttpPost("Post")]
        public IActionResult Post(Instructor nesne)
        {
            nesne.IsActive = true;
            db.Instructors.Add(nesne);
            db.SaveChanges();
            return Json("");
        }
        /// <summary>
        /// Nesneyi güncelleyen metottur 
        /// </summary>
        /// <param name="nesne"></param>
        /// <returns></returns>
        [HttpPut("Put")]
        public IActionResult Put(Instructor nesne)
        {
            nesne.IsActive = true;
            db.Instructors.Update(nesne);
            db.SaveChanges();
            return Json("");

        }
        /// <summary>
        /// Nesneyi silen metottur. 
        /// </summary>
        /// <param name="nesne"></param>
        /// <returns></returns>
        [HttpDelete("Delete")]
        public IActionResult Delete(Instructor nesne)
        {
            nesne.IsActive = false;
            db.Instructors.Update(nesne);
            db.SaveChanges();
            return Json("");
        }
    }
}
