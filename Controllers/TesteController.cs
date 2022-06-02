using Microsoft.AspNetCore.Mvc;

namespace RequestResponse.NamespaceName;

public class TesteController : Controller
{

    public IActionResult Index()
    {
        // var viewResult = new ViewResult();
        // viewResult.ViewName = "Index";
        // return viewResult;
        // var partialViewResult = new PartialViewResult();
        // partialViewResult.ViewName = "Index";
        // return partialViewResult;
        return PartialView();
    }

}