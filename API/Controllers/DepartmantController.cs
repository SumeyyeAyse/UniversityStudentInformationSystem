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
    public class DepartmantController : Controller
    {
        private readonly AppDbContext db;
        public DepartmantController(AppDbContext context)
        {
            db = context;
        }
        /// <summary>
        /// Department Listesini getiren metottur
        /// </summary>
        /// <returns></returns>
        [HttpGet("List")]
        public IActionResult List()
        {
            return Json(db.Departmants.Where(x => x.IsActive == true).ToList());
        }
        /// <summary>
        /// Department Listesini Fakülte ismi ile getiren metottur
        /// </summary>
        /// <returns></returns>
        [HttpGet("DepartmantTable")]
        public IActionResult DepartmantTable()
        {
            return Json(db.V_DepartmantTable.Where(x => x.IsActive == true).ToList());
        }
        /// <summary>
        /// Nesneyi getiren metottur
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            return Json(db.Departmants.Find(id));
        }
        /// <summary>
        ///  Nesneyi ekleyen metottur 
        /// </summary>
        /// <param name="nesne"></param>
        /// <returns></returns>
        [HttpPost("Post")]
        public IActionResult Post(Departmant nesne)
        {
            nesne.IsActive = true;
            db.Departmants.Add(nesne);
            db.SaveChanges();
            return Json("");
        }
        /// <summary>
        /// Nesneyi güncelleyen metottur 
        /// </summary>
        /// <param name="nesne"></param>
        /// <returns></returns>
        [HttpPut("Put")]
        public IActionResult Put(Departmant nesne)
        {
            nesne.IsActive = true;
            db.Departmants.Update(nesne);
            db.SaveChanges();
            return Json("");

        }
        /// <summary>
        /// Nesneyi silen metottur. 
        /// </summary>
        /// <param name="nesne"></param>
        /// <returns></returns>
        [HttpDelete("Delete")]
        public IActionResult Delete(Departmant nesne)
        {
            nesne.IsActive = false;
            db.Departmants.Update(nesne);
            db.SaveChanges();
            return Json("");
        }
    }
}

