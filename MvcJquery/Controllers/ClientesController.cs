using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcJquery.Controllers
{
    public class ClientesController : Controller
    {

        public ActionResult List()
        {
            return PartialView(Context.Clientes);
        }

        //
        // GET: /Index/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Index/Details/5

        public ActionResult Details(int id)
        {
            var model = Context.Clientes.Where(e => e.Codigo == id).SingleOrDefault();

            return View(model);
        }

        //
        // GET: /Index/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Index/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var nome = collection["Nome"];
                var telefone = collection["Telefone"];

                Context.Clientes.Add(new Models.Cliente { Codigo = Context.Clientes.Count + 1, Nome = nome, Telefone = telefone });
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Index/Edit/5

        public ActionResult Edit(int id)
        {
            var model = Context.Clientes.Where(e => e.Codigo == id).SingleOrDefault();

            return View(model);
        }

        //
        // POST: /Index/Edit/5

        [HttpPost]
        public ActionResult Edit(int codigo, FormCollection collection)
        {
            try
            {

                var nome = collection["Nome"];
                var telefone = collection["Telefone"];

                Context.Clientes.Where(e => e.Codigo == codigo).Single().Nome = nome;
                Context.Clientes.Where(e => e.Codigo == codigo).Single().Telefone = telefone;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Index/Delete/5

        public ActionResult Delete(int id)
        {
            var model = Context.Clientes.Where(e => e.Codigo == id).SingleOrDefault();

            //Context.Clientes.Remove(model);
            

            return View(model);
        }

        //
        // POST: /Index/Delete/5

        [HttpPost]
        public ActionResult Delete(int codigo, FormCollection collection)
        {
            try
            {
                var model = Context.Clientes.Where(e => e.Codigo == codigo).SingleOrDefault();

                Context.Clientes.Remove(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
