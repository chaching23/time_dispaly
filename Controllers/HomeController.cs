using Microsoft.AspNetCore.Mvc; 
namespace HellASp

{
    public class HomeController: Controller
    {
        // Requests
        // localhost:5000/
        [HttpGet("")]
    
        public ViewResult Index()
        {
            // Views/Home/index.cshtml
            
            return View();
        }



        // localhost:5000/hello
        // [HttpGet("hello")]
     
        // public RedirectToActionResult Hello()
        // {
        //     System.Console.WriteLine("Hello There, redirecting ...");
        //     var param = new{username="Devon", location ="seattle"};
        //     return RedirectToAction("HelloUser", param);
        // }
        [HttpGet("projects")]

        public ViewResult projects()
        {
            // Views/Home/index.cshtml
            return View("projects");
        }
        [HttpGet("contact")]
        public ViewResult contact()
        {
            // Views/Home/index.cshtml
            return View("contact");
        }




       // localhost:5000/users/???
        // [HttpGet("users/{username}/{location}")]
        // public JsonResult HelloUser(string username, string location)
        // {
        //     var response = new {user= username, place=location};
        //     var stringArray = new string[]
        //     {
        //         "devon", "this", "Is", "Example"
        //     };
        //     bool isCool = true;
        //     return Json(response);
        // }


    }
}