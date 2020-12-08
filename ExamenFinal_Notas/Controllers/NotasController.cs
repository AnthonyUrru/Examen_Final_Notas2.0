using ExamenFinal_Notas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal_Notas.Controllers
{
    public class NotasController : Controller
    {
        private readonly NotasContext _context;
        public NotasController(NotasContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Etiquetas = _context.Etiquetas.ToList();
            ViewBag.Etiquetitas = _context.Etiqueta_Notas.ToList();
            return View();
        }
        [HttpGet]
        public IActionResult _Index(string search)
        {
            var notas = _context.Notas.ToList();
            ViewBag.Etiquetas = _context.Etiquetas.ToList();
            ViewBag.Etiquetitas = _context.Etiqueta_Notas.ToList();
            if (!String.IsNullOrEmpty(search))
            {
                notas = notas.Where(o => o.Tittle.Contains(search) || o.Nota_Content.Contains(search)).ToList();
                return View(notas);
            }
            return View(notas);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Etiquetas = _context.Etiquetas.ToList();
            return View(new Nota());
        }
        [HttpPost]
        public IActionResult Create(Nota nota, List<int> etiqueta)
        {
            nota.DateRegister = DateTime.Now;
            List<Etiqueta_Nota> etiq = new List<Etiqueta_Nota>();
            if (etiqueta.Count() == 0)
                ModelState.AddModelError("etiqueta","Campo invalido");
            
            if (ModelState.IsValid)
            {
                _context.Notas.Add(nota);
                _context.SaveChanges();
                foreach (var item in etiqueta)
                {
                    var eti_nota = new Etiqueta_Nota();
                    eti_nota.EtiquetaId = item;
                    eti_nota.NotaId = nota.Id;
                    etiq.Add(eti_nota);
                }
                _context.Etiqueta_Notas.AddRange(etiq);
                _context.SaveChanges();
                ViewBag.Etiquetas = _context.Etiquetas.ToList();
                return View("Index");
            }
            else
            {
                Response.StatusCode = 400;
                ViewBag.Etiquetas = _context.Etiquetas.ToList();
                return View(nota);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Etiquetas = _context.Etiquetas.ToList();
            var nota = _context.Notas.Where(o => o.Id == id).FirstOrDefault();
            return View(nota);

        }
        [HttpPost]
        public IActionResult Edit(Nota nota /*List<int> etiqueta*/)
        {
            nota.DateRegister = DateTime.Now;
            //List<EtiquetaNota> etic = new List<EtiquetaNota>();

            //if (etiqueta.Count() == 0)
            //    ModelState.AddModelError("etiqueta", "Seleccione por lo menos uno");

            if (ModelState.IsValid)
            {
                _context.Notas.Update(nota);
                _context.SaveChanges();
                //foreach (var item in etiqueta)
                //{
                //    var etique = new EtiquetaNota();
                //    etique.IdEtiqueta = item;
                //    etique.IdNota = nota.Id;
                //    etic.Add(etique);
                //}
                //context.EtiquetaNotas.AddRange(etic);
                //context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                Response.StatusCode = 400;
                ViewBag.Etiquetas = _context.Etiquetas.ToList();
                return View(nota);
            }

        }
        [HttpGet]
        public IActionResult Detalle(int id)
        {

            var etiqueta = _context.Etiquetas.ToList();
            ViewBag.Etiquetas = _context.Etiqueta_Notas.Include(o => o.Etiqueta).ToList();
            var nota = _context.Notas.Where(o => o.Id == id).FirstOrDefault();
            return View(nota);
        }
        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            var nota = _context.Notas.Where(o => o.Id == id).FirstOrDefault();
            var etiqueta = _context.Etiqueta_Notas.Where(o => o.NotaId == id).ToList();
            _context.Notas.Remove(nota);
            _context.Etiqueta_Notas.RemoveRange(etiqueta);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Barra_Lateral()
        {
            return View();
        }


    }
}
