using Microsoft.AspNetCore.Mvc;
using RequestResponse.Models;

namespace RequestResponse.NamespaceName;

public class TesteController : Controller
{

    public IActionResult Index([FromHeader(Name = "accept-language")] string acceptLanguage)
    {
        Console.WriteLine(acceptLanguage);
        return View();
    }

}