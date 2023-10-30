using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
        // Crea una matriz de cadenas
        string[] datos = { "Manzana", "Banana", "Cereza", "Damasco", "Frambuesa" };

        // Pasa la matriz a la vista
        return View(datos);
    }
}
