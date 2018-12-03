using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        // TODO #1 - Create a Results action method to process 
        // search request and display results
        public IActionResult Results(string searchType, string searchTerm)
        {
            
            List<Dictionary<string, string>> jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
            ViewBag.title = "Matching results: \n";
            ViewBag.jobs = jobs;

            ViewBag.columns = ListController.columnChoices;
            //
            //
            //
            //Possible error in view linking
            return View("Index");

            
        }
    }
}
