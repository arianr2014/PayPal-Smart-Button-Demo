/*********************************************************
       Code Generated By  .  .  .  .  Delaney's Script Bot
       WWW .  .  .  .  .  .  .  .  .  www.scriptbot.io
       Version.  .  .  .  .  .  .  .  10.0.0.14 
       Build  .  .  .  .  .  .  .  .  20191113 216
       Template Name.  .  .  .  .  .  Project Green 2.0
       Template Version.  .  .  .  .  20200529 002
       Author .  .  .  .  .  .  .  .  Delaney

                      ,        ,--,_
                       \ _ ___/ /\|
                       ( )__, )
                      |/_  '--,
                        \ `  / '

 *********************************************************/

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delaney.Areas.Controllers
{
    public partial class ProductController : Delaney.Controllers.Abstract
    {
        public ProductController(Delaney.Services.Data.Core.IUnitOfWork unitOfWork) : base(unitOfWork) {}


        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                IEnumerable<Services.Data.Core.Domain.Product> products = null;

                products = _unitOfWork.Products.GetAll();

                _unitOfWork.Baskets.Get(products);

                var Models = new List<Models.Product>();

                if(products != null)
                    foreach(var product in products)
                    {
                        var model = new Models.Product(product);
                        Models.Add(model);
                    }

                var summary = new Models.Summary<Models.Product>
                {
                    Models = Models,
                    Count = Models.Count,
                };
                
                return View(summary);
            }
            catch
            {
                ModelState.AddModelError(
                        "Error",
                        "Cannot get the products");
                
                return View();
            }
        }

        [HttpGet]
        public IActionResult Detail (int? id)
        {
            if (id == null)
                return Redirect("~/product");

            var product = _unitOfWork.Products.GetWithParents((int)id);

            if (product == null)
                return Redirect(
                    "/../Product");
            else
            {
                _unitOfWork.Baskets.Get(product);

                var model = new Models.Product(product);
                
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Delete (int? id)
        {
            if (id == null)
                return Redirect("~/product");

            var product = _unitOfWork.Products.Get(id);

            if (product == null)
                return Redirect("/../Product");
            else
            {
                _unitOfWork.Baskets.Get(product);


                var model = new Models.Product(product);

                return View(model);
            }
        }
        [HttpPost]
        public IActionResult Delete(Models.Product model)
        {
            if (ModelState.IsValid)
            {

                if(model == null)
                    return View(model);

                if(model.Id == null)
                    return View(model);

                try
                {
                    if (_unitOfWork.Products
                                   .Remove((int)model.Id,
                                           out string errorMessage) != Services.Data.DataStoreResult.Success)
                    {
                        ModelState.AddModelError("Error",
                                                 errorMessage);
                        return View(model);
                    }
                

                    _unitOfWork.Complete();

                    return Redirect(
                        "/../Product");
                }
                catch
                {
                    ModelState.AddModelError("Error",
                                             "Cannot delete the Product.");

                    return View(model);
                }

            }
            else
                return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            Services.Data.Core.Domain.Product product;

            if (Id == null)
                product = new Services.Data.Core.Domain.Product();
            else
            {
                product = _unitOfWork.Products.Get((int)Id);

                if (product == null)
                    return Redirect(
                        "/../Product");
                _unitOfWork.Baskets.Get(product);

            }

            var model = new Models.Product(product);

            // Model parents and children
            //model.PopulateChilden();

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Models.Product model)
        {
            if (model != null)
            {
                // Temporary remove many to many selected collections,
                // as they will cause invalid model state if there are any required fields on the many to many selected.
                ModelState.Clear();
                TryValidateModel(model);
            }
            if (ModelState.IsValid)
            {
                try
                {

                    _unitOfWork.Products.Add(model.GetCore());
                    if(_unitOfWork.Complete() == Services.Data.DataStoreResult.Success)
                        return Redirect(
                            "/../Product");

                    return View(model);
                }
                catch
                {
                    ModelState.AddModelError(
                        "Error",
                        "Cannot edit product.");

                    return View(model);
                }
            }
            else
            {
                _unitOfWork.Baskets.Get(model.GetCore());
                model.Backet = new Models.Basket(model.GetCore().Basket);

                return View(model);
            }
        }

        [HttpPost]
        public IActionResult Cancel()
        {
            return Redirect(
                "/../Product");
        }
    }
}