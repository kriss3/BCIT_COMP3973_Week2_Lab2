
using Microsoft.AspNetCore.Mvc;
using AspCorePrimer.NW;
using System.Linq;

public class CategoryController : Controller
{
    private static NorthwindContext ctx = null;
    public CategoryController()
    {
        ctx = new NorthwindContext();
    }
    public IActionResult Index()
    {
        var qry = ctx.Categories;
        return View(qry);
    }

    public IActionResult Details(int id)
    {
        var qry = ctx.Categories.Where(c=>c.CategoryId == id);
        var result = (from m in qry select m).FirstOrDefault();
        return View(result);
    }
}