using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CadastroDeFrutas_SimaoMacedo.Controllers
{
    public class FrutasController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Frutas = new Fruta().Lista();
            return View();
        }

        public ActionResult Novo()
        {
            
            return View();
        }

        public ActionResult Buscar()
        {
            
        return View();
         
            
        }

        [HttpPost]
        public void Criar()
        {
            var fruta = new Fruta();
            fruta.Nome      = Request["nome"];
            fruta.Descricao = Request["descricao"];
            fruta.Imagem    = Request["imagem"];
            fruta.Save();
            Response.Redirect("/frutas");   
        }


        public void Excluir(int id)
        {
            Fruta.Excluir(id);
            Response.Redirect("/frutas");
        }

        public ActionResult Editar(int id)
        {
            var fruta = Fruta.BuscarPorId(id);
            ViewBag.Fruta = fruta;
            return View();
        }

        public ActionResult BuscarPorNome(String nome)
        {

            var fruta = Fruta.BuscarPorNome(nome);
            ViewBag.Fruta = fruta;
            return View();
        }

        [HttpPost]
        public void Alterar(int id)

        {
            try
            {
                var fruta = Fruta.BuscarPorId(id);
                fruta.Nome = Request["nome"];
                fruta.Descricao = Request["descricao"];
                fruta.Imagem = Request["imagem"];
                fruta.Save();
                TempData["Sucesso"] = "Pagina Alterada com sucesso";
                
            }
            catch
            {
                TempData["Erro"] = "Erro na alteração";
            }
            Response.Redirect("/frutas");
        }

    }
}