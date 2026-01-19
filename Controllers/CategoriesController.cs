using Microsoft.AspNetCore.Mvc;
using mvc_trial.Data;

namespace mvc_trial.Controllers
{

    public class CategoriesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        //read action
        public ViewResult getAll()
        {
            var categories = context.categories.ToList();
            return View("./Views/Categories/read.cshtml",categories);
        }


        //read details for specific category 
        public ViewResult getDetails(int id)
        {
            var category = context.categories.Find(id);
            return View("./Views/Categories/getDetails.cshtml", category);
        }
    }
}
