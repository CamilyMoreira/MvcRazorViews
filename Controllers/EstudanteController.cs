using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;

namespace MvcRazorViews.Controllers;

public class EstudanteController : Controller
{
    public static List<EstudanteViewModel> estudantes =
    new List<EstudanteViewModel>{
        new EstudanteViewModel(1, "Eduardo", "R. A, n.1", true),
        new EstudanteViewModel(2, "Paulo", "R. B, n.65", false),
        new EstudanteViewModel(3, "Fernanda", "R. C, n.32", true)
    };

    public IActionResult Index()
    {
        return View(estudantes);
    }

    public IActionResult Show(int id)
    {
        //var estudante = new EstudanteViewModel(7, "Lucas", "Mar", false);

        return View(estudantes[id-1]);
    }
}