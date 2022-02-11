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
                new Oceny() {Album=123456,Punkty=22,Ocena="F",Data="2021-11-02" },
                new Oceny() {Album=122356,Punkty=90,Ocena="A",Data="2021-10-05" },
                new Oceny() {Album=123256,Punkty=70,Ocena="C",Data="2021-07-12"}

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



