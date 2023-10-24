using Microsoft.AspNetCore.Mvc;
namespace IlkDers.Controllers;

public class StudentController : Controller
{
    public StudentController()
    {

    }

    public String Index()
    {
        return "Merhaba Dünya";
    }

    public ViewResult Index2()
    {
        var isimler = new String[]
        {
                "İbrahim","Ahmet","Mehmet"
        };
        return View("Index2", isimler);
    }

    public IActionResult Index3()
    {

        return View();
    }
}

