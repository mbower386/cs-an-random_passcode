using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Diagnostics;

namespace RandomPasscode.Controllers
{
    public class RandomPasscodeController : Controller
    {
        // Index
        [HttpGet ("")]
        public IActionResult Index ()
        {


            return View (new Survey ());
        }

        // remember to use [HttpPost] attributes!
        [HttpPost ("survey/create")]
        public IActionResult RegenPasscode (Survey survey)
        {
            if (ModelState.IsValid)
            {
                return View ("Survey", survey);
            }
            else
            {
                return View ("Index");
            }
        }

    }
}