using Microsoft.AspNetCore.Mvc;
using RequestResponse.Models;

namespace RequestResponse.NamespaceName;

public class TesteController : Controller
{

    public IActionResult Index()
    {
        var file = System.IO.File.ReadAllBytes("wwwroot/Relatorios/relatorio.pdf");
        return File(file, "application/pdf", "relatorio.pdf");
    }

}