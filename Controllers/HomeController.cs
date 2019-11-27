using Microsoft.AspNetCore.Mvc;
namespace Portfolio2.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     // index
        public ViewResult Index()
        {
            //views/home/index.cshtml
            //views/shared/index.cshtml
            return View();
        }

        [HttpGet]       //type of request
        [Route("/projects")]     // index
        public ViewResult projects()
        {
            return View();
        }

        [HttpGet]       //type of request
        [Route("/contact")]     // index
        public ViewResult contact()
        {
            return View();
        }
    }
}
