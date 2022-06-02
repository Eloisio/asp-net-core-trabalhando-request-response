using Microsoft.AspNetCore.Mvc;

namespace RequestResponse.NamespaceName;

public class TesteController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

}