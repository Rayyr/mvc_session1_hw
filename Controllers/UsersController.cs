using Microsoft.AspNetCore.Mvc;

namespace mvc_trial.Controllers
{
    public class UsersController : Controller
    {
        //get users
        public ViewResult get()
        {
            List<string> users = new List<string>();
            users.Add("raya");
            users.Add("ruba");
            users.Add("aya");

            return View("./Views/Users/Index.cshtml",users);
        }

        //create user
        public ViewResult create()
        {
            return View("./Views/Users/create.cshtml");
        }
    }
}
