using System;
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
    }
}