using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Requerimientos.Controllers
{
    public class HistoryController : Controller
    {
        public IActionResult Index()
        {
            List<Models.History> lst = new List<Models.History>();
            using (var db = new Models.BD.DB_A652C3_Proyecto3Context())
            {
                lst = (from d in db.History
                       select new Models.History
                       {
                           IdHistory = d.IdHistory,
                           IdEvent = d.IdEvent,
                           EventMessage = d.EventMessage,
                           IdRequest = d.IdRequest,
                           IdTecnicoArl = d.IdTecnicoArl,
                           eventname = d.IdEventNavigation.Name,
                           requerimiento_titulo = d.IdRequestNavigation.Title,
                           requerimiento_body = d.IdRequestNavigation.Body,
                           requerimiento_forter = d.IdRequestNavigation.Foster,
                           tecnicoARL = d.IdTecnicoArlNavigation.Nombre + d.IdTecnicoArlNavigation.Apellido
                       }).ToList();
            }
            return View(lst);
        }
    }
}
