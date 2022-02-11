using _12174_Jakub_Brandys_termin_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace _12174_Jakub_Brandys_termin_1.Controllers
{

    public class OcenyController1 : ControllerBase
    {

        private List<Oceny> ListaOceny;

        public OcenyController1()
        {
            ListaOceny = new List<Oceny>()
            {
                new Oceny() {Album=123456,Punkty=22,Ocena="F"},
                new Oceny() {Album=122356,Punkty=90,Ocena="A"},
                new Oceny() {Album=123256,Punkty=70,Ocena="C"}

            };
        }

        [Route("/api/exams")]
        [HttpGet]
        public ActionResult<IEnumerable<Oceny>> GetCard()
        {

            return ListaOceny.ToList();
        }

    }
}



