using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()

        {

            var movie = new Movie()
            {
                Name = "Tom And Jerry"
            };
            return View(movie);
            //    return Content("Hello Boss");
            //    return HttpNotFound();
            //    return  new EmptyResult();
            //    return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("Id = " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            // kiểm tra xem các thông tin có chỉ mục trang giá trị hay kh ông
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            // nếu là chuỗi hoặc không gian trắng
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";   
            }

            return Content(String.Format("pageIndex={0}$sortBy={1}",pageIndex,sortBy));
        }


    }
}