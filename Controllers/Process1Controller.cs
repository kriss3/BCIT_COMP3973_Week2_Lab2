using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

public class Process1Controller : Controller
{
    public IActionResult Index()
    {
        var p = Process.GetProcesses();
        //ViewBag.Processes = p;
        return View(p);
    }

    public IActionResult Details(int id)
    {
        var p = Process.GetProcessById(id);
        return View(p);
    }
}