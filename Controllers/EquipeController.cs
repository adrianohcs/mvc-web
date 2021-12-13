using E_JOGOS.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_JOGOS.Controllers
{
    public class EquipeController : Controller
    {
        //IActionResult representa retorno de status HTTP
        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {
            //VIEW => parte responsável pela exibição do frontend
            //Viewbag => armazena as informações do backend p/
            //serem acessadas no frontend (é uma espécie de
            //controller exclusiva da View)
            ViewBag.Equipes = equipeModel.ReadAll();
            return View();
        }

        //public IActionResult Cadastrar(IFormCollection form)
        //{

        //}
    }
}
