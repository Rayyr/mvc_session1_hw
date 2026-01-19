using Microsoft.AspNetCore.Mvc;
using mvc_trial.Data;
using mvc_trial.Models;

namespace mvc_trial.Controllers
{

    public class CategoriesController : Controller
    {
        //database connection
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


        //create new category ( add new one ) 
        public ViewResult createCategory()
        {
            return View("./Views/Categories/create.cshtml");
        }


        //store category
        public RedirectToActionResult store(Category created_category)
        {
            context.categories.Add(created_category);
            context.SaveChanges();
            return RedirectToAction("getAll");
        }


        //delete category based to the passed id via the url 
        public RedirectToActionResult deleteCategory(int id)
        {
            var category_to_be_deleted = context.categories.Find(id);
            context.categories.Remove(category_to_be_deleted);
            context.SaveChanges();

            //in case after deletion i need to get all categories ( home page ) 
            return RedirectToAction("getAll");
        }
    }
}
