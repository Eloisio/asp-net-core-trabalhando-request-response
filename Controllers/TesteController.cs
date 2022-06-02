using Microsoft.AspNetCore.Mvc;
using RequestResponse.Models;

namespace RequestResponse.NamespaceName;

public class TesteController : Controller
{

    public IActionResult Index()
    {
        var produto = new Produto
        {
            Id = 1,
            Nome = "Notebook",
            Descricao = "Muito bom, confia!!!",
            Valor = 10000
        };
        return Json(produto);
    }

}