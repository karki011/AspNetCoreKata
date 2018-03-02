using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreKata.Models;

namespace AspNetCoreKata.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            var list =  new List<Person>
            {
                new Person
                {
                    Name = "Subash Karki",
                    Age = 25
                },
                new Person
                {
                    Name = "Subash Karki",
                    Age = 25
                },
                new Person
                {
                    Name = "Subash Karki",
                    Age = 25
                }, new Person
                {
                    Name = "Subash Karki",
                    Age = 25
                },

            };

            return View(list);
        }
    }
}