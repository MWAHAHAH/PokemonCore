using Microsoft.AspNetCore.Mvc;

namespace HelloWorldCore.Controllers
{
    //[Route("about")]
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        //[Route("")]
        public string Phone()
        {
            return "346 8063831";
        }   

        //[Route("[action]")]
        public string Address()
        {
            return "ITA";
        }
    }
}
