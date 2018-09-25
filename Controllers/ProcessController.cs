using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

public class ProcessController : Controller
{
    public IActionResult Index()
    {
        var p = Process.GetProcesses();
        ViewBag.Processes = p;
        return View();
    }
}