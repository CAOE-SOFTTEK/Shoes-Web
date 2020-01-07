﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shoes.Models;
using Shoes.Models.ViewModels;

namespace Shoes.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<ListProductsViewModel> lista;
            using (DataProductsEntities db = new DataProductsEntities())
            {
                 lista = (from d in db.Products
                             select new ListProductsViewModel
                             {
                                 Id = d.Id,
                                 IdType = d.IdType,
                                 IdColor = d.IdColor,
                                 IdBrand = d.IdBrand,
                                 IdProvider = d.IdProvider,
                                 IdCatalog = d.IdCatalog,
                                 Title = d.Title,
                                 Nombre = d.Nombre,
                                 Description = d.Description,
                                 Observations = d.Observations,
                                 PriceDistributor = d.PriceDistributor,
                                 PriceClient = d.PriceClient,
                                 PriceMember = d.PriceMember,
                                 IsEnabled = d.IsEnabled,
                                 Keywords = d.Keywords,
                                 DateUpdate = d.DateUpdate
                             }).ToList();
            }
                return View(lista);
        }

        public ActionResult Nuevo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Nuevo(ProductViewModel model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    using (DataProductsEntities db = new DataProductsEntities())
                    {
                        var oProduct = new Products();
                            oProduct.Id = model.Id;
                        oProduct.IdType = model.IdType;
                        oProduct.IdColor = model.IdColor;
                        oProduct.IdBrand = model.IdBrand;
                        oProduct.IdProvider = model.IdProvider;
                        oProduct.IdCatalog = model.IdCatalog;
                        oProduct.Title = model.Title;
                        oProduct.Nombre = model.Nombre;
                        oProduct.Description = model.Description;
                        oProduct.Observations = model.Observations;
                        oProduct.PriceDistributor = model.PriceDistributor;
                        oProduct.PriceClient = model.PriceClient;
                        oProduct.PriceMember = model.PriceMember;
                        oProduct.IsEnabled = model.IsEnabled;
                        oProduct.Keywords = model.Keywords;
                        oProduct.DateUpdate = model.DateUpdate;
                        db.Products.Add(oProduct);
                        db.SaveChanges();
                    }
                    return Redirect("~/Products/");
                }
                return View(model);

            }
            catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

    }
}