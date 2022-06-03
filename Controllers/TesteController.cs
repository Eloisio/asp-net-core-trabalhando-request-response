using Microsoft.AspNetCore.Mvc;
using RequestResponse.Models;

namespace RequestResponse.NamespaceName;

public class TesteController : Controller
{

    public IActionResult Index([FromQuery(Name = "nome")] string name, int idade)
    {
        Console.WriteLine(name);
        Console.WriteLine(idade);
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