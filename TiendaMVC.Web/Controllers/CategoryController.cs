using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaMVC.CORE;
using TiendaMVC.CORE.Interfaces;
using TiendaMVC.Web.Models;
using AutoMapper.QueryableExtensions;
using System.Linq.Dynamic;
using TiendaMVC.Web.Extensions;
using TiendaMVC.IFR;

namespace TiendaMVC.Web.Controllers
{
    //Get para dar la vista
    //Post para guardar, modificar o eliminar los datos, todo la comunicación con el controller
    /// <summary>
    /// 
    /// </summary>
    public class CategoryController : Controller
    {
        ICategoryManager categoryManager = null;
        public CategoryController(ICategoryManager categoryManager){
            this.categoryManager = categoryManager;
        }
        // GET: Category
        public ActionResult Index()
        {
            var model = Mapper.Map<ICollection<CategoryViewModel>>(categoryManager.GetAll());
            return View(model);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            CategoryViewModel model = new CategoryViewModel();
            model = PrepareViewModel(model);
            return View(model);
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(CategoryViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                Category category = Mapper.Map<Category>(model);
                categoryManager.Add(category);
                categoryManager.SaveChanges();

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                //TODO: Guardar en el log el error ex.Message
                ModelState.AddModelError("", "Se ha producido un error consulte con el administrador.");
                return View(model);
            }
        }


        private CategoryViewModel PrepareViewModel (CategoryViewModel model) {

            model.Categories = categoryManager.GetAll().Select(e => new SelectListItem
            {
                Value = e.Id.ToString(),
                Text = e.Name
            }).ToList();

            return model;
        }
        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            CategoryViewModel model = null;
            Category category = categoryManager.Find(id);
            if (category != null)
            {
                model = Mapper.Map<CategoryViewModel>(category);
                model = PrepareViewModel(model);
            }
            
            return View(model);
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CategoryViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                Category category = Mapper.Map<Category>(model); //Convertimos el ViewModel a Categoría
                categoryManager.Update(category);
                categoryManager.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                //TODO: Guardar en el log el error ex.Message
                ModelState.AddModelError("", "Se ha producido un error consulte con el administrador.");
                return View(model);
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            CategoryViewModel model = null;
            Category category = categoryManager.Find(id);
            if (category != null)
            {
                model = Mapper.Map<CategoryViewModel>(category);
                model = PrepareViewModel(model);
            }

            return View(model);
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, CategoryViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                Category category = Mapper.Map<Category>(model); //Convertimos el ViewModel a Categoría
                categoryManager.Remove(category);
                categoryManager.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                //TODO: Guardar en el log el error ex.Message
                //Log.WriteError(ex.Message, ex);
                ModelState.AddModelError("", "Se ha producido un error consulte con el administrador.");
                return View(model);
            }
        }

        [HttpPost]
        public JsonResult GetData() {
            // dc.Configuration.LazyLoadingEnabled = false; // if your table is relational, contain foreign key
            var v = categoryManager.GetAll().ProjectTo<CategoryListViewModel>();

            var result = v.Paginate<CategoryListViewModel>(Request);

            return Json(new
            {
                draw = result.draw,
                recordsFiltered = result.recordsFiltered,
                recordsTotal = result.RecordsTotal,
                data = result.Data
            }, JsonRequestBehavior.AllowGet);
            
        }
    }
}
