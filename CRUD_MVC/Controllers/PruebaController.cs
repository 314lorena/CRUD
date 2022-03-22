using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CRUD_MVC.Models;

namespace CRUD_MVC.Controllers
{
    public class PruebaController : Controller
    {
        // GET: PruebaController nombre del metodo
        public List<Prueba> ListadoUsuario()
        {
            return new List<Prueba>()
            {
                new Prueba()
                {
                     Docuemento_usuario=12345,
                     NombreUsuario="liseth",
                     Dirreccion="sdfg",
                     Telefono=1244,
                },
                new Prueba()
                {
                     Docuemento_usuario=12345,
                     NombreUsuario="liseth",
                     Dirreccion="sdfg",
                     Telefono=1244,
                },
                new Prueba()
                {
                     Docuemento_usuario=12345,
                     NombreUsuario="liseth",
                     Dirreccion="sdfg",
                     Telefono=1244,
                },
                new Prueba()
                {
                     Docuemento_usuario=12345,
                     NombreUsuario="liseth",
                     Dirreccion="sdfg",
                     Telefono=1244,
                },
                new Prueba()
                {
                     Docuemento_usuario=12345,
                     NombreUsuario="liseth",
                     Dirreccion="sdfg",
                     Telefono=1244,
                },
                new Prueba()
                {
                     Docuemento_usuario=12345,
                     NombreUsuario="liseth",
                     Dirreccion="sdfg",
                     Telefono=1244,
                },
                new Prueba()
                {
                     Docuemento_usuario=12345,
                     NombreUsuario="liseth",
                     Dirreccion="sdfg",
                     Telefono=1244,
                },
        };
        }

        // GET: PruebaController/Details/5 nombre de la vista
        public ActionResult Prueba()
        {
            var usuarioList = ListadoUsuario().ToList();
            var modelUsuarios = new PruebaIndexModelView();

            modelUsuarios.ListadoDeUsuarios = usuarioList;

            return View(modelUsuarios);
        }

          public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PruebaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PruebaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PruebaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PruebaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PruebaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PruebaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
