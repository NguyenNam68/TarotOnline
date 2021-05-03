using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarot.Model.EF;
using Tarot.Model.Service;

namespace Tarot.Web.Areas.Admin.Controllers
{
    public class ProductCategoryAdminController : BaseController
    {
        // GET: Admin/ProductCategoryAdmin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProductCategory(ProductCategory productCategory)
        {
            if(ModelState.IsValid)
            {
                var service = new ProductCategoryService();
                int id = service.Insert(productCategory);
                if (id > 0)
                {
                    return RedirectToAction("Index", "ProductCategoryAdmin");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm danh mục sản phẩm thành công!");
                }
            }
            return View("Index");
        }
    }
}