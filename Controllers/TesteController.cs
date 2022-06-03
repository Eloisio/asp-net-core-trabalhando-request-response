using Microsoft.AspNetCore.Mvc;
using RequestResponse.Models;

namespace RequestResponse.NamespaceName;

public class TesteController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Form(Produto produto)
    {
        Console.WriteLine(produto.Nome);
        Console.WriteLine(produto.Descricao);
        Console.WriteLine(produto.Valor);
        return RedirectToAction(nameof(Index));
    }

}