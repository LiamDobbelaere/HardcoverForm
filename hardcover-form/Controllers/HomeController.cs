using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hardcover_form.Models;
using Newtonsoft.Json;
using hardcover_form.Data;
using DinkToPdf;
using DinkToPdf.Contracts;

namespace hardcover_form.Controllers
{
    public class HomeController : Controller
    {
        private readonly SalesContext _context;
        private readonly IConverter _converter;

        public HomeController(SalesContext context, IConverter converter)
        {
            _context = context;
            _converter = converter;
        }

        public IActionResult Index()
        {
            return View(_context.SalesForms);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpGet("[controller]/[action]/{id}")]
        public IActionResult Edit(int id)
        {
            var model = _context.SalesForms.Find(id);
            return View("Create", model);
        }

        [HttpGet("[controller]/[action]/{id}")]
        public IActionResult Delete(int id)
        {
            var model = _context.SalesForms.Remove(_context.SalesForms.Find(id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("[controller]/[action]/{id}")]
        public IActionResult Details(int id)
        {
            return View(_context.SalesForms.Find(id));
        }

        [HttpGet("[controller]/[action]/{id}")]
        public IActionResult Download(int id)
        {
            var url = Request.Scheme + "://" + Request.Host + "/Home/Details/" + id;

            var doc = new HtmlToPdfDocument()
            {
                Objects = {
                    new ObjectSettings()
                    {
                        Page = Request.Scheme + "://" + Request.Host + "/Home/Details/" + id
                    }
                }
            };

            byte[] pdfData = _converter.Convert(doc);

            return File(pdfData, "application/pdf");
        }

        [HttpPost]
        public IActionResult Save(SalesForm salesForm)
        {
            if (salesForm.ID == 0)
            {
                _context.SalesForms.Add(salesForm);
            }
            else
            {
                _context.SalesForms.Update(salesForm);
            }

            _context.SaveChanges();

            return RedirectToAction("Edit", new { id = salesForm.ID });
        }
    }
}
