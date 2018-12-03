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
        public IActionResult Results(string searchTerm)
        {
            ViewBag.columns = ListController.columnChoices;

            if (searchTerm != null)
            {
                List<Dictionary<string, string>> jobs = JobData.FindByValue(searchTerm);
                ViewBag.title = "Matching results: \n";
                ViewBag.jobs = jobs;
            }
            else Redirect("Index");
            

            
            //
            //
            //
            //Possible error in view linking
            return View("Index");

            
        }
    }
}
